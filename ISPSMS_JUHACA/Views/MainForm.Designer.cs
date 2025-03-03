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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            customMaterialButton12 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton11 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton10 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton9 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton8 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton7 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton6 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton5 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton4 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton3 = new Modified_Tools.CustomMaterialButton();
            customMaterialButton2 = new Modified_Tools.CustomMaterialButton();
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
            connectedSubscriberViewBindingSource = new BindingSource(components);
            addBtn = new MaterialSkin.Controls.MaterialButton();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            connectedSubscribersBindingSource = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            materialTabControl1.SuspendLayout();
            subscribersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            materialTabControl1.Location = new Point(-3, 77);
            materialTabControl1.Margin = new Padding(3, 2, 3, 2);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1686, 736);
            materialTabControl1.TabIndex = 0;
            // 
            // dashboardPage
            // 
            dashboardPage.Location = new Point(4, 24);
            dashboardPage.Margin = new Padding(3, 2, 3, 2);
            dashboardPage.Name = "dashboardPage";
            dashboardPage.Padding = new Padding(3, 2, 3, 2);
            dashboardPage.Size = new Size(1678, 708);
            dashboardPage.TabIndex = 0;
            dashboardPage.Text = "Dashboard";
            dashboardPage.UseVisualStyleBackColor = true;
            // 
            // subscribersPage
            // 
            subscribersPage.BackColor = Color.FromArgb(241, 240, 233);
            subscribersPage.Controls.Add(label5);
            subscribersPage.Controls.Add(label4);
            subscribersPage.Controls.Add(label3);
            subscribersPage.Controls.Add(label2);
            subscribersPage.Controls.Add(materialComboBox1);
            subscribersPage.Controls.Add(customMaterialButton12);
            subscribersPage.Controls.Add(customMaterialButton11);
            subscribersPage.Controls.Add(customMaterialButton10);
            subscribersPage.Controls.Add(customMaterialButton9);
            subscribersPage.Controls.Add(customMaterialButton8);
            subscribersPage.Controls.Add(customMaterialButton7);
            subscribersPage.Controls.Add(customMaterialButton6);
            subscribersPage.Controls.Add(customMaterialButton5);
            subscribersPage.Controls.Add(customMaterialButton4);
            subscribersPage.Controls.Add(customMaterialButton3);
            subscribersPage.Controls.Add(customMaterialButton2);
            subscribersPage.Controls.Add(disconnectedbtn);
            subscribersPage.Controls.Add(label1);
            subscribersPage.Controls.Add(connectedsubscribersGridView);
            subscribersPage.Controls.Add(addBtn);
            subscribersPage.Location = new Point(4, 24);
            subscribersPage.Margin = new Padding(3, 2, 3, 2);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3, 2, 3, 2);
            subscribersPage.Size = new Size(1678, 708);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(52, 72, 100);
            label5.Location = new Point(1587, 135);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 26;
            label5.Text = "50\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 72, 100);
            label4.Location = new Point(1587, 108);
            label4.Name = "label4";
            label4.Size = new Size(41, 18);
            label4.TabIndex = 25;
            label4.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(111, 130, 157);
            label3.Location = new Point(1538, 135);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 24;
            label3.Text = "Due: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(111, 130, 157);
            label2.Location = new Point(1442, 108);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 23;
            label2.Text = "Total Subscribers: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 118;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 29;
            materialComboBox1.Location = new Point(175, 109);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MaximumSize = new Size(200, 0);
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 35);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 21;
            materialComboBox1.UseTallSize = false;
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // customMaterialButton12
            // 
            customMaterialButton12.AutoSize = false;
            customMaterialButton12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton12.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton12.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton12.BorderRadius = 8;
            customMaterialButton12.BorderSize = 2;
            customMaterialButton12.BottomRightRadius = 0;
            customMaterialButton12.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton12.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton12.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton12.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton12.Depth = 0;
            customMaterialButton12.DrawShadows = false;
            customMaterialButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton12.FlatStyle = FlatStyle.Popup;
            customMaterialButton12.HighEmphasis = true;
            customMaterialButton12.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton12.Icon = null;
            customMaterialButton12.Location = new Point(30, 26);
            customMaterialButton12.Margin = new Padding(4);
            customMaterialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton12.Name = "customMaterialButton12";
            customMaterialButton12.NoAccentTextColor = Color.Empty;
            customMaterialButton12.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton12.Size = new Size(153, 59);
            customMaterialButton12.TabIndex = 20;
            customMaterialButton12.Text = "All";
            customMaterialButton12.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton12.TopRightRadius = 0;
            customMaterialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton12.UseAccentColor = false;
            customMaterialButton12.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton11
            // 
            customMaterialButton11.AutoSize = false;
            customMaterialButton11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton11.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton11.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton11.BorderRadius = 8;
            customMaterialButton11.BorderSize = 2;
            customMaterialButton11.BottomRightRadius = 0;
            customMaterialButton11.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton11.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton11.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton11.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton11.Depth = 0;
            customMaterialButton11.DrawShadows = false;
            customMaterialButton11.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton11.FlatStyle = FlatStyle.Popup;
            customMaterialButton11.HighEmphasis = true;
            customMaterialButton11.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton11.Icon = null;
            customMaterialButton11.Location = new Point(175, 26);
            customMaterialButton11.Margin = new Padding(4);
            customMaterialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton11.Name = "customMaterialButton11";
            customMaterialButton11.NoAccentTextColor = Color.Empty;
            customMaterialButton11.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton11.Size = new Size(153, 59);
            customMaterialButton11.TabIndex = 19;
            customMaterialButton11.Text = "Anahawon";
            customMaterialButton11.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton11.TopRightRadius = 0;
            customMaterialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton11.UseAccentColor = false;
            customMaterialButton11.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton10
            // 
            customMaterialButton10.AutoSize = false;
            customMaterialButton10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton10.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton10.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton10.BorderRadius = 8;
            customMaterialButton10.BorderSize = 2;
            customMaterialButton10.BottomRightRadius = 0;
            customMaterialButton10.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton10.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton10.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton10.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton10.Depth = 0;
            customMaterialButton10.DrawShadows = false;
            customMaterialButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton10.FlatStyle = FlatStyle.Popup;
            customMaterialButton10.HighEmphasis = true;
            customMaterialButton10.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton10.Icon = null;
            customMaterialButton10.Location = new Point(320, 26);
            customMaterialButton10.Margin = new Padding(4);
            customMaterialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton10.Name = "customMaterialButton10";
            customMaterialButton10.NoAccentTextColor = Color.Empty;
            customMaterialButton10.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton10.Size = new Size(153, 59);
            customMaterialButton10.TabIndex = 18;
            customMaterialButton10.Text = "Base Camp";
            customMaterialButton10.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton10.TopRightRadius = 0;
            customMaterialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton10.UseAccentColor = false;
            customMaterialButton10.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton9
            // 
            customMaterialButton9.AutoSize = false;
            customMaterialButton9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton9.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton9.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton9.BorderRadius = 8;
            customMaterialButton9.BorderSize = 2;
            customMaterialButton9.BottomRightRadius = 0;
            customMaterialButton9.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton9.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton9.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton9.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton9.Depth = 0;
            customMaterialButton9.DrawShadows = false;
            customMaterialButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton9.FlatStyle = FlatStyle.Popup;
            customMaterialButton9.HighEmphasis = true;
            customMaterialButton9.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton9.Icon = null;
            customMaterialButton9.Location = new Point(465, 26);
            customMaterialButton9.Margin = new Padding(4);
            customMaterialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton9.Name = "customMaterialButton9";
            customMaterialButton9.NoAccentTextColor = Color.Empty;
            customMaterialButton9.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton9.Size = new Size(153, 59);
            customMaterialButton9.TabIndex = 17;
            customMaterialButton9.Text = "Camp 1";
            customMaterialButton9.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton9.TopRightRadius = 0;
            customMaterialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton9.UseAccentColor = false;
            customMaterialButton9.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton8
            // 
            customMaterialButton8.AutoSize = false;
            customMaterialButton8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton8.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton8.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton8.BorderRadius = 8;
            customMaterialButton8.BorderSize = 2;
            customMaterialButton8.BottomRightRadius = 0;
            customMaterialButton8.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton8.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton8.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton8.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton8.Depth = 0;
            customMaterialButton8.DrawShadows = false;
            customMaterialButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton8.FlatStyle = FlatStyle.Popup;
            customMaterialButton8.HighEmphasis = true;
            customMaterialButton8.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton8.Icon = null;
            customMaterialButton8.Location = new Point(610, 26);
            customMaterialButton8.Margin = new Padding(4);
            customMaterialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton8.Name = "customMaterialButton8";
            customMaterialButton8.NoAccentTextColor = Color.Empty;
            customMaterialButton8.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton8.Size = new Size(153, 59);
            customMaterialButton8.TabIndex = 16;
            customMaterialButton8.Text = "Colambugon";
            customMaterialButton8.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton8.TopRightRadius = 0;
            customMaterialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton8.UseAccentColor = false;
            customMaterialButton8.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton7
            // 
            customMaterialButton7.AutoSize = false;
            customMaterialButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton7.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton7.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton7.BorderRadius = 8;
            customMaterialButton7.BorderSize = 2;
            customMaterialButton7.BottomRightRadius = 0;
            customMaterialButton7.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton7.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton7.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton7.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton7.Depth = 0;
            customMaterialButton7.DrawShadows = false;
            customMaterialButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton7.FlatStyle = FlatStyle.Popup;
            customMaterialButton7.HighEmphasis = true;
            customMaterialButton7.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton7.Icon = null;
            customMaterialButton7.Location = new Point(755, 26);
            customMaterialButton7.Margin = new Padding(4);
            customMaterialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton7.Name = "customMaterialButton7";
            customMaterialButton7.NoAccentTextColor = Color.Empty;
            customMaterialButton7.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton7.Size = new Size(153, 59);
            customMaterialButton7.TabIndex = 15;
            customMaterialButton7.Text = "Danggawan";
            customMaterialButton7.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton7.TopRightRadius = 0;
            customMaterialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton7.UseAccentColor = false;
            customMaterialButton7.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton6
            // 
            customMaterialButton6.AutoSize = false;
            customMaterialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton6.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton6.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton6.BorderRadius = 8;
            customMaterialButton6.BorderSize = 2;
            customMaterialButton6.BottomRightRadius = 0;
            customMaterialButton6.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton6.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton6.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton6.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton6.Depth = 0;
            customMaterialButton6.DrawShadows = false;
            customMaterialButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton6.FlatStyle = FlatStyle.Popup;
            customMaterialButton6.HighEmphasis = true;
            customMaterialButton6.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton6.Icon = null;
            customMaterialButton6.Location = new Point(900, 26);
            customMaterialButton6.Margin = new Padding(4);
            customMaterialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton6.Name = "customMaterialButton6";
            customMaterialButton6.NoAccentTextColor = Color.Empty;
            customMaterialButton6.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton6.Size = new Size(153, 59);
            customMaterialButton6.TabIndex = 14;
            customMaterialButton6.Text = "Dologon";
            customMaterialButton6.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton6.TopRightRadius = 0;
            customMaterialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton6.UseAccentColor = false;
            customMaterialButton6.UseVisualStyleBackColor = true;
            customMaterialButton6.Click += customMaterialButton6_Click;
            // 
            // customMaterialButton5
            // 
            customMaterialButton5.AutoSize = false;
            customMaterialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton5.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton5.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton5.BorderRadius = 8;
            customMaterialButton5.BorderSize = 2;
            customMaterialButton5.BottomRightRadius = 0;
            customMaterialButton5.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton5.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton5.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton5.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton5.Depth = 0;
            customMaterialButton5.DrawShadows = false;
            customMaterialButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton5.FlatStyle = FlatStyle.Popup;
            customMaterialButton5.HighEmphasis = true;
            customMaterialButton5.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton5.Icon = null;
            customMaterialButton5.Location = new Point(1045, 26);
            customMaterialButton5.Margin = new Padding(4);
            customMaterialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton5.Name = "customMaterialButton5";
            customMaterialButton5.NoAccentTextColor = Color.Empty;
            customMaterialButton5.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton5.Size = new Size(153, 59);
            customMaterialButton5.TabIndex = 13;
            customMaterialButton5.Text = "North Pob.";
            customMaterialButton5.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton5.TopRightRadius = 0;
            customMaterialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton5.UseAccentColor = false;
            customMaterialButton5.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton4
            // 
            customMaterialButton4.AutoSize = false;
            customMaterialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton4.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton4.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton4.BorderRadius = 8;
            customMaterialButton4.BorderSize = 2;
            customMaterialButton4.BottomRightRadius = 0;
            customMaterialButton4.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton4.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton4.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton4.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton4.Depth = 0;
            customMaterialButton4.DrawShadows = false;
            customMaterialButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton4.FlatStyle = FlatStyle.Popup;
            customMaterialButton4.HighEmphasis = true;
            customMaterialButton4.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton4.Icon = null;
            customMaterialButton4.Location = new Point(1190, 26);
            customMaterialButton4.Margin = new Padding(4);
            customMaterialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton4.Name = "customMaterialButton4";
            customMaterialButton4.NoAccentTextColor = Color.Empty;
            customMaterialButton4.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton4.Size = new Size(153, 59);
            customMaterialButton4.TabIndex = 12;
            customMaterialButton4.Text = "Panadtalan";
            customMaterialButton4.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton4.TopRightRadius = 0;
            customMaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton4.UseAccentColor = false;
            customMaterialButton4.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton3
            // 
            customMaterialButton3.AutoSize = false;
            customMaterialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton3.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton3.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton3.BorderRadius = 8;
            customMaterialButton3.BorderSize = 2;
            customMaterialButton3.BottomRightRadius = 0;
            customMaterialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton3.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton3.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton3.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton3.Depth = 0;
            customMaterialButton3.DrawShadows = false;
            customMaterialButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton3.FlatStyle = FlatStyle.Popup;
            customMaterialButton3.HighEmphasis = true;
            customMaterialButton3.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton3.Icon = null;
            customMaterialButton3.Location = new Point(1335, 26);
            customMaterialButton3.Margin = new Padding(4);
            customMaterialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton3.Name = "customMaterialButton3";
            customMaterialButton3.NoAccentTextColor = Color.Empty;
            customMaterialButton3.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton3.Size = new Size(153, 59);
            customMaterialButton3.TabIndex = 11;
            customMaterialButton3.Text = "San Miguel";
            customMaterialButton3.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton3.TopRightRadius = 0;
            customMaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton3.UseAccentColor = false;
            customMaterialButton3.UseVisualStyleBackColor = true;
            // 
            // customMaterialButton2
            // 
            customMaterialButton2.AutoSize = false;
            customMaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton2.BackgroundColor = Color.FromArgb(255, 255, 252);
            customMaterialButton2.BorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton2.BorderRadius = 8;
            customMaterialButton2.BorderSize = 2;
            customMaterialButton2.BottomRightRadius = 8;
            customMaterialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            customMaterialButton2.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            customMaterialButton2.ClickedTextColor = Color.FromArgb(52, 72, 100);
            customMaterialButton2.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            customMaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton2.Depth = 0;
            customMaterialButton2.DrawShadows = false;
            customMaterialButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton2.FlatStyle = FlatStyle.Popup;
            customMaterialButton2.HighEmphasis = true;
            customMaterialButton2.HoverBackColor = Color.FromArgb(237, 237, 237);
            customMaterialButton2.Icon = null;
            customMaterialButton2.Location = new Point(1480, 26);
            customMaterialButton2.Margin = new Padding(4);
            customMaterialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton2.Name = "customMaterialButton2";
            customMaterialButton2.NoAccentTextColor = Color.Empty;
            customMaterialButton2.RightBorderColor = Color.FromArgb(212, 208, 208);
            customMaterialButton2.Size = new Size(153, 59);
            customMaterialButton2.TabIndex = 10;
            customMaterialButton2.Text = "South Pob.";
            customMaterialButton2.TextColor = Color.FromArgb(166, 166, 166);
            customMaterialButton2.TopRightRadius = 8;
            customMaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton2.UseAccentColor = false;
            customMaterialButton2.UseVisualStyleBackColor = true;
            // 
            // disconnectedbtn
            // 
            disconnectedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            disconnectedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            disconnectedbtn.Depth = 0;
            disconnectedbtn.HighEmphasis = true;
            disconnectedbtn.Icon = null;
            disconnectedbtn.Location = new Point(397, 108);
            disconnectedbtn.Margin = new Padding(4);
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
            label1.Font = new Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 101);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
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
            connectedsubscribersGridView.DataSource = connectedSubscribersBindingSource;
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
            connectedsubscribersGridView.Location = new Point(30, 135);
            connectedsubscribersGridView.Margin = new Padding(3, 2, 3, 2);
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
            connectedsubscribersGridView.Size = new Size(1604, 498);
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
            // connectedSubscriberViewBindingSource
            // 
            connectedSubscriberViewBindingSource.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(303, 108);
            addBtn.Margin = new Padding(4);
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
            billingPage.Location = new Point(4, 24);
            billingPage.Margin = new Padding(3, 2, 3, 2);
            billingPage.Name = "billingPage";
            billingPage.Size = new Size(1678, 708);
            billingPage.TabIndex = 2;
            billingPage.Text = "Billing";
            billingPage.UseVisualStyleBackColor = true;
            // 
            // transactionsPage
            // 
            transactionsPage.Location = new Point(4, 24);
            transactionsPage.Margin = new Padding(3, 2, 3, 2);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Size = new Size(1678, 708);
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            transactionsPage.UseVisualStyleBackColor = true;
            // 
            // accountsPage
            // 
            accountsPage.Location = new Point(4, 24);
            accountsPage.Margin = new Padding(3, 2, 3, 2);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1678, 708);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            accountsPage.UseVisualStyleBackColor = true;
            // 
            // activitiesPage
            // 
            activitiesPage.Location = new Point(4, 24);
            activitiesPage.Margin = new Padding(3, 2, 3, 2);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1678, 708);
            activitiesPage.TabIndex = 5;
            activitiesPage.Text = "Activities";
            activitiesPage.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = true;
            materialTextBox1.BackColor = Color.FromArgb(255, 255, 252);
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.ForeColor = Color.FromArgb(166, 166, 166);
            materialTextBox1.Hint = "Search...";
            materialTextBox1.LeadingIcon = Properties.Resources.search;
            materialTextBox1.Location = new Point(31, 40);
            materialTextBox1.Margin = new Padding(6, 3, 3, 3);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(308, 50);
            materialTextBox1.TabIndex = 22;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ProfilePic.png");
            imageList1.Images.SetKeyName(1, "5.png");
            imageList1.Images.SetKeyName(2, "ProfileMenu.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1420, 40);
            pictureBox1.MaximumSize = new Size(50, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica Rounded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(52, 72, 100);
            label6.Location = new Point(1476, 52);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 2;
            label6.Text = "Luisa P. Cipriano";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Helvetica Rounded", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(111, 130, 157);
            label7.Location = new Point(1473, 68);
            label7.Name = "label7";
            label7.Size = new Size(127, 13);
            label7.TabIndex = 3;
            label7.Text = " System Administrator";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.ProfileMenu;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1606, 50);
            button1.Name = "button1";
            button1.Size = new Size(25, 31);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // connectedSubscriberViewBindingSource1
            // 
            connectedSubscriberViewBindingSource1.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1680, 810);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(materialTextBox1);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerTabControl = materialTabControl1;
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 24, 3, 2);
            Text = "Form1";
            Load += SubscribersForm_Load;
            materialTabControl1.ResumeLayout(false);
            subscribersPage.ResumeLayout(false);
            subscribersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton disconnectedbtn;
        private Label label1;
        public DataGridView connectedsubscribersGridView;
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
        private MaterialSkin.Controls.MaterialButton addBtn;
        public Modified_Tools.CustomMaterialButton customMaterialButton2;
        public Modified_Tools.CustomMaterialButton customMaterialButton4;
        public Modified_Tools.CustomMaterialButton customMaterialButton3;
        public Modified_Tools.CustomMaterialButton customMaterialButton6;
        public Modified_Tools.CustomMaterialButton customMaterialButton5;
        public Modified_Tools.CustomMaterialButton customMaterialButton10;
        public Modified_Tools.CustomMaterialButton customMaterialButton9;
        public Modified_Tools.CustomMaterialButton customMaterialButton8;
        public Modified_Tools.CustomMaterialButton customMaterialButton7;
        public Modified_Tools.CustomMaterialButton customMaterialButton12;
        public Modified_Tools.CustomMaterialButton customMaterialButton11;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}
