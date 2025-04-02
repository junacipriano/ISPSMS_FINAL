using Domain.Models;
using Infastructure.Data.Repositories;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;
using System.Globalization;


namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class BillingCheckout : KryptonForm
    {
        private readonly IMainSubscriberPage _view;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        private IUnitOfWork dbContext;
        private readonly IUnitOfWork _dbContext;
        private readonly BillingItems _billingItems;
        private readonly BillingPage _billingPage;
        private readonly string _loggedInUser;
        private readonly MainForm _mainForm;
        private readonly string _currentUserName;
        private readonly string _currentUserRole;
        private readonly BillingPresenter _presenter;

        public BillingCheckout(IUnitOfWork dbContext, ConnectedSubscribers selectedSubscribers, BillingPage billingPage, MainForm mainForm)
        {
            InitializeComponent();
            ConSubsEntity = selectedSubscribers;
            _billingPage = billingPage;
            _dbContext = dbContext;
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm)); // Ensure mainForm isn't null
           _loggedInUser = _mainForm.GetUsername();

            _currentUserName = _mainForm.GetUsername();
            _currentUserRole = _mainForm.GetUserRole();
           
            _presenter = new BillingPresenter(billingPage, _dbContext);

            LoadBillingCheckoutData(ConSubsEntity);
            noteComboBox.Items.Clear();
            noteComboBox.Items.Add("None");
            noteComboBox.Items.Add("Advance");
            noteComboBox.Items.Add("Discount");
            noteComboBox.Items.Add("Partial");
            noteComboBox.SelectedIndex = 0;

        }

        private void BillingCheckout_Load(object sender, EventArgs e)
        {
        }

        public async void LoadBillingCheckoutData(ConnectedSubscribers entity)
        {
            if (ConSubsEntity != null)
            {
                var culture = new CultureInfo("fil-PH");

                subIDTextBox.Text = ConSubsEntity.subs_id.ToString();
                mainNameTextBox.Text = ConSubsEntity.Conn_Name;
                subNameTextBox.Text = ConSubsEntity.Conn_Name;
                statusTextBox.Text = ConSubsEntity.Status;
                addressTextBox.Text = ConSubsEntity.Address;
                dueDateTextBox.Text = ConSubsEntity.CurrentDuedate.ToString("MMMM d, yyyy");
                planTextBox.Text = ConSubsEntity.Plan;
                amountTextBox.Text = ConSubsEntity.MonthlyCharge.ToString("C", culture);
                receiptNoTextBox.Text = LoadNextReceiptNumber().ToString();
            }
        }
        private int LoadNextReceiptNumber()
        {
            int nextId = 1;
            if (_dbContext.transactionsRepository.GetAll().Any())
            {
                nextId = _dbContext.transactionsRepository.GetAll().Max(t => t.trans_id) + 1;
            }
            return nextId;
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            decimal monthlyCharge = ConSubsEntity.MonthlyCharge;
            decimal amount = 0;

            try
            {
                var culture = new CultureInfo("fil-PH");
                string amountText = amountTextBox.Text.Replace("₱", "").Trim();
                amount = decimal.Parse(amountText, NumberStyles.Number, culture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid amount format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal balance = monthlyCharge - amount;
            if (balance < 0) balance = 0;

            DateTime nextDueDate = ConSubsEntity.CurrentDuedate.AddMonths(1);

            var newTransaction = new Domain.Models.Transactions
            {
                subs_id = int.Parse(subIDTextBox.Text),
                Trans_Name = mainNameTextBox.Text,
                PaidAmount = amount,
                Balance = balance,
                Note = string.IsNullOrWhiteSpace(noteComboBox.Text) ? "None" : noteComboBox.Text,
                Duedate = nextDueDate.ToString("MMMM d, yyyy"), 
                TransactionDateTime = DateTime.Now,
                Address = addressTextBox.Text
            };

            decimal TotalCharge = monthlyCharge + balance;
            var existingSubscriber = _dbContext.connectedSubscriberRepository.Get(s => s.subs_id == ConSubsEntity.subs_id);

            if (existingSubscriber != null)
            {
                existingSubscriber.Balance = balance;
                existingSubscriber.MonthlyCharge = TotalCharge;
                existingSubscriber.CurrentDuedate = nextDueDate;

                _dbContext.connectedSubscriberRepository.Update(existingSubscriber);
                _dbContext.Save();
            }

            _dbContext.transactionsRepository.Add(newTransaction);
            _dbContext.Save();

            MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ensure transactions are sorted by date
            _presenter.LoadBillingItemsAsync();

            // Print receipt if needed
            DialogResult printReceipt = MessageBox.Show("Do you want to print the receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (printReceipt == DialogResult.Yes)
            {
                PrintReceipt(newTransaction);
            }

            // Log activity
            string activityDescription = $"Processed payment: {mainNameTextBox.Text}";
            if (!string.IsNullOrEmpty(noteComboBox.Text) && noteComboBox.Text != "None")
            {
                activityDescription += $" (Note: {noteComboBox.Text})";
            }
            LogActivity(activityDescription);

            this.Close();
        }


        private string FormatWithOrdinal(int day)
        {
            if (day >= 11 && day <= 13) return day + "th";
            return day + (day % 10 == 1 ? "st" : day % 10 == 2 ? "nd" : day % 10 == 3 ? "rd" : "th");
        }

        private void PrintReceipt(Transactions transaction)
        {
            var receiptForm = new ReceiptForm(transaction, _loggedInUser);
            receiptForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        { 
            amountTextBox.ReadOnly = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUserName,
                AccountRole = _currentUserRole,
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            _dbContext.activityRepository.Update(activity); // Use Add instead of Update for new records
            _dbContext.Save();
        }
    }
}
