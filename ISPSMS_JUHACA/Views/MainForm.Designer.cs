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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            subscribersPage = new TabPage();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            accountsGridView = new DataGridView();
            accountidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountPasswordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            accountsBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            tbSearch = new Krypton.Toolkit.KryptonTextBox();
            activitiesPage = new TabPage();
            dashboardPage = new TabPage();
            imageList1 = new ImageList(components);
            connectedSubscribersBindingSource1 = new BindingSource(components);
            connectedSubscriberViewBindingSource = new BindingSource(components);
            connectedSubscribersBindingSource = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            button1 = new Button();
            disconnectedSubscriberViewBindingSource = new BindingSource(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource1).BeginInit();
            subscribersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            accountsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountsBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(subscribersPage);
            materialTabControl1.Controls.Add(billingPage);
            materialTabControl1.Controls.Add(transactionsPage);
            materialTabControl1.Controls.Add(accountsPage);
            materialTabControl1.Controls.Add(activitiesPage);
            materialTabControl1.Controls.Add(dashboardPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.ImeMode = ImeMode.NoControl;
            materialTabControl1.Location = new Point(3, 77);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1914, 1001);
            materialTabControl1.TabIndex = 0;
            // 
            // subscribersPage
            // 
            subscribersPage.BackColor = Color.FromArgb(241, 240, 233);
            subscribersPage.ImageKey = "database.png";
            subscribersPage.Location = new Point(4, 29);
            subscribersPage.Margin = new Padding(3, 2, 3, 2);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3, 2, 3, 2);
            subscribersPage.Size = new Size(1906, 968);
            subscribersPage.Padding = new Padding(3);
            subscribersPage.Size = new Size(1906, 977);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            // 
            // billingPage
            // 
            billingPage.BackColor = Color.FromArgb(241, 240, 233);
            billingPage.ImageKey = "billing.png";
            billingPage.Location = new Point(4, 29);
            billingPage.Margin = new Padding(3, 2, 3, 2);
            billingPage.Name = "billingPage";
            billingPage.Size = new Size(1906, 968);
            billingPage.Size = new Size(1906, 977);
            billingPage.TabIndex = 2;
            billingPage.Text = "Billing";
            // 
            // transactionsPage
            // 
            transactionsPage.BackColor = Color.FromArgb(241, 240, 233);
            transactionsPage.ImageKey = "transactions.png";
            transactionsPage.Location = new Point(4, 29);
            transactionsPage.Margin = new Padding(3, 2, 3, 2);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Size = new Size(1906, 968);
            transactionsPage.Size = new Size(1906, 977);
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            // 
            // accountsPage
            // 
            accountsPage.BackColor = Color.FromArgb(241, 240, 233);
            accountsPage.ImageKey = "accounts.png";
            accountsPage.Controls.Add(accountsGridView);
            accountsPage.Controls.Add(panel1);
            accountsPage.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountsPage.Location = new Point(4, 29);
            accountsPage.Margin = new Padding(3, 2, 3, 2);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1906, 968);
            accountsPage.Size = new Size(1906, 977);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            // 
            // accountsGridView
            // 
            accountsGridView.AllowUserToOrderColumns = true;
            accountsGridView.AutoGenerateColumns = false;
            accountsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsGridView.Columns.AddRange(new DataGridViewColumn[] { accountidDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, accountPasswordDataGridViewTextBoxColumn, accountRoleDataGridViewTextBoxColumn, Edit, Delete });
            accountsGridView.DataSource = accountsBindingSource;
            accountsGridView.Dock = DockStyle.Fill;
            accountsGridView.Location = new Point(0, 112);
            accountsGridView.Name = "accountsGridView";
            accountsGridView.RowHeadersWidth = 51;
            accountsGridView.Size = new Size(1906, 865);
            accountsGridView.TabIndex = 1;
            accountsGridView.CellContentClick += accountsGridView_CellContentClick;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            accountidDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            accountidDataGridViewTextBoxColumn.Frozen = true;
            accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            accountidDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            accountidDataGridViewTextBoxColumn.Width = 242;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // accountPasswordDataGridViewTextBoxColumn
            // 
            accountPasswordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountPasswordDataGridViewTextBoxColumn.DataPropertyName = "AccountPassword";
            accountPasswordDataGridViewTextBoxColumn.HeaderText = "Account Password";
            accountPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountPasswordDataGridViewTextBoxColumn.Name = "accountPasswordDataGridViewTextBoxColumn";
            accountPasswordDataGridViewTextBoxColumn.Width = 338;
            // 
            // accountRoleDataGridViewTextBoxColumn
            // 
            accountRoleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountRoleDataGridViewTextBoxColumn.DataPropertyName = "AccountRole";
            accountRoleDataGridViewTextBoxColumn.HeaderText = "Account Role";
            accountRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountRoleDataGridViewTextBoxColumn.Name = "accountRoleDataGridViewTextBoxColumn";
            accountRoleDataGridViewTextBoxColumn.Width = 259;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "AccountRole";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Blue;
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Blue;
            Edit.DefaultCellStyle = dataGridViewCellStyle4;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 120;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "AccountRole";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Red;
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 128, 128);
            Delete.DefaultCellStyle = dataGridViewCellStyle5;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 144;
            // 
            // accountsBindingSource
            // 
            accountsBindingSource.DataSource = typeof(Domain.Models.Accounts);
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1906, 112);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 54);
            label2.TabIndex = 0;
            label2.Text = "Accounts";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(kryptonComboBox1);
            panel2.Controls.Add(tbSearch);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1906, 55);
            panel2.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 211;
            kryptonComboBox1.Items.AddRange(new object[] { "ALL", "CEO", "ADMIN", "DEFAULT" });
            kryptonComboBox1.Location = new Point(542, 18);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(211, 26);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 1;
            kryptonComboBox1.Text = "ALL";
            // 
            // tbSearch
            // 
            tbSearch.CueHint.CueHintText = "Search";
            tbSearch.Location = new Point(263, 18);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(226, 27);
            tbSearch.TabIndex = 0;
            // 
            // activitiesPage
            // 
            activitiesPage.BackColor = Color.FromArgb(241, 240, 233);
            activitiesPage.ImageKey = "activities.png";
            activitiesPage.Location = new Point(4, 29);
            activitiesPage.Margin = new Padding(3, 2, 3, 2);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1906, 968);
            activitiesPage.Size = new Size(1906, 977);
            activitiesPage.TabIndex = 5;
            activitiesPage.Text = "Activities";
            // 
            // dashboardPage
            // 
            dashboardPage.BackColor = Color.FromArgb(241, 240, 233);
            dashboardPage.ImageKey = "dashboard.png";
            dashboardPage.Location = new Point(4, 29);
            dashboardPage.Margin = new Padding(3, 2, 3, 2);
            dashboardPage.Name = "dashboardPage";
            dashboardPage.Padding = new Padding(3, 2, 3, 2);
            dashboardPage.Size = new Size(1906, 968);
            dashboardPage.TabIndex = 0;
            dashboardPage.Text = "Dashboard";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth4Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dashboard.png");
            imageList1.Images.SetKeyName(1, "database.png");
            imageList1.Images.SetKeyName(2, "billing.png");
            imageList1.Images.SetKeyName(3, "transactions.png");
            imageList1.Images.SetKeyName(4, "accounts.png");
            imageList1.Images.SetKeyName(5, "activities.png");
            // 
            // connectedSubscribersBindingSource1
            // 
            connectedSubscribersBindingSource1.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // connectedSubscriberViewBindingSource
            // 
            connectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1850, 32);
            button1.Name = "button1";
            button1.Size = new Size(29, 31);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // disconnectedSubscriberViewBindingSource
            // 
            disconnectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(button1);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 24);
            kryptonPanel1.Margin = new Padding(0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1914, 1054);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.TabIndex = 5;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            kryptonPictureBox1.Location = new Point(1658, 20);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(50, 51);
            kryptonPictureBox1.TabIndex = 7;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(1712, 51);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(163, 21);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(111, 130, 157);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(111, 130, 157);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 6;
            kryptonLabel2.Values.Text = " System Administrator";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(1715, 32);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(165, 26);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Luisa P. Cipriano";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1920, 1080);
            Controls.Add(materialTabControl1);
            Controls.Add(kryptonPanel1);
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerUseColors = true;
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 24, 3, 2);
            ShowIcon = false;
            Text = "Form1";
            TransparencyKey = Color.White;
            materialTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage dashboardPage;
        private TabPage billingPage;
        private TabPage transactionsPage;
        private TabPage accountsPage;
        private TabPage activitiesPage;
        private BindingSource connectedSubscriberViewBindingSource;
        private BindingSource connectedSubscriberViewBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource connectedSubscribersBindingSource;
        private TabPage subscribersPage;
        private ImageList imageList1;
        private Button button1;
        private BindingSource connectedSubscribersBindingSource1;
        private BindingSource disconnectedSubscriberViewBindingSource;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
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
        private Panel panel1;
        private DataGridView accountsGridView;
        private BindingSource accountsBindingSource;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private Panel panel2;
        private Label label2;
        private DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountPasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountRoleDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox tbSearch;
    }
}
