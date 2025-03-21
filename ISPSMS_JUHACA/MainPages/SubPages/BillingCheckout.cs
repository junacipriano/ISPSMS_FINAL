using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;
using Krypton.Toolkit;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Unity.Storage.RegistrationSet;

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
        private readonly Accounts _loggedInUser;
        private readonly MainForm _mainForm;
        private readonly string _currentUserName;
        private readonly string _currentUserRole;

        public BillingCheckout(IUnitOfWork dbContext, ConnectedSubscribers selectedSubscribers, BillingPage billingPage, MainForm mainForm)
        {
            InitializeComponent();
            ConSubsEntity = selectedSubscribers;
            _billingPage = billingPage;
            _dbContext = dbContext;
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm)); // Ensure mainForm isn't null

            _currentUserName = _mainForm.GetUsername();
            _currentUserRole = _mainForm.GetUserRole();

            LoadBillingCheckoutData(ConSubsEntity);
        }

        private void BillingCheckout_Load(object sender, EventArgs e)
        {
        }

        public void LoadBillingCheckoutData(ConnectedSubscribers entity)
        {
            if (ConSubsEntity != null)
            {
                subIDTextBox.Text = ConSubsEntity.subs_id.ToString();
                mainNameTextBox.Text = ConSubsEntity.Conn_Name;
                subNameTextBox.Text = ConSubsEntity.Conn_Name;
                statusTextBox.Text = ConSubsEntity.Status;
                addressTextBox.Text = ConSubsEntity.Address;
                dueDateTextBox.Text = ConSubsEntity.CurrentDuedate.ToString("MMMM d, yyyy");
                planTextBox.Text = ConSubsEntity.Plan;
                amountTextBox.Text = ConSubsEntity.MonthlyCharge.ToString("C");
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.TryParse(amountTextBox.Text.Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal value) ? value : 0;
            decimal balance = ConSubsEntity.MonthlyCharge - amount;
            DateTime nextDueDate = ConSubsEntity.CurrentDuedate.AddMonths(1);
            string formattedDueDate = FormatWithOrdinal(nextDueDate.Day);
            var newTransaction = new Domain.Models.Transactions
            {
                trans_id = int.Parse(receiptNoTextBox.Text),
                subs_id = int.Parse(subIDTextBox.Text),
                Trans_Name = mainNameTextBox.Text,
                PaidAmount = amount,
                Balance = balance,
                Note = noteComboBox.Text,
                Duedate = formattedDueDate,
                TransactionDateTime = DateTime.Now
            };
            _dbContext.transactionsRepository.Add(newTransaction);
            _dbContext.Save();

            MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult printReceipt = MessageBox.Show("Do you want to print the receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (printReceipt == DialogResult.Yes)
            {
                PrintReceipt(newTransaction);
            }

            // Log the activity
            string activityDescription = $"Processed payment: {mainNameTextBox.Text}";
            if (!string.IsNullOrEmpty(noteComboBox.Text) && noteComboBox.Text != "None")
            {
                activityDescription += $" (Note: {noteComboBox.Text})";
            }
            LogActivity(activityDescription);

            _billingPage.LoadBillingItems();
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
            noteComboBox.Enabled = true;
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
