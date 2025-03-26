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
            transactionsRepositoryBindingSource = new BindingSource(components);
            transactionsRepositoryBindingSource1 = new BindingSource(components);
            transactionsBindingSource = new BindingSource(components);
            transactionsRepositoryBindingSource2 = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            transExportBtn = new Krypton.Toolkit.KryptonPanel();
            transExportBttn = new Krypton.Toolkit.KryptonButton();
            transPrintBtn = new Krypton.Toolkit.KryptonButton();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            lblTotalAmount = new Krypton.Toolkit.KryptonLabel();
            btnPreviousPage = new Krypton.Toolkit.KryptonButton();
            btnNextPage = new Krypton.Toolkit.KryptonButton();
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
            flowLayoutPanel1.Location = new Point(82, 148);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1724, 781);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // transExportBtn
            // 
            transExportBtn.Controls.Add(transExportBttn);
            transExportBtn.Controls.Add(transPrintBtn);
            transExportBtn.Controls.Add(kryptonDateTimePicker1);
            transExportBtn.Controls.Add(lblTotalAmount);
            transExportBtn.Controls.Add(btnPreviousPage);
            transExportBtn.Controls.Add(btnNextPage);
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
            transExportBtn.Location = new Point(6, 14);
            transExportBtn.Name = "transExportBtn";
            transExportBtn.Size = new Size(1903, 982);
            transExportBtn.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            transExportBtn.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            transExportBtn.TabIndex = 3;
            // 
            // transExportBttn
            // 
            transExportBttn.Location = new Point(1491, 51);
            transExportBttn.Name = "transExportBttn";
            transExportBttn.Size = new Size(74, 25);
            transExportBttn.TabIndex = 18;
            transExportBttn.Values.DropDownArrowColor = Color.Empty;
            transExportBttn.Values.Text = "Export";
            transExportBttn.Click += transExportBttn_Click;
            // 
            // transPrintBtn
            // 
            transPrintBtn.Location = new Point(1576, 51);
            transPrintBtn.Name = "transPrintBtn";
            transPrintBtn.Size = new Size(78, 25);
            transPrintBtn.TabIndex = 17;
            transPrintBtn.Values.DropDownArrowColor = Color.Empty;
            transPrintBtn.Values.Text = "Print";
            transPrintBtn.Click += transPrintBtn_Click;
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new Point(1670, 53);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(136, 21);
            kryptonDateTimePicker1.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonDateTimePicker1.TabIndex = 16;
            kryptonDateTimePicker1.ValueChanged += kryptonDateTimePicker1_ValueChanged;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Location = new Point(430, 942);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(95, 20);
            lblTotalAmount.TabIndex = 14;
            lblTotalAmount.Values.Text = "lblTotalAmount";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(271, 941);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(90, 25);
            btnPreviousPage.TabIndex = 13;
            btnPreviousPage.Values.DropDownArrowColor = Color.Empty;
            btnPreviousPage.Values.Text = "kryptonButton1";
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(144, 935);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(90, 25);
            btnNextPage.TabIndex = 0;
            btnNextPage.Values.DropDownArrowColor = Color.Empty;
            btnNextPage.Values.Text = "NEXT";
            btnNextPage.Click += btnNextPage_Click;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(82, 36);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(211, 32);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel10.TabIndex = 12;
            kryptonLabel10.Values.Text = "TRANSACTIONS";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(1682, 95);
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
            kryptonLabel8.Location = new Point(1475, 95);
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
            kryptonLabel7.Location = new Point(1286, 95);
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
            kryptonLabel6.Location = new Point(1086, 95);
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
            kryptonLabel5.Location = new Point(913, 95);
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
            kryptonLabel4.Location = new Point(743, 95);
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
            kryptonLabel3.Location = new Point(533, 95);
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
            kryptonLabel2.Location = new Point(302, 95);
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
            kryptonLabel1.Location = new Point(150, 95);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(84, 19);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(157, 157, 157);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(157, 157, 157);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Receipt No.";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1906, 973);
            ControlBox = false;
            Controls.Add(transExportBtn);
            ForeColor = Color.White;
            FormStyle = FormStyles.StatusAndActionBar_None;
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
        private Krypton.Toolkit.KryptonButton btnPreviousPage;
        private Krypton.Toolkit.KryptonButton btnNextPage;
        private Krypton.Toolkit.KryptonButton btnLoadMore;
        private Krypton.Toolkit.KryptonLabel lblTotalAmount;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonButton transExportBttn;
        private Krypton.Toolkit.KryptonButton transPrintBtn;
    }
}