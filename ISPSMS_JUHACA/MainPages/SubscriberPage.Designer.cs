namespace ISPSMS_JUHACA.MainPages
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

        #region Windows Form Designer generated code

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label5 = new Label();
            TotalSubscriberLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            allBtn = new Modified_Tools.CustomMaterialButton();
            anahawonBtn = new Modified_Tools.CustomMaterialButton();
            baseCampBtn = new Modified_Tools.CustomMaterialButton();
            camp1Btn = new Modified_Tools.CustomMaterialButton();
            colambugonBtn = new Modified_Tools.CustomMaterialButton();
            danggawanBtn = new Modified_Tools.CustomMaterialButton();
            dologonBtn = new Modified_Tools.CustomMaterialButton();
            northPobBtn = new Modified_Tools.CustomMaterialButton();
            panadtalanBtn = new Modified_Tools.CustomMaterialButton();
            sanMiguelBtn = new Modified_Tools.CustomMaterialButton();
            southPobBtn = new Modified_Tools.CustomMaterialButton();
            disconnectedbtn = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            connectedsubscribersGridView = new DataGridView();
            Conn_Name = new DataGridViewTextBoxColumn();
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
            connectedSubscribersBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            addBtn = new MaterialSkin.Controls.MaterialButton();
            AddButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(52, 72, 100);
            label5.Location = new Point(1807, 109);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 46;
            label5.Text = "50\r\n";
            // 
            // TotalSubscriberLabel
            // 
            TotalSubscriberLabel.AutoSize = true;
            TotalSubscriberLabel.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalSubscriberLabel.ForeColor = Color.FromArgb(52, 72, 100);
            TotalSubscriberLabel.Location = new Point(1804, 89);
            TotalSubscriberLabel.Name = "TotalSubscriberLabel";
            TotalSubscriberLabel.Size = new Size(41, 18);
            TotalSubscriberLabel.TabIndex = 45;
            TotalSubscriberLabel.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(111, 130, 157);
            label3.Location = new Point(1758, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 44;
            label3.Text = "Due: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Rounded", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(111, 130, 157);
            label2.Location = new Point(1659, 89);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 43;
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
            materialComboBox1.Items.AddRange(new object[] { "All", "Active", "Past due", "Overdue" });
            materialComboBox1.Location = new Point(418, 94);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MaximumSize = new Size(200, 0);
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 35);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 42;
            materialComboBox1.UseTallSize = false;
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // allBtn
            // 
            allBtn.AutoSize = false;
            allBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            allBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            allBtn.BorderColor = Color.FromArgb(212, 208, 208);
            allBtn.BorderRadius = 8;
            allBtn.BorderSize = 2;
            allBtn.BottomRightRadius = 0;
            allBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            allBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            allBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            allBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            allBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            allBtn.Depth = 0;
            allBtn.DrawShadows = false;
            allBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            allBtn.FlatStyle = FlatStyle.Popup;
            allBtn.HighEmphasis = true;
            allBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            allBtn.Icon = null;
            allBtn.Location = new Point(174, 22);
            allBtn.Margin = new Padding(4);
            allBtn.MouseState = MaterialSkin.MouseState.HOVER;
            allBtn.Name = "allBtn";
            allBtn.NoAccentTextColor = Color.Empty;
            allBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            allBtn.Size = new Size(162, 59);
            allBtn.TabIndex = 41;
            allBtn.Text = "All";
            allBtn.TextColor = Color.FromArgb(166, 166, 166);
            allBtn.TopRightRadius = 0;
            allBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            allBtn.UseAccentColor = false;
            allBtn.UseVisualStyleBackColor = true;
            allBtn.Click += allBtn_Click;
            // 
            // anahawonBtn
            // 
            anahawonBtn.AutoSize = false;
            anahawonBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            anahawonBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            anahawonBtn.BorderColor = Color.FromArgb(212, 208, 208);
            anahawonBtn.BorderRadius = 8;
            anahawonBtn.BorderSize = 2;
            anahawonBtn.BottomRightRadius = 0;
            anahawonBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            anahawonBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            anahawonBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            anahawonBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            anahawonBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            anahawonBtn.Depth = 0;
            anahawonBtn.DrawShadows = false;
            anahawonBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            anahawonBtn.FlatStyle = FlatStyle.Popup;
            anahawonBtn.HighEmphasis = true;
            anahawonBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            anahawonBtn.Icon = null;
            anahawonBtn.Location = new Point(320, 22);
            anahawonBtn.Margin = new Padding(4);
            anahawonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            anahawonBtn.Name = "anahawonBtn";
            anahawonBtn.NoAccentTextColor = Color.Empty;
            anahawonBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            anahawonBtn.Size = new Size(162, 59);
            anahawonBtn.TabIndex = 40;
            anahawonBtn.Text = "Anahawon";
            anahawonBtn.TextColor = Color.FromArgb(166, 166, 166);
            anahawonBtn.TopRightRadius = 0;
            anahawonBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            anahawonBtn.UseAccentColor = false;
            anahawonBtn.UseVisualStyleBackColor = true;
            anahawonBtn.Click += anahawonBtn_Click;
            // 
            // baseCampBtn
            // 
            baseCampBtn.AutoSize = false;
            baseCampBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            baseCampBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            baseCampBtn.BorderColor = Color.FromArgb(212, 208, 208);
            baseCampBtn.BorderRadius = 8;
            baseCampBtn.BorderSize = 2;
            baseCampBtn.BottomRightRadius = 0;
            baseCampBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            baseCampBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            baseCampBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            baseCampBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            baseCampBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            baseCampBtn.Depth = 0;
            baseCampBtn.DrawShadows = false;
            baseCampBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            baseCampBtn.FlatStyle = FlatStyle.Popup;
            baseCampBtn.HighEmphasis = true;
            baseCampBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            baseCampBtn.Icon = null;
            baseCampBtn.Location = new Point(473, 22);
            baseCampBtn.Margin = new Padding(4);
            baseCampBtn.MouseState = MaterialSkin.MouseState.HOVER;
            baseCampBtn.Name = "baseCampBtn";
            baseCampBtn.NoAccentTextColor = Color.Empty;
            baseCampBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            baseCampBtn.Size = new Size(162, 59);
            baseCampBtn.TabIndex = 39;
            baseCampBtn.Text = "Base Camp";
            baseCampBtn.TextColor = Color.FromArgb(166, 166, 166);
            baseCampBtn.TopRightRadius = 0;
            baseCampBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            baseCampBtn.UseAccentColor = false;
            baseCampBtn.UseVisualStyleBackColor = true;
            baseCampBtn.Click += baseCampBtn_Click;
            // 
            // camp1Btn
            // 
            camp1Btn.AutoSize = false;
            camp1Btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            camp1Btn.BackgroundColor = Color.FromArgb(255, 255, 252);
            camp1Btn.BorderColor = Color.FromArgb(212, 208, 208);
            camp1Btn.BorderRadius = 8;
            camp1Btn.BorderSize = 2;
            camp1Btn.BottomRightRadius = 0;
            camp1Btn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            camp1Btn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            camp1Btn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            camp1Btn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            camp1Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            camp1Btn.Depth = 0;
            camp1Btn.DrawShadows = false;
            camp1Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            camp1Btn.FlatStyle = FlatStyle.Popup;
            camp1Btn.HighEmphasis = true;
            camp1Btn.HoverBackColor = Color.FromArgb(237, 237, 237);
            camp1Btn.Icon = null;
            camp1Btn.Location = new Point(620, 22);
            camp1Btn.Margin = new Padding(4);
            camp1Btn.MouseState = MaterialSkin.MouseState.HOVER;
            camp1Btn.Name = "camp1Btn";
            camp1Btn.NoAccentTextColor = Color.Empty;
            camp1Btn.RightBorderColor = Color.FromArgb(212, 208, 208);
            camp1Btn.Size = new Size(162, 59);
            camp1Btn.TabIndex = 38;
            camp1Btn.Text = "Camp 1";
            camp1Btn.TextColor = Color.FromArgb(166, 166, 166);
            camp1Btn.TopRightRadius = 0;
            camp1Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            camp1Btn.UseAccentColor = false;
            camp1Btn.UseVisualStyleBackColor = true;
            camp1Btn.Click += camp1Btn_Click;
            // 
            // colambugonBtn
            // 
            colambugonBtn.AutoSize = false;
            colambugonBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            colambugonBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            colambugonBtn.BorderColor = Color.FromArgb(212, 208, 208);
            colambugonBtn.BorderRadius = 8;
            colambugonBtn.BorderSize = 2;
            colambugonBtn.BottomRightRadius = 0;
            colambugonBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            colambugonBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            colambugonBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            colambugonBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            colambugonBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            colambugonBtn.Depth = 0;
            colambugonBtn.DrawShadows = false;
            colambugonBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            colambugonBtn.FlatStyle = FlatStyle.Popup;
            colambugonBtn.HighEmphasis = true;
            colambugonBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            colambugonBtn.Icon = null;
            colambugonBtn.Location = new Point(772, 22);
            colambugonBtn.Margin = new Padding(4);
            colambugonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            colambugonBtn.Name = "colambugonBtn";
            colambugonBtn.NoAccentTextColor = Color.Empty;
            colambugonBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            colambugonBtn.Size = new Size(162, 59);
            colambugonBtn.TabIndex = 37;
            colambugonBtn.Text = "Colambugon";
            colambugonBtn.TextColor = Color.FromArgb(166, 166, 166);
            colambugonBtn.TopRightRadius = 0;
            colambugonBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            colambugonBtn.UseAccentColor = false;
            colambugonBtn.UseVisualStyleBackColor = true;
            colambugonBtn.Click += colambugonBtn_Click;
            // 
            // danggawanBtn
            // 
            danggawanBtn.AutoSize = false;
            danggawanBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            danggawanBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            danggawanBtn.BorderColor = Color.FromArgb(212, 208, 208);
            danggawanBtn.BorderRadius = 8;
            danggawanBtn.BorderSize = 2;
            danggawanBtn.BottomRightRadius = 0;
            danggawanBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            danggawanBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            danggawanBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            danggawanBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            danggawanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            danggawanBtn.Depth = 0;
            danggawanBtn.DrawShadows = false;
            danggawanBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            danggawanBtn.FlatStyle = FlatStyle.Popup;
            danggawanBtn.HighEmphasis = true;
            danggawanBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            danggawanBtn.Icon = null;
            danggawanBtn.Location = new Point(921, 22);
            danggawanBtn.Margin = new Padding(4);
            danggawanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            danggawanBtn.Name = "danggawanBtn";
            danggawanBtn.NoAccentTextColor = Color.Empty;
            danggawanBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            danggawanBtn.Size = new Size(162, 59);
            danggawanBtn.TabIndex = 36;
            danggawanBtn.Text = "Danggawan";
            danggawanBtn.TextColor = Color.FromArgb(166, 166, 166);
            danggawanBtn.TopRightRadius = 0;
            danggawanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            danggawanBtn.UseAccentColor = false;
            danggawanBtn.UseVisualStyleBackColor = true;
            danggawanBtn.Click += danggawanBtn_Click;
            // 
            // dologonBtn
            // 
            dologonBtn.AutoSize = false;
            dologonBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dologonBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            dologonBtn.BorderColor = Color.FromArgb(212, 208, 208);
            dologonBtn.BorderRadius = 8;
            dologonBtn.BorderSize = 2;
            dologonBtn.BottomRightRadius = 0;
            dologonBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            dologonBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            dologonBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            dologonBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            dologonBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            dologonBtn.Depth = 0;
            dologonBtn.DrawShadows = false;
            dologonBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            dologonBtn.FlatStyle = FlatStyle.Popup;
            dologonBtn.HighEmphasis = true;
            dologonBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            dologonBtn.Icon = null;
            dologonBtn.Location = new Point(1074, 22);
            dologonBtn.Margin = new Padding(4);
            dologonBtn.MouseState = MaterialSkin.MouseState.HOVER;
            dologonBtn.Name = "dologonBtn";
            dologonBtn.NoAccentTextColor = Color.Empty;
            dologonBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            dologonBtn.Size = new Size(162, 59);
            dologonBtn.TabIndex = 35;
            dologonBtn.Text = "Dologon";
            dologonBtn.TextColor = Color.FromArgb(166, 166, 166);
            dologonBtn.TopRightRadius = 0;
            dologonBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            dologonBtn.UseAccentColor = false;
            dologonBtn.UseVisualStyleBackColor = true;
            dologonBtn.Click += dologonBtn_Click;
            // 
            // northPobBtn
            // 
            northPobBtn.AutoSize = false;
            northPobBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            northPobBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            northPobBtn.BorderColor = Color.FromArgb(212, 208, 208);
            northPobBtn.BorderRadius = 8;
            northPobBtn.BorderSize = 2;
            northPobBtn.BottomRightRadius = 0;
            northPobBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            northPobBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            northPobBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            northPobBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            northPobBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            northPobBtn.Depth = 0;
            northPobBtn.DrawShadows = false;
            northPobBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            northPobBtn.FlatStyle = FlatStyle.Popup;
            northPobBtn.HighEmphasis = true;
            northPobBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            northPobBtn.Icon = null;
            northPobBtn.Location = new Point(1226, 22);
            northPobBtn.Margin = new Padding(4);
            northPobBtn.MouseState = MaterialSkin.MouseState.HOVER;
            northPobBtn.Name = "northPobBtn";
            northPobBtn.NoAccentTextColor = Color.Empty;
            northPobBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            northPobBtn.Size = new Size(162, 59);
            northPobBtn.TabIndex = 34;
            northPobBtn.Text = "North Pob.";
            northPobBtn.TextColor = Color.FromArgb(166, 166, 166);
            northPobBtn.TopRightRadius = 0;
            northPobBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            northPobBtn.UseAccentColor = false;
            northPobBtn.UseVisualStyleBackColor = true;
            northPobBtn.Click += northPobBtn_Click;
            // 
            // panadtalanBtn
            // 
            panadtalanBtn.AutoSize = false;
            panadtalanBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panadtalanBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            panadtalanBtn.BorderColor = Color.FromArgb(212, 208, 208);
            panadtalanBtn.BorderRadius = 8;
            panadtalanBtn.BorderSize = 2;
            panadtalanBtn.BottomRightRadius = 0;
            panadtalanBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            panadtalanBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            panadtalanBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            panadtalanBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            panadtalanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            panadtalanBtn.Depth = 0;
            panadtalanBtn.DrawShadows = false;
            panadtalanBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            panadtalanBtn.FlatStyle = FlatStyle.Popup;
            panadtalanBtn.HighEmphasis = true;
            panadtalanBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            panadtalanBtn.Icon = null;
            panadtalanBtn.Location = new Point(1380, 22);
            panadtalanBtn.Margin = new Padding(4);
            panadtalanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            panadtalanBtn.Name = "panadtalanBtn";
            panadtalanBtn.NoAccentTextColor = Color.Empty;
            panadtalanBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            panadtalanBtn.Size = new Size(162, 59);
            panadtalanBtn.TabIndex = 33;
            panadtalanBtn.Text = "Panadtalan";
            panadtalanBtn.TextColor = Color.FromArgb(166, 166, 166);
            panadtalanBtn.TopRightRadius = 0;
            panadtalanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            panadtalanBtn.UseAccentColor = false;
            panadtalanBtn.UseVisualStyleBackColor = true;
            panadtalanBtn.Click += panadtalanBtn_Click;
            // 
            // sanMiguelBtn
            // 
            sanMiguelBtn.AutoSize = false;
            sanMiguelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sanMiguelBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            sanMiguelBtn.BorderColor = Color.FromArgb(212, 208, 208);
            sanMiguelBtn.BorderRadius = 8;
            sanMiguelBtn.BorderSize = 2;
            sanMiguelBtn.BottomRightRadius = 0;
            sanMiguelBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            sanMiguelBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            sanMiguelBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            sanMiguelBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            sanMiguelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sanMiguelBtn.Depth = 0;
            sanMiguelBtn.DrawShadows = false;
            sanMiguelBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            sanMiguelBtn.FlatStyle = FlatStyle.Popup;
            sanMiguelBtn.HighEmphasis = true;
            sanMiguelBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            sanMiguelBtn.Icon = null;
            sanMiguelBtn.Location = new Point(1532, 22);
            sanMiguelBtn.Margin = new Padding(4);
            sanMiguelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            sanMiguelBtn.Name = "sanMiguelBtn";
            sanMiguelBtn.NoAccentTextColor = Color.Empty;
            sanMiguelBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            sanMiguelBtn.Size = new Size(162, 59);
            sanMiguelBtn.TabIndex = 32;
            sanMiguelBtn.Text = "San Miguel";
            sanMiguelBtn.TextColor = Color.FromArgb(166, 166, 166);
            sanMiguelBtn.TopRightRadius = 0;
            sanMiguelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sanMiguelBtn.UseAccentColor = false;
            sanMiguelBtn.UseVisualStyleBackColor = true;
            sanMiguelBtn.Click += sanMiguelBtn_Click;
            // 
            // southPobBtn
            // 
            southPobBtn.AutoSize = false;
            southPobBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            southPobBtn.BackgroundColor = Color.FromArgb(255, 255, 252);
            southPobBtn.BorderColor = Color.FromArgb(212, 208, 208);
            southPobBtn.BorderRadius = 8;
            southPobBtn.BorderSize = 2;
            southPobBtn.BottomRightRadius = 8;
            southPobBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            southPobBtn.ClickedBorderColor = Color.FromArgb(225, 111, 74);
            southPobBtn.ClickedTextColor = Color.FromArgb(52, 72, 100);
            southPobBtn.CustomFont = new Font("Arial", 10F, FontStyle.Bold);
            southPobBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            southPobBtn.Depth = 0;
            southPobBtn.DrawShadows = false;
            southPobBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 237);
            southPobBtn.FlatStyle = FlatStyle.Popup;
            southPobBtn.HighEmphasis = true;
            southPobBtn.HoverBackColor = Color.FromArgb(237, 237, 237);
            southPobBtn.Icon = null;
            southPobBtn.Location = new Point(1686, 22);
            southPobBtn.Margin = new Padding(4);
            southPobBtn.MouseState = MaterialSkin.MouseState.HOVER;
            southPobBtn.Name = "southPobBtn";
            southPobBtn.NoAccentTextColor = Color.Empty;
            southPobBtn.RightBorderColor = Color.FromArgb(212, 208, 208);
            southPobBtn.Size = new Size(162, 59);
            southPobBtn.TabIndex = 31;
            southPobBtn.Text = "South Pob.";
            southPobBtn.TextColor = Color.FromArgb(166, 166, 166);
            southPobBtn.TopRightRadius = 8;
            southPobBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            southPobBtn.UseAccentColor = false;
            southPobBtn.UseVisualStyleBackColor = true;
            southPobBtn.Click += southPobBtn_Click;
            // 
            // disconnectedbtn
            // 
            disconnectedbtn.AutoSize = false;
            disconnectedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            disconnectedbtn.BackColor = Color.FromArgb(248, 132, 86);
            disconnectedbtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            disconnectedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            disconnectedbtn.Depth = 0;
            disconnectedbtn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            disconnectedbtn.ForeColor = Color.FromArgb(255, 255, 252);
            disconnectedbtn.HighEmphasis = true;
            disconnectedbtn.Icon = null;
            disconnectedbtn.Location = new Point(788, 89);
            disconnectedbtn.Margin = new Padding(4);
            disconnectedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            disconnectedbtn.Name = "disconnectedbtn";
            disconnectedbtn.NoAccentTextColor = Color.Empty;
            disconnectedbtn.Size = new Size(130, 36);
            disconnectedbtn.TabIndex = 30;
            disconnectedbtn.Text = "disconnected";
            disconnectedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            disconnectedbtn.UseAccentColor = false;
            disconnectedbtn.UseVisualStyleBackColor = false;
            disconnectedbtn.Click += disconnectedbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            label1.ForeColor = Color.FromArgb(52, 72, 100);
            label1.Location = new Point(169, 89);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 29;
            label1.Text = "ALL SUBSCRIBERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
            // 
            // connectedsubscribersGridView
            // 
            connectedsubscribersGridView.AllowUserToOrderColumns = true;
            connectedsubscribersGridView.AllowUserToResizeColumns = false;
            connectedsubscribersGridView.AllowUserToResizeRows = false;
            connectedsubscribersGridView.AutoGenerateColumns = false;
            connectedsubscribersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connectedsubscribersGridView.BackgroundColor = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.BorderStyle = BorderStyle.None;
            connectedsubscribersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            connectedsubscribersGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 252);
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(166, 166, 166);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(212, 208, 208);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            connectedsubscribersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            connectedsubscribersGridView.ColumnHeadersHeight = 50;
            connectedsubscribersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            connectedsubscribersGridView.Columns.AddRange(new DataGridViewColumn[] { Conn_Name, subsidDataGridViewTextBoxColumn, connNameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, planDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, installationDateDataGridViewTextBoxColumn, monthlyChargeDataGridViewTextBoxColumn, editButton, disconnectButton });
            connectedsubscribersGridView.DataSource = connectedSubscribersBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 252);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 72, 100);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 242, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(166, 166, 166);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            connectedsubscribersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            connectedsubscribersGridView.EnableHeadersVisualStyles = false;
            connectedsubscribersGridView.GridColor = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.ImeMode = ImeMode.NoControl;
            connectedsubscribersGridView.Location = new Point(174, 132);
            connectedsubscribersGridView.Margin = new Padding(3, 2, 3, 2);
            connectedsubscribersGridView.Name = "connectedsubscribersGridView";
            connectedsubscribersGridView.RightToLeft = RightToLeft.No;
            connectedsubscribersGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 252);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(166, 166, 166);
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 219, 199);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            connectedsubscribersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            connectedsubscribersGridView.RowHeadersWidth = 51;
            connectedsubscribersGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 252);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(52, 72, 100);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(242, 242, 242);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(225, 111, 74);
            connectedsubscribersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            connectedsubscribersGridView.ScrollBars = ScrollBars.Vertical;
            connectedsubscribersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            connectedsubscribersGridView.Size = new Size(1674, 803);
            connectedsubscribersGridView.TabIndex = 28;
            connectedsubscribersGridView.CellContentClick += connectedsubscribersGridView_CellContentClick;
            // 
            // Conn_Name
            // 
            Conn_Name.DataPropertyName = "Conn_Name";
            Conn_Name.HeaderText = "NAME";
            Conn_Name.MinimumWidth = 6;
            Conn_Name.Name = "Conn_Name";
            // 
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            subsidDataGridViewTextBoxColumn.HeaderText = "subs_id";
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            // 
            // connNameDataGridViewTextBoxColumn
            // 
            connNameDataGridViewTextBoxColumn.DataPropertyName = "Conn_Name";
            connNameDataGridViewTextBoxColumn.HeaderText = "Conn_Name";
            connNameDataGridViewTextBoxColumn.Name = "connNameDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // planDataGridViewTextBoxColumn
            // 
            planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            planDataGridViewTextBoxColumn.HeaderText = "Plan";
            planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.HeaderText = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge";
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
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // connectedSubscriberViewBindingSource1
            // 
            connectedSubscriberViewBindingSource1.DataSource = typeof(Domain.ViewModels.ConnectedSubscriberView);
            // 
            // addBtn
            // 
            // 
            // AddButton
            // 
            AddButton.Location = new Point(591, 100);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(90, 25);
            AddButton.TabIndex = 47;
            AddButton.Values.DropDownArrowColor = Color.Empty;
            AddButton.Values.Text = "kryptonButton1";
            AddButton.Click += AddButton_Click;
            // 
            // SubscriberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 949);
            Controls.Add(AddButton);
            Controls.Add(label5);
            Controls.Add(TotalSubscriberLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(materialComboBox1);
            Controls.Add(allBtn);
            Controls.Add(anahawonBtn);
            Controls.Add(baseCampBtn);
            Controls.Add(camp1Btn);
            Controls.Add(colambugonBtn);
            Controls.Add(danggawanBtn);
            Controls.Add(dologonBtn);
            Controls.Add(northPobBtn);
            Controls.Add(panadtalanBtn);
            Controls.Add(sanMiguelBtn);
            Controls.Add(southPobBtn);
            Controls.Add(disconnectedbtn);
            Controls.Add(label1);
            Controls.Add(connectedsubscribersGridView);
            Name = "SubscriberPage";
            Padding = new Padding(3, 0, 3, 3);
            Text = "SubscriberPage";
            Load += SubscriberPage_Load;
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label TotalSubscriberLabel;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        public Modified_Tools.CustomMaterialButton customMaterialButton12;
        public Modified_Tools.CustomMaterialButton customMaterialButton11;
        public Modified_Tools.CustomMaterialButton customMaterialButton10;
        public Modified_Tools.CustomMaterialButton customMaterialButton9;
        public Modified_Tools.CustomMaterialButton colambugonBtn;
        public Modified_Tools.CustomMaterialButton danggawanBtn;
        public Modified_Tools.CustomMaterialButton dologonBtn;
        public Modified_Tools.CustomMaterialButton northPobBtn;
        public Modified_Tools.CustomMaterialButton panadtalanBtn;
        public Modified_Tools.CustomMaterialButton sanMiguelBtn;
        public Modified_Tools.CustomMaterialButton southPobBtn;
        private MaterialSkin.Controls.MaterialButton disconnectedbtn;
        private Label label1;
        public DataGridView connectedsubscribersGridView;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private BindingSource connectedSubscriberViewBindingSource;
        public Modified_Tools.CustomMaterialButton allBtn;
        public Modified_Tools.CustomMaterialButton anahawonBtn;
        public Modified_Tools.CustomMaterialButton baseCampBtn;
        public Modified_Tools.CustomMaterialButton camp1;
        public Modified_Tools.CustomMaterialButton camp1Btn;
        private BindingSource connectedSubscriberViewBindingSource1;
        private DataGridViewTextBoxColumn Conn_Name;
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
        private BindingSource bindingSource1;
        private BindingSource connectedSubscribersBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Krypton.Toolkit.KryptonButton AddButton;
    }
}