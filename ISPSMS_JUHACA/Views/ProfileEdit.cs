using Domain.Models;
using Infastructure.Data.Repositories;
using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Views
{
    public partial class ProfileEdit : Form
    {
        private readonly IUnitOfWork _context;
        private readonly int _userId;
        private Accounts _account;
        private string _actualPassword;
        private bool _isPasswordVisible = false;
        private readonly string _currentUserName;
        private readonly string _currentUserRole;

        public ProfileEdit(int userId, string accountName, string username, string password, IUnitOfWork unitOfWork, string role)
        {
            InitializeComponent();
            _context = unitOfWork;
            _userId = userId;
            _currentUserName = accountName;
            _currentUserRole = role;

            try
            {
                // Retrieve user account from database
                _account = _context.accountsRepository.Get(a => a.account_id == _userId);
                if (_account == null)
                {
                    MessageBox.Show("Error: User account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                _actualPassword = password;

                // Split the name properly (handling multiple first names)
                var nameParts = accountName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (nameParts.Length >= 3)
                {
                    tbFName.Text = string.Join(" ", nameParts.Take(nameParts.Length - 2)); // First name (handling multiple parts)
                    tbMi.Text = nameParts[nameParts.Length - 2]; // Middle Initial
                    tbLName.Text = nameParts.Last(); // Last name
                }
                else if (nameParts.Length == 2)
                {
                    tbFName.Text = nameParts[0];
                    tbLName.Text = nameParts[1];
                    tbMi.Text = "";
                }
                else
                {
                    tbFName.Text = accountName;
                    tbLName.Text = "";
                    tbMi.Text = "";
                }

                tbUsername.Text = username;
                tbPass.UseSystemPasswordChar = true; // Mask the password
                tbConfirmPass.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_account == null) return;

            try
            {
                // Validate password fields
                if (string.IsNullOrWhiteSpace(tbPass.Text) || string.IsNullOrWhiteSpace(tbConfirmPass.Text))
                {
                    MessageBox.Show("Password fields cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate password confirmation
                if (tbPass.Text != tbConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate middle initial length (if provided)
                if (!string.IsNullOrWhiteSpace(tbMi.Text) && tbMi.Text.Length > 1)
                {
                    MessageBox.Show("Middle initial should only be one letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update account details
                _account.AccountName = $"{tbFName.Text} {tbMi.Text} {tbLName.Text}".Trim();
                _account.Username = tbUsername.Text;

                // Hash the new password before saving (only if changed)
                if (tbPass.Text != _actualPassword)
                {
                    _account.AccountPassword = BCrypt.Net.BCrypt.HashPassword(tbPass.Text);
                }

                LogActivity("Edited his/her account: " + _account.AccountName);

                _context.accountsRepository.Update(_account);
                _context.Save(); // Save changes to the database

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Switch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _isPasswordVisible = Switch.Checked;

                tbPass.UseSystemPasswordChar = !_isPasswordVisible;
                tbConfirmPass.UseSystemPasswordChar = !_isPasswordVisible;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while toggling password visibility: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogActivity(string activityDescription)
        {
            try
            {
                var activity = new Domain.Models.Activity
                {
                    AccountName = _currentUserName,
                    AccountRole = _currentUserRole,
                    ActivitiesDone = activityDescription,
                    ActivitiesDateTime = DateTime.Now
                };

                _context.activityRepository.Update(activity);
                _context.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to log activity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
