namespace ISPSMS_JUHACA.MainPages
{
    partial class Transaction
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            transactionsRepositoryBindingSource = new BindingSource(components);
            transactionsRepositoryBindingSource1 = new BindingSource(components);
            transactionsBindingSource = new BindingSource(components);
            transactionsRepositoryBindingSource2 = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            transExportBtn = new Krypton.Toolkit.KryptonPanel();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            TotalTransactionDay = new Krypton.Toolkit.KryptonTextBox();
            lblTotalAmount = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            Time = new Krypton.Toolkit.KryptonTextBox();
            Date = new Krypton.Toolkit.KryptonTextBox();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            paginationStatusTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            btnNextPage = new Krypton.Toolkit.KryptonButton();
            btnPreviousPage = new Krypton.Toolkit.KryptonButton();
            transPrintBtn = new Krypton.Toolkit.KryptonButton();
            transExportBttn = new Krypton.Toolkit.KryptonButton();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transExportBtn).BeginInit();
            transExportBtn.SuspendLayout();
            SuspendLayout();
            // 
            // transactionsRepositoryBindingSource
            // 
            transactionsRepositoryBindingSource.DataSource = typeof(Infastructure.Data.Repositories.TransactionsRepository);
            // 
            // transactionsRepositoryBindingSource1
            // 
            transactionsRepositoryBindingSource1.DataSource = typeof(Infastructure.Data.Repositories.TransactionsRepository);
            // 
            // transactionsBindingSource
            // 
            transactionsBindingSource.DataSource = typeof(Domain.Models.Transactions);
            // 
            // transactionsRepositoryBindingSource2
            // 
            transactionsRepositoryBindingSource2.DataSource = typeof(Infastructure.Data.Repositories.TransactionsRepository);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(241, 240, 233);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(83, 143);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1755, 628);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // transExportBtn
            // 
            transExportBtn.Controls.Add(kryptonTextBox4);
            transExportBtn.Controls.Add(TotalTransactionDay);
            transExportBtn.Controls.Add(lblTotalAmount);
            transExportBtn.Controls.Add(kryptonTextBox3);
            transExportBtn.Controls.Add(Time);
            transExportBtn.Controls.Add(Date);
            transExportBtn.Controls.Add(kryptonBorderEdge2);
            transExportBtn.Controls.Add(paginationStatusTextBox);
            transExportBtn.Controls.Add(kryptonTextBox2);
            transExportBtn.Controls.Add(btnNextPage);
            transExportBtn.Controls.Add(btnPreviousPage);
            transExportBtn.Controls.Add(transPrintBtn);
            transExportBtn.Controls.Add(transExportBttn);
            transExportBtn.Controls.Add(kryptonBorderEdge1);
            transExportBtn.Controls.Add(kryptonDateTimePicker1);
            transExportBtn.Controls.Add(kryptonLabel10);
            transExportBtn.Controls.Add(kryptonLabel9);
            transExportBtn.Controls.Add(kryptonLabel8);
            transExportBtn.Controls.Add(kryptonLabel7);
            transExportBtn.Controls.Add(kryptonLabel6);
            transExportBtn.Controls.Add(kryptonLabel5);
            transExportBtn.Controls.Add(kryptonLabel4);
            transExportBtn.Controls.Add(kryptonLabel3);
            transExportBtn.Controls.Add(kryptonLabel2);
            transExportBtn.Controls.Add(kryptonLabel1);
            transExportBtn.Controls.Add(flowLayoutPanel1);
            transExportBtn.Controls.Add(kryptonTextBox1);
            transExportBtn.Location = new Point(-1, 3);
            transExportBtn.MaximumSize = new Size(1906, 973);
            transExportBtn.MinimumSize = new Size(1920, 990);
            transExportBtn.Name = "transExportBtn";
            transExportBtn.Size = new Size(1920, 990);
            transExportBtn.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            transExportBtn.TabIndex = 3;
            transExportBtn.Paint += transExportBtn_Paint;
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.Location = new Point(376, 903);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.Size = new Size(189, 32);
            kryptonTextBox4.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox4.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox4.StateCommon.Content.Color1 = Color.FromArgb(115, 115, 115);
            kryptonTextBox4.StateCommon.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox4.StateNormal.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox4.TabIndex = 81;
            kryptonTextBox4.Text = "Transactions";
            // 
            // TotalTransactionDay
            // 
            TotalTransactionDay.Location = new Point(377, 872);
            TotalTransactionDay.Name = "TotalTransactionDay";
            TotalTransactionDay.Size = new Size(241, 32);
            TotalTransactionDay.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            TotalTransactionDay.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            TotalTransactionDay.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            TotalTransactionDay.StateCommon.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTransactionDay.StateNormal.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTransactionDay.TabIndex = 80;
            TotalTransactionDay.Text = "9999";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Location = new Point(1505, 891);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(266, 32);
            lblTotalAmount.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            lblTotalAmount.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            lblTotalAmount.StateCommon.Content.Color1 = Color.FromArgb(115, 115, 115);
            lblTotalAmount.StateCommon.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.StateNormal.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.TabIndex = 79;
            lblTotalAmount.Text = "9999.00";
            lblTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new Point(1530, 854);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(241, 32);
            kryptonTextBox3.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox3.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox3.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            kryptonTextBox3.StateCommon.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox3.StateNormal.Content.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox3.TabIndex = 78;
            kryptonTextBox3.Text = "Total Amount";
            kryptonTextBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // Time
            // 
            Time.Location = new Point(114, 892);
            Time.Name = "Time";
            Time.Size = new Size(149, 36);
            Time.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            Time.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            Time.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            Time.StateCommon.Content.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.TabIndex = 77;
            Time.Text = "12:59 PM";
            // 
            // Date
            // 
            Date.Location = new Point(114, 847);
            Date.Name = "Date";
            Date.Size = new Size(232, 36);
            Date.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            Date.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            Date.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            Date.StateCommon.Content.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.TabIndex = 76;
            Date.Text = "December 30, 2025";
            // 
            // kryptonBorderEdge2
            // 
            kryptonBorderEdge2.Location = new Point(355, 834);
            kryptonBorderEdge2.MinimumSize = new Size(2, 105);
            kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            kryptonBorderEdge2.Orientation = Orientation.Vertical;
            kryptonBorderEdge2.Size = new Size(2, 105);
            kryptonBorderEdge2.StateCommon.Color1 = Color.FromArgb(182, 182, 182);
            kryptonBorderEdge2.StateCommon.Width = 2;
            kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // paginationStatusTextBox
            // 
            paginationStatusTextBox.Enabled = false;
            paginationStatusTextBox.Location = new Point(1610, 785);
            paginationStatusTextBox.Name = "paginationStatusTextBox";
            paginationStatusTextBox.ReadOnly = true;
            paginationStatusTextBox.Size = new Size(113, 27);
            paginationStatusTextBox.StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            paginationStatusTextBox.StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            paginationStatusTextBox.StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            paginationStatusTextBox.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            paginationStatusTextBox.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 11.25F);
            paginationStatusTextBox.TabIndex = 66;
            paginationStatusTextBox.Text = "1 -10 of 999";
            paginationStatusTextBox.Click += btnPreviousPage_Click;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Enabled = false;
            kryptonTextBox2.Location = new Point(1447, 785);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.ReadOnly = true;
            kryptonTextBox2.Size = new Size(135, 27);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            kryptonTextBox2.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            kryptonTextBox2.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 11.25F);
            kryptonTextBox2.TabIndex = 65;
            kryptonTextBox2.Text = "Items per page: 20";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(1780, 786);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.OverrideDefault.Back.Color1 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideDefault.Back.Color2 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideDefault.Border.Color1 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideFocus.Back.Color1 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideFocus.Back.Color2 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideFocus.Border.Color1 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideFocus.Border.Color2 = Color.FromArgb(255, 255, 252);
            btnNextPage.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            btnNextPage.Size = new Size(25, 25);
            btnNextPage.StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            btnNextPage.StateCommon.Back.Color2 = Color.FromArgb(241, 240, 233);
            btnNextPage.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            btnNextPage.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnNextPage.StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            btnNextPage.StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            btnNextPage.StateDisabled.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Disabled;
            btnNextPage.TabIndex = 64;
            btnNextPage.TabStop = false;
            btnNextPage.ToolTipValues.ImageTransparentColor = Color.FromArgb(255, 255, 252);
            btnNextPage.Values.DropDownArrowColor = Color.Empty;
            btnNextPage.Values.ImageStates.ImageCheckedNormal = null;
            btnNextPage.Values.ImageStates.ImageCheckedPressed = null;
            btnNextPage.Values.ImageStates.ImageCheckedTracking = null;
            btnNextPage.Values.ImageStates.ImageDisabled = Properties.NewResources.angle_right;
            btnNextPage.Values.ImageStates.ImageNormal = Properties.NewResources.angle_right;
            btnNextPage.Values.ImageStates.ImagePressed = Properties.NewResources.angle_right__3_1;
            btnNextPage.Values.ImageStates.ImageTracking = Properties.NewResources.angle_right__3_;
            btnNextPage.Values.Text = "";
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(1718, 786);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(25, 25);
            btnPreviousPage.StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            btnPreviousPage.StateCommon.Back.Color2 = Color.FromArgb(241, 240, 233);
            btnPreviousPage.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnPreviousPage.StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            btnPreviousPage.StateCommon.Border.Color2 = Color.FromArgb(241, 240, 233);
            btnPreviousPage.StateDisabled.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Disabled;
            btnPreviousPage.TabIndex = 63;
            btnPreviousPage.TabStop = false;
            btnPreviousPage.ToolTipValues.ImageTransparentColor = Color.FromArgb(255, 255, 252);
            btnPreviousPage.Values.DropDownArrowColor = Color.Empty;
            btnPreviousPage.Values.ImageStates.ImageCheckedNormal = null;
            btnPreviousPage.Values.ImageStates.ImageCheckedPressed = null;
            btnPreviousPage.Values.ImageStates.ImageCheckedTracking = null;
            btnPreviousPage.Values.ImageStates.ImageDisabled = Properties.NewResources.angle_left;
            btnPreviousPage.Values.ImageStates.ImageNormal = Properties.NewResources.angle_left;
            btnPreviousPage.Values.ImageStates.ImagePressed = Properties.NewResources.angle_left__1_;
            btnPreviousPage.Values.ImageStates.ImageTracking = Properties.NewResources.angle_left__1_;
            btnPreviousPage.Values.Text = "";
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // transPrintBtn
            // 
            transPrintBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            transPrintBtn.Location = new Point(1498, 37);
            transPrintBtn.Margin = new Padding(5);
            transPrintBtn.Name = "transPrintBtn";
            transPrintBtn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 255, 252);
            transPrintBtn.OverrideDefault.Border.Color1 = Color.FromArgb(205, 205, 205);
            transPrintBtn.OverrideDefault.Border.Rounding = 5F;
            transPrintBtn.OverrideFocus.Back.Color1 = Color.FromArgb(94, 167, 178);
            transPrintBtn.OverrideFocus.Back.Color2 = Color.FromArgb(94, 167, 178);
            transPrintBtn.OverrideFocus.Border.Color1 = Color.FromArgb(205, 205, 205);
            transPrintBtn.OverrideFocus.Border.Rounding = 5F;
            transPrintBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            transPrintBtn.OverrideFocus.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transPrintBtn.Size = new Size(93, 40);
            transPrintBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            transPrintBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            transPrintBtn.StateCommon.Border.Color1 = Color.FromArgb(205, 205, 205);
            transPrintBtn.StateCommon.Border.Color2 = Color.FromArgb(205, 205, 205);
            transPrintBtn.StateCommon.Border.Rounding = 5F;
            transPrintBtn.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.True;
            transPrintBtn.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.True;
            transPrintBtn.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            transPrintBtn.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            transPrintBtn.StateCommon.Content.LongText.Image = (Image)resources.GetObject("transPrintBtn.StateCommon.Content.LongText.Image");
            transPrintBtn.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            transPrintBtn.StateCommon.Content.Padding = new Padding(8, -1, -1, -1);
            transPrintBtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            transPrintBtn.StateCommon.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transPrintBtn.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            transPrintBtn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            transPrintBtn.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            transPrintBtn.StateTracking.Back.Color1 = Color.FromArgb(94, 167, 178);
            transPrintBtn.StateTracking.Back.Color2 = Color.FromArgb(94, 167, 178);
            transPrintBtn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.StateTracking.Content.ShortText.Color2 = Color.FromArgb(94, 167, 178);
            transPrintBtn.TabIndex = 61;
            transPrintBtn.TabStop = false;
            transPrintBtn.ToolTipValues.Description = "";
            transPrintBtn.Values.DropDownArrowColor = Color.Empty;
            transPrintBtn.Values.Image = (Image)resources.GetObject("transPrintBtn.Values.Image");
            transPrintBtn.Values.ImageStates.ImageCheckedNormal = null;
            transPrintBtn.Values.ImageStates.ImageCheckedPressed = null;
            transPrintBtn.Values.ImageStates.ImageCheckedTracking = null;
            transPrintBtn.Values.ImageStates.ImageNormal = Properties.NewResources.print__1_;
            transPrintBtn.Values.ImageStates.ImagePressed = Properties.NewResources.print1;
            transPrintBtn.Values.ImageStates.ImageTracking = Properties.NewResources.print1;
            transPrintBtn.Values.Text = "Print";
            transPrintBtn.Values.UseAsADialogButton = true;
            transPrintBtn.Values.UseAsUACElevationButton = true;
            transPrintBtn.Click += transPrintBtn_Click;
            // 
            // transExportBttn
            // 
            transExportBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            transExportBttn.Location = new Point(1392, 37);
            transExportBttn.Margin = new Padding(5);
            transExportBttn.Name = "transExportBttn";
            transExportBttn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 255, 252);
            transExportBttn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 255, 252);
            transExportBttn.OverrideDefault.Border.Color1 = Color.FromArgb(205, 205, 205);
            transExportBttn.OverrideFocus.Back.Color1 = Color.FromArgb(94, 167, 178);
            transExportBttn.OverrideFocus.Back.Color2 = Color.FromArgb(94, 167, 178);
            transExportBttn.OverrideFocus.Border.Color1 = Color.FromArgb(205, 205, 205);
            transExportBttn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            transExportBttn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(255, 255, 252);
            transExportBttn.OverrideFocus.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transExportBttn.Size = new Size(93, 40);
            transExportBttn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            transExportBttn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            transExportBttn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            transExportBttn.StateCommon.Border.Color1 = Color.FromArgb(205, 205, 205);
            transExportBttn.StateCommon.Border.Color2 = Color.FromArgb(205, 205, 205);
            transExportBttn.StateCommon.Border.Rounding = 5F;
            transExportBttn.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.True;
            transExportBttn.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.True;
            transExportBttn.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            transExportBttn.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            transExportBttn.StateCommon.Content.LongText.Image = (Image)resources.GetObject("transExportBttn.StateCommon.Content.LongText.Image");
            transExportBttn.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            transExportBttn.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            transExportBttn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            transExportBttn.StateCommon.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transExportBttn.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            transExportBttn.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            transExportBttn.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            transExportBttn.StateTracking.Back.Color1 = Color.FromArgb(94, 167, 178);
            transExportBttn.StateTracking.Back.Color2 = Color.FromArgb(94, 167, 178);
            transExportBttn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(255, 255, 252);
            transExportBttn.TabIndex = 60;
            transExportBttn.TabStop = false;
            transExportBttn.ToolTipValues.Description = "";
            transExportBttn.Values.DropDownArrowColor = Color.Empty;
            transExportBttn.Values.Image = (Image)resources.GetObject("transExportBttn.Values.Image");
            transExportBttn.Values.ImageStates.ImageCheckedNormal = null;
            transExportBttn.Values.ImageStates.ImageCheckedPressed = null;
            transExportBttn.Values.ImageStates.ImageCheckedTracking = null;
            transExportBttn.Values.ImageStates.ImageNormal = Properties.NewResources.upload;
            transExportBttn.Values.ImageStates.ImagePressed = Properties.NewResources.upload__1_;
            transExportBttn.Values.ImageStates.ImageTracking = Properties.NewResources.upload__1_;
            transExportBttn.Values.Text = "Export ";
            transExportBttn.Values.UseAsADialogButton = true;
            transExportBttn.Values.UseAsUACElevationButton = true;
            transExportBttn.Click += transExportBttn_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(94, 91);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1704, 1);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(182, 182, 182);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.AlwaysActive = false;
            kryptonDateTimePicker1.CalendarDayOfWeekStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            kryptonDateTimePicker1.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            kryptonDateTimePicker1.CalendarHeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary;
            kryptonDateTimePicker1.CalendarTodayFormat = "D";
            kryptonDateTimePicker1.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            kryptonDateTimePicker1.Location = new Point(1600, 37);
            kryptonDateTimePicker1.MinimumSize = new Size(136, 40);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(197, 40);
            kryptonDateTimePicker1.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonDateTimePicker1.StateCommon.Border.Color1 = Color.FromArgb(182, 182, 182);
            kryptonDateTimePicker1.StateCommon.Border.Rounding = 20F;
            kryptonDateTimePicker1.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonDateTimePicker1.StateCommon.Content.Padding = new Padding(5, -1, -1, -1);
            kryptonDateTimePicker1.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonDateTimePicker1.TabIndex = 16;
            kryptonDateTimePicker1.TabStop = false;
            kryptonDateTimePicker1.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            kryptonDateTimePicker1.ValueNullable = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            kryptonDateTimePicker1.ValueChanged += kryptonDateTimePicker1_ValueChanged;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(85, 45);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(193, 38);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel10.TabIndex = 12;
            kryptonLabel10.Values.Text = "Transactions";
            kryptonLabel10.Click += kryptonLabel10_Click;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(1567, 104);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(42, 19);
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel9.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 11;
            kryptonLabel9.Values.Text = "Time";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(1320, 104);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(119, 19);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel8.TabIndex = 10;
            kryptonLabel8.Values.Text = "Transaction Date";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(1150, 104);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(69, 19);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel7.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 9;
            kryptonLabel7.Values.Text = "Due Date";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(1010, 104);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(41, 19);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel6.TabIndex = 8;
            kryptonLabel6.Values.Text = "Note";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(848, 104);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(62, 19);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Balance";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(694, 104);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(61, 19);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 6;
            kryptonLabel4.Values.Text = "Amount";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(467, 104);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(47, 19);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 5;
            kryptonLabel3.Values.Text = "Name";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(253, 104);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(96, 19);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Subscriber Id";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(128, 104);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(84, 19);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Receipt No.";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(83, 826);
            kryptonTextBox1.MaximumSize = new Size(1724, 100);
            kryptonTextBox1.MinimumSize = new Size(1719, 120);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(1719, 120);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Rounding = 15F;
            kryptonTextBox1.TabIndex = 19;
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1918, 990);
            ControlBox = false;
            Controls.Add(transExportBtn);
            ForeColor = Color.White;
            FormStyle = FormStyles.StatusAndActionBar_None;
            MaximumSize = new Size(1918, 990);
            MinimumSize = new Size(1918, 990);
            Name = "Transaction";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Transactions";
            TransparencyKey = Color.White;
            Load += Transaction_Load;
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)transExportBtn).EndInit();
            transExportBtn.ResumeLayout(false);
            transExportBtn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource transactionsRepositoryBindingSource1;
        private BindingSource transactionsRepositoryBindingSource;
        private BindingSource transactionsBindingSource;
        private BindingSource transactionsRepositoryBindingSource2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel transExportBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonButton btnNextPage;
        private Krypton.Toolkit.KryptonButton btnLoadMore;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton transPrintBtn;
        private Krypton.Toolkit.KryptonButton transExportBttn;
        private Krypton.Toolkit.KryptonTextBox paginationStatusTextBox;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonButton btnPreviousPage;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private Krypton.Toolkit.KryptonTextBox Time;
        private Krypton.Toolkit.KryptonTextBox Date;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox TotalTransactionDay;
        private Krypton.Toolkit.KryptonTextBox lblTotalAmount;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
    }
}