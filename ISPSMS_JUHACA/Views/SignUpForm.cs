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

        public string Username
        {
            get => tbUserName.Text.Trim().ToUpper();
            set => tbUserName.Text = value;
        }

        public string AccountName
        {
            get
            {
                return $"{tbFirstName.Text.Trim()} {tbMi.Text.Trim()} {tbLastName.Text.Trim()}".Trim();
            }
            set
            {
                try
                {
                    var parts = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    tbFirstName.Text = parts.Length > 0 ? parts[0] : "";
                    tbMi.Text = parts.Length > 1 ? parts[1].Substring(0, 1).ToUpper() : ""; // Ensuring only one letter
                    tbLastName.Text = parts.Length > 2 ? parts[2] : "";
                }
                catch (Exception ex)
                {
                    ShowError($"Error setting account name: {ex.Message}");
                }
            }
        }

        public string AccountPassword
        {
            get => tbPassword.Text;
            set => tbPassword.Text = value;
        }

        public string AccountRole
        {
            get => "DEFAULT";
            set { }
        }

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
            try
            {
                if (string.IsNullOrWhiteSpace(Username))
                {
                    ShowError("Username is required.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text))
                {
                    ShowError("First name and last name are required.");
                    return false;
                }

                if (!string.IsNullOrWhiteSpace(tbMi.Text) && tbMi.Text.Length > 1)
                {
                    ShowError("Middle initial should be only one letter.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(AccountPassword))
                {
                    ShowError("Password is required.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ShowError($"Unexpected validation error: {ex.Message}");
                return false;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    Save?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                ShowError($"An error occurred while saving: {ex.Message}");
            }
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {

            if (tbPassword.InvokeRequired)
            {
                tbPassword.Invoke(new Action(() => TogglePasswordVisibility()));
            }
            else
            {
                TogglePasswordVisibility();
            }

        }

        private void TogglePasswordVisibility()
        {
            tbPassword.Password = !tbPassword.Password;

            // Optionally change button text/icon for better UX
            ShowPass.Text = tbPassword.Password ? "Show" : "Hide";

            tbPassword.Refresh();
        }

        public void ClearFields()
        {
            tbUserName.Text = "";
            tbFirstName.Text = "";
            tbMi.Text = "";
            tbLastName.Text = "";
            tbPassword.Text = "";
            tbConfirmPass.Text = "";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearFields();
        }
    }
}
