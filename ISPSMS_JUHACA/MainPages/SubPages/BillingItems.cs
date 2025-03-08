using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class BillingItems : KryptonForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        private SubscriberPage _subscribersForm;
        private MainForm mainForm;
        private ConnectedSubscribers subscriber;
        public BindingSource BindingSource => bindingSource;

        public BillingItems(IUnitOfWork dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;

            // Populate UI with subscriber info
        }

        private void BillingItems_Load(object sender, EventArgs e)
        {

            LoadBillingItemData();
        }

        public void LoadBillingItemData()
        {

            string subID = ConSubsEntity.CurrentDuedate.ToString("MMMM")[0] + ConSubsEntity.subs_id.ToString();
            subIDTextBox.Text = subID;

            nameTextBox.Text = ConSubsEntity.Conn_Name ?? "N/A";
            statusTextBox.Text = $"Status: " + ConSubsEntity.Status ?? "N/A";
            dueDateTextBox.Text = ConSubsEntity.CurrentDuedate.ToString("MMMM d, yyyy");
            addressTextBox.Text = ConSubsEntity.Address ?? "N/A";
            planTextBox.Text = ConSubsEntity.Plan ?? "N/A";
            amountTextBox.Text = ConSubsEntity.MonthlyCharge.ToString("C") ?? "₱0.00";
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}