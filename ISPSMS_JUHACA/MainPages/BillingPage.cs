using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using ISPSMS_JUHACA.Views.IVews;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class BillingPage : MaterialForm, IBillingView
    {
        private readonly BillingPresenter _presenter;
        private Label lblLoading;
        private readonly MainForm _main;
        private SubscriberPage _subscribersForm;

        public BillingPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            
            InitializeComponent();
            _presenter = new BillingPresenter(this, dbContext);
            _main = mainForm;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager?.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE
            );

            billingFlowPanel.BackColor = Color.FromArgb(241, 240, 233);

            // Loading Label
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
            await _presenter.LoadBillingItemsAsync();
        }

        public void ShowLoadingIndicator(bool show)
        {
            lblLoading.Visible = show;
        }

        public void DisplaySubscribers(List<ConnectedSubscribers> subscribers, int start, int end, int totalItems)
        {

            billingFlowPanel.Controls.Clear();

            foreach (var subscriber in subscribers)
            {
                BillingItems billingItem = new BillingItems(_presenter.GetDbContext(), _subscribersForm, this, _main)
                {
                    TopLevel = false,
                    Dock = DockStyle.Top,
                    ConSubsEntity = subscriber
                };
                billingItem.LoadBillingItemData();
                billingFlowPanel.Controls.Add(billingItem);
                billingItem.Show();
            }

            paginationStatusTextBox.Text = $"{start}-{end} of {totalItems}";
        }

        public void EnablePagination(bool enableNext, bool enablePrev)
        {
            btnNext.Enabled = enableNext;
            btnPrev.Enabled = enablePrev;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            await _presenter.NextPage();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            await _presenter.PreviousPage();
        }

        // Expose the presenter to MainForm
        public BillingPresenter GetPresenter()
        {
            return _presenter;
        }
    }
}
