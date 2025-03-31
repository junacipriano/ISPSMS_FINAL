namespace ISPSMS_JUHACA.MainPages.SubPages
{
    partial class ActivityForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            activityBindingSource = new BindingSource(components);
            activityRepositoryBindingSource = new BindingSource(components);
            activityBindingSource1 = new BindingSource(components);
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            dataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn5 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            bgPanel = new Krypton.Toolkit.KryptonTextBox();
            DateFilter = new Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // activityBindingSource
            // 
            activityBindingSource.DataSource = typeof(Domain.Models.Activity);
            // 
            // activityRepositoryBindingSource
            // 
            activityRepositoryBindingSource.DataSource = typeof(Infastructure.Data.Repositories.ActivityRepository);
            // 
            // activityBindingSource1
            // 
            activityBindingSource1.DataSource = typeof(Domain.Models.Activity);
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(85, 104);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1690, 1);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(182, 182, 182);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(81, 55);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(257, 38);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.FromArgb(55, 71, 79);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel10.TabIndex = 67;
            kryptonLabel10.Values.Text = "Account Activities";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kryptonDataGridViewTextBoxColumn1, kryptonDataGridViewTextBoxColumn2, kryptonDataGridViewTextBoxColumn3, kryptonDataGridViewTextBoxColumn4, kryptonDataGridViewTextBoxColumn5 });
            dataGridView1.DataSource = activityBindingSource;
            dataGridView1.Location = new Point(109, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Helvetica Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(234, 98, 38);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1645, 763);
            dataGridView1.StateCommon.Background.Color1 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridView1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.DataCell.Border.Color1 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.DataCell.Border.Color2 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(255, 255, 252);
            dataGridView1.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(166, 166, 166);
            dataGridView1.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(166, 166, 166);
            dataGridView1.StateCommon.HeaderColumn.Content.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView1.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridView1.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridView1.StateCommon.HeaderRow.Border.Rounding = 20F;
            dataGridView1.StateCommon.HeaderRow.Content.Color1 = Color.FromArgb(52, 72, 100);
            dataGridView1.StateCommon.HeaderRow.Content.Color2 = Color.FromArgb(52, 72, 100);
            dataGridView1.StateCommon.HeaderRow.Content.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.TabIndex = 68;
            dataGridView1.TabStop = false;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            kryptonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn1.DataPropertyName = "activities_id";
            kryptonDataGridViewTextBoxColumn1.HeaderText = "Activity No.";
            kryptonDataGridViewTextBoxColumn1.MinimumWidth = 200;
            kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            kryptonDataGridViewTextBoxColumn1.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn1.Width = 200;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            kryptonDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn2.DataPropertyName = "AccountName";
            kryptonDataGridViewTextBoxColumn2.HeaderText = "Name";
            kryptonDataGridViewTextBoxColumn2.MinimumWidth = 300;
            kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            kryptonDataGridViewTextBoxColumn2.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn2.Width = 300;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            kryptonDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn3.DataPropertyName = "AccountRole";
            kryptonDataGridViewTextBoxColumn3.HeaderText = "Role";
            kryptonDataGridViewTextBoxColumn3.MinimumWidth = 200;
            kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            kryptonDataGridViewTextBoxColumn3.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn3.Width = 200;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            kryptonDataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn4.DataPropertyName = "ActivitiesDone";
            kryptonDataGridViewTextBoxColumn4.HeaderText = "Activity";
            kryptonDataGridViewTextBoxColumn4.MinimumWidth = 500;
            kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            kryptonDataGridViewTextBoxColumn4.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn4.Width = 500;
            // 
            // kryptonDataGridViewTextBoxColumn5
            // 
            kryptonDataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn5.DataPropertyName = "ActivitiesDateTime";
            kryptonDataGridViewTextBoxColumn5.HeaderText = "Date and Time";
            kryptonDataGridViewTextBoxColumn5.MinimumWidth = 400;
            kryptonDataGridViewTextBoxColumn5.Name = "kryptonDataGridViewTextBoxColumn5";
            kryptonDataGridViewTextBoxColumn5.ReadOnly = true;
            kryptonDataGridViewTextBoxColumn5.Width = 400;
            // 
            // bgPanel
            // 
            bgPanel.AccessibleRole = AccessibleRole.None;
            bgPanel.AlwaysActive = false;
            bgPanel.Location = new Point(79, 123);
            bgPanel.MaximumSize = new Size(1674, 663);
            bgPanel.MinimumSize = new Size(1704, 810);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1704, 810);
            bgPanel.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Rounding = 15F;
            bgPanel.TabIndex = 69;
            // 
            // DateFilter
            // 
            DateFilter.AlwaysActive = false;
            DateFilter.CalendarDayOfWeekStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            DateFilter.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            DateFilter.CalendarHeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary;
            DateFilter.CalendarTodayFormat = "D";
            DateFilter.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            DateFilter.Location = new Point(1581, 46);
            DateFilter.MinimumSize = new Size(136, 40);
            DateFilter.Name = "DateFilter";
            DateFilter.Size = new Size(197, 40);
            DateFilter.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            DateFilter.StateCommon.Border.Color1 = Color.FromArgb(182, 182, 182);
            DateFilter.StateCommon.Border.Rounding = 20F;
            DateFilter.StateCommon.Content.Color1 = Color.FromArgb(55, 71, 79);
            DateFilter.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateFilter.StateCommon.Content.Padding = new Padding(5, -1, -1, -1);
            DateFilter.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            DateFilter.TabIndex = 70;
            DateFilter.TabStop = false;
            DateFilter.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            DateFilter.ValueNullable = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            DateFilter.ValueChanged += DateFilter_ValueChanged;
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1920, 990);
            Controls.Add(DateFilter);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(kryptonLabel10);
            Controls.Add(dataGridView1);
            Controls.Add(bgPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActivityForm";
            Text = "ActivityForm";
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource activityBindingSource;
        private BindingSource activityRepositoryBindingSource;
        private BindingSource activityBindingSource1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonDataGridView dataGridView1;
        private Krypton.Toolkit.KryptonTextBox bgPanel;
        private Krypton.Toolkit.KryptonDateTimePicker DateFilter;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn5;
    }
}