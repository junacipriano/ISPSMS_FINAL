﻿using Infastructure.Data.Repositories.IRepositories;
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
using ISPSMS_JUHACA.Views.toPrintData;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class Transaction : MaterialForm, ITransactionView
    {
        private readonly TransactionPresenter _presenter;
        private readonly MainForm _mainForm;
        private readonly BindingSource _bindingSource;
        private bool _isLoading = false;
        private Label _loadingLabel;

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
            materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // Enable double buffering on the existing flowLayoutPanel1
            flowLayoutPanel1.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(flowLayoutPanel1, true, null);

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        public async void Transaction_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = "Loading...";
            ShowLoadingIndicator(true);
            await Task.Delay(100);
            await _presenter.LoadAllTransactionDataAsync();
            ShowLoadingIndicator(false);
        }

        public void UpdatePaidAmountLabel(decimal totalPaidAmount)
        {
            lblTotalAmount.Text = totalPaidAmount.ToString("C");
        }

        public void DisplayTransactions(IEnumerable<Transactions> transactions)
        {
            flowLayoutPanel1.SuspendLayout();

            // Avoid excessive UI operations
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            foreach (var transaction in transactions)
            {
                TransactionTemplate transactionTemplate = new TransactionTemplate(transaction)
                {
                    AutoSize = true
                };
                flowLayoutPanel1.Controls.Add(transactionTemplate);
                transactionTemplate.Show();
            }

            flowLayoutPanel1.ResumeLayout();
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

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_isLoading) return;
            await _presenter.LoadTransactionsPageAsync(false);
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoading) return;
            await _presenter.LoadTransactionsPageAsync(true);
        }

        private async void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = kryptonDateTimePicker1.Value.Date;
            await _presenter.LoadTransactionsByDateAsync(selectedDate);
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
    

    }
}