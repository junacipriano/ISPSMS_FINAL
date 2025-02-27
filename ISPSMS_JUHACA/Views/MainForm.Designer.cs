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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            connectedSubscribersBindingSource = new BindingSource(components);
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            connectedSubscriberViewBindingSource = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            materialTabControl1.SuspendLayout();
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
            subscribersPage.Location = new Point(4, 29);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3);
            subscribersPage.Size = new Size(1906, 980);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            subscribersPage.UseVisualStyleBackColor = true;
            // 
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
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
            // connectedSubscriberViewBindingSource1
            // 
            connectedSubscriberViewBindingSource1.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
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
            materialTabControl1.ResumeLayout(false);
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
        private TabPage activitiesPage;
        private BindingSource connectedSubscriberViewBindingSource;
        private BindingSource connectedSubscriberViewBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource connectedSubscribersBindingSource;
    }
}
