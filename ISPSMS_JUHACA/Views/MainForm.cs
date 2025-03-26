using MaterialSkin;
using MaterialSkin.Controls;
using Infastructure.Data.Repositories.IRepositories;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.MainPages;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using ISPSMS_JUHACA.Presenter;

namespace ISPSMS_JUHACA
{
    public partial class MainForm : MaterialForm
    {
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        private UserProfileForm _userProfileForm;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork unitOfWork;
        private readonly IConnectedSubscribersRepository _connectedSubscribersRepository;
        private readonly Accounts accounts;

        private SubscriberPage _subscriberPage;
        private TransactionPresenter transpres;
        private BillingPage _billingPage;
        private AccountsForm _accountsPage;
        private Transaction _transactionsPage;
        private DashboardPage _dashboardPage;
        private ActivityForm _activityPage;

        int userId = 1;

        public MainForm(IUnitOfWork dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.unitOfWork = dbContext;
            _connectedSubscribersRepository = unitOfWork.connectedSubscriberRepository;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.BackColor = Color.FromArgb(241, 240, 233);
            SetTabPagesBackColor();

            bindingSource = new BindingSource();
            _userProfileForm = new UserProfileForm(unitOfWork, userId);

            // Preload forms to avoid first-click lag
            PreloadTabPages();

            this.Shown += (s, e) => FixMaterialSkinRendering();
            materialTabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void SetTabPagesBackColor()
        {
            Color bgColor = Color.FromArgb(241, 240, 233);
            subscribersPage.BackColor = bgColor;
            billingPage.BackColor = bgColor;
            transactionsPage.BackColor = bgColor;
            accountsPage.BackColor = bgColor;
            activitiesPage.BackColor = bgColor;
            dashboardPage.BackColor = bgColor;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            materialTabControl1.SelectedTab = subscribersPage;
        }

        private void FixMaterialSkinRendering()
        {
            this.Invalidate(); // Repaint the form
            this.Refresh();
        }

        private void PreloadTabPages()
        {
            _subscriberPage = new SubscriberPage(dbContext, this);
            _billingPage = new BillingPage(dbContext, this);
            _accountsPage = new AccountsForm(dbContext, this);
            _transactionsPage = new Transaction(dbContext, this);
            _dashboardPage = new DashboardPage(_connectedSubscribersRepository, dbContext, this);
            _activityPage = new ActivityForm(dbContext, this);

            // Attach forms to tabs but do not load data yet
            AttachPageToTab(subscribersPage, _subscriberPage);
            AttachPageToTab(billingPage, _billingPage);
            AttachPageToTab(accountsPage, _accountsPage);
            AttachPageToTab(transactionsPage, _transactionsPage);
            AttachPageToTab(dashboardPage, _dashboardPage);
            AttachPageToTab(activitiesPage, _activityPage);
        }


        private void AttachPageToTab(TabPage tabPage, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }


        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == subscribersPage)
            {
                EnsurePageLoaded(_subscriberPage);
            }
            else if (materialTabControl1.SelectedTab == billingPage)
            {
                EnsurePageLoaded(_billingPage);
            }
            else if (materialTabControl1.SelectedTab == accountsPage)
            {
                EnsurePageLoaded(_accountsPage);
            }
            else if (materialTabControl1.SelectedTab == transactionsPage)
            {
                EnsurePageLoaded(_transactionsPage);
            }
            else if (materialTabControl1.SelectedTab == dashboardPage)
            {
                EnsurePageLoaded(_dashboardPage);
            }
            else if (materialTabControl1.SelectedTab == activitiesPage)
            {
                EnsurePageLoaded(_activityPage);
            }
        }

        private void EnsurePageLoaded(Form page)
        {
            if (!page.Visible)
            {
                page.Show();
            }
        }


        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim().ToLower();

            if (materialTabControl1.SelectedTab == subscribersPage && _subscriberPage != null)
            {
                _subscriberPage.FilterData(searchText);
            }
            else if (materialTabControl1.SelectedTab == billingPage && _billingPage != null)
            {
                _billingPage.FilterData(searchText);
            }
            else if (materialTabControl1.SelectedTab == transactionsPage && _transactionsPage != null)
            {
                _transactionsPage.FilterData(searchText);
            }
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            if (_userProfileForm == null || _userProfileForm.IsDisposed)
            {
                _userProfileForm = new UserProfileForm(unitOfWork, userId);
            }
            _userProfileForm.Show();
        }

        public void SetUserProfile(string username, string role, string password, string profname, string id)
        {
            lblUsername.Text = username;
            lblRole.Text = role;
            _userProfileForm.UpdateProfile(username, role, password, profname, id);
        }

        public string GetUserRole() => lblRole.Text;
        public string GetUsername() => lblUsername.Text;
    }
}
