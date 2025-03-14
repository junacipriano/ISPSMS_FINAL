        using MaterialSkin;
        using MaterialSkin.Controls;
        using Infastructure.Data.Repositories.IRepositories;
        using Domain.Models;
    using ISPSMS_JUHACA.Views;
    using ISPSMS_JUHACA.MainPages;

    namespace ISPSMS_JUHACA
        {
    public partial class MainForm : MaterialForm
    {
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        private UserProfileForm _userProfileForm;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;

        public MainForm(IUnitOfWork dbContext)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.BackColor = Color.FromArgb(241, 240, 233);
            subscribersPage.BackColor = Color.FromArgb(241, 240, 233);
            billingPage.BackColor = Color.FromArgb(241, 240, 233);
            transactionsPage.BackColor = Color.FromArgb(241, 240, 233);
            accountsPage.BackColor = Color.FromArgb(241, 240, 233);
            activitiesPage.BackColor = Color.FromArgb(241, 240, 233);
            dashboardPage.BackColor = Color.FromArgb(241, 240, 233);

            this.dbContext = dbContext;
            bindingSource = new BindingSource();
            _userProfileForm = new UserProfileForm();

            materialTabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {

            if (materialTabControl1.SelectedTab == subscribersPage)
            {

                subscribersPage.Controls.Clear();

                var subsPage = new SubscriberPage(dbContext, this);

                subsPage.TopLevel = false;
                subsPage.FormBorderStyle = FormBorderStyle.None;
                subsPage.Dock = DockStyle.Fill;

                subscribersPage.Controls.Add(subsPage);
                subsPage.Show();

            }
            else if (materialTabControl1.SelectedTab == billingPage)
            {

                billingPage.Controls.Clear();

                var billPage = new BillingPage(dbContext, this);

                billPage.TopLevel = false;
                billPage.FormBorderStyle = FormBorderStyle.None;
                billPage.Dock = DockStyle.Fill;

                billingPage.Controls.Add(billPage);
                billPage.Show();

            }
            else if (materialTabControl1.SelectedTab == accountsPage)
            {

                accountsPage.Controls.Clear();

                var accPage = new AccountsForm(dbContext, this);

                accPage.TopLevel = false;
                accPage.FormBorderStyle = FormBorderStyle.None;
                accPage.Dock = DockStyle.Fill;

                accountsPage.Controls.Add(accPage);
                accPage.Show();

            }
            else if (materialTabControl1.SelectedTab == transactionsPage)
            {

                transactionsPage.Controls.Clear();

                var traPage = new Transaction(dbContext, this);

                traPage.TopLevel = false;
                traPage.FormBorderStyle = FormBorderStyle.None;
                traPage.Dock = DockStyle.Fill;

                transactionsPage.Controls.Add(traPage);
                traPage.Show();

            }

        }



        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim().ToLower();

            if (materialTabControl1.SelectedTab == subscribersPage)
            {
                if (subscribersPage.Controls[0] is SubscriberPage subsPage)
                {
                    subsPage.FilterData(searchText);
                }
            }
            else if (materialTabControl1.SelectedTab == billingPage)
            {
                if (billingPage.Controls[0] is BillingPage billPage)
                {
                    billPage.FilterData(searchText);
                }
            }
            else if (materialTabControl1.SelectedTab == transactionsPage)
            {
                if (transactionsPage.Controls[0] is Transaction TransPage)
                {
                    TransPage.FilterData(searchText);
                }
            }
        }



        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            if (_userProfileForm == null || _userProfileForm.IsDisposed)
            {
                _userProfileForm = new UserProfileForm();
            }
            _userProfileForm.Show();
        }
        public void SetUserProfile(string username, string role, string password, string profname, string id)
        {
            lblUsername.Text = username;
            lblRole.Text = role;
            string pass = password;
            string prof = profname;
            string idd = id;
            _userProfileForm.UpdateProfile(username, role, password, profname, id);
        }

        public void OpenSubscribersPage()
        {
            materialTabControl1.SelectedTab = subscribersPage;


            subscribersPage.Controls.Clear();

            var subsPage = new SubscriberPage(dbContext, this);
            subsPage.TopLevel = false;
            subsPage.FormBorderStyle = FormBorderStyle.None;
            subsPage.Dock = DockStyle.Fill;

            subscribersPage.Controls.Add(subsPage);
            subsPage.Show();
        }

        public string GetUserRole()
        {
            return lblRole.Text;
        }

  

        //private void SubscribersForm_Load(object sender, EventArgs e)
        //{

        //    getSubscribers();
        //}

        //public void getSubscribers()
        //{
        //    var subscribers = dbContext.connectedSubscriberRepository.GetAll();
        //    connectedsubscribersGridView.DataSource = subscribers;
        //}

        //private void addBtn_Click(object sender, EventArgs e)
        //{
        //    ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

        //    var AddForm = new addSubscribersForm(dbContext, this);
        //    AddForm.ShowDialog();

        //}

        /*  private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              ConSubsEntity = (Domain.Models.ConnectedSubscribers)bindingSource.Current;

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
                          // Ensure we are working with a tracked entity
                          var subscriberToDelete = dbContext.connectedSubscriberRepository
                                                            .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                          if (subscriberToDelete == null)
                          {
                              MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              return;
                          }

                          dbContext.connectedSubscriberRepository.Remove(subscriberToDelete);
                          dbContext.Save();

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
          }*/

        //private void disconnectedbtn_Click(object sender, EventArgs e)
        //{
        //    ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

        //    var Disconnected = new Disconnected(dbContext, this);
        //    Disconnected.ShowDialog();
        //}




    }
}
