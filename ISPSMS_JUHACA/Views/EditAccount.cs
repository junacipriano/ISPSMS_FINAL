using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Windows.Forms;
using ISPSMS_JUHACA.Views.IVews.ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Views
{
    public partial class EditAccount : Form, IEditAccountView
    {
        private readonly EditAccountPresenter _presenter;
        private bool isLoading = false;

        public EditAccount(Accounts selectedAccount, IUnitOfWork dbContext1, string currentUserRole, string currentUserName)
        {
            InitializeComponent();
            _presenter = new EditAccountPresenter(this, dbContext1, selectedAccount, currentUserName, currentUserRole);
            CurrentUserRole = currentUserRole;
            LoadAccountData();
        }

        public string Username
        {
            get => tbUsername.Text;
            set => tbUsername.Text = value;
        }

        public string AccountName
        {
            get => tbAccountName.Text;
            set => tbAccountName.Text = value;
        }

        public string Password
        {
            get => tbPassword.Text;
            set => tbPassword.Text = value;
        }

        public string ConfirmPassword
        {
            get => tbConfirmPass.Text;
            set => tbConfirmPass.Text = value;
        }

        public string ProfileName
        {
            get => pName.Text;
            set => pName.Text = value;
        } 
        
        public string ProfileRole
        {
            get => pRole.Text;
            set => pRole.Text = value;
        }



        public string AccountRole
        {
            get => ComboRole.SelectedItem?.ToString();
            set
            {
                if (CurrentUserRole == "ADMIN" && (value == "ADMIN" || value == "CEO"))
                {
                    MessageBox.Show("You do not have permission to change this role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ComboRole.SelectedItem = value;
            }
        }

        public string CurrentUserRole { get; }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void LoadAccountData()
        {
            isLoading = true;
            _presenter.LoadAccountData();
            isLoading = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _presenter.SaveAccount();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (CurrentUserRole == "CEO")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _presenter.DeleteAccount();
                }
            }
            else
            {
                ShowMessage("You do not have permission to delete this account.", "Access Denied");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {





















        }
    }
}
