using MaterialSkin;
using MaterialSkin.Controls;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.MainPages;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using Microsoft.Graph.Models;
using Infastructure.Data.Repositories.IRepositories;
using System.Runtime.InteropServices;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Small;
using Image = System.Drawing.Image;
using Application = System.Windows.Forms.Application;

namespace ISPSMS_JUHACA
{
    public partial class MainForm : MaterialForm
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IConnectedSubscribersRepository _connectedSubscribersRepository;
        private BindingSource bindingSource;
        private UserProfileForm _userProfileForm;
        private int userId = 1;

        // Cache pages to avoid repeated instantiations
        private SubscriberPage _subsPage;
        private BillingPage _billPage;
        private AccountsForm _accPage;
        private Transaction _traPage;
        private DashboardPage _dbPage;
        private ActivityForm _actPage;

        public MainForm(IUnitOfWork dbContext)
        {
            InitializeComponent();
            unitOfWork = dbContext;
            _connectedSubscribersRepository = unitOfWork.connectedSubscriberRepository;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey700, Primary.Grey900, Accent.Red200, TextShade.WHITE);

            materialTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            materialTabControl1.Invalidate();

            bindingSource = new BindingSource();
            _userProfileForm = new UserProfileForm(unitOfWork, userId);
        }
        private void MaterialTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;

            // Get the tab rectangle and text
            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            string tabText = tabControl.TabPages[e.Index].Text;
            Font font = new Font("Arial", 10, FontStyle.Bold);

            // Custom colors
            Color backColor = (e.Index == tabControl.SelectedIndex) ? Color.FromArgb(255, 254, 250) : Color.FromArgb(255, 254, 250);
            Color textColor = Color.FromArgb(255, 254, 250);

            // Fill background
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, tabRect);
            }

            // Draw text centered
            TextRenderer.DrawText(e.Graphics, tabText, font, tabRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = new Rectangle(0, this.Height - this.ClientSize.Height, this.Width, this.ClientSize.Height);

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(241, 240, 233)))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

        }

        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Form newPage = null;

            if (materialTabControl1.SelectedTab == subscribersPage)
                newPage = _subsPage ??= new SubscriberPage(unitOfWork, this);
            else if (materialTabControl1.SelectedTab == billingPage)
                newPage = _billPage ??= new BillingPage(unitOfWork, this);
            else if (materialTabControl1.SelectedTab == accountsPage)
                newPage = _accPage ??= new AccountsForm(unitOfWork, this);
            else if (materialTabControl1.SelectedTab == transactionsPage)
                newPage = _traPage ??= new Transaction(unitOfWork, this);
            else if (materialTabControl1.SelectedTab == dashboardPage)
                newPage = _dbPage ??= new DashboardPage(_connectedSubscribersRepository, unitOfWork, this);
            else if (materialTabControl1.SelectedTab == activitiesPage)
                newPage = _actPage ??= new ActivityForm(unitOfWork, this);
            if (newPage != null)
                LoadFormIntoTab(materialTabControl1.SelectedTab, newPage);
        }


        private void LoadFormIntoTab(TabPage tabPage, Form form)
        {
            if (!tabPage.Controls.Contains(form))
            {
                tabPage.Controls.Clear();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                tabPage.Controls.Add(form);
                form.Show();
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim().ToLower();

            if (materialTabControl1.SelectedTab == subscribersPage && _subsPage != null)
                _subsPage.FilterData(searchText);
            else if (materialTabControl1.SelectedTab == billingPage && _billPage != null)
                _billPage.FilterData(searchText);
            else if (materialTabControl1.SelectedTab == transactionsPage && _traPage != null)
                _traPage.FilterData(searchText);
        }


        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            if (_userProfileForm == null || _userProfileForm.IsDisposed)
                _userProfileForm = new UserProfileForm(unitOfWork, userId);

            _userProfileForm.Show();
        }

        public void SetUserProfile(string username, string role, string password, string profname, string id)
        {
            lblUsername.Text = username;
            lblRole.Text = role;
            _userProfileForm.UpdateProfile(username, role, password, profname, id);
        }

        public void OpenSubscribersPage()
        {
            materialTabControl1.SelectedTab = subscribersPage;
            if (_subsPage != null)
                _subsPage.getSubscribers();
        }

        public string GetUserRole() => lblRole.Text;
        public string GetUsername() => lblUsername.Text;

        
    }

}