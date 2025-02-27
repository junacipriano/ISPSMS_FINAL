    using MaterialSkin;
    using MaterialSkin.Controls;
    using Infastructure.Data.Repositories.IRepositories;
    using Domain.Models;
using ISPSMS_JUHACA.Views;

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
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
        }
        private void SubscribersForm_Load(object sender, EventArgs e)
        {
            getSubscribers();
        }

        public void getSubscribers()
        {
            var subscribers = dbContext.connectedSubscriberRepository.GetAll();
            connectedsubscribersGridView.DataSource = subscribers;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this);
            AddForm.ShowDialog();

        }

        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                        dbContext.connectedSubscriberRepository.Remove(selectedSubscriber);
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
        }

        private void disconnectedbtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var Disconnected = new Disconnected(dbContext, this);
            Disconnected.ShowDialog();
        }
    }
}
