using Domain.Models;
using Krypton.Toolkit;
using Microsoft.VisualBasic;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class TransactionTemplate : UserControl
    {
        private readonly Transactions _transaction;

        private PrintDocument printDocument = new PrintDocument();
        public Transactions Transaction { get; private set; }
        public TransactionTemplate(Transactions transaction)
        {
            InitializeComponent();
            Transaction = transaction;
            _transaction = transaction;
            LoadTransactionData();
        }

        public void LoadTransactionData()
        {
            receiptNoTextBox.Text = _transaction.trans_id.ToString();
            subIDTextBox.Text = _transaction.subs_id.ToString();
            name.Text = _transaction.Trans_Name;
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

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string printText = "Hello test print";
            Font printFont = new Font("Arial", 12);
            e.Graphics.DrawString(printText, printFont, Brushes.Black, 50, 50);
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
