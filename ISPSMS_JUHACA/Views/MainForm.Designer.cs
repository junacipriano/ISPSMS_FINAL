namespace ISPSMS_JUHACA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            disconnectedbtn = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            connectedsubscribersGridView = new DataGridView();
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Conn_Name = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            planDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlyChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editButton = new DataGridViewButtonColumn();
            disconnectButton = new DataGridViewButtonColumn();
            connectedSubscribersBindingSource = new BindingSource(components);
            addBtn = new MaterialSkin.Controls.MaterialButton();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            connectedSubscriberViewBindingSource = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            materialTabControl1.SuspendLayout();
            subscribersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(dashboardPage);
            materialTabControl1.Controls.Add(subscribersPage);
            materialTabControl1.Controls.Add(billingPage);
            materialTabControl1.Controls.Add(transactionsPage);
            materialTabControl1.Controls.Add(accountsPage);
            materialTabControl1.Controls.Add(activitiesPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1914, 1013);
            materialTabControl1.TabIndex = 0;
            // 
            // dashboardPage
            // 
            dashboardPage.Location = new Point(4, 29);
            dashboardPage.Name = "dashboardPage";
            dashboardPage.Padding = new Padding(3);
            dashboardPage.Size = new Size(1906, 980);
            dashboardPage.TabIndex = 0;
            dashboardPage.Text = "Dashboard";
            dashboardPage.UseVisualStyleBackColor = true;
            // 
            // subscribersPage
            // 
            subscribersPage.Controls.Add(materialTextBox1);
            subscribersPage.Controls.Add(disconnectedbtn);
            subscribersPage.Controls.Add(label1);
            subscribersPage.Controls.Add(connectedsubscribersGridView);
            subscribersPage.Controls.Add(addBtn);
            subscribersPage.Location = new Point(4, 29);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3);
            subscribersPage.Size = new Size(1906, 980);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            subscribersPage.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Search";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(1636, 8);
            materialTextBox1.MaximumSize = new Size(250, 36);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            materialTextBox1.Size = new Size(250, 36);
            materialTextBox1.TabIndex = 5;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // disconnectedbtn
            // 
            disconnectedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            disconnectedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            disconnectedbtn.Depth = 0;
            disconnectedbtn.HighEmphasis = true;
            disconnectedbtn.Icon = null;
            disconnectedbtn.Location = new Point(1499, 8);
            disconnectedbtn.Margin = new Padding(4, 6, 4, 6);
            disconnectedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            disconnectedbtn.Name = "disconnectedbtn";
            disconnectedbtn.NoAccentTextColor = Color.Empty;
            disconnectedbtn.Size = new Size(130, 36);
            disconnectedbtn.TabIndex = 4;
            disconnectedbtn.Text = "disconnected";
            disconnectedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            disconnectedbtn.UseAccentColor = false;
            disconnectedbtn.UseVisualStyleBackColor = true;
            disconnectedbtn.Click += disconnectedbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(4, 10);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 3;
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
            connectedsubscribersGridView.Columns.AddRange(new DataGridViewColumn[] { subsidDataGridViewTextBoxColumn, Conn_Name, contactNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, planDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, installationDateDataGridViewTextBoxColumn, monthlyChargeDataGridViewTextBoxColumn, editButton, disconnectButton });
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
            connectedsubscribersGridView.Location = new Point(0, 50);
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
            connectedsubscribersGridView.Size = new Size(1888, 883);
            connectedsubscribersGridView.TabIndex = 1;
            connectedsubscribersGridView.CellContentClick += connectedsubscribersGridView_CellContentClick;
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "ID NO.";
            subsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            // 
            // Conn_Name
            // 
            Conn_Name.DataPropertyName = "Conn_Name";
            Conn_Name.HeaderText = "NAME";
            Conn_Name.MinimumWidth = 6;
            Conn_Name.Name = "Conn_Name";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "CONTACT NO.";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // planDataGridViewTextBoxColumn
            // 
            planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            planDataGridViewTextBoxColumn.HeaderText = "PLAN";
            planDataGridViewTextBoxColumn.MinimumWidth = 6;
            planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            duedateDataGridViewTextBoxColumn.HeaderText = "DUEDATE";
            duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.HeaderText = "INSTALLATION DATE";
            installationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MONTHLY CHARGE";
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
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(1403, 8);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(86, 36);
            addBtn.TabIndex = 0;
            addBtn.Text = "add new";
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // billingPage
            // 
            billingPage.Location = new Point(4, 29);
            billingPage.Name = "billingPage";
            billingPage.Size = new Size(1906, 980);
            billingPage.TabIndex = 2;
            billingPage.Text = "Billing";
            billingPage.UseVisualStyleBackColor = true;
            // 
            // transactionsPage
            // 
            transactionsPage.Location = new Point(4, 29);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Size = new Size(1906, 980);
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            transactionsPage.UseVisualStyleBackColor = true;
            // 
            // accountsPage
            // 
            accountsPage.Location = new Point(4, 29);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1906, 980);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            accountsPage.UseVisualStyleBackColor = true;
            // 
            // activitiesPage
            // 
            activitiesPage.Location = new Point(4, 29);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1906, 980);
            activitiesPage.TabIndex = 5;
            activitiesPage.Text = "Activities";
            activitiesPage.UseVisualStyleBackColor = true;
            // 
            // connectedSubscriberViewBindingSource
            // 
            connectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerTabControl = materialTabControl1;
            Name = "MainForm";
            Text = "Form1";
            Load += SubscribersForm_Load;
            materialTabControl1.ResumeLayout(false);
            subscribersPage.ResumeLayout(false);
            subscribersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage dashboardPage;
        private TabPage subscribersPage;
        private TabPage billingPage;
        private TabPage transactionsPage;
        private TabPage accountsPage;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private TabPage activitiesPage;
        public DataGridView connectedsubscribersGridView;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton disconnectedbtn;
        private BindingSource connectedSubscriberViewBindingSource;
        private BindingSource connectedSubscriberViewBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource connectedSubscribersBindingSource;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Conn_Name;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthlyChargeDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn disconnectButton;
    }
}
