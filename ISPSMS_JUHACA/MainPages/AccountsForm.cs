using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ISPSMS_JUHACA.MainPages
{
    public partial class AccountsForm : Form
    {
        private string currentUserRole;
        private BindingSource bindingSource;
        private IUnitOfWork dbContext;
        private MainForm mainForm;

/*        public AccountsForm()
        {
            InitializeComponent();
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
            currentUserRole = GetCurrentUserRole();
        }*/

        public AccountsForm(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;
            bindingSource = new BindingSource();
            currentUserRole = GetCurrentUserRole();
        }

        public void getAccounts()
        {
            try
            {
                var accounts = dbContext.accountsRepository.GetAll();
                accountsGridView.DataSource = accounts; // Assuming you have a DataGridView named accountsGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accountsGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                var selectedAccount = accountsGridView.Rows[e.RowIndex].DataBoundItem as Accounts;
                if (selectedAccount != null)
                {
                    if (currentUserRole == "DEFAULT")
                    {
                        MessageBox.Show("You do not have permission to edit this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var editForm = new EditAccount(selectedAccount, dbContext as DbContext, currentUserRole); // Pass currentUserRole
                    editForm.ShowDialog();
                    getAccounts(); // Refresh the accounts grid view after editing
                }
            }
            else if (accountsGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                if (currentUserRole != "CEO")
                {
                    MessageBox.Show("You do not have permission to delete this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedAccount = accountsGridView.Rows[e.RowIndex].DataBoundItem as Accounts;
                if (selectedAccount != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this account?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            dbContext.accountsRepository.Remove(selectedAccount);
                            dbContext.Save();
                            getAccounts(); // Refresh the accounts grid view after deletion
                            MessageBox.Show("Account successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private string GetCurrentUserRole()
        {
            var identity = System.Threading.Thread.CurrentPrincipal?.Identity;
            if (identity is ClaimsIdentity claimsIdentity)
            {
                var roleClaim = claimsIdentity.FindFirst(ClaimTypes.Role);
                return roleClaim?.Value ?? "DEFAULT";
            }
            return "DEFAULT";
        }

       
    }
}
