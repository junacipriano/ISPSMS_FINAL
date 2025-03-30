using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class BillingItems : KryptonForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private SubscriberPage _subscribersForm;
        internal BillingPage _billingPage;
        private MainForm _mainForm; // Declare _mainForm
        private int currentBillingIndex = 0;

        public BillingItems(IUnitOfWork dbContext, SubscriberPage subscribersForm, BillingPage billingPage, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            _billingPage = billingPage;
            _mainForm = mainForm; 


        }

        private void BillingItems_Load(object sender, EventArgs e)
        {
            LoadBillingItemData();
        }

        public void LoadBillingItemData()
        {
            string subID = ConSubsEntity.CurrentDuedate.ToString("MMMM")[0] + ConSubsEntity.subs_id.ToString();
            var culture = new CultureInfo("fil-PH");
            subIDTextBox.Text = subID;

            nameTextBox.Text = ConSubsEntity.Conn_Name ?? "N/A";
            statusTextBox.Text = $"Status: " + ConSubsEntity.Status ?? "N/A";
            dueDateTextBox.Text = ConSubsEntity.CurrentDuedate.ToString("MMMM d, yyyy");
            addressTextBox.Text = ConSubsEntity.Address ?? "N/A";
            planTextBox.Text = ConSubsEntity.Plan ?? "N/A";
            amountTextBox.Text = ConSubsEntity.MonthlyCharge.ToString("C", culture);

            payBtn.Tag = ConSubsEntity;
            payBtn.Click -= payBtn_Click;
            payBtn.Click += payBtn_Click;
        }


        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (ConSubsEntity == null)
            {
                MessageBox.Show("Error: No subscriber data found!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConSubsEntity.CurrentDuedate = ConSubsEntity.CurrentDuedate;
            dbContext.connectedSubscriberRepository.Update(ConSubsEntity);
            dbContext.connectedSubscriberRepository.Save();
            BillingCheckout paymentForm = new BillingCheckout(dbContext, ConSubsEntity, _billingPage, _mainForm);
            paymentForm.ShowDialog();
        }

        private void kryptonBorderEdge1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}