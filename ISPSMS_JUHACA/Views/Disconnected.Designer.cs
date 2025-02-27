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
            dataGridView1 = new DataGridView();
            disconnectedSubscribersBindingSource = new BindingSource(components);
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            disconnNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            planDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentDuedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlyChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Helvetica Rounded", 23.9999981F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.ForeColor = Color.Coral;
            materialLabel1.Location = new Point(26, 93);
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
            materialTextBox1.Location = new Point(946, 82);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(238, 50);
            materialTextBox1.TabIndex = 1;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { subsidDataGridViewTextBoxColumn, disconnNameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, planDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, currentDuedateDataGridViewTextBoxColumn, installationDateDataGridViewTextBoxColumn, monthlyChargeDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, totalChargeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = disconnectedSubscribersBindingSource;
            dataGridView1.Location = new Point(26, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1158, 474);
            dataGridView1.TabIndex = 2;
            // 
            // disconnectedSubscribersBindingSource
            // 
            disconnectedSubscribersBindingSource.DataSource = typeof(Domain.Models.DisconnectedSubscribers);
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "ID NO.";
            subsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            subsidDataGridViewTextBoxColumn.Width = 125;
            // 
            // disconnNameDataGridViewTextBoxColumn
            // 
            disconnNameDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            disconnNameDataGridViewTextBoxColumn.HeaderText = "Disconn_Name";
            disconnNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            disconnNameDataGridViewTextBoxColumn.Name = "disconnNameDataGridViewTextBoxColumn";
            disconnNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "CONTACT NO.";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            contactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // planDataGridViewTextBoxColumn
            // 
            planDataGridViewTextBoxColumn.DataPropertyName = "PLAN";
            planDataGridViewTextBoxColumn.HeaderText = "Plan";
            planDataGridViewTextBoxColumn.MinimumWidth = 6;
            planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            planDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "DUEDATE";
            duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            duedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentDuedateDataGridViewTextBoxColumn
            // 
            currentDuedateDataGridViewTextBoxColumn.DataPropertyName = "DD";
            currentDuedateDataGridViewTextBoxColumn.HeaderText = "CurrentDuedate";
            currentDuedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            currentDuedateDataGridViewTextBoxColumn.Name = "currentDuedateDataGridViewTextBoxColumn";
            currentDuedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            installationDateDataGridViewTextBoxColumn.DataPropertyName = "INSTALLATION DATE";
            installationDateDataGridViewTextBoxColumn.HeaderText = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            installationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            monthlyChargeDataGridViewTextBoxColumn.Name = "monthlyChargeDataGridViewTextBoxColumn";
            monthlyChargeDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalChargeDataGridViewTextBoxColumn
            // 
            totalChargeDataGridViewTextBoxColumn.DataPropertyName = "MONTHLY CHARGE";
            totalChargeDataGridViewTextBoxColumn.HeaderText = "TotalCharge";
            totalChargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalChargeDataGridViewTextBoxColumn.Name = "totalChargeDataGridViewTextBoxColumn";
            totalChargeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Disconnected
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 652);
            Controls.Add(dataGridView1);
            Controls.Add(materialTextBox1);
            Controls.Add(materialLabel1);
            Name = "Disconnected";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscribersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn disconnNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDuedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthlyChargeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalChargeDataGridViewTextBoxColumn;
        private BindingSource disconnectedSubscribersBindingSource;
    }
}