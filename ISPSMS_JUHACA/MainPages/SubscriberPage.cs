using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using System.Collections.Generic;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.IVews;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Krypton.Toolkit;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class SubscriberPage : KryptonForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        internal bool isEdit;
        private MainForm mainForm;
        private MaterialButton activeButton;
        private readonly string _currentUsername;
        private readonly string _currentUserRole;

        public BindingSource BindingSource => bindingSource;
        private List<ConnectedSubscribers> originalSubscribers = new List<ConnectedSubscribers>();
        public SubscriberPage(IUnitOfWork dbContext, MainForm mainForm)  // Change parameter name to match usage
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;  // Assign the passed instance to the class-level variable



            _currentUsername = mainForm.GetUsername();
            _currentUserRole = mainForm.GetUserRole();

            bindingSource = new BindingSource();
            connectedsubscribersGridView.AutoGenerateColumns = false;

            materialComboBox1.Items.Add("All");
            materialComboBox1.Items.Add("Active");
            materialComboBox1.Items.Add("Past due");
            materialComboBox1.Items.Add("Overdue");


            materialComboBox1.SelectedIndex = 0;
            connectedsubscribersGridView.AllowUserToOrderColumns = false;
        }

        private void SetActiveButton(MaterialButton clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.UseAccentColor = false;
            }

            activeButton = clickedButton;
            activeButton.UseAccentColor = true;
        }

        public void getSubscribers()
        {
            originalSubscribers = dbContext.connectedSubscriberRepository.GetAll()
         .OrderByDescending(s => s.Duedate)
         .ToList();
            AddActionButtons();

            // Assign statuses
            UpdateStatuses();

            if (connectedsubscribersGridView.Rows.Count > 0)
            {
                connectedsubscribersGridView.Rows[0].Selected = false;
            }

            GetColumnOrder();

            // Set data source
            bindingSource.DataSource = originalSubscribers;
            connectedsubscribersGridView.DataSource = bindingSource;
            // Move buttons to last position
            MoveButtonsToLastColumn();
            var currentDueDateColumn = connectedsubscribersGridView.Columns["currentDuedateDataGridViewTextBoxColumn"];
            if (currentDueDateColumn != null)
            {
                currentDueDateColumn.Visible = false;
            }
            var connNameColumn = connectedsubscribersGridView.Columns["Conn_Name"];
            if (connNameColumn != null)
            {
                connNameColumn.Visible = false;
            }

            TotalSubscriberLabel.Text = originalSubscribers.Count.ToString();
        }

        private void MoveToDisconnectedList(ConnectedSubscribers subscriber)
        {
            try
            {
                // Create new Disconnected Subscriber
                var disconnectedSubscriber = new DisconnectedSubscribers
                {
                    Disconn_Name = subscriber.Conn_Name,
                    ContactNumber = subscriber.ContactNumber,
                    Address = subscriber.Address,
                    Plan = subscriber.Plan,
                    Status = "Disconnected",
                    Duedate = subscriber.Duedate,
                    CurrentDuedate = DateTime.Now,
                    InstallationDate = subscriber.InstallationDate,
                    MonthlyCharge = subscriber.MonthlyCharge,
                    Balance = subscriber.Balance,
                    Charge = subscriber.Charge,
                };

                // Add to disconnected list and remove from connected list
                dbContext.disconnectedSubscriberRepository.Add(disconnectedSubscriber);
                dbContext.connectedSubscriberRepository.Remove(subscriber);
                dbContext.Save();

                // Optionally, update the UI
                bindingSource.Remove(subscriber);
                MessageBox.Show("Subscriber automatically disconnected due to Prepaid plan and overdue date.", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while disconnecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void disconnectedbtn_Click(object sender, EventArgs e)
        {


            var disconnectedForm = new Disconnected(dbContext, this);
            disconnectedForm.ShowDialog();
        }

        private void connectedsubscribersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (connectedsubscribersGridView.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().Trim();

                Console.WriteLine($"Row {e.RowIndex}, Column {e.ColumnIndex}, Status Value: {status}");

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
                else if (status.Equals("Past Due", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
                else if (status.Equals("Overdue", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
            }
        }



        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedSubscriber = connectedsubscribersGridView.Rows[e.RowIndex].DataBoundItem as Domain.Models.ConnectedSubscribers;
            if (selectedSubscriber == null) return;

            string columnName = connectedsubscribersGridView.Columns[e.ColumnIndex].Name;


            if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "editButton")
            {
                isEdit = true;

                var addsubs = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm)
                {
                    EditedSubscriber = selectedSubscriber,
                    Text = "Edit Subscriber Information",

                };

                // Update the constructor call to include the required parameters 'currentUserName' and 'currentUserRole'
                var presenter = new AddSubscriberPresenter(addsubs, dbContext, this, _currentUsername, mainForm);

                presenter.EditLoad();

                addsubs.ShowDialog();
            }
            else if (columnName == "disconnectButton")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to disconnect this subscriber?",
                                                      "Confirm Disconnection",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var subscriberToDelete = dbContext.connectedSubscriberRepository
                                                          .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                        if (subscriberToDelete == null)
                        {
                            MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var disconnectedSubscriber = new DisconnectedSubscribers
                        {
                            Disconn_Name = subscriberToDelete.Conn_Name,
                            ContactNumber = subscriberToDelete.ContactNumber,
                            Address = subscriberToDelete.Address,
                            Plan = subscriberToDelete.Plan,
                            Status = "Disconnected",
                            Duedate = subscriberToDelete.Duedate,
                            CurrentDuedate = DateTime.Now,
                            InstallationDate = subscriberToDelete.InstallationDate,
                            MonthlyCharge = subscriberToDelete.MonthlyCharge,
                            Balance = subscriberToDelete.Balance,
                            Charge = subscriberToDelete.Charge,
                        };

                        dbContext.disconnectedSubscriberRepository.Add(disconnectedSubscriber);
                        dbContext.connectedSubscriberRepository.Remove(subscriberToDelete);
                        dbContext.Save();

                        LogActivity($"Disconnected subscriber: {subscriberToDelete.Conn_Name}");

                        bindingSource.Remove(selectedSubscriber);
                        getSubscribers(); // Refresh grid

                        MessageBox.Show("Subscriber successfully disconnected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while disconnecting: {ex.InnerException?.Message ?? ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();
            connectedsubscribersGridView.CellFormatting += connectedsubscribersGridView_CellFormatting;


        }

        private void FilterSubscribersByAddress(string address)
        {
            var filteredSubscribers = originalSubscribers
             .Where(s => s.Address.Contains(address, StringComparison.OrdinalIgnoreCase))
             .ToList();

            if (filteredSubscribers.Any())
            {
                bindingSource.DataSource = filteredSubscribers;
            }
            else
            {

                bindingSource.DataSource = new List<ConnectedSubscribers>();
            }

            connectedsubscribersGridView.DataSource = bindingSource;
            TotalSubscriberLabel.Text = filteredSubscribers.Count.ToString();
        }

        public void FilterData(string searchText)
        {
            if (originalSubscribers == null || !originalSubscribers.Any())
            {
                Console.WriteLine("No subscribers loaded in memory.");
                return;
            }

            Console.WriteLine($"Filtering for: {searchText}");

            if (string.IsNullOrEmpty(searchText))
            {
                bindingSource.DataSource = new List<ConnectedSubscribers>(originalSubscribers);
            }
            else
            {
                var filteredList = originalSubscribers
                    .Where(sub => !string.IsNullOrEmpty(sub.Conn_Name) && sub.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  !string.IsNullOrEmpty(sub.Address) && sub.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  !string.IsNullOrEmpty(sub.ContactNumber) && sub.ContactNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                Console.WriteLine($"Filtered Count: {filteredList.Count}");

                bindingSource.DataSource = filteredList.Any() ? filteredList : new List<ConnectedSubscribers>();
            }

            connectedsubscribersGridView.DataSource = bindingSource;
            TotalSubscriberLabel.Text = ((List<ConnectedSubscribers>)bindingSource.DataSource).Count.ToString();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            getSubscribers();
        }


        private void anahawonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Anahawon");
        }

        private void baseCampBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Base Camp");
        }

        private void camp1Btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Camp 1");
        }

        private void colambugonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Colambugon");


        }

        private void danggawanBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Danggawan");
        }

        private void dologonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Dologon");
        }

        private void northPobBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("North Poblacion");
        }

        private void panadtalanBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Panadtalan");
        }

        private void sanMiguelBtn_Click(object sender, EventArgs e)
        {

            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("San Miguel");
        }

        private void southPobBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("South Poblacion");
        }


        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUsername,
                AccountRole = _currentUserRole,
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            dbContext.activityRepository.Update(activity); // Use Add instead of Update for new records
            dbContext.Save();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = materialComboBox1.SelectedItem.ToString();

            // Call the filter method with the selected state
            FilterSubscribersByState(selectedState);
        }

        private void FilterSubscribersByState(string filterState)
        {

            UpdateStatuses();

            List<ConnectedSubscribers> filteredSubscribers = filterState switch
            {
                "Past due" => originalSubscribers.Where(s => s.Status == "Past Due").ToList(),
                "Overdue" => originalSubscribers.Where(s => s.Status == "Overdue").ToList(),
                "Active" => originalSubscribers.Where(s => s.Status == "Active").ToList(),
                "All" => originalSubscribers,
                _ => originalSubscribers
            };

            bindingSource.DataSource = null;
            bindingSource.DataSource = filteredSubscribers;
            connectedsubscribersGridView.DataSource = bindingSource;

            // Re-add edit button column after filtering
            AddActionButtons();

            connectedsubscribersGridView.Refresh();
            TotalSubscriberLabel.Text = filteredSubscribers.Count.ToString();
        }
        private void AddActionButtons()
        {  // Remove existing action button columns if they exist
            if (connectedsubscribersGridView.Columns.Contains("editButton"))
            {
                connectedsubscribersGridView.Columns.Remove("editButton");
            }

            if (connectedsubscribersGridView.Columns.Contains("disconnectButton"))
            {
                connectedsubscribersGridView.Columns.Remove("disconnectButton");
            }

            // Create Edit Button Column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "editButton",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            // Create Disconnect Button Column
            DataGridViewButtonColumn disconnectButtonColumn = new DataGridViewButtonColumn
            {
                Name = "disconnectButton",
                HeaderText = "Disconnect",
                Text = "Disconnect",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            // Add columns at the end (last position)
            connectedsubscribersGridView.Columns.Add(editButtonColumn);
            connectedsubscribersGridView.Columns.Add(disconnectButtonColumn);
        }

        private void UpdateStatuses()
        {
            DateTime currentDate = DateTime.Now;

            foreach (var subscriber in originalSubscribers)
            {
                DateTime dueDate = subscriber.CurrentDuedate.Date;

                if (subscriber.Plan == "Prepaid" && currentDate >= dueDate)
                {
                    subscriber.Status = "Disconnected";
                    MoveToDisconnectedList(subscriber);
                }
                else
                {
                    if (currentDate < dueDate)
                    {
                        subscriber.Status = "Active";
                    }
                    else if (currentDate >= dueDate && currentDate < dueDate.AddMonths(1))
                    {
                        subscriber.Status = "Past Due";
                    }
                    else
                    {
                        subscriber.Status = "Overdue";
                    }
                }

         
                var dbSubscriber = dbContext.connectedSubscriberRepository.Get(s => s.subs_id == subscriber.subs_id, tracked: true);
                if (dbSubscriber != null)
                {
                    dbSubscriber.Status = subscriber.Status;
                }
            }

            dbContext.Save(); // Save status changes to the database
        }


        private void MoveButtonsToLastColumn()
        {
            connectedsubscribersGridView.Columns["editButton"].DisplayIndex = connectedsubscribersGridView.Columns.Count - 1;
            connectedsubscribersGridView.Columns["disconnectButton"].DisplayIndex = connectedsubscribersGridView.Columns.Count - 1;
        }

        public void GetColumnOrder()
        {
            if (connectedsubscribersGridView.Columns.Contains("subs_id"))
            {
                connectedsubscribersGridView.Columns["subs_id"].DisplayIndex = 0; // Ensure subs_id is first
            }

            if (connectedsubscribersGridView.Columns.Contains("ContactNumber"))
            {
                connectedsubscribersGridView.Columns["ContactNumber"].DisplayIndex = 1;
            }

            if (connectedsubscribersGridView.Columns.Contains("Address"))
            {
                connectedsubscribersGridView.Columns["Address"].DisplayIndex = 2;
            }

            if (connectedsubscribersGridView.Columns.Contains("Plan"))
            {
                connectedsubscribersGridView.Columns["Plan"].DisplayIndex = 3;
            }

            if (connectedsubscribersGridView.Columns.Contains("Status"))
            {
                connectedsubscribersGridView.Columns["Status"].DisplayIndex = 4;
            }

            if (connectedsubscribersGridView.Columns.Contains("Duedate"))
            {
                connectedsubscribersGridView.Columns["Duedate"].DisplayIndex = 5;
            }

            if (connectedsubscribersGridView.Columns.Contains("MonthlyCharge"))
            {
                connectedsubscribersGridView.Columns["MonthlyCharge"].DisplayIndex = 6;
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            isEdit = false;
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm);
            AddForm.ShowDialog();
        }
    }
}