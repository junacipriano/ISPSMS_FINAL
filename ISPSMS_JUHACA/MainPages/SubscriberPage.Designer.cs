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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriberPage));
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
            label1 = new Label();
            connectedSubscribersBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            connectedSubscriberViewBindingSource1 = new BindingSource(components);
            addBtn = new MaterialSkin.Controls.MaterialButton();
            AddButton = new Krypton.Toolkit.KryptonButton();
            Previous = new Krypton.Toolkit.KryptonButton();
            Next = new Krypton.Toolkit.KryptonButton();
            connectedsubscribersGridView = new Krypton.Toolkit.KryptonDataGridView();
            kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn2 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn3 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn4 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn5 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn6 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn7 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn9 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonDataGridViewTextBoxColumn12 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            editButton = new DataGridViewButtonColumn();
            disconnectButton = new DataGridViewButtonColumn();
            bgPanel = new Krypton.Toolkit.KryptonTextBox();
            disconnectedbtn = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            exportSubsBtn = new Krypton.Toolkit.KryptonButton();
            transPrintBtn = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            SuspendLayout();
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
            materialComboBox1.Location = new Point(451, 104);
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
            allBtn.Location = new Point(175, 32);
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
            anahawonBtn.Location = new Point(321, 32);
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
            baseCampBtn.Location = new Point(474, 32);
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
            camp1Btn.Location = new Point(621, 32);
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
            colambugonBtn.Location = new Point(773, 32);
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
            danggawanBtn.Location = new Point(922, 32);
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
            dologonBtn.Location = new Point(1075, 32);
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
            northPobBtn.Location = new Point(1227, 32);
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
            panadtalanBtn.Location = new Point(1381, 32);
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
            sanMiguelBtn.Location = new Point(1533, 32);
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
            southPobBtn.Location = new Point(1687, 32);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            label1.ForeColor = Color.FromArgb(52, 72, 100);
            label1.Location = new Point(175, 104);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 29;
            label1.Text = "ALL SUBSCRIBERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
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
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(54, -18);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(75, 36);
            addBtn.TabIndex = 0;
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(598, 101);
            AddButton.Name = "AddButton";
            AddButton.OverrideDefault.Back.Color1 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideDefault.Back.Color2 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideDefault.Border.Color1 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideDefault.Border.Color2 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideFocus.Back.Color1 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideFocus.Back.Color2 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideFocus.Border.Color1 = Color.FromArgb(82, 147, 157);
            AddButton.OverrideFocus.Border.Color2 = Color.FromArgb(82, 147, 157);
            AddButton.Size = new Size(96, 40);
            AddButton.StateCommon.Back.Color1 = Color.FromArgb(94, 167, 178);
            AddButton.StateCommon.Back.Color2 = Color.FromArgb(94, 167, 178);
            AddButton.StateCommon.Border.Color1 = Color.FromArgb(94, 167, 178);
            AddButton.StateCommon.Border.Color2 = Color.FromArgb(94, 167, 178);
            AddButton.StateCommon.Border.Rounding = 5F;
            AddButton.StateCommon.Content.ShortText.Color1 = Color.FromArgb(241, 240, 233);
            AddButton.StateCommon.Content.ShortText.Color2 = Color.FromArgb(241, 240, 233);
            AddButton.StateCommon.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.TabIndex = 47;
            AddButton.Values.DropDownArrowColor = Color.Empty;
            AddButton.Values.Text = "Add New";
            AddButton.Click += AddButton_Click;
            // 
            // Previous
            // 
            Previous.Location = new Point(1728, 774);
            Previous.Name = "Previous";
            Previous.Size = new Size(25, 25);
            Previous.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            Previous.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            Previous.StateCommon.Back.Image = (Image)resources.GetObject("Previous.StateCommon.Back.Image");
            Previous.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            Previous.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            Previous.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            Previous.TabIndex = 48;
            Previous.TabStop = false;
            Previous.ToolTipValues.ImageTransparentColor = Color.FromArgb(255, 255, 252);
            Previous.Values.DropDownArrowColor = Color.Empty;
            Previous.Values.Text = "";
            Previous.Click += Previous_Click;
            // 
            // Next
            // 
            Next.Location = new Point(1799, 775);
            Next.Name = "Next";
            Next.OverrideDefault.Back.Color1 = Color.FromArgb(255, 255, 252);
            Next.OverrideDefault.Back.Color2 = Color.FromArgb(255, 255, 252);
            Next.OverrideDefault.Border.Color1 = Color.FromArgb(255, 255, 252);
            Next.OverrideFocus.Back.Color1 = Color.FromArgb(255, 255, 252);
            Next.OverrideFocus.Back.Color2 = Color.FromArgb(255, 255, 252);
            Next.OverrideFocus.Border.Color1 = Color.FromArgb(255, 255, 252);
            Next.OverrideFocus.Border.Color2 = Color.FromArgb(255, 255, 252);
            Next.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            Next.Size = new Size(25, 25);
            Next.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            Next.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            Next.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            Next.StateCommon.Back.Image = (Image)resources.GetObject("Next.StateCommon.Back.Image");
            Next.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            Next.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            Next.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            Next.TabIndex = 49;
            Next.TabStop = false;
            Next.ToolTipValues.ImageTransparentColor = Color.FromArgb(255, 255, 252);
            Next.Values.DropDownArrowColor = Color.Empty;
            Next.Values.Text = "";
            Next.Click += Next_Click;
            // 
            // connectedsubscribersGridView
            // 
            connectedsubscribersGridView.AutoGenerateColumns = false;
            connectedsubscribersGridView.BorderStyle = BorderStyle.None;
            connectedsubscribersGridView.ColumnHeadersHeight = 30;
            connectedsubscribersGridView.Columns.AddRange(new DataGridViewColumn[] { kryptonDataGridViewTextBoxColumn1, kryptonDataGridViewTextBoxColumn2, kryptonDataGridViewTextBoxColumn3, kryptonDataGridViewTextBoxColumn4, kryptonDataGridViewTextBoxColumn5, kryptonDataGridViewTextBoxColumn6, kryptonDataGridViewTextBoxColumn7, kryptonDataGridViewTextBoxColumn9, kryptonDataGridViewTextBoxColumn12, editButton, disconnectButton });
            connectedsubscribersGridView.DataSource = connectedSubscribersBindingSource;
            connectedsubscribersGridView.Location = new Point(189, 170);
            connectedsubscribersGridView.Name = "connectedsubscribersGridView";
            connectedsubscribersGridView.RowHeadersVisible = false;
            connectedsubscribersGridView.RowHeadersWidth = 50;
            connectedsubscribersGridView.Size = new Size(1645, 589);
            connectedsubscribersGridView.StateCommon.Background.Color1 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            connectedsubscribersGridView.StateCommon.DataCell.Back.Color1 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.DataCell.Back.Color2 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.DataCell.Border.Color1 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.DataCell.Border.Color2 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(255, 255, 252);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(166, 166, 166);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Content.Color2 = Color.FromArgb(166, 166, 166);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Content.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connectedsubscribersGridView.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            connectedsubscribersGridView.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            connectedsubscribersGridView.StateCommon.HeaderRow.Border.Rounding = 20F;
            connectedsubscribersGridView.TabIndex = 52;
            connectedsubscribersGridView.TabStop = false;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            kryptonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn1.DataPropertyName = "subs_id";
            kryptonDataGridViewTextBoxColumn1.HeaderText = "Id No.";
            kryptonDataGridViewTextBoxColumn1.MinimumWidth = 80;
            kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            kryptonDataGridViewTextBoxColumn1.Width = 80;
            // 
            // kryptonDataGridViewTextBoxColumn2
            // 
            kryptonDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn2.DataPropertyName = "Conn_Name";
            kryptonDataGridViewTextBoxColumn2.HeaderText = "Name";
            kryptonDataGridViewTextBoxColumn2.MinimumWidth = 300;
            kryptonDataGridViewTextBoxColumn2.Name = "kryptonDataGridViewTextBoxColumn2";
            kryptonDataGridViewTextBoxColumn2.Width = 300;
            // 
            // kryptonDataGridViewTextBoxColumn3
            // 
            kryptonDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn3.DataPropertyName = "ContactNumber";
            kryptonDataGridViewTextBoxColumn3.HeaderText = "Phone No.";
            kryptonDataGridViewTextBoxColumn3.MinimumWidth = 150;
            kryptonDataGridViewTextBoxColumn3.Name = "kryptonDataGridViewTextBoxColumn3";
            kryptonDataGridViewTextBoxColumn3.Width = 150;
            // 
            // kryptonDataGridViewTextBoxColumn4
            // 
            kryptonDataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn4.DataPropertyName = "Address";
            kryptonDataGridViewTextBoxColumn4.HeaderText = "Address";
            kryptonDataGridViewTextBoxColumn4.MinimumWidth = 300;
            kryptonDataGridViewTextBoxColumn4.Name = "kryptonDataGridViewTextBoxColumn4";
            kryptonDataGridViewTextBoxColumn4.Width = 300;
            // 
            // kryptonDataGridViewTextBoxColumn5
            // 
            kryptonDataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn5.DataPropertyName = "Plan";
            kryptonDataGridViewTextBoxColumn5.HeaderText = "Plan";
            kryptonDataGridViewTextBoxColumn5.MinimumWidth = 150;
            kryptonDataGridViewTextBoxColumn5.Name = "kryptonDataGridViewTextBoxColumn5";
            kryptonDataGridViewTextBoxColumn5.Width = 150;
            // 
            // kryptonDataGridViewTextBoxColumn6
            // 
            kryptonDataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn6.DataPropertyName = "Status";
            kryptonDataGridViewTextBoxColumn6.HeaderText = "Status";
            kryptonDataGridViewTextBoxColumn6.MinimumWidth = 180;
            kryptonDataGridViewTextBoxColumn6.Name = "kryptonDataGridViewTextBoxColumn6";
            kryptonDataGridViewTextBoxColumn6.Width = 180;
            // 
            // kryptonDataGridViewTextBoxColumn7
            // 
            kryptonDataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn7.DataPropertyName = "Duedate";
            kryptonDataGridViewTextBoxColumn7.HeaderText = "Duedate";
            kryptonDataGridViewTextBoxColumn7.MinimumWidth = 100;
            kryptonDataGridViewTextBoxColumn7.Name = "kryptonDataGridViewTextBoxColumn7";
            // 
            // kryptonDataGridViewTextBoxColumn9
            // 
            kryptonDataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn9.DataPropertyName = "InstallationDate";
            kryptonDataGridViewTextBoxColumn9.HeaderText = "Installation Date";
            kryptonDataGridViewTextBoxColumn9.MinimumWidth = 150;
            kryptonDataGridViewTextBoxColumn9.Name = "kryptonDataGridViewTextBoxColumn9";
            kryptonDataGridViewTextBoxColumn9.Width = 150;
            // 
            // kryptonDataGridViewTextBoxColumn12
            // 
            kryptonDataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            kryptonDataGridViewTextBoxColumn12.DataPropertyName = "MonthlyCharge";
            kryptonDataGridViewTextBoxColumn12.HeaderText = "Charge";
            kryptonDataGridViewTextBoxColumn12.MinimumWidth = 120;
            kryptonDataGridViewTextBoxColumn12.Name = "kryptonDataGridViewTextBoxColumn12";
            kryptonDataGridViewTextBoxColumn12.Width = 120;
            // 
            // editButton
            // 
            editButton.DataPropertyName = "subs_id";
            editButton.HeaderText = "";
            editButton.MinimumWidth = 50;
            editButton.Name = "editButton";
            editButton.Width = 50;
            // 
            // disconnectButton
            // 
            disconnectButton.DataPropertyName = "subs_id";
            disconnectButton.HeaderText = "";
            disconnectButton.MinimumWidth = 50;
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Width = 50;
            // 
            // bgPanel
            // 
            bgPanel.AccessibleRole = AccessibleRole.None;
            bgPanel.AlwaysActive = false;
            bgPanel.Location = new Point(175, 154);
            bgPanel.MaximumSize = new Size(1674, 663);
            bgPanel.MinimumSize = new Size(1674, 620);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1674, 620);
            bgPanel.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            bgPanel.StateCommon.Border.Rounding = 15F;
            bgPanel.TabIndex = 53;
            bgPanel.TextChanged += bgPanel_TextChanged;
            // 
            // disconnectedbtn
            // 
            disconnectedbtn.Location = new Point(710, 101);
            disconnectedbtn.Name = "disconnectedbtn";
            disconnectedbtn.OverrideDefault.Back.Color1 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideDefault.Back.Color2 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideDefault.Border.Color1 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideDefault.Border.Color2 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideFocus.Back.Color1 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideFocus.Back.Color2 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideFocus.Border.Color1 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.OverrideFocus.Border.Color2 = Color.FromArgb(234, 98, 38);
            disconnectedbtn.Size = new Size(120, 40);
            disconnectedbtn.StateCommon.Back.Color1 = Color.FromArgb(248, 132, 86);
            disconnectedbtn.StateCommon.Back.Color2 = Color.FromArgb(248, 132, 86);
            disconnectedbtn.StateCommon.Border.Color1 = Color.FromArgb(248, 132, 86);
            disconnectedbtn.StateCommon.Border.Color2 = Color.FromArgb(248, 132, 86);
            disconnectedbtn.StateCommon.Border.Rounding = 5F;
            disconnectedbtn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(241, 240, 233);
            disconnectedbtn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(241, 240, 233);
            disconnectedbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disconnectedbtn.TabIndex = 54;
            disconnectedbtn.Values.DropDownArrowColor = Color.Empty;
            disconnectedbtn.Values.Text = "Disconnected";
            disconnectedbtn.Click += disconnectedbtn_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(175, 764);
            kryptonTextBox1.MinimumSize = new Size(1674, 50);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(1674, 50);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            kryptonTextBox1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 15F;
            kryptonTextBox1.StateCommon.Border.Width = 1;
            kryptonTextBox1.TabIndex = 55;
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // exportSubsBtn
            // 
            exportSubsBtn.Location = new Point(1711, 109);
            exportSubsBtn.Margin = new Padding(5);
            exportSubsBtn.Name = "exportSubsBtn";
            exportSubsBtn.Size = new Size(42, 37);
            exportSubsBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            exportSubsBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            exportSubsBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            exportSubsBtn.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            exportSubsBtn.StateCommon.Border.Color2 = Color.FromArgb(255, 255, 252);
            exportSubsBtn.StateCommon.Content.LongText.Image = (Image)resources.GetObject("exportSubsBtn.StateCommon.Content.LongText.Image");
            exportSubsBtn.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            exportSubsBtn.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            exportSubsBtn.TabIndex = 51;
            exportSubsBtn.Values.DropDownArrowColor = Color.Empty;
            exportSubsBtn.Values.ImageStates.ImageCheckedNormal = null;
            exportSubsBtn.Values.ImageStates.ImageCheckedPressed = null;
            exportSubsBtn.Values.ImageStates.ImageCheckedTracking = null;
            exportSubsBtn.Values.ImageStates.ImageNormal = (Image)resources.GetObject("exportSubsBtn.Values.ImageStates.ImageNormal");
            exportSubsBtn.Values.Text = "Export ";
            exportSubsBtn.Click += exportSubsBtn_Click;
            // 
            // transPrintBtn
            // 
            transPrintBtn.Location = new Point(1583, 101);
            transPrintBtn.Name = "transPrintBtn";
            transPrintBtn.Size = new Size(35, 30);
            transPrintBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 255, 252);
            transPrintBtn.StateCommon.Back.Image = (Image)resources.GetObject("transPrintBtn.StateCommon.Back.Image");
            transPrintBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            transPrintBtn.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            transPrintBtn.TabIndex = 50;
            transPrintBtn.Values.DropDownArrowColor = Color.Empty;
            transPrintBtn.Values.Text = "";
            transPrintBtn.Click += transPrintBtn_Click;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(1455, 774);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(113, 24);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox2.StateCommon.Content.Color1 = Color.FromArgb(52, 72, 100);
            kryptonTextBox2.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F);
            kryptonTextBox2.TabIndex = 57;
            kryptonTextBox2.Text = "Rows per page: 30";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new Point(1615, 774);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(113, 24);
            kryptonTextBox3.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox3.StateCommon.Border.Color1 = Color.FromArgb(255, 255, 252);
            kryptonTextBox3.StateCommon.Content.Color1 = Color.FromArgb(52, 72, 100);
            kryptonTextBox3.StateCommon.Content.Font = new Font("Franklin Gothic Medium", 9.75F);
            kryptonTextBox3.TabIndex = 58;
            kryptonTextBox3.Text = "1 -10 of 999";
            // 
            // SubscriberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1926, 847);
            ControlBox = false;
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(connectedsubscribersGridView);
            Controls.Add(disconnectedbtn);
            Controls.Add(exportSubsBtn);
            Controls.Add(transPrintBtn);
            Controls.Add(Next);
            Controls.Add(Previous);
            Controls.Add(AddButton);
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
            Controls.Add(label1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(bgPanel);
            Name = "SubscriberPage";
            Padding = new Padding(3, 0, 3, 3);
            ShowInTaskbar = false;
            Load += SubscriberPage_Load;
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscriberViewBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private BindingSource connectedSubscriberViewBindingSource;
        public Modified_Tools.CustomMaterialButton allBtn;
        public Modified_Tools.CustomMaterialButton anahawonBtn;
        public Modified_Tools.CustomMaterialButton baseCampBtn;
        public Modified_Tools.CustomMaterialButton camp1;
        public Modified_Tools.CustomMaterialButton camp1Btn;
        private BindingSource connectedSubscriberViewBindingSource1;
        private BindingSource bindingSource1;
        private BindingSource connectedSubscribersBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Krypton.Toolkit.KryptonButton AddButton;
        private Krypton.Toolkit.KryptonButton previousPageButton;
        private Krypton.Toolkit.KryptonButton nextPageButton;
        private Krypton.Toolkit.KryptonButton Previous;
        private Krypton.Toolkit.KryptonButton Next;
        private Krypton.Toolkit.KryptonDataGridView connectedsubscribersGridView;
        private Krypton.Toolkit.KryptonTextBox bgPanel;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn2;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn3;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn4;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn5;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn6;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn7;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn9;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn12;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn disconnectButton;
        private Krypton.Toolkit.KryptonButton disconnectedbtn;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton exportSubsBtn;
        private Krypton.Toolkit.KryptonButton transPrintBtn;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
    }
}