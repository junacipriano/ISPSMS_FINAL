﻿namespace ISPSMS_JUHACA
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
            disconnectedSubscriberViewBindingSource = new BindingSource(components);
            searchBar = new Krypton.Toolkit.KryptonTextBox();
            buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblUsername = new Krypton.Toolkit.KryptonLabel();
            lblRole = new Krypton.Toolkit.KryptonLabel();
            btnProfile = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
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
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.ImeMode = ImeMode.NoControl;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1920, 990);
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
            dashboardPage.Size = new Size(1912, 962);
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
            subscribersPage.Size = new Size(1912, 962);
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
            billingPage.Size = new Size(1912, 962);
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
            transactionsPage.Size = new Size(1912, 962);
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
            accountsPage.Size = new Size(1912, 962);
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
            activitiesPage.Size = new Size(1912, 962);
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
            imageList1.Images.SetKeyName(6, "Untitled design (19).png");
            imageList1.Images.SetKeyName(7, "Untitled design (18).png");
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
            // disconnectedSubscriberViewBindingSource
            // 
            disconnectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.DisconnectedSubscriberView);
            // 
            // searchBar
            // 
            searchBar.ButtonSpecs.Add(buttonSpecAny1);
            searchBar.CueHint.Color1 = Color.FromArgb(182, 182, 182);
            searchBar.CueHint.CueHintText = "Search...";
            searchBar.CueHint.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(201, 18);
            searchBar.MinimumSize = new Size(100, 40);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(295, 42);
            searchBar.StateActive.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateCommon.Border.Color1 = Color.FromArgb(182, 182, 182);
            searchBar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            searchBar.StateCommon.Border.Rounding = 20F;
            searchBar.StateDisabled.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.StateNormal.Back.Color1 = Color.FromArgb(255, 255, 252);
            searchBar.TabIndex = 1;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            buttonSpecAny1.Enabled = Krypton.Toolkit.ButtonEnabled.False;
            buttonSpecAny1.Image = Properties.NewResources.search2;
            buttonSpecAny1.UniqueName = "6dfdb83314eb427a9bc99a64425fdba7";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(1703, 15);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(45, 47);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.StateCommon.Image = Properties.NewResources.Profile;
            kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonPanel1.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(1751, 21);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 19);
            lblUsername.StateCommon.ShortText.Color1 = Color.FromArgb(242, 242, 242);
            lblUsername.StateCommon.ShortText.Color2 = Color.FromArgb(242, 242, 242);
            lblUsername.StateCommon.ShortText.Font = new Font("Helvetica Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.TabIndex = 3;
            lblUsername.Values.Text = "Luisa P. Cipriano";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(1752, 41);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(90, 18);
            lblRole.StateCommon.ShortText.Color1 = Color.FromArgb(242, 242, 242);
            lblRole.StateCommon.ShortText.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.TabIndex = 4;
            lblRole.Values.Text = "System Admin";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(1881, 21);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(31, 33);
            btnProfile.StateCommon.Back.Color1 = Color.Transparent;
            btnProfile.StateCommon.Back.Color2 = Color.Transparent;
            btnProfile.StateCommon.Border.Color1 = Color.FromArgb(55, 71, 79);
            btnProfile.TabIndex = 5;
            btnProfile.Values.DropDownArrowColor = Color.Empty;
            btnProfile.Values.ImageStates.ImageCheckedNormal = null;
            btnProfile.Values.ImageStates.ImageCheckedPressed = null;
            btnProfile.Values.ImageStates.ImageCheckedTracking = null;
            btnProfile.Values.ImageStates.ImageNormal = Properties.NewResources.menu;
            btnProfile.Values.ImageStates.ImagePressed = Properties.NewResources.menu1;
            btnProfile.Values.ImageStates.ImageTracking = Properties.NewResources.menu1;
            btnProfile.Values.Text = "0";
            btnProfile.Click += btnProfile_Click_1;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPanel3);
            kryptonPanel2.Controls.Add(searchBar);
            kryptonPanel2.Controls.Add(btnProfile);
            kryptonPanel2.Controls.Add(lblUsername);
            kryptonPanel2.Controls.Add(lblRole);
            kryptonPanel2.Controls.Add(kryptonPanel1);
            kryptonPanel2.Location = new Point(-4, -7);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1933, 71);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(55, 71, 79);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(55, 71, 79);
            kryptonPanel2.TabIndex = 6;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Location = new Point(25, 8);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(138, 64);
            kryptonPanel3.StateCommon.Color1 = Color.Transparent;
            kryptonPanel3.StateCommon.Image = Properties.NewResources.PC;
            kryptonPanel3.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonPanel3.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1926, 1056);
            Controls.Add(kryptonPanel2);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerUseColors = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 64, 3, 2);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            materialTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)disconnectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
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
        private BindingSource connectedSubscribersBindingSource1;
        private BindingSource disconnectedSubscriberViewBindingSource;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox searchBar;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Krypton.Toolkit.KryptonLabel lblRole;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
    }
}
