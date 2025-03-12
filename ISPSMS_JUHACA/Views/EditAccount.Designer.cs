namespace ISPSMS_JUHACA.Views
{
    partial class EditAccount
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnDelete = new Krypton.Toolkit.KryptonButton();
            btnSave = new Krypton.Toolkit.KryptonButton();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ComboRole = new Krypton.Toolkit.KryptonComboBox();
            tbConfirmPass = new Krypton.Toolkit.KryptonTextBox();
            tbPassword = new Krypton.Toolkit.KryptonTextBox();
            tbUsername = new Krypton.Toolkit.KryptonTextBox();
            tbAccountName = new Krypton.Toolkit.KryptonTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboRole).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(40, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 156);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(kryptonLabel5);
            panel2.Controls.Add(kryptonLabel4);
            panel2.Controls.Add(kryptonLabel3);
            panel2.Controls.Add(kryptonLabel2);
            panel2.Controls.Add(kryptonLabel1);
            panel2.Controls.Add(ComboRole);
            panel2.Controls.Add(tbConfirmPass);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbUsername);
            panel2.Controls.Add(tbAccountName);
            panel2.Location = new Point(40, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 303);
            panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(145, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Values.DropDownArrowColor = Color.Empty;
            btnDelete.Values.Text = "Delete";
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(285, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 31);
            btnSave.TabIndex = 10;
            btnSave.Values.DropDownArrowColor = Color.Empty;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(424, 231);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(388, 139);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(135, 24);
            kryptonLabel5.TabIndex = 8;
            kryptonLabel5.Values.Text = "Confirm Password";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(388, 78);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(42, 24);
            kryptonLabel4.TabIndex = 7;
            kryptonLabel4.Values.Text = "Role";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(90, 138);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(76, 24);
            kryptonLabel3.TabIndex = 6;
            kryptonLabel3.Values.Text = "Password";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(90, 78);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(80, 24);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Username";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(90, 15);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(113, 24);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Account Name";
            // 
            // ComboRole
            // 
            ComboRole.DropDownWidth = 209;
            ComboRole.Items.AddRange(new object[] { "CEO", "ADMIN", "DEFAULT" });
            ComboRole.Location = new Point(388, 106);
            ComboRole.Name = "ComboRole";
            ComboRole.Size = new Size(209, 26);
            ComboRole.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ComboRole.TabIndex = 4;
            ComboRole.SelectedIndexChanged += ComboRole_SelectedIndexChanged;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.Location = new Point(388, 169);
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.PasswordChar = '*';
            tbConfirmPass.Size = new Size(209, 27);
            tbConfirmPass.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(90, 168);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(209, 27);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(90, 105);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(209, 27);
            tbUsername.TabIndex = 1;
            // 
            // tbAccountName
            // 
            tbAccountName.Location = new Point(90, 45);
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(511, 27);
            tbAccountName.TabIndex = 0;
            // 
            // EditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 595);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EditAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAccount";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComboRole).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonTextBox tbAccountName;
        private Krypton.Toolkit.KryptonComboBox ComboRole;
        private Krypton.Toolkit.KryptonTextBox tbConfirmPass;
        private Krypton.Toolkit.KryptonTextBox tbPassword;
        private Krypton.Toolkit.KryptonTextBox tbUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnDelete;
    }
}