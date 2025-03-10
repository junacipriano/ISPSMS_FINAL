namespace ISPSMS_JUHACA
{
    partial class addSubscribersForm
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
            label1 = new Label();
            lastNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            firstNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            MITextBox = new MaterialSkin.Controls.MaterialTextBox2();
            barangayComboBox = new MaterialSkin.Controls.MaterialComboBox();
            districtComboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            planComboBox = new MaterialSkin.Controls.MaterialComboBox();
            dueDatePicker = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            monthlyChargeTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            contactNumberTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            CancelBtn = new MaterialSkin.Controls.MaterialButton();
            SaveBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(17, 64);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Client";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.AnimateReadOnly = false;
            lastNameTextBox.BackgroundImageLayout = ImageLayout.None;
            lastNameTextBox.CharacterCasing = CharacterCasing.Normal;
            lastNameTextBox.Depth = 0;
            lastNameTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.HideSelection = true;
            lastNameTextBox.Hint = "Last Name";
            lastNameTextBox.LeadingIcon = null;
            lastNameTextBox.Location = new Point(20, 110);
            lastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            lastNameTextBox.MaxLength = 32767;
            lastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PasswordChar = '\0';
            lastNameTextBox.PrefixSuffixText = null;
            lastNameTextBox.ReadOnly = false;
            lastNameTextBox.RightToLeft = RightToLeft.No;
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.SelectionLength = 0;
            lastNameTextBox.SelectionStart = 0;
            lastNameTextBox.ShortcutsEnabled = true;
            lastNameTextBox.Size = new Size(157, 48);
            lastNameTextBox.TabIndex = 1;
            lastNameTextBox.TabStop = false;
            lastNameTextBox.TextAlign = HorizontalAlignment.Left;
            lastNameTextBox.TrailingIcon = null;
            lastNameTextBox.UseSystemPasswordChar = false;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.AnimateReadOnly = false;
            firstNameTextBox.BackgroundImageLayout = ImageLayout.None;
            firstNameTextBox.CharacterCasing = CharacterCasing.Normal;
            firstNameTextBox.Depth = 0;
            firstNameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstNameTextBox.HideSelection = true;
            firstNameTextBox.Hint = "First Name";
            firstNameTextBox.LeadingIcon = null;
            firstNameTextBox.Location = new Point(193, 110);
            firstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            firstNameTextBox.MaxLength = 32767;
            firstNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PasswordChar = '\0';
            firstNameTextBox.PrefixSuffixText = null;
            firstNameTextBox.ReadOnly = false;
            firstNameTextBox.RightToLeft = RightToLeft.No;
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.SelectionLength = 0;
            firstNameTextBox.SelectionStart = 0;
            firstNameTextBox.ShortcutsEnabled = true;
            firstNameTextBox.Size = new Size(156, 48);
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.TabStop = false;
            firstNameTextBox.TextAlign = HorizontalAlignment.Left;
            firstNameTextBox.TrailingIcon = null;
            firstNameTextBox.UseSystemPasswordChar = false;
            // 
            // MITextBox
            // 
            MITextBox.AnimateReadOnly = false;
            MITextBox.BackgroundImageLayout = ImageLayout.None;
            MITextBox.CharacterCasing = CharacterCasing.Normal;
            MITextBox.Depth = 0;
            MITextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            MITextBox.HideSelection = true;
            MITextBox.Hint = "M.I.";
            MITextBox.LeadingIcon = null;
            MITextBox.Location = new Point(365, 110);
            MITextBox.Margin = new Padding(3, 2, 3, 2);
            MITextBox.MaxLength = 32767;
            MITextBox.MouseState = MaterialSkin.MouseState.OUT;
            MITextBox.Name = "MITextBox";
            MITextBox.PasswordChar = '\0';
            MITextBox.PrefixSuffixText = null;
            MITextBox.ReadOnly = false;
            MITextBox.RightToLeft = RightToLeft.No;
            MITextBox.SelectedText = "";
            MITextBox.SelectionLength = 0;
            MITextBox.SelectionStart = 0;
            MITextBox.ShortcutsEnabled = true;
            MITextBox.Size = new Size(66, 48);
            MITextBox.TabIndex = 3;
            MITextBox.TabStop = false;
            MITextBox.TextAlign = HorizontalAlignment.Left;
            MITextBox.TrailingIcon = null;
            MITextBox.UseSystemPasswordChar = false;
            // 
            // barangayComboBox
            // 
            barangayComboBox.AutoResize = false;
            barangayComboBox.BackColor = Color.FromArgb(255, 255, 255);
            barangayComboBox.Depth = 0;
            barangayComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            barangayComboBox.DropDownHeight = 174;
            barangayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            barangayComboBox.DropDownWidth = 121;
            barangayComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            barangayComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            barangayComboBox.FormattingEnabled = true;
            barangayComboBox.Hint = "Baranggay";
            barangayComboBox.IntegralHeight = false;
            barangayComboBox.ItemHeight = 43;
            barangayComboBox.Items.AddRange(new object[] { "North Poblacion", "South Poblacion", "Dologon" });
            barangayComboBox.Location = new Point(20, 173);
            barangayComboBox.Margin = new Padding(3, 2, 3, 2);
            barangayComboBox.MaxDropDownItems = 4;
            barangayComboBox.MouseState = MaterialSkin.MouseState.OUT;
            barangayComboBox.Name = "barangayComboBox";
            barangayComboBox.Size = new Size(195, 49);
            barangayComboBox.StartIndex = 0;
            barangayComboBox.TabIndex = 4;
            // 
            // districtComboBox
            // 
            districtComboBox.AutoResize = false;
            districtComboBox.BackColor = Color.FromArgb(255, 255, 255);
            districtComboBox.Depth = 0;
            districtComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            districtComboBox.DropDownHeight = 174;
            districtComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            districtComboBox.DropDownWidth = 121;
            districtComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            districtComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            districtComboBox.FormattingEnabled = true;
            districtComboBox.Hint = "District/Purok";
            districtComboBox.IntegralHeight = false;
            districtComboBox.ItemHeight = 43;
            districtComboBox.Items.AddRange(new object[] { "Purok 2", "Purok 5", "Purok 10" });
            districtComboBox.Location = new Point(237, 173);
            districtComboBox.Margin = new Padding(3, 2, 3, 2);
            districtComboBox.MaxDropDownItems = 4;
            districtComboBox.MouseState = MaterialSkin.MouseState.OUT;
            districtComboBox.Name = "districtComboBox";
            districtComboBox.Size = new Size(195, 49);
            districtComboBox.StartIndex = 0;
            districtComboBox.TabIndex = 5;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel1.Location = new Point(20, 155);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(53, 17);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Address";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel2.Location = new Point(20, 230);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(30, 17);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Plan";
            // 
            // planComboBox
            // 
            planComboBox.AutoResize = false;
            planComboBox.BackColor = Color.FromArgb(255, 255, 255);
            planComboBox.Depth = 0;
            planComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            planComboBox.DropDownHeight = 174;
            planComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            planComboBox.DropDownWidth = 121;
            planComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            planComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            planComboBox.FormattingEnabled = true;
            planComboBox.Hint = "Plan";
            planComboBox.IntegralHeight = false;
            planComboBox.ItemHeight = 43;
            planComboBox.Items.AddRange(new object[] { "Postpaid", "Prepaid" });
            planComboBox.Location = new Point(20, 247);
            planComboBox.Margin = new Padding(3, 2, 3, 2);
            planComboBox.MaxDropDownItems = 4;
            planComboBox.MouseState = MaterialSkin.MouseState.OUT;
            planComboBox.Name = "planComboBox";
            planComboBox.Size = new Size(195, 49);
            planComboBox.StartIndex = 0;
            planComboBox.TabIndex = 7;
            // 
            // dueDatePicker
            // 
            dueDatePicker.Location = new Point(237, 247);
            dueDatePicker.Margin = new Padding(3, 2, 3, 2);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(195, 23);
            dueDatePicker.TabIndex = 9;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.Location = new Point(237, 230);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(59, 17);
            materialLabel3.TabIndex = 10;
            materialLabel3.Text = "Due Date";
            // 
            // monthlyChargeTextBox
            // 
            monthlyChargeTextBox.AnimateReadOnly = false;
            monthlyChargeTextBox.BackgroundImageLayout = ImageLayout.None;
            monthlyChargeTextBox.CharacterCasing = CharacterCasing.Normal;
            monthlyChargeTextBox.Depth = 0;
            monthlyChargeTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlyChargeTextBox.HideSelection = true;
            monthlyChargeTextBox.Hint = "Monthly Charge";
            monthlyChargeTextBox.LeadingIcon = null;
            monthlyChargeTextBox.Location = new Point(20, 308);
            monthlyChargeTextBox.Margin = new Padding(3, 2, 3, 2);
            monthlyChargeTextBox.MaxLength = 32767;
            monthlyChargeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            monthlyChargeTextBox.Name = "monthlyChargeTextBox";
            monthlyChargeTextBox.PasswordChar = '\0';
            monthlyChargeTextBox.PrefixSuffixText = null;
            monthlyChargeTextBox.ReadOnly = false;
            monthlyChargeTextBox.RightToLeft = RightToLeft.No;
            monthlyChargeTextBox.SelectedText = "";
            monthlyChargeTextBox.SelectionLength = 0;
            monthlyChargeTextBox.SelectionStart = 0;
            monthlyChargeTextBox.ShortcutsEnabled = true;
            monthlyChargeTextBox.Size = new Size(194, 48);
            monthlyChargeTextBox.TabIndex = 11;
            monthlyChargeTextBox.TabStop = false;
            monthlyChargeTextBox.TextAlign = HorizontalAlignment.Left;
            monthlyChargeTextBox.TrailingIcon = null;
            monthlyChargeTextBox.UseSystemPasswordChar = false;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.AnimateReadOnly = false;
            contactNumberTextBox.BackgroundImageLayout = ImageLayout.None;
            contactNumberTextBox.CharacterCasing = CharacterCasing.Normal;
            contactNumberTextBox.Depth = 0;
            contactNumberTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactNumberTextBox.HelperText = "09XXXXXXXXX";
            contactNumberTextBox.HideSelection = true;
            contactNumberTextBox.Hint = "Contact Number";
            contactNumberTextBox.LeadingIcon = null;
            contactNumberTextBox.Location = new Point(237, 308);
            contactNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            contactNumberTextBox.MaxLength = 32767;
            contactNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.PasswordChar = '\0';
            contactNumberTextBox.PrefixSuffixText = null;
            contactNumberTextBox.ReadOnly = false;
            contactNumberTextBox.RightToLeft = RightToLeft.No;
            contactNumberTextBox.SelectedText = "";
            contactNumberTextBox.SelectionLength = 0;
            contactNumberTextBox.SelectionStart = 0;
            contactNumberTextBox.ShortcutsEnabled = true;
            contactNumberTextBox.Size = new Size(194, 48);
            contactNumberTextBox.TabIndex = 12;
            contactNumberTextBox.TabStop = false;
            contactNumberTextBox.TextAlign = HorizontalAlignment.Left;
            contactNumberTextBox.TrailingIcon = null;
            contactNumberTextBox.UseSystemPasswordChar = false;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancelBtn.Depth = 0;
            CancelBtn.HighEmphasis = true;
            CancelBtn.Icon = null;
            CancelBtn.Location = new Point(286, 374);
            CancelBtn.Margin = new Padding(4, 4, 4, 4);
            CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            CancelBtn.Name = "CancelBtn";
            CancelBtn.NoAccentTextColor = Color.Empty;
            CancelBtn.Size = new Size(77, 36);
            CancelBtn.TabIndex = 13;
            CancelBtn.Text = "CANCEL";
            CancelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CancelBtn.UseAccentColor = false;
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveBtn.Depth = 0;
            SaveBtn.HighEmphasis = true;
            SaveBtn.Icon = null;
            SaveBtn.Location = new Point(375, 374);
            SaveBtn.Margin = new Padding(4, 4, 4, 4);
            SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NoAccentTextColor = Color.Empty;
            SaveBtn.Size = new Size(64, 36);
            SaveBtn.TabIndex = 14;
            SaveBtn.Text = "SAVE";
            SaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveBtn.UseAccentColor = false;
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // addSubscribersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 433);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(contactNumberTextBox);
            Controls.Add(monthlyChargeTextBox);
            Controls.Add(materialLabel3);
            Controls.Add(dueDatePicker);
            Controls.Add(materialLabel2);
            Controls.Add(planComboBox);
            Controls.Add(materialLabel1);
            Controls.Add(districtComboBox);
            Controls.Add(barangayComboBox);
            Controls.Add(MITextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "addSubscribersForm";
            Padding = new Padding(3, 48, 3, 2);
            Load += addSubscribersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton CancelBtn;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        public MaterialSkin.Controls.MaterialTextBox2 lastNameTextBox;
        public MaterialSkin.Controls.MaterialTextBox2 firstNameTextBox;
        public MaterialSkin.Controls.MaterialTextBox2 MITextBox;
        public MaterialSkin.Controls.MaterialComboBox barangayComboBox;
        public MaterialSkin.Controls.MaterialComboBox districtComboBox;
        public MaterialSkin.Controls.MaterialComboBox planComboBox;
        public DateTimePicker dueDatePicker;
        public MaterialSkin.Controls.MaterialTextBox2 monthlyChargeTextBox;
        public MaterialSkin.Controls.MaterialTextBox2 contactNumberTextBox;
    }
}