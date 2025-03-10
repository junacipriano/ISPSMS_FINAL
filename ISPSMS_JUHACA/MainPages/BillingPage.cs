using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using Krypton.Docking;
using Krypton.Navigator;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class BillingPage : MaterialForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        internal bool isEdit;
        private MainForm mainForm;
        private readonly SubscriberPage _subscribersForm;

        public BillingPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public void getSubscribers()
        {
            var subscribers = dbContext.connectedSubscriberRepository.GetAll().ToList();
        }

        private void BillingPage_Load(object sender, EventArgs e)
        {
            LoadBillingItems();
        }

        public void LoadBillingItems()
        {
            billingFlowPanel.Controls.Clear(); // Ensure it's empty before adding new items

            var subscribers = dbContext.connectedSubscriberRepository
                .GetAll()
                .OrderBy(sub => sub.CurrentDuedate)
                .ToList();
            if (!subscribers.Any())
            {
                MessageBox.Show("No subscribers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var subscriber in subscribers)
            {

                BillingItems billingItem = new BillingItems(dbContext, _subscribersForm, this)

                {
                    TopLevel = false, // Prevents form from opening in a new window
                    FormBorderStyle = FormBorderStyle.None, // No borders
                    Dock = DockStyle.Top // Stack items in FlowLayoutPanel
                };

                // Set data
                billingItem.ConSubsEntity = subscriber;
                billingItem.LoadBillingItemData(); // Ensure data is applied

                // Add to panel
                billingFlowPanel.Controls.Add(billingItem);
                billingItem.Show();
            }
        }



    }
}