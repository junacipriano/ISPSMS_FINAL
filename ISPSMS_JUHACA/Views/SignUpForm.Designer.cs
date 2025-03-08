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
            tbAccountName = new MaterialSkin.Controls.MaterialTextBox();
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            tbConfirmPass = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
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
            tbUserName.Location = new Point(80, 50);
            tbUserName.MaxLength = 50;
            tbUserName.MouseState = MaterialSkin.MouseState.OUT;
            tbUserName.Multiline = false;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(239, 50);
            tbUserName.TabIndex = 0;
            tbUserName.Text = "";
            tbUserName.TrailingIcon = null;
            // 
            // tbAccountName
            // 
            tbAccountName.AnimateReadOnly = false;
            tbAccountName.BorderStyle = BorderStyle.None;
            tbAccountName.Depth = 0;
            tbAccountName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAccountName.Hint = "Account Name";
            tbAccountName.LeadingIcon = null;
            tbAccountName.Location = new Point(80, 106);
            tbAccountName.MaxLength = 50;
            tbAccountName.MouseState = MaterialSkin.MouseState.OUT;
            tbAccountName.Multiline = false;
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(239, 50);
            tbAccountName.TabIndex = 2;
            tbAccountName.Text = "";
            tbAccountName.TrailingIcon = null;
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Depth = 0;
            tbPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(80, 173);
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
            tbConfirmPass.Location = new Point(80, 229);
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
            btnSave.Location = new Point(142, 312);
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
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 427);
            Controls.Add(btnSave);
            Controls.Add(tbConfirmPass);
            Controls.Add(tbPassword);
            Controls.Add(tbAccountName);
            Controls.Add(tbUserName);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbUserName;
        private MaterialSkin.Controls.MaterialTextBox tbAccountName;
        private MaterialSkin.Controls.MaterialTextBox tbPassword;
        private MaterialSkin.Controls.MaterialTextBox tbConfirmPass;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}