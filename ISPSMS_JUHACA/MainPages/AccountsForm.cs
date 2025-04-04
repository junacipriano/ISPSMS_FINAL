﻿   using Domain.Models;
using Infastructure.Data.Repositories;
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
        private readonly string _currentUserName;
        private readonly string _currentUserRole;

        public AccountsForm(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            bindingSource = new BindingSource();
            currentUserRole = mainForm.GetUserRole();
            _currentUserName = mainForm.GetUsername();
            _currentUserRole = mainForm.GetUserRole();

            accountsGridView.CellFormatting += accountsGridView_CellFormatting;

            getAccounts();
        }

        public void getAccounts()
        {
            try
            {
                var accounts = dbContext.accountsRepository.GetAll();
                accountsGridView.DataSource = accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accountsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is "AccountPassword" and the value is not null
            if (accountsGridView.Columns[e.ColumnIndex].DataPropertyName == "AccountPassword" && e.Value != null)
            {
                e.Value = new string('*', 10); // Show 10 asterisks
                e.FormattingApplied = true;
            }
        }

        private void accountsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            var selectedAccount = accountsGridView.Rows[e.RowIndex].DataBoundItem as Accounts;
            if (selectedAccount == null) return;

            if (accountsGridView.Columns[e.ColumnIndex].Name == "editButton" && e.RowIndex >= 0)
            {
                if (currentUserRole == "DEFAULT")
                {
                    MessageBox.Show("You do not have permission to edit this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (currentUserRole == "ADMIN" && (selectedAccount.AccountRole == "ADMIN" || selectedAccount.AccountRole == "CEO"))
                {
                    MessageBox.Show("You can only edit accounts with DEFAULT role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Update the constructor call to include the missing 'currentUserName' parameter
                var editForm = new EditAccount(selectedAccount, dbContext, currentUserRole, mainForm.GetUsername());
                editForm.ShowDialog();
                getAccounts();
            }
            else if (accountsGridView.Columns[e.ColumnIndex].Name == "deleteButton" && e.RowIndex >= 0)
            {
                if (currentUserRole == "ADMIN" && (selectedAccount.AccountRole == "ADMIN" || selectedAccount.AccountRole == "CEO"))
                {
                    MessageBox.Show("You can only delete accounts with DEFAULT role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (currentUserRole == "ADMIN" && selectedAccount.AccountRole == "DEFAULT")
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
                            LogActivity("Deleted account: " + selectedAccount.Username);
                            getAccounts();
                            MessageBox.Show("Account successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (currentUserRole != "CEO")
                {
                    MessageBox.Show("You do not have permission to delete this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
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
                            LogActivity("Deleted account: " + selectedAccount.Username);
                            getAccounts();
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

        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUserName,
                AccountRole = _currentUserRole,
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            dbContext.activityRepository.Update(activity);
            dbContext.Save();
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboFilter.SelectedItem.ToString();

            try
            {
                var accounts = dbContext.accountsRepository.GetAll();

                if (selectedRole != "ALL")
                {
                    accounts = accounts.Where(a => a.AccountRole == selectedRole).ToList();
                }

                accountsGridView.DataSource = accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void accountsGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == accountsGridView.Columns["editButton"].Index ||
                    e.ColumnIndex == accountsGridView.Columns["deleteButton"].Index)
                {
                    // Prevent default paint
                    e.Handled = true;

                    // Set your custom background color
                    Color bgColor = Color.FromArgb(255, 255, 252);
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    // Draw the image
                    Image image = null;
                    if (e.ColumnIndex == accountsGridView.Columns["editButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\edit.png");
                    }
                    else if (e.ColumnIndex == accountsGridView.Columns["deleteButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\minus-circle.png");
                    }

                    if (image != null)
                    {
                        var imageSize = new Size(25, 25); // Desired size
                        var x = e.CellBounds.Left + (e.CellBounds.Width - imageSize.Width) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - imageSize.Height) / 2;
                        e.Graphics.DrawImage(image, new Rectangle(new Point(x, y), imageSize));
                    }
                }
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == accountsGridView.Columns["editButton"].Index ||
                    e.ColumnIndex == accountsGridView.Columns["deleteButton"].Index)
                {
                    e.Handled = true;

                    Color bgColor = Color.FromArgb(255, 255, 252);
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    Image image = null;
                    if (e.ColumnIndex == accountsGridView.Columns["editButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\edit.png");
                    }
                    else if (e.ColumnIndex == accountsGridView.Columns["deleteButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\minus-circle.png");
                    }

                    if (image != null)
                    {
                        var imageSize = new Size(25, 25);
                        var x = e.CellBounds.Left + (e.CellBounds.Width - imageSize.Width) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - imageSize.Height) / 2;
                        e.Graphics.DrawImage(image, new Rectangle(new Point(x, y), imageSize));
                    }
                }
            }
        }
    }
}
