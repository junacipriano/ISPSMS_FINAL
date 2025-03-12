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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
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
            flowLayoutPanel1.Location = new Point(163, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1688, 920);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Location = new Point(18, 38);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1891, 958);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.TabIndex = 3;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1906, 973);
            ControlBox = false;
            Controls.Add(kryptonPanel1);
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
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource transactionsRepositoryBindingSource1;
        private BindingSource transactionsRepositoryBindingSource;
        private BindingSource transactionsBindingSource;
        private BindingSource transactionsRepositoryBindingSource2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}