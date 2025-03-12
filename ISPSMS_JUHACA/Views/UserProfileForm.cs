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
    public partial class UserProfileForm : Form
    {
        private Label lblUsername;
        private Label lblRole;

        public UserProfileForm()
        {
            InitializeComponent();
            lblUsername = new Label();
            lblRole = new Label();
            Controls.Add(lblUsername);
            Controls.Add(lblRole);
        }

        public void UpdateProfile(string username, string role)
        {
            Username.Text = username;
            UserRole.Text = role;
        }
    }
}
