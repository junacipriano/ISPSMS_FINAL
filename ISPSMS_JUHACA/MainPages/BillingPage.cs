using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages.SubPages;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private MaterialButton activeButton;
        private MainForm mainForm;

        public BindingSource BindingSource => bindingSource;
        public BillingPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            bindingSource = new BindingSource();

            var billingItem = new BillingItems(dbContext, this);
            billingItem.Show();

        }

        private void BillingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
