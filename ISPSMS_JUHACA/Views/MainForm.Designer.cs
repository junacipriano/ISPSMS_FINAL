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
            subscribersPage = new TabPage();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
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
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            // 
            // accountsPage
            // 
            accountsPage.BackColor = Color.FromArgb(241, 240, 233);
            accountsPage.ImageKey = "accounts.png";
            accountsPage.Location = new Point(4, 29);
            accountsPage.Margin = new Padding(3, 2, 3, 2);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1906, 968);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            // 
            // activitiesPage
            // 
            activitiesPage.BackColor = Color.FromArgb(241, 240, 233);
            activitiesPage.ImageKey = "activities.png";
            activitiesPage.Location = new Point(4, 29);
            activitiesPage.Margin = new Padding(3, 2, 3, 2);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1906, 968);
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
    }
}
