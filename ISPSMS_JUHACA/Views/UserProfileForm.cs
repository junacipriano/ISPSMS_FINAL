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
        private string actualPassword;

        public event EventHandler? Logout;

        public UserProfileForm()
        {
            InitializeComponent();
            lblUsername = new Label();
            lblRole = new Label();
            Controls.Add(lblUsername);
            Controls.Add(lblRole);

        }

        public void UpdateProfile(string username, string role, string password, string pname, string id)
        {
            actualPassword = password;
            Username.Text = username;
            UserRole.Text = role;
            personName.Text = pname;
            personPassword.Text = new string('*', password.Length);
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
                // Restart the application
                Application.Restart();
                Environment.Exit(0); // Ensures the current instance closes properly
            }
        }


        private void Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch.Checked)
            {
                personPassword.Text = actualPassword; // Show actual password
            }
            else
            {
                personPassword.Text = new string('*', actualPassword.Length); // Mask password
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
