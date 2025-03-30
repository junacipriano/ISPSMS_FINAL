namespace ISPSMS_JUHACA.Views
{
    partial class ProfileEdit
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
            Switch = new MaterialSkin.Controls.MaterialSwitch();
            tbLName = new Krypton.Toolkit.KryptonTextBox();
            tbMi = new Krypton.Toolkit.KryptonTextBox();
            tbConfirmPass = new Krypton.Toolkit.KryptonTextBox();
            tbPass = new Krypton.Toolkit.KryptonTextBox();
            tbUsername = new Krypton.Toolkit.KryptonTextBox();
            tbFName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnSave = new Krypton.Toolkit.KryptonButton();
            btnClose = new Krypton.Toolkit.KryptonButton();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Switch);
            panel1.Controls.Add(tbLName);
            panel1.Controls.Add(tbMi);
            panel1.Controls.Add(tbConfirmPass);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbFName);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(kryptonLabel9);
            panel1.Controls.Add(kryptonLabel6);
            panel1.Controls.Add(kryptonLabel7);
            panel1.Controls.Add(kryptonLabel5);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 375);
            panel1.TabIndex = 6;
            // 
            // Switch
            // 
            Switch.AutoSize = true;
            Switch.Depth = 0;
            Switch.Location = new Point(80, 268);
            Switch.Margin = new Padding(0);
            Switch.MouseLocation = new Point(-1, -1);
            Switch.MouseState = MaterialSkin.MouseState.HOVER;
            Switch.Name = "Switch";
            Switch.Ripple = true;
            Switch.Size = new Size(172, 37);
            Switch.TabIndex = 26;
            Switch.Text = "Show Password";
            Switch.UseVisualStyleBackColor = true;
            Switch.CheckedChanged += Switch_CheckedChanged;
            // 
            // tbLName
            // 
            tbLName.CueHint.CueHintText = "Last Name";
            tbLName.Location = new Point(78, 177);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(243, 27);
            tbLName.TabIndex = 25;
            // 
            // tbMi
            // 
            tbMi.CueHint.CueHintText = "Middle Initial";
            tbMi.Location = new Point(78, 144);
            tbMi.Name = "tbMi";
            tbMi.Size = new Size(243, 27);
            tbMi.TabIndex = 24;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.CueHint.CueHintText = "Change Password";
            tbConfirmPass.Location = new Point(341, 238);
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.Size = new Size(260, 27);
            tbConfirmPass.TabIndex = 23;
            // 
            // tbPass
            // 
            tbPass.CueHint.CueHintText = "Change Password";
            tbPass.Location = new Point(80, 238);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(243, 27);
            tbPass.TabIndex = 22;
            // 
            // tbUsername
            // 
            tbUsername.CueHint.CueHintText = "User Name";
            tbUsername.Location = new Point(341, 111);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(256, 27);
            tbUsername.TabIndex = 21;
            // 
            // tbFName
            // 
            tbFName.CueHint.CueHintText = "First  Name";
            tbFName.Location = new Point(78, 111);
            tbFName.Name = "tbFName";
            tbFName.Size = new Size(243, 27);
            tbFName.TabIndex = 18;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(341, 209);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(222, 31);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 17;
            kryptonLabel3.Values.Text = "Confirm Password:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(192, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 31);
            btnSave.TabIndex = 16;
            btnSave.Values.DropDownArrowColor = Color.Empty;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnSave_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(74, 327);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 31);
            btnClose.TabIndex = 5;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "Cancel";
            btnClose.Click += btnClose_Click;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(57, 209);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(129, 31);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 12;
            kryptonLabel9.Values.Text = "Password:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(42, 288);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(6, 2);
            kryptonLabel6.TabIndex = 11;
            kryptonLabel6.Values.Text = "";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(339, 74);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(134, 31);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 10;
            kryptonLabel7.Values.Text = "Username:";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(163, 22);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(291, 31);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Edit Personal Information";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(42, 238);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(6, 2);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(5, 74);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(181, 31);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Account Name:";
            // 
            // ProfileEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 408);
            Controls.Add(panel1);
            Name = "ProfileEdit";
            Text = "ProfileEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox tbFName;
        private Krypton.Toolkit.KryptonTextBox tbUsername;
        private Krypton.Toolkit.KryptonTextBox tbPass;
        private Krypton.Toolkit.KryptonTextBox tbConfirmPass;
        private Krypton.Toolkit.KryptonTextBox tbLName;
        private Krypton.Toolkit.KryptonTextBox tbMi;
        private MaterialSkin.Controls.MaterialSwitch Switch;
    }
}