using Domain.Models;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Views
{
    public partial class ReceiptForm : KryptonForm
    {
        private Transactions _transaction;
        private Accounts _loggedInUser;
        public ReceiptForm(Transactions transactionData, Accounts loggedInUser)
        {
            InitializeComponent();
            _transaction = transactionData;
            _loggedInUser = loggedInUser;
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            receiptNoTextBox.Text = _transaction.trans_id.ToString();
            transactionDateTextBox.Text = _transaction.TransactionDateTime.ToString();   
            addressTextBox.Text = _transaction.Address.ToString();
            amountNumberTextBox.Text = _transaction.PaidAmount.ToString("C");
            amountWordTextBox.Text = ConvertAmountToWords(_transaction.PaidAmount);
            receivedByTextBox.Text = _loggedInUser.AccountName;
        }

        private string ConvertAmountToWords(decimal amount)
        {
            if (amount == 0)
                return "Zero";

            String[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            String[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            String[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            String[] thousands = { "", "Thousand" };

            int num = (int)amount;
            string words = "";
            int thousandCounter = 0;

            while (num > 0)
            {
                int chunk = num % 1000;
                if (chunk > 0)
                {
                    string chunkWords = "";
                    int hundreds = chunk / 100;
                    int remainder = chunk % 100;

                    if (hundreds > 0)
                    {
                        chunkWords += units[hundreds] + " Hundred ";
                    }

                    if (remainder > 0)
                    {
                        if (remainder < 10)
                        {
                            chunkWords += units[remainder];
                        }
                        else if (remainder < 20)
                        {
                            chunkWords += teens[remainder - 10];
                        }
                        else
                        {
                            chunkWords += units[remainder / 10];
                            if (remainder % 10 > 0)
                                chunkWords += "-" + units[remainder % 10];
                        }
                    }

                    words = chunkWords + " " + thousands[thousandCounter] + " " + words;
                }
                num /= 1000;
                thousandCounter++;
            }

            return words.Trim() + " Pesos Only";
        }
    }
}
