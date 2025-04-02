using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Domain.Models;
using ISPSMS_JUHACA.MainPages.SubPages;
using Krypton.Toolkit;
using MaterialSkin.Controls;
using MaterialSkin;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views;
using System.Data;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using ISPSMS_JUHACA.toPrintData;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class Transaction : MaterialForm, ITransactionView
    {
        private readonly TransactionPresenter _presenter;
        private readonly MainForm _mainForm;
        private readonly BindingSource _bindingSource;
        private bool _isLoading = false;
        private Label _loadingLabel;
        private int _currentPage = 1;
        private int _itemsPerPage = 10;
        private int _totalItems = 0;
        private List<Transactions> _currentTransactions = new List<Transactions>();
        private readonly Timer updateTimer = new Timer { Interval = 86400000 };

        public BindingSource BindingSource => _bindingSource;


        public Transaction(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _presenter = new TransactionPresenter(this, dbContext);
            _bindingSource = new BindingSource();

            // Apply MaterialSkin styles
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            flowLayoutPanel1.GetType().GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            ?.SetValue(flowLayoutPanel1, true, null);
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public async void Transaction_Load(object sender, EventArgs e)
        {
            kryptonDateTimePicker1.Value = DateTime.Today;
            lblTotalAmount.Text = "Loading...";
            ShowLoadingIndicator(true);
            await Task.Delay(100);
            await RefreshTransactions();
            
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTime();

            ShowLoadingIndicator(false);

        }
            
        private async Task RefreshTransactions()
        {
            var transactions = await _presenter.LoadTransactionsByDateAsync(kryptonDateTimePicker1.Value.Date);
            if (transactions.Count != _currentTransactions.Count) // Only refresh if there are changes
            {
                _currentTransactions = transactions;
                _totalItems = transactions.Count;
                _currentPage = 1;
                DisplayTransactions(transactions, filterByDate: true);
                UpdatePaginationButtons();
            }
        }
        public void UpdatePaidAmountLabel(decimal totalPaidAmount)
        {
            var culture = new CultureInfo("fil-PH");
            lblTotalAmount.Text = totalPaidAmount.ToString("C", culture);
        }

        public void SetPaginationData(int currentPage, int itemsPerPage, int totalItems)
        {
            _currentPage = currentPage;
            _itemsPerPage = itemsPerPage;
            _totalItems = totalItems;
        }

        public void DisplayTransactions(IEnumerable<Transactions> transactions, bool filterByDate = true)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            var filteredTransactions = transactions
                .Where(t => t.TransactionDateTime.Date == kryptonDateTimePicker1.Value.Date)
                .OrderByDescending(t => t.TransactionDateTime)
                .ToList();

            int totalFilteredItems = filteredTransactions.Count;
            int startIndex = (_currentPage - 1) * _itemsPerPage;
            int endIndex = Math.Min(startIndex + _itemsPerPage, totalFilteredItems);

            var pagedTransactions = filteredTransactions
                .Skip(startIndex)
                .Take(_itemsPerPage);

            foreach (var transaction in pagedTransactions)
            {
                TransactionTemplate template = new TransactionTemplate(transaction)
                {
                    AutoSize = true
                };
                flowLayoutPanel1.Controls.Add(template);
                template.Show();
            }

            flowLayoutPanel1.ResumeLayout();
            flowLayoutPanel1.Refresh();

            if (totalFilteredItems > 0)
            {
                paginationStatusTextBox.Text = $"{startIndex + 1}-{endIndex} of {totalFilteredItems}";
            }
            else
            {
                paginationStatusTextBox.Text = "No transactions found";
            }
            TotalTransactionDay.Text = totalFilteredItems.ToString();
        }

        public void FilterData(string searchText)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TransactionTemplate transactionTemplate && transactionTemplate.Transaction != null)
                {
                    var transaction = transactionTemplate.Transaction;
                    transactionTemplate.Visible = (!string.IsNullOrEmpty(transaction.Trans_Name) &&
                                                   transaction.Trans_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                                                  (!string.IsNullOrEmpty(transaction.Note) &&
                                                   transaction.Note.Contains(searchText, StringComparison.OrdinalIgnoreCase));
                }
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoading) return;
            if ((_currentPage * _itemsPerPage) >= _totalItems) return; // No next page

            _currentPage++;
            DisplayTransactions(_currentTransactions, filterByDate: false);
            UpdatePaginationButtons();
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_isLoading) return;
            if (_currentPage == 1) return; // No previous page

            _currentPage--;
            DisplayTransactions(_currentTransactions, filterByDate: false);
            UpdatePaginationButtons();
        }


        private async void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = kryptonDateTimePicker1.Value.Date;

            try
            {
                _currentPage = 1;
                var transactions = await _presenter.LoadTransactionsByDateAsync(selectedDate);

                if (transactions == null || transactions.Count == 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    SetPaginationButtons(false, false);
                    lblTotalAmount.Text = "₱0.00"; // Reset total amount if no transactions
                    return;
                }

                _currentTransactions = transactions;
                _totalItems = transactions.Count;
                DisplayTransactions(transactions, filterByDate: false);
                UpdatePaginationButtons();

                decimal totalPaidAmount = transactions
        .Where(t => t.TransactionDateTime.Date == kryptonDateTimePicker1.Value.Date)
        .Sum(t => t.PaidAmount);

                UpdatePaidAmountLabel(totalPaidAmount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }

        }

        private void UpdatePaginationButtons()
        {
            btnPreviousPage.Enabled = _currentPage > 1;
            btnNextPage.Enabled = (_currentPage * _itemsPerPage) < _totalItems;
        }

        private void ShowLoadingIndicator(bool show)
        {
            if (_loadingLabel == null)
            {
                _loadingLabel = new Label
                {
                    Text = "Loading...",
                    AutoSize = true,
                    Location = new Point(10, 10),
                    Visible = show
                };
                this.Controls.Add(_loadingLabel);
            }
            else
            {
                _loadingLabel.Visible = show;
            }
        }

        public void SetPaginationStatusText(string statusText)
        {
            paginationStatusTextBox.Text = statusText;
        }

        public void SetPaginationButtons(bool enablePrevious, bool enableNext)
        {
            btnPreviousPage.Enabled = enablePrevious;
            btnNextPage.Enabled = enableNext;
        }
        private async void transPrintBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = kryptonDateTimePicker1.Value.Date;

            List<Transactions> filteredTransactions = await _presenter.LoadTransactionsByDateAsync(selectedDate);

            if (filteredTransactions == null || filteredTransactions.Count == 0)
            {
                MessageBox.Show("No transactions found for the selected date.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TransactionPrintDocs printDoc = new TransactionPrintDocs(filteredTransactions, selectedDate);
            printDoc.Print();
        }

        private void transExportBttn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = kryptonDateTimePicker1.Value.Date;
            string connectionString = "Data Source=LAPTOP-AEJ6B24K\\SQLEXPRESS;Initial Catalog=connected_subscribers_db;User ID=ISPSMS_JUHACA;Password=OPTICALITSOLUTIONS2025;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT * FROM dbo.transactions WHERE CAST([TransactionDateTime] AS DATE) = @SelectedDate";

            DataTable dt = GetDataTable(connectionString, query, selectedDate);
            if (dt.Rows.Count > 0)
            {
                SaveExcelFile(dt, selectedDate);
            }
            else
            {
                MessageBox.Show("No data found for the selected date.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetDataTable(string connectionString, string query, DateTime selectedDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        private void SaveExcelFile(DataTable dt, DateTime selectedDate)
        {
            using (SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                FileName = $"JUHACA {selectedDate:yyyy} TRANSACTIONS AS OF {selectedDate:MMMM dd, yyyy}.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {   
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Transactions");
                        ws.Cells["A1"].LoadFromDataTable(dt, true);

                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void UpdateDateTime()
        {
            Date.Text = DateTime.Now.ToString("MMMM dd, yyyy"); // Example: March 27, 2025
            DateTime today = DateTime.Now.Date;
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transExportBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}