using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using System.Collections.Generic;
using ISPSMS_JUHACA.Presenter;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class SubscriberPage : MaterialForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        internal bool isEdit;

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

        }
        public void getSubscribers()
        {
            var subscribers = dbContext.connectedSubscriberRepository.GetAll();
            bindingSource.DataSource = subscribers;
            connectedsubscribersGridView.DataSource = bindingSource;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this);
            AddForm.ShowDialog();
        }

        private void disconnectedbtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

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

            // ✅ Handling the Disconnect Button
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

                        // ✅ Remove the subscriber from the database
                        dbContext.connectedSubscriberRepository.Remove(subscriberToDelete);
                        dbContext.Save();

                        // ✅ Refresh the UI
                        bindingSource.Remove(selectedSubscriber);
                        getSubscribers();

                        MessageBox.Show("Subscriber successfully disconnected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // ✅ Handling the Edit Button
            if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "editButton")
            {
                // Open the AddSubscriberForm in Edit Mode
                var addsubs = new addSubscribersForm(dbContext, this)
                {
                    EditedSubscriber = selectedSubscriber,
                    Text = "Edit Subscriber Information",
                    message = "Subscriber updated successfully."
                };

                // ✅ Initialize the Presenter and Load Data
                var presenter = new AddSubscriberPresenter(addsubs, dbContext, this);
                presenter.EditLoad(); // Load data into the form

                if (addsubs.ShowDialog() == DialogResult.OK) // ✅ Handle save logic
                {
                    try
                    {
                        // ✅ Update the subscriber in the database
                        dbContext.connectedSubscriberRepository.Update(selectedSubscriber);
                        dbContext.Save();

                        // ✅ Refresh the UI
                        getSubscribers();
                        MessageBox.Show("Subscriber successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();
        }
        
    }
}
