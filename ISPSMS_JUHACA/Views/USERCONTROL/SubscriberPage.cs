using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Presenter;

namespace ISPSMS_JUHACA.Views.USERCONTROL
{
    public partial class SubscriberPage : Form
    {
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;

        public BindingSource BindingSource => bindingSource;

        private readonly SubscriberPage subscriberPage;
        public SubscriberPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
            connectedsubscribersGridView.DataSource = bindingSource;
            connectedsubscribersGridView.VirtualMode = true;
            this.TopLevel = false;
        }
        public void getSubscribers()
        {
            var subscribers = dbContext.connectedSubscriberRepository.GetAll();
            connectedsubscribersGridView.DataSource = subscribers;

        }
        private void disconnectedbtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var Disconnected = new Disconnected(dbContext, this);
            Disconnected.ShowDialog();
        }

        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "disconnectButton")
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
                DialogResult result = MessageBox.Show("Are you sure you want to disconnect this subscriber?",
                                                      "Confirm Disconnection",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        dbContext.connectedSubscriberRepository.Remove(selectedSubscriber);
                        dbContext.Save();
                        bindingSource.Remove(selectedSubscriber);
                        getSubscribers();

                        MessageBox.Show("Subscriber successfully disconnected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while deletin  g: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this);
            AddForm.ShowDialog();
        }
    }
}
