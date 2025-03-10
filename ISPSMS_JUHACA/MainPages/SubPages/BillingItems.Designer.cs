namespace ISPSMS_JUHACA.MainPages.SubPages
{
    partial class BillingItems
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            subIDTextBox = new Krypton.Toolkit.KryptonTextBox();
            nameTextBox = new Krypton.Toolkit.KryptonTextBox();
            statusTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            dueDateTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox6 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox8 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox9 = new Krypton.Toolkit.KryptonTextBox();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonTextBox11 = new Krypton.Toolkit.KryptonTextBox();
            addressTextBox = new Krypton.Toolkit.KryptonTextBox();
            amountTextBox = new Krypton.Toolkit.KryptonTextBox();
            payBtn = new Krypton.Toolkit.KryptonButton();
            planTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // subIDTextBox
            // 
            subIDTextBox.CausesValidation = false;
            subIDTextBox.CharacterCasing = CharacterCasing.Upper;
            subIDTextBox.Location = new Point(43, 59);
            subIDTextBox.MaximumSize = new Size(60, 60);
            subIDTextBox.MinimumSize = new Size(60, 55);
            subIDTextBox.Name = "subIDTextBox";
            subIDTextBox.ReadOnly = true;
            subIDTextBox.Size = new Size(60, 55);
            subIDTextBox.StateCommon.Back.Color1 = Color.FromArgb(196, 159, 86);
            subIDTextBox.StateCommon.Border.Color1 = Color.FromArgb(196, 159, 86);
            subIDTextBox.StateCommon.Border.Color2 = Color.FromArgb(196, 159, 86);
            subIDTextBox.StateCommon.Border.Rounding = 6F;
            subIDTextBox.StateCommon.Content.Color1 = Color.FromArgb(255, 255, 252);
            subIDTextBox.StateCommon.Content.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subIDTextBox.TabIndex = 1;
            subIDTextBox.Text = "M2";
            subIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(109, 64);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(211, 37);
            nameTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            nameTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            nameTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            nameTextBox.StateCommon.Content.Color1 = Color.FromArgb(52, 72, 100);
            nameTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.TabIndex = 2;
            nameTextBox.Text = "Name N. Ame";
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(110, 91);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(151, 27);
            statusTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            statusTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            statusTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            statusTextBox.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            statusTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Book", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusTextBox.TabIndex = 3;
            statusTextBox.Text = "Status: ";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(46, 157);
            kryptonBorderEdge1.MinimumSize = new Size(318, 2);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(318, 2);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(166, 166, 166);
            kryptonBorderEdge1.StateCommon.Color2 = Color.FromArgb(166, 166, 166);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.Location = new Point(43, 125);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.Size = new Size(89, 24);
            kryptonTextBox4.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox4.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox4.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox4.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox4.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox4.TabIndex = 5;
            kryptonTextBox4.Text = "Due date: ";
            // 
            // dueDateTextBox
            // 
            dueDateTextBox.Location = new Point(192, 125);
            dueDateTextBox.Name = "dueDateTextBox";
            dueDateTextBox.Size = new Size(169, 24);
            dueDateTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            dueDateTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            dueDateTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            dueDateTextBox.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            dueDateTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDateTextBox.TabIndex = 6;
            dueDateTextBox.Text = "March 7, 2025";
            dueDateTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // kryptonTextBox6
            // 
            kryptonTextBox6.Location = new Point(45, 171);
            kryptonTextBox6.Name = "kryptonTextBox6";
            kryptonTextBox6.Size = new Size(89, 24);
            kryptonTextBox6.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox6.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox6.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox6.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox6.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 9.75F);
            kryptonTextBox6.TabIndex = 7;
            kryptonTextBox6.Text = "Received from:";
            // 
            // kryptonTextBox8
            // 
            kryptonTextBox8.Location = new Point(45, 212);
            kryptonTextBox8.Name = "kryptonTextBox8";
            kryptonTextBox8.Size = new Size(89, 24);
            kryptonTextBox8.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox8.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox8.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox8.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox8.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 9.75F);
            kryptonTextBox8.TabIndex = 9;
            kryptonTextBox8.Text = "Address:";
            // 
            // kryptonTextBox9
            // 
            kryptonTextBox9.Location = new Point(43, 296);
            kryptonTextBox9.Name = "kryptonTextBox9";
            kryptonTextBox9.Size = new Size(89, 24);
            kryptonTextBox9.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox9.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox9.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox9.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox9.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox9.TabIndex = 10;
            kryptonTextBox9.Text = "Amount:";
            // 
            // kryptonBorderEdge2
            // 
            kryptonBorderEdge2.Location = new Point(46, 290);
            kryptonBorderEdge2.MinimumSize = new Size(318, 2);
            kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            kryptonBorderEdge2.Size = new Size(318, 2);
            kryptonBorderEdge2.StateCommon.Color1 = Color.FromArgb(166, 166, 166);
            kryptonBorderEdge2.StateCommon.Color2 = Color.FromArgb(166, 166, 166);
            kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // kryptonTextBox11
            // 
            kryptonTextBox11.Location = new Point(230, 171);
            kryptonTextBox11.Name = "kryptonTextBox11";
            kryptonTextBox11.Size = new Size(133, 24);
            kryptonTextBox11.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox11.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox11.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox11.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox11.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F);
            kryptonTextBox11.TabIndex = 14;
            kryptonTextBox11.Text = "P & C Internet Shop";
            kryptonTextBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(164, 212);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(199, 24);
            addressTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            addressTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            addressTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            addressTextBox.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            addressTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F);
            addressTextBox.TabIndex = 15;
            addressTextBox.Text = "Purok 2, Anahawon";
            addressTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(43, 316);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(113, 28);
            amountTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            amountTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            amountTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            amountTextBox.StateCommon.Content.Color1 = Color.FromArgb(160, 122, 4);
            amountTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTextBox.TabIndex = 16;
            amountTextBox.Text = "₱2000.00";
            // 
            // payBtn
            // 
            payBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payBtn.Location = new Point(270, 307);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(91, 37);
            payBtn.StateCommon.Back.Color1 = Color.FromArgb(94, 167, 178);
            payBtn.StateCommon.Back.Color2 = Color.FromArgb(94, 167, 178);
            payBtn.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            payBtn.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            payBtn.StateCommon.Border.Rounding = 10F;
            payBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            payBtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            payBtn.StateCommon.Content.ShortText.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            payBtn.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            payBtn.StatePressed.Back.Color1 = Color.FromArgb(82, 147, 157);
            payBtn.StatePressed.Back.Color2 = Color.FromArgb(82, 147, 157);
            payBtn.StatePressed.Border.Color1 = Color.FromArgb(82, 147, 157);
            payBtn.StatePressed.Border.Color2 = Color.FromArgb(82, 147, 157);
            payBtn.StatePressed.Border.Rounding = 10F;
            payBtn.TabIndex = 17;
            payBtn.Values.DropDownArrowColor = Color.Empty;
            payBtn.Values.Text = "Pay";
            payBtn.Click += payBtn_Click;
            // 
            // planTextBox
            // 
            planTextBox.Location = new Point(230, 252);
            planTextBox.Name = "planTextBox";
            planTextBox.Size = new Size(133, 24);
            planTextBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            planTextBox.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            planTextBox.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            planTextBox.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            planTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F);
            planTextBox.TabIndex = 19;
            planTextBox.Text = "Prepaid";
            planTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(45, 252);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(89, 24);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox2.StateCommon.Content.Color1 = Color.FromArgb(48, 48, 48);
            kryptonTextBox2.StateCommon.Content.Font = new Font("Franklin Gothic Demi", 9.75F);
            kryptonTextBox2.TabIndex = 18;
            kryptonTextBox2.Text = "Plan:";
            kryptonTextBox2.TextChanged += kryptonTextBox2_TextChanged;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(16, 27);
            kryptonTextBox1.MaximumSize = new Size(379, 354);
            kryptonTextBox1.MinimumSize = new Size(379, 354);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(379, 354);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.TabIndex = 22;
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // BillingItems
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(413, 409);
            ControlBox = false;
            Controls.Add(planTextBox);
            Controls.Add(kryptonTextBox2);
            Controls.Add(payBtn);
            Controls.Add(amountTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(kryptonTextBox11);
            Controls.Add(kryptonBorderEdge2);
            Controls.Add(kryptonTextBox9);
            Controls.Add(kryptonTextBox8);
            Controls.Add(kryptonTextBox6);
            Controls.Add(dueDateTextBox);
            Controls.Add(kryptonTextBox4);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(statusTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(subIDTextBox);
            Controls.Add(kryptonTextBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 255, 252);
            FormBorderStyle = FormBorderStyle.None;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximumSize = new Size(427, 423);
            MinimumSize = new Size(427, 423);
            Name = "BillingItems";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.Manual;
            StateActive.Border.Rounding = 20F;
            StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Back.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Back.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Border.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Border.Color2 = Color.FromArgb(241, 240, 233);
            TransparencyKey = Color.FromArgb(241, 240, 233);
            Load += BillingItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Krypton.Toolkit.KryptonTextBox statusTextBox;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox6;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox9;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private Krypton.Toolkit.KryptonButton payBtn;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        public Krypton.Toolkit.KryptonTextBox dueDateTextBox;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox11;
        public Krypton.Toolkit.KryptonTextBox addressTextBox;
        public Krypton.Toolkit.KryptonTextBox amountTextBox;
        public Krypton.Toolkit.KryptonTextBox planTextBox;
        public Krypton.Toolkit.KryptonTextBox subIDTextBox;
        public Krypton.Toolkit.KryptonTextBox nameTextBox;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}