namespace ISPSMS_JUHACA.Views
{
    partial class Disconnected
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            disconnectedSubscribersBindingSource = new BindingSource(components);
            DisconnectedGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn5 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn6 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn7 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn9 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn10 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            reconnectButton = new DataGridViewImageColumn();
            deleteButton = new DataGridViewImageColumn();
            bgPanel = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            searchBar = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisconnectedGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.ForeColor = Color.Coral;
            materialLabel1.Location = new Point(16, 71);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 0;
            // 
            // disconnectedSubscribersBindingSource
            // 
            disconnectedSubscribersBindingSource.DataSource = typeof(Domain.Models.DisconnectedSubscribers);
            // 
            // DisconnectedGridView1
            // 
            DisconnectedGridView1.AllowUserToAddRows = false;
            DisconnectedGridView1.AllowUserToResizeColumns = false;
            DisconnectedGridView1.AllowUserToResizeRows = false;
            DisconnectedGridView1.AutoGenerateColumns = false;
            DisconnectedGridView1.BorderStyle = BorderStyle.None;
            DisconnectedGridView1.ColumnHeadersHeight = 30;
            DisconnectedGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DisconnectedGridView1.Columns.AddRange(new DataGridViewColumn[] { kryptonDataGridViewTextBoxColumn1, kryptonDataGridViewTextBoxColumn2, kryptonDataGridViewTextBoxColumn3, kryptonDataGridViewTextBoxColumn4, kryptonDataGridViewTextBoxColumn5, kryptonDataGridViewTextBoxColumn6, kryptonDataGridViewTextBoxColumn7, kryptonDataGridViewTextBoxColumn9, kryptonDataGridViewTextBoxColumn10, reconnectButton, deleteButton });
            DisconnectedGridView1.DataSource = disconnectedSubscribersBindingSource;
            DisconnectedGridView1.Location = new Point(67, 87);
            DisconnectedGridView1.Name = "DisconnectedGridView1";
            DisconnectedGridView1.ReadOnly = true;
            DisconnectedGridView1.RowHeadersVisible = false;
            DisconnectedGridView1.RowHeadersWidth = 50;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Helvetica Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(234, 98, 38);
            DisconnectedGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DisconnectedGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            DisconnectedGridView1.RowTemplate.Height = 40;
            DisconnectedGridView1.RowTemplate.ReadOnly = true;
            DisconnectedGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            DisconnectedGridView1.ScrollBars = ScrollBars.Vertical;
            DisconnectedGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DisconnectedGridView1.Size = new Size(1322, 588);
            DisconnectedGridView1.StateCommon.Background.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.Background.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            DisconnectedGridView1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(166, 166, 166);
            DisconnectedGridView1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(166, 166, 166);
            DisconnectedGridView1.StateCommon.HeaderColumn.Content.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisconnectedGridView1.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            DisconnectedGridView1.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            DisconnectedGridView1.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderRow.Back.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateCommon.HeaderRow.Border.Rounding = 20F;
            DisconnectedGridView1.StateCommon.HeaderRow.Content.Color1 = Color.FromArgb(52, 72, 100);
            DisconnectedGridView1.StateCommon.HeaderRow.Content.Color2 = Color.FromArgb(52, 72, 100);
            DisconnectedGridView1.StateCommon.HeaderRow.Content.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisconnectedGridView1.StateNormal.Background.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateNormal.Background.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateNormal.DataCell.Back.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateNormal.DataCell.Back.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateNormal.PaletteBorder.Color1 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.StateNormal.PaletteBorder.Color2 = Color.FromArgb(255, 255, 252);
            DisconnectedGridView1.TabIndex = 54;
            DisconnectedGridView1.TabStop = false;
            DisconnectedGridView1.CellClick += DisconnectedGridView1_CellClick;
            DisconnectedGridView1.CellPainting += DisconnectedGridView1_CellPainting;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            kryptonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn1.DataPropertyName = "subs_id";
            kryptonDataGridViewTextBoxColumn1.HeaderText = "Id No.";
            kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            kryptonDataGridViewTextBoxColumn1.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn1.Width = 71;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            kryptonDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Disconn_Name";
            kryptonDataGridViewTextBoxColumn2.HeaderText = "Name";
            kryptonDataGridViewTextBoxColumn2.MinimumWidth = 200;
            kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            kryptonDataGridViewTextBoxColumn2.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn2.Width = 200;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            kryptonDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn3.DataPropertyName = "ContactNumber";
            kryptonDataGridViewTextBoxColumn3.HeaderText = "Phone No.";
            kryptonDataGridViewTextBoxColumn3.MinimumWidth = 100;
            kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            kryptonDataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn4.DataPropertyName = "Address";
            kryptonDataGridViewTextBoxColumn4.HeaderText = "Address";
            kryptonDataGridViewTextBoxColumn4.MinimumWidth = 250;
            kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn4.Width = 250;
            // 
            // kryptonDataGridViewTextBoxColumn5
            // 
            kryptonDataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn5.DataPropertyName = "Plan";
            kryptonDataGridViewTextBoxColumn5.HeaderText = "Plan";
            kryptonDataGridViewTextBoxColumn5.Name = "kryptonDataGridViewTextBoxColumn5";
            kryptonDataGridViewTextBoxColumn5.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn5.Width = 62;
            // 
            // kryptonDataGridViewTextBoxColumn6
            // 
            kryptonDataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn6.DataPropertyName = "Status";
            kryptonDataGridViewTextBoxColumn6.HeaderText = "Status";
            kryptonDataGridViewTextBoxColumn6.MinimumWidth = 180;
            kryptonDataGridViewTextBoxColumn6.Name = "kryptonDataGridViewTextBoxColumn6";
            kryptonDataGridViewTextBoxColumn6.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn6.Width = 180;
            // 
            // kryptonDataGridViewTextBoxColumn7
            // 
            kryptonDataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn7.DataPropertyName = "Duedate";
            kryptonDataGridViewTextBoxColumn7.HeaderText = "Duedate";
            kryptonDataGridViewTextBoxColumn7.MinimumWidth = 50;
            kryptonDataGridViewTextBoxColumn7.Name = "kryptonDataGridViewTextBoxColumn7";
            kryptonDataGridViewTextBoxColumn7.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn7.Width = 85;
            // 
            // kryptonDataGridViewTextBoxColumn9
            // 
            kryptonDataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn9.DataPropertyName = "InstallationDate";
            kryptonDataGridViewTextBoxColumn9.HeaderText = "Date Installed";
            kryptonDataGridViewTextBoxColumn9.MinimumWidth = 100;
            kryptonDataGridViewTextBoxColumn9.Name = "kryptonDataGridViewTextBoxColumn9";
            kryptonDataGridViewTextBoxColumn9.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn9.Width = 117;
            // 
            // kryptonDataGridViewTextBoxColumn10
            // 
            kryptonDataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn10.DataPropertyName = "Charge";
            kryptonDataGridViewTextBoxColumn10.HeaderText = "Charge";
            kryptonDataGridViewTextBoxColumn10.MinimumWidth = 50;
            kryptonDataGridViewTextBoxColumn10.Name = "kryptonDataGridViewTextBoxColumn10";
            kryptonDataGridViewTextBoxColumn10.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn10.Width = 78;
            // 
            // reconnectButton
            // 
            reconnectButton.DataPropertyName = "reconnectButton";
            reconnectButton.FillWeight = 50F;
            reconnectButton.HeaderText = "";
            reconnectButton.Name = "reconnectButton";
            reconnectButton.ReadOnly = true;
            reconnectButton.Width = 50;
            // 
            // deleteButton
            // 
            deleteButton.DataPropertyName = "deleteButton";
            deleteButton.FillWeight = 50F;
            deleteButton.HeaderText = "";
            deleteButton.Name = "deleteButton";
            deleteButton.ReadOnly = true;
            deleteButton.Width = 50;
            // 
            // bgPanel
            // 
            bgPanel.AccessibleRole = AccessibleRole.None;
            bgPanel.AlwaysActive = false;
            bgPanel.Location = new Point(40, 71);
            bgPanel.MinimumSize = new Size(1100, 630);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1376, 630);
            bgPanel.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Rounding = 15F;
            bgPanel.TabIndex = 55;
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.Location = new Point(47, 14);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.Size = new Size(382, 36);
            kryptonTextBox4.StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            kryptonTextBox4.StateCommon.Border.Color1 = Color.FromArgb(241, 240, 233);
            kryptonTextBox4.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            kryptonTextBox4.StateCommon.Content.Font = new Font("Helvetica Rounded", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox4.TabIndex = 62;
            kryptonTextBox4.Text = "Disconnected Subscribers";
            // 
            // searchBar
            // 
            searchBar.CueHint.Color1 = Color.FromArgb(182, 182, 182);
            searchBar.CueHint.CueHintText = "Search...";
            searchBar.CueHint.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(1121, 10);
            searchBar.MinimumSize = new Size(100, 40);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(295, 40);
            searchBar.StateActive.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateCommon.Border.Color1 = Color.FromArgb(182, 182, 182);
            searchBar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            searchBar.StateCommon.Border.Rounding = 20F;
            searchBar.StateDisabled.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateNormal.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.TabIndex = 63;
            // 
            // Disconnected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1455, 735);
            Controls.Add(searchBar);
            Controls.Add(kryptonTextBox4);
            Controls.Add(DisconnectedGridView1);
            Controls.Add(bgPanel);
            Controls.Add(materialLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Disconnected";
            Padding = new Padding(3, 48, 3, 2);
            ShowIcon = false;
            StateCommon.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Back.Color2 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Back.Color1 = Color.FromArgb(241, 240, 233);
            StateCommon.Header.Back.Color2 = Color.FromArgb(241, 240, 233);
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisconnectedGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private DataGridViewTextBoxColumn disconnNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDuedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalChargeDataGridViewTextBoxColumn;
        private BindingSource disconnectedSubscribersBindingSource;
        private BindingSource disconnectedSubscribersBindingSource2;
        private BindingSource disconnectedSubscribersBindingSource1;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn monthlyChargeDataGridViewTextBoxColumn;
        private BindingSource disconnectedSubscriberViewBindingSource3;
        private BindingSource disconnectedSubscriberViewBindingSource;
        private BindingSource disconnectedSubscriberViewBindingSource1;
        private BindingSource disconnectedSubscriberViewBindingSource2;
        private Krypton.Toolkit.KryptonDataGridView DisconnectedGridView1;
        private Krypton.Toolkit.KryptonTextBox bgPanel;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox searchBar;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn5;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn6;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn7;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn9;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn10;
        private DataGridViewImageColumn reconnectButton;
        private DataGridViewImageColumn deleteButton;
    }
}