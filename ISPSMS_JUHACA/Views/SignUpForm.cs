using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.IVews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Views
{
    public partial class SignUpForm : Form, ISignUp
    {
        public event EventHandler Save;
        public SignUpForm(IUnitOfWork dbContext, IAccountsRepository repository)
        {
            InitializeComponent();
            new SignUpPresenter(this, dbContext, repository);
        }

        public string Username { get => tbUserName.Text.Trim().ToUpper(); set => tbUserName.Text = value; }
        public string AccountName { get => tbAccountName.Text.Trim().ToUpper(); set => tbAccountName.Text = value; }
        public string AccountPassword { get => tbPassword.Text; set => tbPassword.Text = value; }
        public string AccountRole { get => tbRole.Text.Trim().ToUpper(); set => tbRole.Text = value; }
        public string AccountEmail { get => tbEmail.Text.Trim().ToUpper(); set => tbEmail.Text = value; }
        public string AccountPhone { get => tbPhone.Text.Trim().ToUpper(); set => tbPhone.Text = value; }
        public string AccountAddress { get => tbAddress.Text.Trim().ToUpper(); set => tbAddress.Text = value; }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Save?.Invoke(this, EventArgs.Empty);
        }
    }
}
