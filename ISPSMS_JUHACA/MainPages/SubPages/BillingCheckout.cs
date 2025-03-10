using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
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
        public BillingCheckout(IUnitOfWork dbContext, ConnectedSubscribers selectedSubscribers, BillingPage billingPage)
        {
            InitializeComponent();
            ConSubsEntity = selectedSubscribers;
            _billingPage = billingPage;
            _dbContext = dbContext;
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
            decimal amount = decimal.TryParse(amountTextBox.Text, out decimal value) ? value : 0;
            decimal balance = ConSubsEntity.MonthlyCharge - amount;
            var newTransaction = new Domain.Models.Transactions
            {
                trans_id = int.Parse(receiptNoTextBox.Text),
                subs_id = int.Parse(subIDTextBox.Text),
                Trans_Name = mainNameTextBox.Text,
                Address = addressTextBox.Text,
                PaidAmount = amount,
                Balance = balance,
                Note = noteComboBox.Text = "None",
                Duedate = dueDateTextBox.Text,
                TransactionDateTime = DateTime.Now
            };
            _dbContext.transactionsRepository.Add(newTransaction);
            _dbContext.Save();

            MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _billingPage.LoadBillingItems();

            this.Close();
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
    }
}
