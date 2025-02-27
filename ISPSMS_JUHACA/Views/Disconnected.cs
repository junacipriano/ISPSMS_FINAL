using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Views.USERCONTROL;


namespace ISPSMS_JUHACA.Views
{
    public partial class Disconnected : MaterialForm
    {
        public readonly IUnitOfWork dbContext;
        private System.Windows.Forms.BindingSource bindingSource;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public Disconnected(IUnitOfWork dbContext, SubscriberPage subscribersForm)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.dbContext = dbContext;
            bindingSource = new System.Windows.Forms.BindingSource();
        }
    }
}
