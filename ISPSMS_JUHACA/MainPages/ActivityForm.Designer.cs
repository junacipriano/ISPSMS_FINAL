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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            activityBindingSource = new BindingSource(components);
            activityRepositoryBindingSource = new BindingSource(components);
            activityBindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            DateFilter = new Krypton.Toolkit.KryptonDateTimePicker();
            dataGridView1 = new DataGridView();
            activitiesDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activitiesDoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activitiesidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(kryptonLabel2);
            panel2.Controls.Add(kryptonLabel1);
            panel2.Controls.Add(DateFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1534, 48);
            panel2.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(1078, 12);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(59, 24);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "Filter:";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(93, 13);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(113, 31);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Activities";
            // 
            // DateFilter
            // 
            DateFilter.CalendarTodayDate = new DateTime(2025, 3, 25, 0, 0, 0, 0);
            DateFilter.Location = new Point(1143, 12);
            DateFilter.Name = "DateFilter";
            DateFilter.Size = new Size(192, 25);
            DateFilter.TabIndex = 0;
            DateFilter.ValueChanged += DateFilter_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { activitiesidDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountRoleDataGridViewTextBoxColumn, activitiesDoneDataGridViewTextBoxColumn, activitiesDateTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = activityBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1534, 639);
            dataGridView1.TabIndex = 0;
            // 
            // activitiesDateTimeDataGridViewTextBoxColumn
            // 
            activitiesDateTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            activitiesDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ActivitiesDateTime";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Info;
            activitiesDateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            activitiesDateTimeDataGridViewTextBoxColumn.HeaderText = "ActivitiesDateTime";
            activitiesDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            activitiesDateTimeDataGridViewTextBoxColumn.Name = "activitiesDateTimeDataGridViewTextBoxColumn";
            // 
            // activitiesDoneDataGridViewTextBoxColumn
            // 
            activitiesDoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            activitiesDoneDataGridViewTextBoxColumn.DataPropertyName = "ActivitiesDone";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Info;
            activitiesDoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            activitiesDoneDataGridViewTextBoxColumn.HeaderText = "ActivitiesDone";
            activitiesDoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            activitiesDoneDataGridViewTextBoxColumn.Name = "activitiesDoneDataGridViewTextBoxColumn";
            // 
            // accountRoleDataGridViewTextBoxColumn
            // 
            accountRoleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountRoleDataGridViewTextBoxColumn.DataPropertyName = "AccountRole";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Info;
            accountRoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            accountRoleDataGridViewTextBoxColumn.HeaderText = "AccountRole";
            accountRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountRoleDataGridViewTextBoxColumn.Name = "accountRoleDataGridViewTextBoxColumn";
            accountRoleDataGridViewTextBoxColumn.Width = 122;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Info;
            accountNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            accountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // activitiesidDataGridViewTextBoxColumn
            // 
            activitiesidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            activitiesidDataGridViewTextBoxColumn.DataPropertyName = "activities_id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            activitiesidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            activitiesidDataGridViewTextBoxColumn.HeaderText = "activities_id";
            activitiesidDataGridViewTextBoxColumn.MinimumWidth = 6;
            activitiesidDataGridViewTextBoxColumn.Name = "activitiesidDataGridViewTextBoxColumn";
            activitiesidDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            activitiesidDataGridViewTextBoxColumn.Width = 115;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(dataGridView1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 48);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1534, 639);
            kryptonPanel1.TabIndex = 2;
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 687);
            Controls.Add(kryptonPanel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivityForm";
            Text = "ActivityForm";
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource activityBindingSource;
        private BindingSource activityRepositoryBindingSource;
        private BindingSource activityBindingSource1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonDateTimePicker DateFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn activitiesidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountRoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activitiesDoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activitiesDateTimeDataGridViewTextBoxColumn;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}