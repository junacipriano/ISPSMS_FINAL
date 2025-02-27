    using MaterialSkin;
    using MaterialSkin.Controls;
    using Infastructure.Data.Repositories.IRepositories;
    using Domain.Models;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using System.Windows.Forms;
using ISPSMS_JUHACA.Views.USERCONTROL;

namespace ISPSMS_JUHACA
    {
    public partial class MainForm : MaterialForm
    {
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;

        public BindingSource BindingSource => bindingSource;

        
        public MainForm(IUnitOfWork dbContext)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
     
         
            materialTabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab== subscribersPage)
            {
           
                subscribersPage.Controls.Clear();

                var subsPage = new SubscriberPage(dbContext, this);
        
                subsPage.TopLevel = false;
                subsPage.FormBorderStyle = FormBorderStyle.None;
                subsPage.Dock = DockStyle.Fill;

                subscribersPage.Controls.Add(subsPage);
                subsPage.Show();

            }
            else if(materialTabControl1.SelectedTab == dashboardPage)
            {
                dashboardPage.Controls.Clear();
              

            }
            else if(materialTabControl1.SelectedTab == billingPage)
            {
                billingPage.Controls.Clear();
            }
            else if(materialTabControl1.SelectedTab == transactionsPage)
            {
                transactionsPage.Controls.Clear();
            }
            else if(materialTabControl1.SelectedTab == accountsPage)
            {
                accountsPage.Controls.Clear();
            }
         
            else
            {
                return ;
            }
        }   
    }

       

 
     
    
}
