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
            Username = new Krypton.Toolkit.KryptonLabel();
            UserRole = new Krypton.Toolkit.KryptonLabel();
            btnClose = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(64, 68);
            Username.Name = "Username";
            Username.Size = new Size(52, 24);
            Username.TabIndex = 0;
            Username.Values.Text = "Name";
            // 
            // UserRole
            // 
            UserRole.Location = new Point(64, 141);
            UserRole.Name = "UserRole";
            UserRole.Size = new Size(42, 24);
            UserRole.TabIndex = 1;
            UserRole.Values.Text = "Role";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(43, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 31);
            btnClose.TabIndex = 2;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "Close";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(UserRole);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(123, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 320);
            panel1.TabIndex = 3;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel Username;
        private Krypton.Toolkit.KryptonLabel UserRole;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Panel panel1;
    }
}