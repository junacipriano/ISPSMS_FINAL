using Infastructure.Data.Repositories.IRepositories;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.Presenter;
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
using ISPSMS_JUHACA.Data;

namespace ISPSMS_JUHACA.Views
{
    public partial class UserProfileForm : Form
    {
        private Label lblUsername;
        private Label lblRole;

        public event EventHandler? Logout;

        public UserProfileForm()
        {
            InitializeComponent();
            lblUsername = new Label();
            lblRole = new Label();
            Controls.Add(lblUsername);
            Controls.Add(lblRole);

        }

        public void UpdateProfile(string username, string role,string password, string pname, string id)
        {
            Username.Text = username;
            UserRole.Text = role;
            personName.Text = pname;
            personPassword.Text = password;
            personUsername.Text = username;
            personID.Text = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Find and close all open forms except login
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is LoginForm))
                    {
                        form.Close();
                    }
                }

                // Check if LoginForm is still open
                LoginForm login = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if (login == null)
                {
                    // Recreate the login form with necessary dependencies
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                    optionsBuilder.UseSqlServer("Data Source=LAPTOP-AEJ6B24K\\SQLEXPRESS;Initial Catalog=connected_subscribers_db;User ID=ISPSMS_JUHACA;Password=OPTICALITSOLUTIONS2025;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False\r\n");
                    AppDbContext dbContext = new AppDbContext(optionsBuilder.Options);

                    IAccountsRepository repository = new AccountsRepository(dbContext);
                    IUnitOfWork unitOfWork = new UnitOfWork(dbContext);
                    login = new LoginForm(unitOfWork);

                    LoginPresenter loginPresenter = new LoginPresenter(login, unitOfWork, repository);
                }

                login.Show();
            }
        }

    }
}
