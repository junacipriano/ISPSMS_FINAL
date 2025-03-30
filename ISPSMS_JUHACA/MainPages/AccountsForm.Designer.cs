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
            accountsBindingSource = new BindingSource(components);
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            comboFilter = new Krypton.Toolkit.KryptonComboBox();
            accountsGridView = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn5 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            editButton = new DataGridViewImageColumn();
            deleteButton = new DataGridViewImageColumn();
            bgPanel = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsGridView).BeginInit();
            SuspendLayout();
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Domain.Models.Accounts);
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(137, 86);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1704, 1);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(182, 182, 182);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(128, 40);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(142, 36);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel10.TabIndex = 14;
            kryptonLabel10.Values.Text = "Accounts";
            // 
            // comboFilter
            // 
            comboFilter.AlwaysActive = false;
            comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilter.DropDownWidth = 96;
            comboFilter.Items.AddRange(new object[] { "ALL", "CEO", "ADMIN", "DEFAULT" });
            comboFilter.Location = new Point(1691, 36);
            comboFilter.MaximumSize = new Size(150, 60);
            comboFilter.MinimumSize = new Size(100, 40);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(150, 40);
            comboFilter.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(255, 255, 252);
            comboFilter.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(205, 205, 205);
            comboFilter.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(205, 205, 205);
            comboFilter.StateCommon.ComboBox.Border.Rounding = 20F;
            comboFilter.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(52, 72, 100);
            comboFilter.StateCommon.ComboBox.Content.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboFilter.StateCommon.DropBack.Color1 = Color.FromArgb(255, 255, 252);
            comboFilter.StateCommon.DropBack.Color2 = Color.FromArgb(255, 255, 252);
            comboFilter.StateCommon.Item.Border.Rounding = 20F;
            comboFilter.StateCommon.Item.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            comboFilter.TabIndex = 63;
            comboFilter.TabStop = false;
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged;
            // 
            // accountsGridView
            // 
            accountsGridView.AllowUserToAddRows = false;
            accountsGridView.AllowUserToResizeColumns = false;
            accountsGridView.AllowUserToResizeRows = false;
            accountsGridView.AutoGenerateColumns = false;
            accountsGridView.BorderStyle = BorderStyle.None;
            accountsGridView.ColumnHeadersHeight = 30;
            accountsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            accountsGridView.Columns.AddRange(new DataGridViewColumn[] { kryptonDataGridViewTextBoxColumn1, kryptonDataGridViewTextBoxColumn2, kryptonDataGridViewTextBoxColumn3, kryptonDataGridViewTextBoxColumn4, kryptonDataGridViewTextBoxColumn5, editButton, deleteButton });
            accountsGridView.DataSource = accountsBindingSource;
            accountsGridView.Location = new Point(167, 123);
            accountsGridView.Name = "accountsGridView";
            accountsGridView.ReadOnly = true;
            accountsGridView.RowHeadersVisible = false;
            accountsGridView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Helvetica Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(234, 98, 38);
            accountsGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            accountsGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            accountsGridView.RowTemplate.Height = 40;
            accountsGridView.RowTemplate.ReadOnly = true;
            accountsGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            accountsGridView.ScrollBars = ScrollBars.Vertical;
            accountsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountsGridView.Size = new Size(1645, 735);
            accountsGridView.StateCommon.Background.Color1 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            accountsGridView.StateCommon.DataCell.Back.Color1 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.DataCell.Back.Color2 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.DataCell.Border.Color1 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.DataCell.Border.Color2 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(255, 255, 252);
            accountsGridView.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(166, 166, 166);
            accountsGridView.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(166, 166, 166);
            accountsGridView.StateCommon.HeaderColumn.Content.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountsGridView.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            accountsGridView.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            accountsGridView.StateCommon.HeaderRow.Border.Rounding = 20F;
            accountsGridView.StateCommon.HeaderRow.Content.Color1 = Color.FromArgb(52, 72, 100);
            accountsGridView.StateCommon.HeaderRow.Content.Color2 = Color.FromArgb(52, 72, 100);
            accountsGridView.StateCommon.HeaderRow.Content.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountsGridView.TabIndex = 64;
            accountsGridView.TabStop = false;
            accountsGridView.CellContentClick += accountsGridView_CellContentClick_1;
            accountsGridView.CellPainting += accountsGridView_CellPainting;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            kryptonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn1.DataPropertyName = "account_id";
            kryptonDataGridViewTextBoxColumn1.HeaderText = "Account ID";
            kryptonDataGridViewTextBoxColumn1.MinimumWidth = 100;
            kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            kryptonDataGridViewTextBoxColumn1.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn1.Width = 102;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            kryptonDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Username";
            kryptonDataGridViewTextBoxColumn2.HeaderText = "Username";
            kryptonDataGridViewTextBoxColumn2.MinimumWidth = 400;
            kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            kryptonDataGridViewTextBoxColumn2.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn2.Width = 400;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            kryptonDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn3.DataPropertyName = "AccountName";
            kryptonDataGridViewTextBoxColumn3.HeaderText = "Account Name";
            kryptonDataGridViewTextBoxColumn3.MinimumWidth = 400;
            kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn3.Width = 400;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            kryptonDataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn4.DataPropertyName = "AccountPassword";
            kryptonDataGridViewTextBoxColumn4.HeaderText = "Password";
            kryptonDataGridViewTextBoxColumn4.MinimumWidth = 400;
            kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn4.Width = 400;
            // 
            // kryptonDataGridViewTextBoxColumn5
            // 
            kryptonDataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn5.DataPropertyName = "AccountRole";
            kryptonDataGridViewTextBoxColumn5.HeaderText = "Role";
            kryptonDataGridViewTextBoxColumn5.MinimumWidth = 250;
            kryptonDataGridViewTextBoxColumn5.Name = "kryptonDataGridViewTextBoxColumn5";
            kryptonDataGridViewTextBoxColumn5.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn5.Width = 250;
            // 
            // editButton
            // 
            editButton.DataPropertyName = "subs_id";
            editButton.FillWeight = 20F;
            editButton.HeaderText = "";
            editButton.MinimumWidth = 50;
            editButton.Name = "editButton";
            editButton.ReadOnly = true;
            editButton.Resizable = DataGridViewTriState.False;
            editButton.Width = 50;
            // 
            // deleteButton
            // 
            deleteButton.DataPropertyName = "subs_id";
            deleteButton.FillWeight = 20F;
            deleteButton.HeaderText = "";
            deleteButton.MinimumWidth = 50;
            deleteButton.Name = "deleteButton";
            deleteButton.ReadOnly = true;
            deleteButton.Resizable = DataGridViewTriState.False;
            deleteButton.Width = 50;
            // 
            // bgPanel
            // 
            bgPanel.AccessibleRole = AccessibleRole.None;
            bgPanel.AlwaysActive = false;
            bgPanel.Location = new Point(137, 108);
            bgPanel.MaximumSize = new Size(1674, 663);
            bgPanel.MinimumSize = new Size(1704, 780);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1704, 780);
            bgPanel.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Rounding = 15F;
            bgPanel.TabIndex = 65;
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1906, 929);
            Controls.Add(comboFilter);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(kryptonLabel10);
            Controls.Add(accountsGridView);
            Controls.Add(bgPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountsForm";
            Text = "AccountsForm";
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource accountsBindingSource;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonComboBox comboFilter;
        private Krypton.Toolkit.KryptonDataGridView accountsGridView;
        private Krypton.Toolkit.KryptonTextBox bgPanel;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn5;
        private DataGridViewImageColumn editButton;
        private DataGridViewImageColumn deleteButton;
    }
}