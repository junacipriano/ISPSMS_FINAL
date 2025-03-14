namespace ISPSMS_JUHACA.Views
{
    partial class LoginForm
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
            tbUsername = new MaterialSkin.Controls.MaterialTextBox();
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnSignUp = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.AnimateReadOnly = false;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Depth = 0;
            tbUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsername.Hint = "Username";
            tbUsername.LeadingIcon = null;
            tbUsername.Location = new Point(51, 121);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.MaxLength = 50;
            tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(258, 50);
            tbUsername.TabIndex = 0;
            tbUsername.Text = "";
            tbUsername.TrailingIcon = null;
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Depth = 0;
            tbPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(51, 197);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Password = true;
            tbPassword.Size = new Size(258, 50);
            tbPassword.TabIndex = 1;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(91, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(183, 57);
            btnLogin.StateCommon.Back.Image = Properties.Resources._1;
            btnLogin.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            btnLogin.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnLogin.StateCommon.Border.Rounding = 30F;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.TabIndex = 4;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Sign in";
            btnLogin.Click += btnLogin_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(91, 51);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(172, 65);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(236, 73, 20);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(236, 73, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Croogla 4F", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Sign in";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(459, 269);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(183, 59);
            btnSignUp.StateCommon.Back.Color1 = Color.FromArgb(159, 144, 113);
            btnSignUp.StateCommon.Back.Color2 = Color.FromArgb(159, 144, 113);
            btnSignUp.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            btnSignUp.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnSignUp.StateCommon.Border.Rounding = 30F;
            btnSignUp.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            btnSignUp.StateCommon.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            btnSignUp.StateCommon.Content.ShortText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.TabIndex = 6;
            btnSignUp.Values.DropDownArrowColor = Color.Empty;
            btnSignUp.Values.ImageTransparentColor = Color.FromArgb(239, 222, 178);
            btnSignUp.Values.Text = "Sign in";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(367, 51);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(361, 65);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(114, 114, 88);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(114, 114, 88);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Croogla 4F", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "Welcome Back!";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(345, 149);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(6, 2);
            kryptonLabel3.StateCommon.LongText.Color1 = Color.FromArgb(114, 114, 88);
            kryptonLabel3.StateCommon.LongText.Color2 = Color.FromArgb(114, 114, 88);
            kryptonLabel3.StateCommon.LongText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(114, 114, 88);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(114, 114, 88);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 8;
            kryptonLabel3.Values.Text = "";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(758, 374);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(btnSignUp);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Back.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Border.Rounding = 15F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Back.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Border.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Border.Color2 = Color.FromArgb(241, 240, 233);
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbUsername;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}