using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Models;
using ISPSMS_JUHACA.MainPages.SubPages;
using Krypton.Toolkit;
using MaterialSkin.Controls;
using MaterialSkin;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class Transaction : MaterialForm, ITransactionView
    {
        private readonly TransactionPresenter _presenter;
        private MainForm mainForm;
        private BindingSource bindingSource;
        private int _currentPage = 1;
        private const int PageSize = 20;
        private int _totalPages = 1;

        private bool _isLoading = false;
        private Label loadingLabel;

        public BindingSource BindingSource => bindingSource;

        public Transaction(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _presenter = new TransactionPresenter(this, dbContext);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            flowLayoutPanel1.AutoScroll = true;  // Enable scrolling
            flowLayoutPanel1.WrapContents = false;  // Prevent horizontal wrapping
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;  // Arrange items vertically


        }

        private async void Transaction_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = "Loading...";
            btnPreviousPage.Enabled = false;
            btnPreviousPage.Text = "Previous";
            await Task.Delay(100);
            await LoadTransactionsAsync(_currentPage);
            await UpdateTotalPaidAmountAsync();

        }

        private async Task LoadTransactionsAsync(int pageNumber)
        {
            if (_isLoading) return;
            _isLoading = true;

            try
            {



                await _presenter.LoadTransactionsAsync(pageNumber, PageSize);
                _totalPages = await _presenter.GetTotalPagesAsync(PageSize);
                UpdatePaginationButtons();

                await UpdateTotalPaidAmountAsync();
            }
            finally
            {

                _isLoading = false;
            }
        }


        public void UpdatePaidAmountLabel(decimal totalPaidAmount)
        {
            lblTotalAmount.Text = "Loading...";
            lblTotalAmount.Text = totalPaidAmount.ToString("C");
        }


        public void DisplayTransactions(List<Transactions> transactions)
        {

            flowLayoutPanel1.Controls.Clear();


            // Reverse order to show latest transactions at the top
            foreach (var transaction in transactions.OrderByDescending(t => t.TransactionDateTime))
            {
                TransactionTemplate transactionTemplate = new TransactionTemplate(transaction)
                {

                    AutoSize = true
                };

                flowLayoutPanel1.Controls.Add(transactionTemplate);
                transactionTemplate.Show();
            }

        }

        public void FilterData(string searchText)
        {
            if (flowLayoutPanel1 == null || flowLayoutPanel1.Controls.Count == 0)
            {
                return; // Exit if there are no items to filter
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TransactionTemplate transactionTemplate && transactionTemplate.Transaction != null)
                {
                    var transaction = transactionTemplate.Transaction;
                    bool isVisible = (!string.IsNullOrEmpty(transaction.Trans_Name) &&
                                      transaction.Trans_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                                     (!string.IsNullOrEmpty(transaction.Note) &&
                                      transaction.Note.Contains(searchText, StringComparison.OrdinalIgnoreCase));

                    transactionTemplate.Visible = isVisible;
                }
            }
        }
        private async Task UpdateTotalPaidAmountAsync()
        {
            decimal totalPaidAmount = await _presenter.GetTotalPaidAmountAsync();
            UpdatePaidAmountLabel(totalPaidAmount);
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_isLoading || _currentPage <= 1) return;
            _currentPage--;
            await LoadTransactionsAsync(_currentPage);
        }



        private void UpdatePaginationButtons()
        {
            btnPreviousPage.Enabled = _currentPage > 1;
            btnNextPage.Enabled = _currentPage < _totalPages;

        }



        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_isLoading || _currentPage >= _totalPages) return; // Prevent multiple clicks
            _currentPage++;
            await LoadTransactionsAsync(_currentPage);
        }

        private async Task LoadTransactionsByDateAsync(DateTime date)
        {
            if (_isLoading) return;
            _isLoading = true;

            try
            {
                var transactions = await _presenter.GetTransactionsByDateAsync(date);
                DisplayTransactions(transactions);
            }
            finally
            {
                _isLoading = false;
            }
        }
        private void transactionsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }




        private async void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = kryptonDateTimePicker1.Value.Date;
            await LoadTransactionsByDateAsync(selectedDate);
        }

    }
}
