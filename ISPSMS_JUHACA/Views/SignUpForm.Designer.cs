namespace ISPSMS_JUHACA.Views
{
    partial class SignUpForm
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
            tbUserName = new MaterialSkin.Controls.MaterialTextBox();
            tbFirstName = new MaterialSkin.Controls.MaterialTextBox();
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            tbConfirmPass = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tbMi = new MaterialSkin.Controls.MaterialTextBox();
            tbLastName = new MaterialSkin.Controls.MaterialTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ShowPass = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.AnimateReadOnly = false;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Depth = 0;
            tbUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUserName.Hint = "User Name";
            tbUserName.LeadingIcon = null;
            tbUserName.Location = new Point(345, 101);
            tbUserName.MaxLength = 50;
            tbUserName.MouseState = MaterialSkin.MouseState.OUT;
            tbUserName.Multiline = false;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(239, 50);
            tbUserName.TabIndex = 0;
            tbUserName.Text = "";
            tbUserName.TrailingIcon = null;
            // 
            // tbFirstName
            // 
            tbFirstName.AnimateReadOnly = false;
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Depth = 0;
            tbFirstName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFirstName.Hint = "First Name";
            tbFirstName.LeadingIcon = null;
            tbFirstName.Location = new Point(92, 101);
            tbFirstName.MaxLength = 50;
            tbFirstName.MouseState = MaterialSkin.MouseState.OUT;
            tbFirstName.Multiline = false;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(239, 50);
            tbFirstName.TabIndex = 2;
            tbFirstName.Text = "";
            tbFirstName.TrailingIcon = null;
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Depth = 0;
            tbPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(92, 302);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Password = true;
            tbPassword.Size = new Size(239, 50);
            tbPassword.TabIndex = 4;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.AnimateReadOnly = false;
            tbConfirmPass.BorderStyle = BorderStyle.None;
            tbConfirmPass.Depth = 0;
            tbConfirmPass.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbConfirmPass.Hint = "Confirm Password";
            tbConfirmPass.LeadingIcon = null;
            tbConfirmPass.Location = new Point(92, 358);
            tbConfirmPass.MaxLength = 50;
            tbConfirmPass.MouseState = MaterialSkin.MouseState.OUT;
            tbConfirmPass.Multiline = false;
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.Password = true;
            tbConfirmPass.Size = new Size(239, 50);
            tbConfirmPass.TabIndex = 10;
            tbConfirmPass.Text = "";
            tbConfirmPass.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(287, 492);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 18;
            btnSave.Text = "Confirm";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += materialButton1_Click;
            // 
            // tbMi
            // 
            tbMi.AnimateReadOnly = false;
            tbMi.BorderStyle = BorderStyle.None;
            tbMi.Depth = 0;
            tbMi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbMi.Hint = "Middle Initial";
            tbMi.LeadingIcon = null;
            tbMi.Location = new Point(92, 157);
            tbMi.MaxLength = 50;
            tbMi.MouseState = MaterialSkin.MouseState.OUT;
            tbMi.Multiline = false;
            tbMi.Name = "tbMi";
            tbMi.Size = new Size(239, 50);
            tbMi.TabIndex = 19;
            tbMi.Text = "";
            tbMi.TrailingIcon = null;
            // 
            // tbLastName
            // 
            tbLastName.AnimateReadOnly = false;
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Depth = 0;
            tbLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLastName.Hint = "Last Name";
            tbLastName.LeadingIcon = null;
            tbLastName.Location = new Point(92, 213);
            tbLastName.MaxLength = 50;
            tbLastName.MouseState = MaterialSkin.MouseState.OUT;
            tbLastName.Multiline = false;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(239, 50);
            tbLastName.TabIndex = 20;
            tbLastName.Text = "";
            tbLastName.TrailingIcon = null;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(61, 66);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(159, 28);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 21;
            kryptonLabel1.Values.Text = "Account Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(345, 66);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(127, 28);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 22;
            kryptonLabel2.Values.Text = "User Name:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(61, 268);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(196, 28);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 23;
            kryptonLabel3.Values.Text = "Account Password:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(214, 22);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(207, 28);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 24;
            kryptonLabel4.Values.Text = "Create your Account";
            // 
            // ShowPass
            // 
            ShowPass.Location = new Point(130, 433);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(112, 31);
            ShowPass.TabIndex = 25;
            ShowPass.Values.DropDownArrowColor = Color.Empty;
            ShowPass.Values.Text = "Show";
            ShowPass.Click += ShowPass_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(108, 497);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(112, 31);
            kryptonButton1.TabIndex = 26;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(638, 605);
            Controls.Add(kryptonButton1);
            Controls.Add(ShowPass);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(tbLastName);
            Controls.Add(tbMi);
            Controls.Add(btnSave);
            Controls.Add(tbConfirmPass);
            Controls.Add(tbPassword);
            Controls.Add(tbFirstName);
            Controls.Add(tbUserName);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton ShowPass;
        public MaterialSkin.Controls.MaterialTextBox tbUserName;
        public MaterialSkin.Controls.MaterialTextBox tbFirstName;
        public MaterialSkin.Controls.MaterialTextBox tbPassword;
        public MaterialSkin.Controls.MaterialTextBox tbConfirmPass;
        public MaterialSkin.Controls.MaterialTextBox tbMi;
        public MaterialSkin.Controls.MaterialTextBox tbLastName;
        public Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}