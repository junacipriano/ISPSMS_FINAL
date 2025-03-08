using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;

using ISPSMS_JUHACA.MainPages;
using Domain.Models;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;

namespace ISPSMS_JUHACA.Views
{
    public partial class Disconnected : MaterialForm, IDisconnected
    {
        public readonly IUnitOfWork dbContext;
        private System.Windows.Forms.BindingSource bindingSource;

        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        internal Disconnected disconnected;
        private DisconnectedPresenter presenter;

        public ConnectedSubscribers SelectedSubscriber { get; internal set; }

        public Disconnected(IUnitOfWork dbContext, SubscriberPage subscribersForm)
        {
            InitializeComponent();



            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.dbContext = dbContext;
            bindingSource = new System.Windows.Forms.BindingSource();

            presenter = new DisconnectedPresenter(dbContext, this);
            this.Shown += Disconnected_Shown;
        }

        private void Disconnected_Shown(object? sender, EventArgs e)
        {
            presenter.LoadDisconnectedSubscribers();
        }

        //public void LoadDisconnectedSubscribers()
        //{
        //    var disconnectedSubscribers = dbContext.disconnectedSubscriberRepository.GetAll();
        //    DisconnectdataGridView1.DataSource = disconnectedSubscribers;
        //}

        //private void Disconnected_Load(object sender, EventArgs e)
        //{
        //    // LoadDisconnectedSubscribers();
        //presenter.LoadDisconnectedSubscribers();
        //}

        public void SetDisconnectedSubscribers(IEnumerable<DisconnectedSubscribers> subscribers)
        {
            DisconnectedGridView1.DataSource = subscribers;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
