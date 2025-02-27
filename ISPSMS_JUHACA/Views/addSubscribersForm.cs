using Domain.Models;

using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.USERCONTROL;


namespace ISPSMS_JUHACA
{
    public partial class addSubscribersForm : MaterialForm, IMainSubscriberPage
    {
        public readonly IUnitOfWork dbContext;
        internal SubscriberPage SubscribersForm;
        private readonly AddSubscriberPresenter _presenter;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        private readonly MainForm mainForm;


        public event EventHandler SaveSubscriber;
        public event EventHandler FormLoaded;

        public string LastName
        {
            get => lastNameTextBox.Text.Trim().ToUpper();
            set => lastNameTextBox.Text = value;
        }

        public string FirstName
        {
            get => firstNameTextBox.Text.Trim().ToUpper();
            set => firstNameTextBox.Text = value;
        }

        public string MiddleInitial
        {
            get => MITextBox.Text.Trim().ToUpper();
            set => MITextBox.Text = value;
        }

        public string District
        {
            get => districtComboBox.Text;
            set => districtComboBox.Text = value;
        }

        public string Barangay
        {
            get => barangayComboBox.Text;
            set => barangayComboBox.Text = value;
        }

        public string Plan
        {
            get => planComboBox.Text;
            set => planComboBox.Text = value;
        }

        public string ContactNumber
        {
            get => contactNumberTextBox.Text;
            set => contactNumberTextBox.Text = value;
        }

        public decimal MonthlyCharge
        {
            get => decimal.TryParse(monthlyChargeTextBox.Text, out decimal value) ? value : 0;
            set => monthlyChargeTextBox.Text = value.ToString();
        }

        public DateTime DueDate
        {
            get => dueDatePicker.Value;
            set => dueDatePicker.Value = value;
        }




        public addSubscribersForm(IUnitOfWork dbContext, SubscriberPage SubscribersForm)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.SubscribersForm = SubscribersForm;
            _presenter = new AddSubscriberPresenter(this, dbContext, SubscribersForm);

              }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

            SaveSubscriber?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Adding Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CloseForm()
        {
            Hide();
        }

        private void addSubscribersForm_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke(this, EventArgs.Empty);
        }
    }
}