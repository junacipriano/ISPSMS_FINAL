using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using Krypton.Docking;
using Krypton.Navigator;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        // Pagination
        private int currentPage = 1;
        private const int itemsPerPage = 20;

        // Label for loading indicator
        private Label lblLoading;

        public BindingSource BindingSource => bindingSource;

        public BillingPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;

            try
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager?.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                    Accent.LightBlue200, TextShade.WHITE
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"MaterialSkin initialization failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            billingFlowPanel.BackColor = Color.FromArgb(241, 240, 233);

            // Initialize loading label
            lblLoading = new Label
            {
                Text = "Loading...",
                AutoSize = true,
                ForeColor = Color.DarkGray,
                Font = new Font("Arial", 12, FontStyle.Italic),
                Visible = false
            };
            billingFlowPanel.Controls.Add(lblLoading);
        }

        private async void BillingPage_Load(object sender, EventArgs e)
        {
            await LoadBillingItemsAsync();
        }

        // Asynchronous method to load billing items
        public async Task LoadBillingItemsAsync(int page = 1)
        {
            // Disable pagination buttons while loading
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            lblLoading.Visible = true; // Show loading indicator

            billingFlowPanel.Controls.Clear();
            billingFlowPanel.Controls.Add(lblLoading); // Keep label visible

            currentPage = page;

            var subscribers = await Task.Run(() =>
                dbContext.connectedSubscriberRepository
                .GetAll()
                .OrderBy(sub => sub.CurrentDuedate)
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList()
            );

            lblLoading.Visible = false; // Hide loading indicator

            if (!subscribers.Any())
            {
                MessageBox.Show("No more subscribers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var subscriber in subscribers)
            {
                BillingItems billingItem = new BillingItems(dbContext, _subscribersForm, this, mainForm)
                {
                    TopLevel = false,
                    Dock = DockStyle.Top
                };

                billingItem.ConSubsEntity = subscriber;
                billingItem.LoadBillingItemData();
                billingFlowPanel.Controls.Add(billingItem);
                billingItem.Show();
            }

            // Enable buttons after loading is complete
            btnNext.Enabled = subscribers.Count == itemsPerPage; // Enable if more pages exist
            btnPrev.Enabled = currentPage > 1; // Enable if not on the first page
        }

        // Pagination: Load Next Page
        private async void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadBillingItemsAsync(currentPage);
        }

        // Pagination: Load Previous Page
        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadBillingItemsAsync(currentPage);
            }
        }

        public async void FilterData(string searchText)
        {
            // Disable buttons while filtering
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            lblLoading.Visible = true;

            var subscribers = await Task.Run(() =>
                dbContext.connectedSubscriberRepository
                .GetAll()
                .Where(sub =>
                    sub.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    sub.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .OrderBy(sub => sub.CurrentDuedate)
                .ToList()
            );

            lblLoading.Visible = false;
            billingFlowPanel.Controls.Clear();

            foreach (var subscriber in subscribers)
            {
                BillingItems billingItem = new BillingItems(dbContext, _subscribersForm, this, mainForm)
                {
                    TopLevel = false,
                    Dock = DockStyle.Top
                };

                billingItem.ConSubsEntity = subscriber;
                billingItem.LoadBillingItemData();
                billingFlowPanel.Controls.Add(billingItem);
                billingItem.Show();
            }

            // Re-enable buttons after filtering
            btnNext.Enabled = subscribers.Count == itemsPerPage;
            btnPrev.Enabled = currentPage > 1;
        }
    }
}
