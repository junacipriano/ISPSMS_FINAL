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
            dataGridView1 = new DataGridView();
            transactionsRepositoryBindingSource2 = new BindingSource(components);
            transactionsBindingSource = new BindingSource(components);
            transidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paidAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transidDataGridViewTextBoxColumn, subsidDataGridViewTextBoxColumn, transNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, paidAmountDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, transactionDateTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionsBindingSource;
            dataGridView1.Location = new Point(27, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(990, 150);
            dataGridView1.TabIndex = 0;
            // 
            // transactionsRepositoryBindingSource2
            // 
            transactionsRepositoryBindingSource2.DataSource = typeof(Infastructure.Data.Repositories.TransactionsRepository);
            // 
            // transactionsBindingSource
            // 
            transactionsBindingSource.DataSource = typeof(Domain.Models.Transactions);
            // 
            // transidDataGridViewTextBoxColumn
            // 
            transidDataGridViewTextBoxColumn.DataPropertyName = "trans_id";
            transidDataGridViewTextBoxColumn.HeaderText = "trans_id";
            transidDataGridViewTextBoxColumn.Name = "transidDataGridViewTextBoxColumn";
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "subs_id";
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            // 
            // transNameDataGridViewTextBoxColumn
            // 
            transNameDataGridViewTextBoxColumn.DataPropertyName = "Trans_Name";
            transNameDataGridViewTextBoxColumn.HeaderText = "Trans_Name";
            transNameDataGridViewTextBoxColumn.Name = "transNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // paidAmountDataGridViewTextBoxColumn
            // 
            paidAmountDataGridViewTextBoxColumn.DataPropertyName = "PaidAmount";
            paidAmountDataGridViewTextBoxColumn.HeaderText = "PaidAmount";
            paidAmountDataGridViewTextBoxColumn.Name = "paidAmountDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Note";
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // transactionDateTimeDataGridViewTextBoxColumn
            // 
            transactionDateTimeDataGridViewTextBoxColumn.DataPropertyName = "TransactionDateTime";
            transactionDateTimeDataGridViewTextBoxColumn.HeaderText = "TransactionDateTime";
            transactionDateTimeDataGridViewTextBoxColumn.Name = "transactionDateTimeDataGridViewTextBoxColumn";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 726);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Transactions";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsRepositoryBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource transactionsRepositoryBindingSource1;
        private BindingSource transactionsRepositoryBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn transidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateTimeDataGridViewTextBoxColumn;
        private BindingSource transactionsBindingSource;
        private BindingSource transactionsRepositoryBindingSource2;
    }
}