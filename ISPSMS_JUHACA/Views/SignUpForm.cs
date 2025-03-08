using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.IVews;
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
    public partial class SignUpForm : Form, ISignUp
    {
        public event EventHandler Save;
        public SignUpForm(IUnitOfWork dbContext, IAccountsRepository repository)
        {
            InitializeComponent();
            new SignUpPresenter(this, dbContext, repository);
        }

        public string Username { get => tbUserName.Text.Trim().ToUpper(); set => tbUserName.Text = value; }
        public string AccountName { get => tbAccountName.Text.Trim().ToUpper(); set => tbAccountName.Text = value; }
        public string AccountPassword { get => tbPassword.Text; set => tbPassword.Text = value; }
        public string AccountRole { get => "DEFAULT"; set { } }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ShowError("Username is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AccountName))
            {
                ShowError("Account Name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AccountPassword))
            {
                ShowError("Password is required.");
                return false;
            }

            return true;
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Save?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
