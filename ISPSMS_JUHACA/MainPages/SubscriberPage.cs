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

namespace ISPSMS_JUHACA.MainPages
{
    public partial class SubscriberPage : MaterialForm
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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                                                               Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _currentUsername = mainForm.GetUsername();
            _currentUserRole = mainForm.GetUserRole();

            bindingSource = new BindingSource();
            connectedsubscribersGridView.AutoGenerateColumns = true;
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
            originalSubscribers = dbContext.connectedSubscriberRepository.GetAll().ToList(); 
            bindingSource.DataSource = originalSubscribers;  
            connectedsubscribersGridView.DataSource = bindingSource;
            TotalSubscriberLabel.Text = originalSubscribers.Count.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm);
            AddForm.ShowDialog();
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
            }
        }



        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                MessageBox.Show("No valid subscriber selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedSubscriber = connectedsubscribersGridView.Rows[e.RowIndex].DataBoundItem as Domain.Models.ConnectedSubscribers;
            if (selectedSubscriber == null)
            {
                MessageBox.Show("Subscriber not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "disconnectButton")
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
                        // Log the activity after successfully disconnecting
                        LogActivity($"Disconnected subscriber: {subscriberToDelete.Conn_Name}");



                        bindingSource.Remove(selectedSubscriber);
                        getSubscribers();

                        MessageBox.Show("Subscriber successfully disconnected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while disconnecting: {ex.InnerException?.Message ?? ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

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
        }
        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();
            connectedsubscribersGridView.CellFormatting += connectedsubscribersGridView_CellFormatting;

        }

        private void FilterSubscribersByAddress(string address)
        {
            var filteredSubscribers = dbContext.connectedSubscriberRepository
       .GetAll(s => s.Address.Contains(address))
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
            if (string.IsNullOrEmpty(searchText))
            {
                bindingSource.DataSource = new List<ConnectedSubscribers>(originalSubscribers);
            }
            else
            {
                var filteredList = originalSubscribers
                    .Where(sub => sub.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  sub.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  sub.ContactNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                bindingSource.DataSource = filteredList;
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

    }
}