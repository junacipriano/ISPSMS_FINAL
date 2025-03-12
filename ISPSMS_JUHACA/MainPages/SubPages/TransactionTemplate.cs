using Domain.Models;
using Krypton.Toolkit;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class TransactionTemplate : KryptonForm
    {
        private readonly Transactions _transaction;

        public TransactionTemplate(Transactions transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            LoadTransactionData();
        }

        public void LoadTransactionData()
        {
            receiptNoTextBox.Text = _transaction.trans_id.ToString();
            subIDTextBox.Text = _transaction.subs_id.ToString();
            name.Text = _transaction.Trans_Name;
            address.Text = _transaction.Address;
            amount.Text = _transaction.PaidAmount.ToString("C");
            balance.Text = _transaction.Balance.ToString("C");
            note.Text = _transaction.Note;
            dueDate.Text = _transaction.Duedate;
            date.Text = _transaction.TransactionDateTime.ToString("MMMM d, yyyy HH:mm");
            time.Text = _transaction.TransactionDateTime.ToString("hh:mm tt");
        }

        private void TransactionTemplate_Load(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
