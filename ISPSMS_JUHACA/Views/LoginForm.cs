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
    public partial class LoginForm : Form, ILogin
    {
        public event EventHandler Login;
        public event EventHandler SignUp;

        public LoginForm()
        {
            InitializeComponent();
        }

        public string Username
        {
            get => tbUsername.Text.Trim();
            set => tbUsername.Text = value;
        }

        public string AccountPassword
        {
            get => tbPassword.Text;
            set => tbPassword.Text = value;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CloseForm()
        {
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Login?.Invoke(this, EventArgs.Empty);
                // Remove this.Close(); as it will be handled in the presenter
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp?.Invoke(this, EventArgs.Empty);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ShowError("Username is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(AccountPassword))
            {
                ShowError("Password is required.");
                return false;
            }

            return true;
        }


    }
}
