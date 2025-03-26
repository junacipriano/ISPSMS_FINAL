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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            accountsGridView = new DataGridView();
            accountidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountPasswordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            accountsBindingSource = new BindingSource(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            comboFilter = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)accountsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboFilter).BeginInit();
            SuspendLayout();
            // 
            // accountsGridView
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = Color.White;
            accountsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            accountsGridView.AutoGenerateColumns = false;
            accountsGridView.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            accountsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            accountsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsGridView.Columns.AddRange(new DataGridViewColumn[] { accountidDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountPasswordDataGridViewTextBoxColumn, accountRoleDataGridViewTextBoxColumn, Edit, Delete });
            accountsGridView.DataSource = accountsBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Info;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            accountsGridView.DefaultCellStyle = dataGridViewCellStyle10;
            accountsGridView.Dock = DockStyle.Fill;
            accountsGridView.Location = new Point(0, 71);
            accountsGridView.Margin = new Padding(3, 4, 3, 4);
            accountsGridView.Name = "accountsGridView";
            accountsGridView.RowHeadersWidth = 51;
            accountsGridView.Size = new Size(1241, 653);
            accountsGridView.TabIndex = 0;
            accountsGridView.CellContentClick += accountsGridView_CellContentClick_1;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            accountidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            dataGridViewCellStyle3.BackColor = SystemColors.Info;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            accountidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            accountidDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            accountidDataGridViewTextBoxColumn.Width = 109;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            dataGridViewCellStyle4.BackColor = SystemColors.Info;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 104;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            dataGridViewCellStyle5.BackColor = SystemColors.Info;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            accountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // accountPasswordDataGridViewTextBoxColumn
            // 
            accountPasswordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountPasswordDataGridViewTextBoxColumn.DataPropertyName = "AccountPassword";
            dataGridViewCellStyle6.BackColor = SystemColors.Info;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountPasswordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            accountPasswordDataGridViewTextBoxColumn.HeaderText = "AccountPassword";
            accountPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountPasswordDataGridViewTextBoxColumn.Name = "accountPasswordDataGridViewTextBoxColumn";
            accountPasswordDataGridViewTextBoxColumn.Width = 153;
            // 
            // accountRoleDataGridViewTextBoxColumn
            // 
            accountRoleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountRoleDataGridViewTextBoxColumn.DataPropertyName = "AccountRole";
            dataGridViewCellStyle7.BackColor = SystemColors.Info;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountRoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            accountRoleDataGridViewTextBoxColumn.HeaderText = "AccountRole";
            accountRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountRoleDataGridViewTextBoxColumn.Name = "accountRoleDataGridViewTextBoxColumn";
            accountRoleDataGridViewTextBoxColumn.Width = 122;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "account_id";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Info;
            dataGridViewCellStyle8.ForeColor = Color.White;
            Edit.DefaultCellStyle = dataGridViewCellStyle8;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 64;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "account_id";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Info;
            dataGridViewCellStyle9.ForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle9;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 59;
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Domain.Models.Accounts);
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(comboFilter);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1241, 71);
            kryptonPanel1.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(322, 19);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(59, 24);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Filter:";
            // 
            // comboFilter
            // 
            comboFilter.DropDownWidth = 152;
            comboFilter.Items.AddRange(new object[] { "ALL", "CEO", "ADMIN", "DEFAULT" });
            comboFilter.Location = new Point(403, 17);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(152, 26);
            comboFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboFilter.TabIndex = 3;
            comboFilter.Text = "ALL";
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(49, 12);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(115, 31);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Accounts";
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 724);
            Controls.Add(accountsGridView);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountsForm";
            Text = "AccountsForm";
            ((System.ComponentModel.ISupportInitialize)accountsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView accountsGridView;
        private BindingSource accountsBindingSource;
        private DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountPasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountRoleDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonComboBox comboFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}