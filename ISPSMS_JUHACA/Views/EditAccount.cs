using Domain.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class EditAccount : Form
    {
        private Accounts _account;
        private readonly DbContext dbContext;
        private readonly string _currentUserRole;

        public EditAccount(Accounts account, DbContext context, string currentUserRole)
        {
            InitializeComponent();
            _account = account;
            dbContext = context;
            _currentUserRole = currentUserRole;
            LoadAccountData();
        }

        // ...existing code...
        private void LoadAccountData()
        {
            tbUsername.Text = _account.Username;
            tbAccountName.Text = _account.AccountName;
            tbPassword.Text = _account.AccountPassword;
            ComboRole.SelectedText = _account.AccountRole;
            // Set other fields as needed

            if (_currentUserRole == "CEO")
            {
                ComboRole.Enabled = true;
                ComboRole.SelectedItem = _account.AccountRole; // Assuming you have a role field
            }
            else if (_currentUserRole == "ADMIN")
            {
                ComboRole.Enabled = true;
                ComboRole.SelectedItem = _account.AccountRole; // Assuming you have a role field
            }
            else
            {
                ComboRole.Enabled = false;
            }

            if (_currentUserRole == "DEFAULT")
            {
                MessageBox.Show("You do not have permission to edit this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _account.Username = tbUsername.Text;
            _account.AccountName = tbAccountName.Text;
            _account.AccountPassword = tbPassword.Text;
            _account.AccountRole = ComboRole.SelectedItem.ToString();
            // Update other fields as needed

            if (_currentUserRole == "CEO")
            {
                _account.AccountRole = ComboRole.SelectedItem.ToString();
            }
            else if (_currentUserRole == "ADMIN")
            {
                if (_account.AccountRole == "CEO" || _account.AccountRole == "ADMIN")
                {
                    MessageBox.Show("You do not have permission to modify this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _account.AccountRole = ComboRole.SelectedItem.ToString();
            }

            dbContext.SaveChanges();
            MessageBox.Show("Account details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentUserRole == "CEO")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dbContext.Remove(_account);
                    dbContext.SaveChanges();
                    MessageBox.Show("Account successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to delete this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
