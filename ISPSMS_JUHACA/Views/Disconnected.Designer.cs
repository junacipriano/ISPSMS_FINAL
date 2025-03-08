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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            DisconnectedGridView1 = new DataGridView();
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            monthlyChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            disconnectedSubscriberViewBindingSource3 = new BindingSource(components);
            disconnectedSubscribersBindingSource2 = new BindingSource(components);
            disconnectedSubscribersBindingSource = new BindingSource(components);
            disconnectedSubscribersBindingSource1 = new BindingSource(components);
            disconnectedSubscriberViewBindingSource = new BindingSource(components);
            disconnectedSubscriberViewBindingSource1 = new BindingSource(components);
            disconnectedSubscriberViewBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DisconnectedGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.ForeColor = Color.Coral;
            materialLabel1.Location = new Point(23, 70);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(280, 29);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Disconnected Subscribers";
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Search";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(828, 62);
            materialTextBox1.Margin = new Padding(3, 2, 3, 2);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(208, 50);
            materialTextBox1.TabIndex = 1;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // DisconnectedGridView1
            // 
            DisconnectedGridView1.AutoGenerateColumns = false;
            DisconnectedGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            DisconnectedGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisconnectedGridView1.Columns.AddRange(new DataGridViewColumn[] { subsidDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, monthlyChargeDataGridViewTextBoxColumn });
            DisconnectedGridView1.DataSource = disconnectedSubscriberViewBindingSource3;
            DisconnectedGridView1.Location = new Point(23, 112);
            DisconnectedGridView1.Margin = new Padding(3, 2, 3, 2);
            DisconnectedGridView1.Name = "DisconnectedGridView1";
            DisconnectedGridView1.RowHeadersWidth = 51;
            DisconnectedGridView1.Size = new Size(1013, 356);
            DisconnectedGridView1.TabIndex = 2;
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "subs_id";
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Disconn_Name";
            dataGridViewTextBoxColumn1.HeaderText = "Disconn_Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ContactNumber";
            dataGridViewTextBoxColumn2.HeaderText = "ContactNumber";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            dataGridViewTextBoxColumn3.HeaderText = "Address";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Plan";
            dataGridViewTextBoxColumn4.HeaderText = "Plan";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Duedate";
            dataGridViewTextBoxColumn6.HeaderText = "Duedate";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "InstallationDate";
            dataGridViewTextBoxColumn7.HeaderText = "InstallationDate";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.Name = "monthlyChargeDataGridViewTextBoxColumn";
            // 
            // disconnectedSubscriberViewBindingSource3
            // 
            disconnectedSubscriberViewBindingSource3.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // disconnectedSubscribersBindingSource2
            // 
            disconnectedSubscribersBindingSource2.DataSource = typeof(Domain.Models.DisconnectedSubscribers);
            // 
            // disconnectedSubscribersBindingSource
            // 
            disconnectedSubscribersBindingSource.DataSource = typeof(Domain.Models.DisconnectedSubscribers);
            // 
            // disconnectedSubscribersBindingSource1
            // 
            disconnectedSubscribersBindingSource1.DataSource = typeof(Domain.Models.DisconnectedSubscribers);
            // 
            // disconnectedSubscriberViewBindingSource
            // 
            disconnectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // disconnectedSubscriberViewBindingSource1
            // 
            disconnectedSubscriberViewBindingSource1.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // disconnectedSubscriberViewBindingSource2
            // 
            disconnectedSubscriberViewBindingSource2.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // Disconnected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 489);
            Controls.Add(DisconnectedGridView1);
            Controls.Add(materialTextBox1);
            Controls.Add(materialLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Disconnected";
            Padding = new Padding(3, 48, 3, 2);
            ((System.ComponentModel.ISupportInitialize)DisconnectedGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private DataGridView DisconnectedGridView1;
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
    }
}