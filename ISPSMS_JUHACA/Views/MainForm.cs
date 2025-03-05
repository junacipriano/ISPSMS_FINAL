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
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public MainForm(IUnitOfWork dbContext)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
       
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.dbContext = dbContext;
            bindingSource = new BindingSource();

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

        private void customMaterialButton6_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customMaterialButton11_Click(object sender, EventArgs e)
        {

        }

        private void customMaterialButton10_Click(object sender, EventArgs e)
        {

        }

        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
