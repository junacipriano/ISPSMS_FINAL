namespace ISPSMS_JUHACA.Views.USERCONTROL
{
    partial class SubscriberPage
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

        #region Component Designer generated code

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
            label1 = new Label();
            connectedsubscribersGridView = new DataGridView();
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            connNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            planDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlyChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editButton = new DataGridViewButtonColumn();
            disconnectButton = new DataGridViewButtonColumn();
            connectedSubscriberViewBindingSource = new BindingSource(components);
            connectedSubscribersBindingSource = new BindingSource(components);
            disconnectedbtn = new MaterialSkin.Controls.MaterialButton();
            addBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 4;
            label1.Text = "ALL SUBSCRIBERS";
            // 
            // connectedsubscribersGridView
            // 
            connectedsubscribersGridView.AllowUserToResizeColumns = false;
            connectedsubscribersGridView.AllowUserToResizeRows = false;
            connectedsubscribersGridView.AutoGenerateColumns = false;
            connectedsubscribersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connectedsubscribersGridView.BackgroundColor = Color.Ivory;
            connectedsubscribersGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.OldLace;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            connectedsubscribersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            connectedsubscribersGridView.ColumnHeadersHeight = 29;
            connectedsubscribersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            connectedsubscribersGridView.Columns.AddRange(new DataGridViewColumn[] { subsidDataGridViewTextBoxColumn, connNameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, planDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, installationDateDataGridViewTextBoxColumn, monthlyChargeDataGridViewTextBoxColumn, editButton, disconnectButton });
            connectedsubscribersGridView.DataSource = connectedSubscriberViewBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.Gray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            connectedsubscribersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            connectedsubscribersGridView.GridColor = Color.Ivory;
            connectedsubscribersGridView.ImeMode = ImeMode.NoControl;
            connectedsubscribersGridView.Location = new Point(-13, 66);
            connectedsubscribersGridView.Name = "connectedsubscribersGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.OldLace;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Silver;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            connectedsubscribersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            connectedsubscribersGridView.RowHeadersWidth = 51;
            connectedsubscribersGridView.ScrollBars = ScrollBars.Vertical;
            connectedsubscribersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            connectedsubscribersGridView.Size = new Size(1300, 900);
            connectedsubscribersGridView.TabIndex = 5;
            connectedsubscribersGridView.CellContentClick += connectedsubscribersGridView_CellContentClick;
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "subs_id";
            subsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            // 
            // connNameDataGridViewTextBoxColumn
            // 
            connNameDataGridViewTextBoxColumn.DataPropertyName = "Conn_Name";
            connNameDataGridViewTextBoxColumn.HeaderText = "Conn_Name";
            connNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            connNameDataGridViewTextBoxColumn.Name = "connNameDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // planDataGridViewTextBoxColumn
            // 
            planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            planDataGridViewTextBoxColumn.HeaderText = "Plan";
            planDataGridViewTextBoxColumn.MinimumWidth = 6;
            planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.HeaderText = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            monthlyChargeDataGridViewTextBoxColumn.Name = "monthlyChargeDataGridViewTextBoxColumn";
            // 
            // editButton
            // 
            editButton.DataPropertyName = "subs_id";
            editButton.FillWeight = 19.2589474F;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.HeaderText = "";
            editButton.MinimumWidth = 3;
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;
            // 
            // disconnectButton
            // 
            disconnectButton.DataPropertyName = "disconnectButton";
            disconnectButton.FillWeight = 17.6470585F;
            disconnectButton.FlatStyle = FlatStyle.Popup;
            disconnectButton.HeaderText = "";
            disconnectButton.MinimumWidth = 3;
            disconnectButton.Name = "disconnectButton";
            disconnectButton.UseColumnTextForButtonValue = true;
            // 
            // connectedSubscriberViewBindingSource
            // 
            connectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // disconnectedbtn
            // 
            disconnectedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            disconnectedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            disconnectedbtn.Depth = 0;
            disconnectedbtn.HighEmphasis = true;
            disconnectedbtn.Icon = null;
            disconnectedbtn.Location = new Point(1067, 31);
            disconnectedbtn.Margin = new Padding(4, 6, 4, 6);
            disconnectedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            disconnectedbtn.Name = "disconnectedbtn";
            disconnectedbtn.NoAccentTextColor = Color.Empty;
            disconnectedbtn.Size = new Size(130, 36);
            disconnectedbtn.TabIndex = 7;
            disconnectedbtn.Text = "disconnected";
            disconnectedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            disconnectedbtn.UseAccentColor = false;
            disconnectedbtn.UseVisualStyleBackColor = true;
            disconnectedbtn.Click += disconnectedbtn_Click;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(973, 31);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(86, 36);
            addBtn.TabIndex = 6;
            addBtn.Text = "add new";
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // SubscriberPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 933);
            Controls.Add(disconnectedbtn);
            Controls.Add(addBtn);
            Controls.Add(connectedsubscribersGridView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubscriberPage";
            Load += SubscriberPage_Load;
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView connectedsubscribersGridView;
        private MaterialSkin.Controls.MaterialButton disconnectedbtn;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private BindingSource connectedSubscribersBindingSource;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthlyChargeDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn disconnectButton;
        private BindingSource connectedSubscriberViewBindingSource;
    }
}
