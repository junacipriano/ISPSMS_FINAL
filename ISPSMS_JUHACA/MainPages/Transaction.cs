using Infastructure.Data.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain.Models;
using ISPSMS_JUHACA.MainPages.SubPages;
using Krypton.Toolkit;
using MaterialSkin.Controls;
using MaterialSkin;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class Transaction : MaterialForm, ITransactionView
    {
        private readonly TransactionPresenter _presenter;
        private MainForm mainForm;
        private BindingSource bindingSource;
        public BindingSource BindingSource => bindingSource;
        public Transaction(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _presenter = new TransactionPresenter(this, dbContext);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

         
        }
        private void LoadTransactions()
        {
            _presenter.LoadTransactions();
        }
            
        public void DisplayTransactions(List<Transactions> transactions)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var transaction in transactions)
            {
                TransactionTemplate transactionTemplate = new TransactionTemplate(transaction)
                {
                    TopLevel = false,
                    Dock = DockStyle.None
                };


                flowLayoutPanel1.Controls.Add(transactionTemplate);
                transactionTemplate.Show();
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
               LoadTransactions();
        }

        public void FilterData(string searchText)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is BillingItems billingItem)
                {
                    var subscriber = billingItem.ConSubsEntity;
                    bool isVisible = subscriber.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                     subscriber.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase);

                    billingItem.Visible = isVisible;
                }
            }
        }
    }
}
