using Domain.Models;
using ISPSMS_JUHACA.Views;
using Krypton.Toolkit;
using Microsoft.Graph.Models.Security;
using Microsoft.VisualBasic;
using System;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class TransactionTemplate : UserControl
    {
        private readonly Transactions _transaction;
        private readonly string _loggedInUser;

        private PrintDocument printDocument = new PrintDocument();
        public Transactions Transaction { get; private set; }
        public TransactionTemplate(Transactions transaction)
        {
            InitializeComponent();
            Transaction = transaction;
            _transaction = transaction;
            this.DoubleBuffered = true;
            LoadTransactionData();
        }

        public void LoadTransactionData()
        {
            var culture = new CultureInfo("fil-PH");
            receiptNoTextBox.Text = _transaction.trans_id.ToString();
            subIDTextBox.Text = _transaction.subs_id.ToString();
            name.Text = _transaction.Trans_Name;
            amount.Text = _transaction.PaidAmount.ToString("C", culture);
            balance.Text = _transaction.Balance.ToString("C", culture);
            note.Text = _transaction.Note;
            dueDate.Text = _transaction.Duedate;
            date.Text = _transaction.TransactionDateTime.ToString("MMMM d, yyyy ");
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

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Transactions transaction = new Transactions();
            var receiptForm = new ReceiptForm(transaction, _loggedInUser);
            receiptForm.ShowDialog();
        }

        private void prinyBtn_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void amount_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
