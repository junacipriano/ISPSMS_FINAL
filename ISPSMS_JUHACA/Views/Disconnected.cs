using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;

using ISPSMS_JUHACA.MainPages;
using Domain.Models;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using Krypton.Toolkit;
using Microsoft.VisualBasic;


namespace ISPSMS_JUHACA.Views
{
    public partial class Disconnected : MaterialForm, IDisconnected
    {
        public readonly IUnitOfWork dbContext;
        private System.Windows.Forms.BindingSource bindingSource;

        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        internal Disconnected disconnected;
        private DisconnectedPresenter presenter;
        private SubscriberPage subs;

        public ConnectedSubscribers SelectedSubscriber { get; internal set; }

        public Disconnected(IUnitOfWork dbContext, SubscriberPage subs)
        {

            InitializeComponent();
            this.subs = subs;


            try
            {
               
                // Check if MaterialSkinManager.Instance is null before using it
                var materialSkinManager = MaterialSkinManager.Instance;
                if (materialSkinManager != null)
                {
                    materialSkinManager.AddFormToManage(this);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                        Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                        Accent.LightBlue200, TextShade.WHITE);
                }
                else
                {
                    MessageBox.Show("MaterialSkinManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.dbContext = dbContext;
                bindingSource = new System.Windows.Forms.BindingSource();

                presenter = new DisconnectedPresenter(dbContext, this);
                this.Shown += Disconnected_Shown;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Disconnected_Shown(object? sender, EventArgs e)
        {
            presenter.LoadDisconnectedSubscribers();
        }

        //public void LoadDisconnectedSubscribers()
        //{
        //    var disconnectedSubscribers = dbContext.disconnectedSubscriberRepository.GetAll();
        //    DisconnectdataGridView1.DataSource = disconnectedSubscribers;
        //}

        //private void Disconnected_Load(object sender, EventArgs e)
        //{
        //    // LoadDisconnectedSubscribers();
        //presenter.LoadDisconnectedSubscribers();
        //}

        public void SetDisconnectedSubscribers(IEnumerable<DisconnectedSubscribers> subscribers)
        {
            DisconnectedGridView1.DataSource = null;
            DisconnectedGridView1.DataSource = subscribers.ToList(); // Convert to List for binding

            // Check if the button column already exists
            if (!DisconnectedGridView1.Columns.Contains("ReconnectColumn"))
            {
                DataGridViewButtonColumn reconnectColumn = new DataGridViewButtonColumn
                {
                    Name = "ReconnectColumn",
                    HeaderText = "Action",
                    Text = "Reconnect",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };

                DisconnectedGridView1.Columns.Add(reconnectColumn);
            }
            if (!DisconnectedGridView1.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    HeaderText = "Action",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };

                DisconnectedGridView1.Columns.Add(deleteColumn);
            }

            DisconnectedGridView1.CellClick += DisconnectedGridView1_CellClick;
        }

        private void DisconnectedGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedSubscriber = (DisconnectedSubscribers)DisconnectedGridView1.Rows[e.RowIndex].DataBoundItem;

                // Handle the "Reconnect" button click
                if (DisconnectedGridView1.Columns[e.ColumnIndex].Name == "ReconnectColumn")
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to reconnect {selectedSubscriber.Disconn_Name}?",
                                                          "Confirm Reconnection",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var subscriberToReconnect = dbContext.disconnectedSubscriberRepository
                                                                  .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                            if (subscriberToReconnect == null)
                            {
                                MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            var dueDate = DateTime.Now.AddMonths(1);  // Get the due date one month from now
                            var dueDateWithOrdinal = GetOrdinal(dueDate.Day);  // Get the ordinal suffix

                            // Format the due date as a string with the ordinal suffix (e.g., "2025-04-1st")
                            var formattedDueDate = $"{dueDateWithOrdinal}";

                            var connectedSubscriber = new ConnectedSubscribers
                            {
                                Conn_Name = subscriberToReconnect.Disconn_Name,
                                ContactNumber = subscriberToReconnect.ContactNumber,
                                Address = subscriberToReconnect.Address,
                                Plan = subscriberToReconnect.Plan,
                                Status = "Active", // Set status to Active
                                Duedate = formattedDueDate, // Use the formatted due date as a string
                                CurrentDuedate = DateTime.Now.AddMonths(1), // You can also set this as DateTime if needed
                                InstallationDate = DateTime.Now,
                                MonthlyCharge = subscriberToReconnect.MonthlyCharge,
                                Balance = subscriberToReconnect.Balance,
                                Charge = subscriberToReconnect.Charge
                            };

                            // Add the subscriber to the ConnectedSubscribers table and remove from the DisconnectedSubscribers table
                            dbContext.connectedSubscriberRepository.Add(connectedSubscriber);
                            dbContext.disconnectedSubscriberRepository.Remove(subscriberToReconnect);
                            dbContext.Save();

                            // Update the binding source and refresh the grid
                            bindingSource.Remove(selectedSubscriber);
                            presenter.LoadDisconnectedSubscribers();

                            subs.getSubscribers();
                          
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while reconnecting: {ex.InnerException?.Message ?? ex.Message}",
                                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Handle the "Delete" button click
                if (DisconnectedGridView1.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedSubscriber.Disconn_Name}?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var subscriberToDelete = dbContext.disconnectedSubscriberRepository
                                                              .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                            if (subscriberToDelete == null)
                            {
                                MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Remove the subscriber from the database
                            dbContext.disconnectedSubscriberRepository.Remove(subscriberToDelete);
                            dbContext.Save();

                            // Update the binding source and refresh the grid
                            bindingSource.Remove(selectedSubscriber);
                            presenter.LoadDisconnectedSubscribers();

                            // Success message
                            MessageBox.Show("Subscriber successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while deleting: {ex.InnerException?.Message ?? ex.Message}",
                                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public string GetOrdinal(int day)
        {
            if (day % 10 == 1 && day != 11)
                return day + "st";
            if (day % 10 == 2 && day != 12)
                return day + "nd";
            if (day % 10 == 3 && day != 13)
                return day + "rd";
            return day + "th";
        }

    

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
