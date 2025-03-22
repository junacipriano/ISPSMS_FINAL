using ISPSMS_JUHACA.Views.IVews;
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
    public partial class LoginForm : KryptonForm, ILogin
    {
        public event EventHandler Login;
        public event EventHandler SignUp;

        public LoginForm(Infastructure.Data.Repositories.IRepositories.IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        }

        public string Username
        {
            get
            {
                if (tbUsername.InvokeRequired)
                {
                    return (string)tbUsername.Invoke(new Func<string>(() => tbUsername.Text.Trim()));
                }
                return tbUsername.Text.Trim();
            }
            set
            {
                if (tbUsername.InvokeRequired)
                {
                    tbUsername.Invoke(new Action(() => tbUsername.Text = value));
                }
                else
                {
                    tbUsername.Text = value;
                }
            }
        }

        public string AccountPassword
        {
            get
            {
                if (tbPassword.InvokeRequired)
                {
                    return (string)tbPassword.Invoke(new Func<string>(() => tbPassword.Text));
                }
                return tbPassword.Text;
            }
            set
            {
                if (tbPassword.InvokeRequired)
                {
                    tbPassword.Invoke(new Action(() => tbPassword.Text = value));
                }
                else
                {
                    tbPassword.Text = value;
                }
            }
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
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateInputs())
                {
                    Login?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            SignUp?.Invoke(this, EventArgs.Empty);
        }
    }
}