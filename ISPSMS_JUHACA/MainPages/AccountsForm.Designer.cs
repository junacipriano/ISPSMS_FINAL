namespace ISPSMS_JUHACA.MainPages
{
    partial class AccountsForm
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
            accountsGridView = new DataGridView();
            accountsBindingSource = new BindingSource(components);
            accountidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountPasswordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)accountsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // accountsGridView
            // 
            accountsGridView.AutoGenerateColumns = false;
            accountsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsGridView.Columns.AddRange(new DataGridViewColumn[] { accountidDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountPasswordDataGridViewTextBoxColumn, accountRoleDataGridViewTextBoxColumn });
            accountsGridView.DataSource = accountsBindingSource;
            accountsGridView.Dock = DockStyle.Fill;
            accountsGridView.Location = new Point(0, 0);
            accountsGridView.Name = "accountsGridView";
            accountsGridView.Size = new Size(800, 450);
            accountsGridView.TabIndex = 0;
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Domain.Models.Accounts);
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // accountPasswordDataGridViewTextBoxColumn
            // 
            accountPasswordDataGridViewTextBoxColumn.DataPropertyName = "AccountPassword";
            accountPasswordDataGridViewTextBoxColumn.HeaderText = "AccountPassword";
            accountPasswordDataGridViewTextBoxColumn.Name = "accountPasswordDataGridViewTextBoxColumn";
            // 
            // accountRoleDataGridViewTextBoxColumn
            // 
            accountRoleDataGridViewTextBoxColumn.DataPropertyName = "AccountRole";
            accountRoleDataGridViewTextBoxColumn.HeaderText = "AccountRole";
            accountRoleDataGridViewTextBoxColumn.Name = "accountRoleDataGridViewTextBoxColumn";
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(accountsGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountsForm";
            Text = "AccountsForm";
            ((System.ComponentModel.ISupportInitialize)accountsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView accountsGridView;
        private DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountPasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountRoleDataGridViewTextBoxColumn;
        private BindingSource accountsBindingSource;
    }
}