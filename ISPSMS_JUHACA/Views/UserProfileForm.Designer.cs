namespace ISPSMS_JUHACA.Views
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Krypton.Toolkit.KryptonButton();
            Username = new Krypton.Toolkit.KryptonLabel();
            UserRole = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            btnEdit = new Krypton.Toolkit.KryptonButton();
            personID = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            Switch = new MaterialSkin.Controls.MaterialSwitch();
            personPassword = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            personUsername = new Krypton.Toolkit.KryptonLabel();
            personName = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(15, 367);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 31);
            btnClose.TabIndex = 2;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // Username
            // 
            Username.Location = new Point(227, 24);
            Username.Name = "Username";
            Username.Size = new Size(52, 24);
            Username.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            Username.TabIndex = 0;
            Username.Values.Text = "Name";
            // 
            // UserRole
            // 
            UserRole.Location = new Point(527, 24);
            UserRole.Name = "UserRole";
            UserRole.Size = new Size(42, 24);
            UserRole.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            UserRole.TabIndex = 1;
            UserRole.Values.Text = "Role";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 138);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(181, 31);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Account Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(40, 180);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(6, 2);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(personID);
            panel1.Controls.Add(kryptonLabel10);
            panel1.Controls.Add(Switch);
            panel1.Controls.Add(personPassword);
            panel1.Controls.Add(kryptonLabel9);
            panel1.Controls.Add(kryptonLabel6);
            panel1.Controls.Add(kryptonLabel7);
            panel1.Controls.Add(personUsername);
            panel1.Controls.Add(personName);
            panel1.Controls.Add(kryptonLabel5);
            panel1.Controls.Add(kryptonLabel4);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Controls.Add(UserRole);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 306);
            panel1.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(527, 252);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(177, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Values.DropDownArrowColor = Color.Empty;
            btnEdit.Values.Text = "Edit Profile";
            btnEdit.Click += btnEdit_Click;
            // 
            // personID
            // 
            personID.Location = new Point(490, 138);
            personID.Name = "personID";
            personID.Size = new Size(52, 24);
            personID.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            personID.TabIndex = 16;
            personID.Values.Text = "Name";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(340, 138);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(144, 31);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel10.TabIndex = 15;
            kryptonLabel10.Values.Text = "Peroson ID:";
            // 
            // Switch
            // 
            Switch.AutoSize = true;
            Switch.Depth = 0;
            Switch.Location = new Point(55, 246);
            Switch.Margin = new Padding(0);
            Switch.MouseLocation = new Point(-1, -1);
            Switch.MouseState = MaterialSkin.MouseState.HOVER;
            Switch.Name = "Switch";
            Switch.Ripple = true;
            Switch.Size = new Size(172, 37);
            Switch.TabIndex = 14;
            Switch.Text = "Show Password";
            Switch.UseVisualStyleBackColor = true;
            Switch.CheckedChanged += Switch_CheckedChanged;
            // 
            // personPassword
            // 
            personPassword.Location = new Point(190, 219);
            personPassword.Name = "personPassword";
            personPassword.Size = new Size(52, 24);
            personPassword.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            personPassword.TabIndex = 13;
            personPassword.Values.Text = "Name";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(55, 212);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(129, 31);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 12;
            kryptonLabel9.Values.Text = "Password:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(40, 230);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(6, 2);
            kryptonLabel6.TabIndex = 11;
            kryptonLabel6.Values.Text = "";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(50, 175);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(134, 31);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 10;
            kryptonLabel7.Values.Text = "Username:";
            // 
            // personUsername
            // 
            personUsername.Location = new Point(190, 182);
            personUsername.Name = "personUsername";
            personUsername.Size = new Size(52, 24);
            personUsername.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            personUsername.TabIndex = 9;
            personUsername.Values.Text = "Name";
            // 
            // personName
            // 
            personName.Location = new Point(190, 138);
            personName.Name = "personName";
            personName.Size = new Size(52, 24);
            personName.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 12F);
            personName.TabIndex = 8;
            personName.Values.Text = "Name";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(228, 81);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(242, 31);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Personal Information";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(40, 17);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(181, 31);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 6;
            kryptonLabel4.Values.Text = "Account Name:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(449, 17);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(72, 31);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 5;
            kryptonLabel3.Values.Text = "Role:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(539, 367);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(177, 31);
            btnLogout.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogout.TabIndex = 4;
            btnLogout.Values.DropDownArrowColor = Color.Empty;
            btnLogout.Values.Text = "Log Out";
            btnLogout.Click += btnLogout_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 450);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel Username;
        private Krypton.Toolkit.KryptonLabel UserRole;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel personUsername;
        private Krypton.Toolkit.KryptonLabel personName;
        private MaterialSkin.Controls.MaterialSwitch Switch;
        private Krypton.Toolkit.KryptonLabel personPassword;
        private Krypton.Toolkit.KryptonLabel personID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonButton btnEdit;
    }
}