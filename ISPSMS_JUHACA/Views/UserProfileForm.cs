using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Windows.Forms;
using Domain.Models;

namespace ISPSMS_JUHACA.Views
{
    public partial class UserProfileForm : Form
    {
        private ProfileEdit _profileEdit;
        private readonly IUnitOfWork _unitOfWork;
        private string _actualPassword;
        private Accounts _account;
        private Label lblUsername;
        private Label lblRole;

        public event EventHandler? Logout;

        public UserProfileForm(IUnitOfWork unitOfWork, int userId)
        {
            InitializeComponent();
            lblUsername = new Label();
            lblRole = new Label();

            Controls.Add(lblUsername);
            Controls.Add(lblRole);
            _unitOfWork = unitOfWork;

            // Load user account details
            _account = _unitOfWork.accountsRepository.Get(a => a.account_id == userId);
            if (_account != null)
            {
                UpdateProfile(_account.Username, _account.AccountRole, _account.AccountPassword, _account.AccountName, _account.account_id.ToString());
            }
        }

        public void UpdateProfile(string username, string role, string password, string pname, string id)
        {
            _actualPassword = password;
            Username.Text = username;
            UserRole.Text = role;
            personName.Text = username;
            personPassword.Text = new string('*', password.Length);
            personUsername.Text = pname;
            personID.Text = id;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_profileEdit == null || _profileEdit.IsDisposed)
            {
                _profileEdit = new ProfileEdit(
                    Convert.ToInt32(personID.Text),
                    personName.Text,
                    personUsername.Text,
                    _actualPassword,
                    _unitOfWork, UserRole.Text
                );
            }

            _profileEdit.FormClosed += ProfileEdit_FormClosed; // Refresh after closing
            _profileEdit.Show();
        }

        private void ProfileEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload updated data from the database
            _account = _unitOfWork.accountsRepository.Get(a => a.account_id == Convert.ToInt32(personID.Text));
            if (_account != null)
            {
                UpdateProfile(_account.AccountName, _account.AccountRole, _account.AccountPassword, _account.Username, _account.account_id.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void Switch_CheckedChanged(object sender, EventArgs e)
        {
            personPassword.Text = Switch.Checked ? _actualPassword : new string('*', _actualPassword.Length);
        }
    }
}
