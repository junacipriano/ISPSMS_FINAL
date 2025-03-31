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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lastNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            firstNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            MITextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            barangayComboBox = new Krypton.Toolkit.KryptonComboBox();
            districtComboBox = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            planComboBox = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            dueDatePicker = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            monthlyChargeTextBox = new Krypton.Toolkit.KryptonTextBox();
            contactNumberTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            SaveBtn = new Krypton.Toolkit.KryptonButton();
            CancelBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)barangayComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)districtComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planComboBox).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(16, -5);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(200, 34);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(248, 132, 86);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 15;
            kryptonLabel1.Values.Text = "Add Subscriber";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            lastNameTextBox.CueHint.CueHintText = "Last Name";
            lastNameTextBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(23, 62);
            lastNameTextBox.MinimumSize = new Size(194, 40);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(223, 40);
            lastNameTextBox.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            lastNameTextBox.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            lastNameTextBox.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            lastNameTextBox.StateCommon.Border.Rounding = 5F;
            lastNameTextBox.TabIndex = 16;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            firstNameTextBox.CueHint.CueHintText = "First Name";
            firstNameTextBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(256, 62);
            firstNameTextBox.MinimumSize = new Size(194, 40);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(223, 40);
            firstNameTextBox.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            firstNameTextBox.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            firstNameTextBox.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            firstNameTextBox.StateCommon.Border.Rounding = 5F;
            firstNameTextBox.TabIndex = 17;
            // 
            // MITextBox
            // 
            MITextBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            MITextBox.CueHint.CueHintText = "M.I.";
            MITextBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MITextBox.Location = new Point(489, 62);
            MITextBox.MinimumSize = new Size(50, 40);
            MITextBox.Name = "MITextBox";
            MITextBox.Size = new Size(56, 40);
            MITextBox.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            MITextBox.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            MITextBox.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            MITextBox.StateCommon.Border.Rounding = 5F;
            MITextBox.TabIndex = 18;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(21, 40);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(57, 22);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 19;
            kryptonLabel2.Values.Text = "Name";
            // 
            // barangayComboBox
            // 
            barangayComboBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            barangayComboBox.CueHint.CueHintText = "Barangay";
            barangayComboBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barangayComboBox.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            barangayComboBox.DropDownWidth = 251;
            barangayComboBox.Items.AddRange(new object[] { "North Poblacion", "South Poblacion", "Dologon", "Anahawon", "Base Camp", "Colambugon", "Danggawan", "Panadtalan", "San Miguel", "Camp 1" });
            barangayComboBox.Location = new Point(23, 146);
            barangayComboBox.MinimumSize = new Size(255, 40);
            barangayComboBox.Name = "barangayComboBox";
            barangayComboBox.Size = new Size(255, 40);
            barangayComboBox.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.ComboBox.Border.Rounding = 5F;
            barangayComboBox.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(55, 71, 79);
            barangayComboBox.StateCommon.ComboBox.Content.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barangayComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            barangayComboBox.StateCommon.DropBack.Color1 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.DropBack.Color2 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.Item.Back.Color1 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.Item.Back.Color2 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.Item.Border.Color1 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.Item.Border.Color2 = Color.FromArgb(237, 237, 237);
            barangayComboBox.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            barangayComboBox.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            barangayComboBox.StateCommon.Item.Content.ShortText.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barangayComboBox.TabIndex = 20;
            // 
            // districtComboBox
            // 
            districtComboBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            districtComboBox.CueHint.CueHintText = "District";
            districtComboBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            districtComboBox.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            districtComboBox.DropDownWidth = 251;
            districtComboBox.Items.AddRange(new object[] { "Purok 2", "Purok 5", "Purok 10" });
            districtComboBox.Location = new Point(290, 146);
            districtComboBox.MinimumSize = new Size(255, 40);
            districtComboBox.Name = "districtComboBox";
            districtComboBox.Size = new Size(255, 40);
            districtComboBox.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.ComboBox.Border.Rounding = 5F;
            districtComboBox.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(55, 71, 79);
            districtComboBox.StateCommon.ComboBox.Content.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            districtComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            districtComboBox.StateCommon.DropBack.Color1 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.DropBack.Color2 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.Item.Back.Color1 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.Item.Back.Color2 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.Item.Border.Color1 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.Item.Border.Color2 = Color.FromArgb(237, 237, 237);
            districtComboBox.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            districtComboBox.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            districtComboBox.StateCommon.Item.Content.ShortText.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            districtComboBox.TabIndex = 21;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(21, 124);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(73, 22);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 22;
            kryptonLabel3.Values.Text = "Address";
            // 
            // planComboBox
            // 
            planComboBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            planComboBox.CueHint.CueHintText = "Internet Plan";
            planComboBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planComboBox.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            planComboBox.DropDownWidth = 251;
            planComboBox.Items.AddRange(new object[] { "Postpaid", "Prepaid" });
            planComboBox.Location = new Point(23, 234);
            planComboBox.MinimumSize = new Size(255, 40);
            planComboBox.Name = "planComboBox";
            planComboBox.Size = new Size(255, 40);
            planComboBox.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.ComboBox.Border.Rounding = 5F;
            planComboBox.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(55, 71, 79);
            planComboBox.StateCommon.ComboBox.Content.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            planComboBox.StateCommon.DropBack.Color1 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.DropBack.Color2 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.Item.Back.Color1 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.Item.Back.Color2 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.Item.Border.Color1 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.Item.Border.Color2 = Color.FromArgb(237, 237, 237);
            planComboBox.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            planComboBox.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            planComboBox.StateCommon.Item.Content.ShortText.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planComboBox.TabIndex = 23;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(22, 212);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(46, 22);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 24;
            kryptonLabel4.Values.Text = "Plan";
            // 
            // dueDatePicker
            // 
            dueDatePicker.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            dueDatePicker.Location = new Point(290, 234);
            dueDatePicker.MinimumSize = new Size(255, 40);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(255, 40);
            dueDatePicker.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            dueDatePicker.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            dueDatePicker.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            dueDatePicker.StateCommon.Border.Rounding = 5F;
            dueDatePicker.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            dueDatePicker.TabIndex = 25;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(287, 212);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(83, 22);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 26;
            kryptonLabel5.Values.Text = "Due Date";
            // 
            // monthlyChargeTextBox
            // 
            monthlyChargeTextBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            monthlyChargeTextBox.CueHint.CueHintText = "Charge Amount";
            monthlyChargeTextBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlyChargeTextBox.Location = new Point(21, 327);
            monthlyChargeTextBox.MinimumSize = new Size(194, 40);
            monthlyChargeTextBox.Name = "monthlyChargeTextBox";
            monthlyChargeTextBox.Size = new Size(257, 40);
            monthlyChargeTextBox.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            monthlyChargeTextBox.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            monthlyChargeTextBox.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            monthlyChargeTextBox.StateCommon.Border.Rounding = 5F;
            monthlyChargeTextBox.TabIndex = 27;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.CueHint.Color1 = Color.FromArgb(142, 138, 138);
            contactNumberTextBox.CueHint.CueHintText = "09XXXXXXXXX";
            contactNumberTextBox.CueHint.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactNumberTextBox.Location = new Point(290, 327);
            contactNumberTextBox.MinimumSize = new Size(194, 40);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(255, 40);
            contactNumberTextBox.StateCommon.Back.Color1 = Color.FromArgb(237, 237, 237);
            contactNumberTextBox.StateCommon.Border.Color1 = Color.FromArgb(237, 237, 237);
            contactNumberTextBox.StateCommon.Border.Color2 = Color.FromArgb(237, 237, 237);
            contactNumberTextBox.StateCommon.Border.Rounding = 5F;
            contactNumberTextBox.TabIndex = 28;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(20, 303);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(131, 22);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel6.TabIndex = 29;
            kryptonLabel6.Values.Text = "Monthly Charge";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(286, 303);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(136, 22);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 30;
            kryptonLabel7.Values.Text = "Contact Number";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(455, 387);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.OverrideFocus.Back.Color1 = Color.FromArgb(94, 167, 178);
            SaveBtn.OverrideFocus.Back.Color2 = Color.FromArgb(94, 167, 178);
            SaveBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            SaveBtn.Size = new Size(90, 37);
            SaveBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            SaveBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            SaveBtn.StateCommon.Border.Color1 = Color.FromArgb(52, 72, 100);
            SaveBtn.StateCommon.Border.Color2 = Color.FromArgb(52, 72, 100);
            SaveBtn.StateCommon.Border.Rounding = 20F;
            SaveBtn.StateCommon.Border.Width = 1;
            SaveBtn.StateCommon.Content.Padding = new Padding(0);
            SaveBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            SaveBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            SaveBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.StateTracking.Back.Color1 = Color.FromArgb(94, 167, 178);
            SaveBtn.StateTracking.Back.Color2 = Color.FromArgb(94, 167, 178);
            SaveBtn.StateTracking.Border.Color1 = Color.FromArgb(52, 72, 100);
            SaveBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            SaveBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            SaveBtn.TabIndex = 33;
            SaveBtn.Values.DropDownArrowColor = Color.Empty;
            SaveBtn.Values.Text = "Save";
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(355, 387);
            CancelBtn.Margin = new Padding(0);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.OverrideFocus.Back.Color1 = Color.FromArgb(239, 131, 131);
            CancelBtn.OverrideFocus.Back.Color2 = Color.FromArgb(239, 131, 131);
            CancelBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            CancelBtn.Size = new Size(90, 37);
            CancelBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            CancelBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            CancelBtn.StateCommon.Border.Color1 = Color.FromArgb(52, 72, 100);
            CancelBtn.StateCommon.Border.Color2 = Color.FromArgb(52, 72, 100);
            CancelBtn.StateCommon.Border.Rounding = 20F;
            CancelBtn.StateCommon.Border.Width = 1;
            CancelBtn.StateCommon.Content.Padding = new Padding(0);
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            CancelBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.StateTracking.Back.Color1 = Color.FromArgb(239, 131, 131);
            CancelBtn.StateTracking.Back.Color2 = Color.FromArgb(239, 131, 131);
            CancelBtn.StateTracking.Border.Color1 = Color.FromArgb(52, 72, 100);
            CancelBtn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CancelBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            CancelBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            CancelBtn.TabIndex = 32;
            CancelBtn.Values.DropDownArrowColor = Color.Empty;
            CancelBtn.Values.Text = "Cancel";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // addSubscribersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 250);
            ClientSize = new Size(572, 436);
            Controls.Add(SaveBtn);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(contactNumberTextBox);
            Controls.Add(monthlyChargeTextBox);
            Controls.Add(kryptonLabel5);
            Controls.Add(dueDatePicker);
            Controls.Add(kryptonLabel4);
            Controls.Add(planComboBox);
            Controls.Add(barangayComboBox);
            Controls.Add(kryptonLabel3);
            Controls.Add(districtComboBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(kryptonLabel2);
            Controls.Add(MITextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(kryptonLabel1);
            Controls.Add(CancelBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "addSubscribersForm";
            Padding = new Padding(3, 48, 3, 2);
            ShowIcon = false;
            StateCommon.Back.Color1 = Color.FromArgb(255, 254, 250);
            StateCommon.Back.Color2 = Color.FromArgb(255, 254, 250);
            StateCommon.Border.Color1 = Color.FromArgb(255, 254, 250);
            StateCommon.Border.Rounding = 20F;
            StateCommon.Header.Back.Color1 = Color.FromArgb(255, 254, 250);
            StateCommon.Header.Back.Color2 = Color.FromArgb(255, 254, 250);
            TransparencyKey = Color.FromArgb(241, 240, 233);
            Load += addSubscribersForm_Load;
            ((System.ComponentModel.ISupportInitialize)barangayComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)districtComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)planComboBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonButton SaveBtn;
        private Krypton.Toolkit.KryptonButton CancelBtn;
        public Krypton.Toolkit.KryptonTextBox lastNameTextBox;
        public Krypton.Toolkit.KryptonTextBox firstNameTextBox;
        public Krypton.Toolkit.KryptonTextBox MITextBox;
        public Krypton.Toolkit.KryptonComboBox barangayComboBox;
        public Krypton.Toolkit.KryptonComboBox districtComboBox;
        public Krypton.Toolkit.KryptonComboBox planComboBox;
        public Krypton.Toolkit.KryptonDateTimePicker dueDatePicker;
        public Krypton.Toolkit.KryptonTextBox contactNumberTextBox;
        public Krypton.Toolkit.KryptonTextBox monthlyChargeTextBox;
    }
}