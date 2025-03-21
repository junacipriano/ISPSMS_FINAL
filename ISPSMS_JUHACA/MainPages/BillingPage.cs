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
        private BindingSource bindingSource;
        internal bool isEdit;
        private MainForm mainForm;
        private readonly SubscriberPage _subscribersForm;

        public BindingSource BindingSource => bindingSource;
        public BillingPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            billingFlowPanel.BackColor = Color.FromArgb(241, 240, 233);
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
            billingFlowPanel.Controls.Clear();

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

                BillingItems billingItem = new BillingItems(dbContext, _subscribersForm, this, mainForm)
                {
                    TopLevel = false, 
                    Dock = DockStyle.Top 
                };

                // Set data
                billingItem.ConSubsEntity = subscriber;
                billingItem.LoadBillingItemData();

                // Add to panel
                billingFlowPanel.Controls.Add(billingItem);
                billingItem.Show();
            }
        }

        public void FilterData(string searchText)
        {
            foreach (Control control in billingFlowPanel.Controls)
            {
                if (control is BillingItems billingItem)
                {
                    var subscriber = billingItem.ConSubsEntity;
                    bool isVisible = subscriber.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                     subscriber.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase);

                    billingItem.Visible = isVisible;
                }
            }
        }



    }
}