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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            imageList1 = new ImageList(components);
            connectedSubscribersBindingSource1 = new BindingSource(components);
            connectedSubscriberViewBindingSource = new BindingSource(components);
            connectedSubscribersBindingSource = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            btnProfile = new Button();
            disconnectedSubscriberViewBindingSource = new BindingSource(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            searchBar = new Krypton.Toolkit.KryptonTextBox();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            lblRole = new Krypton.Toolkit.KryptonLabel();
            lblUsername = new Krypton.Toolkit.KryptonLabel();
            materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource1).BeginInit();
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
            materialTabControl1.Controls.Add(dashboardPage);
            materialTabControl1.Controls.Add(subscribersPage);
            materialTabControl1.Controls.Add(billingPage);
            materialTabControl1.Controls.Add(transactionsPage);
            materialTabControl1.Controls.Add(accountsPage);
            materialTabControl1.Controls.Add(activitiesPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.ImeMode = ImeMode.NoControl;
            materialTabControl1.Location = new Point(3, 121);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1914, 957);
            materialTabControl1.TabIndex = 0;
         
            // 
            // dashboardPage
            // 
            dashboardPage.BackColor = Color.FromArgb(241, 240, 233);
            dashboardPage.ImageKey = "dashboard.png";
            dashboardPage.Location = new Point(4, 24);
            dashboardPage.Margin = new Padding(3, 2, 3, 2);
            dashboardPage.Name = "dashboardPage";
            dashboardPage.Padding = new Padding(3, 2, 3, 2);
            dashboardPage.Size = new Size(1906, 929);
            dashboardPage.TabIndex = 0;
            dashboardPage.Text = "Dashboard";
            // 
            // subscribersPage
            // 
            subscribersPage.BackColor = Color.FromArgb(241, 240, 233);
            subscribersPage.ImageKey = "database.png";
            subscribersPage.Location = new Point(4, 24);
            subscribersPage.Margin = new Padding(3, 2, 3, 2);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3, 2, 3, 2);
            subscribersPage.Size = new Size(1906, 973);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            // 
            // billingPage
            // 
            billingPage.BackColor = Color.FromArgb(241, 240, 233);
            billingPage.ImageKey = "billing.png";
            billingPage.Location = new Point(4, 24);
            billingPage.Margin = new Padding(3, 2, 3, 2);
            billingPage.Name = "billingPage";
            billingPage.Size = new Size(1906, 973);
            billingPage.TabIndex = 2;
            billingPage.Text = "Billing";
            // 
            // transactionsPage
            // 
            transactionsPage.BackColor = Color.FromArgb(241, 240, 233);
            transactionsPage.ImageKey = "transactions.png";
            transactionsPage.Location = new Point(4, 24);
            transactionsPage.Margin = new Padding(3, 2, 3, 2);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Size = new Size(1906, 973);
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            // 
            // accountsPage
            // 
            accountsPage.BackColor = Color.FromArgb(241, 240, 233);
            accountsPage.ImageKey = "accounts.png";
            accountsPage.Location = new Point(4, 24);
            accountsPage.Margin = new Padding(3, 2, 3, 2);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1906, 973);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            // 
            // activitiesPage
            // 
            activitiesPage.BackColor = Color.FromArgb(241, 240, 233);
            activitiesPage.ImageKey = "activities.png";
            activitiesPage.Location = new Point(4, 24);
            activitiesPage.Margin = new Padding(3, 2, 3, 2);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1906, 973);
            activitiesPage.TabIndex = 5;
            activitiesPage.Text = "Activities";
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
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.BackgroundImage = Properties.Resources.ProfileMenu;
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.Transparent;
            btnProfile.Location = new Point(1835, 15);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(29, 31);
            btnProfile.TabIndex = 4;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // disconnectedSubscriberViewBindingSource
            // 
            disconnectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(searchBar);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(btnProfile);
            kryptonPanel1.Controls.Add(lblRole);
            kryptonPanel1.Controls.Add(lblUsername);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 64);
            kryptonPanel1.Margin = new Padding(0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1920, 990);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.TabIndex = 5;
            // 
            // searchBar
            // 
            searchBar.CueHint.Color1 = Color.FromArgb(115, 115, 115);
            searchBar.CueHint.CueHintText = "Search";
            searchBar.CueHint.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.CueHint.Padding = new Padding(8, 4, -1, -1);
            searchBar.Location = new Point(16, 8);
            searchBar.MinimumSize = new Size(252, 40);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(277, 40);
            searchBar.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateCommon.Border.Color1 = Color.FromArgb(115, 115, 115);
            searchBar.StateCommon.Border.Color2 = Color.FromArgb(115, 115, 115);
            searchBar.StateCommon.Border.Image = Properties.Resources.search;
            searchBar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            searchBar.StateCommon.Border.Rounding = 20F;
            searchBar.StateCommon.Border.Width = 1;
            searchBar.StateCommon.Content.Color1 = Color.FromArgb(115, 115, 115);
            searchBar.TabIndex = 8;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = Properties.Resources.ProfilePic;
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            kryptonPictureBox1.Location = new Point(1643, 3);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(50, 51);
            kryptonPictureBox1.TabIndex = 7;
            kryptonPictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(1697, 34);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(131, 18);
            lblRole.StateCommon.ShortText.Color1 = Color.FromArgb(111, 130, 157);
            lblRole.StateCommon.ShortText.Color2 = Color.FromArgb(111, 130, 157);
            lblRole.StateCommon.ShortText.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.TabIndex = 6;
            lblRole.Values.Text = " System Administrator";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(1700, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(141, 22);
            lblUsername.StateCommon.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            lblUsername.StateCommon.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            lblUsername.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.TabIndex = 5;
            lblUsername.Values.Text = "Luisa P. Cipriano";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1926, 1056);
            Controls.Add(materialTabControl1);
            Controls.Add(kryptonPanel1);
            DrawerTabControl = materialTabControl1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 64, 3, 2);
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
        private Button btnProfile;
        private BindingSource connectedSubscribersBindingSource1;
        private BindingSource disconnectedSubscriberViewBindingSource;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel lblRole;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonTextBox searchBar;
    }
}
