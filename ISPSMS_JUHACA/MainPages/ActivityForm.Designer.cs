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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            activityBindingSource = new BindingSource(components);
            activityRepositoryBindingSource = new BindingSource(components);
            activityBindingSource1 = new BindingSource(components);
            activitiesidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activitiesDoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activitiesDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 687);
            panel1.TabIndex = 0;
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
            dataGridView1.Size = new Size(1534, 687);
            dataGridView1.TabIndex = 0;
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
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 687);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivityForm";
            Text = "ActivityForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private BindingSource activityBindingSource;
        private BindingSource activityRepositoryBindingSource;
        private BindingSource activityBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn activitiesidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountRoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activitiesDoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activitiesDateTimeDataGridViewTextBoxColumn;
    }
}