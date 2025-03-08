using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using System.Collections.Generic;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class SubscriberPage : MaterialForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        internal bool isEdit;
        private MaterialButton activeButton;

        public BindingSource BindingSource => bindingSource;



        public SubscriberPage(IUnitOfWork dbContext, MainForm mainform)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            bindingSource = new BindingSource();
            connectedsubscribersGridView.AutoGenerateColumns = true;
        }

        private void SetActiveButton(MaterialButton clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.UseAccentColor = false; // Reset previous button
            }

            activeButton = clickedButton;
            activeButton.UseAccentColor = true; // Highlight active button
        }

        public void getSubscribers()
        {
            var subscribers = dbContext.connectedSubscriberRepository.GetAll().ToList();
            bindingSource.DataSource = subscribers;
            connectedsubscribersGridView.DataSource = bindingSource;
            TotalSubscriberLabel.Text = subscribers.Count.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            isEdit = false;
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this);
            AddForm.ShowDialog();
        }

        private void disconnectedbtn_Click(object sender, EventArgs e)
        {


            var disconnectedForm = new Disconnected(dbContext, this);
            disconnectedForm.ShowDialog();
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
                        dbContext.Save(); // ✅ Make sure changes are saved before updating UI

                        // ✅ Refresh UI
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

                var addsubs = new addSubscribersForm(dbContext, this)
                {
                    EditedSubscriber = selectedSubscriber, // ✅ Load the subscriber data
                    Text = "Edit Subscriber Information",

                };

                var presenter = new AddSubscriberPresenter(addsubs, dbContext, this);
                presenter.EditLoad();

                addsubs.ShowDialog();// ✅ Handle save logic
            }

            /*   if (e.RowIndex < 0) return;
               var selectedSubscriber = connectedsubscribersGridView.Rows[e.RowIndex].DataBoundItem as ConnectedSubscribers;
               if (selectedSubscriber == null) return;

               if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "disconnectButton")
               {
                   _presenter.DisconnectSubscriber(selectedSubscriber);
               }
               else if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "editButton")
               {

                   _presenter.EditSubscriber(selectedSubscriber);
               }*/
        }

        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();

        }

        private void FilterSubscribersByAddress(string address)
        {
            var filteredSubscribers = dbContext.connectedSubscriberRepository
       .GetAll(s => s.Address.Contains(address)) // Use Contains for partial matches
       .ToList();

            if (filteredSubscribers.Any()) // Check if any data is found
            {
                bindingSource.DataSource = filteredSubscribers;
                connectedsubscribersGridView.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("No subscribers found for this address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getSubscribers(); // Reload all subscribers if no match is found

            }
        }



        /* public void LoadSubscribers(IEnumerable<ConnectedSubscribers> subscribers)
           {
               BindingSource.DataSource = subscribers.ToList();
               connectedsubscribersGridView.DataSource = BindingSource;
           }*/

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

    }
}
