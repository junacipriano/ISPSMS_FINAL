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
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            btnSignUp = new MaterialSkin.Controls.MaterialButton();
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
            tbUsername.Location = new Point(177, 56);
            tbUsername.MaxLength = 50;
            tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(275, 50);
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
            tbPassword.Location = new Point(177, 135);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Password = true;
            tbPassword.Size = new Size(275, 50);
            tbPassword.TabIndex = 1;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(208, 207);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(64, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnSignUp
            // 
            btnSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignUp.Depth = 0;
            btnSignUp.HighEmphasis = true;
            btnSignUp.Icon = null;
            btnSignUp.Location = new Point(280, 207);
            btnSignUp.Margin = new Padding(4, 6, 4, 6);
            btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignUp.Name = "btnSignUp";
            btnSignUp.NoAccentTextColor = Color.Empty;
            btnSignUp.Size = new Size(77, 36);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignUp.UseAccentColor = false;
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbUsername;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
    }
}