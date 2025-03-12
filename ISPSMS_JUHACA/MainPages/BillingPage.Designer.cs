namespace ISPSMS_JUHACA.MainPages
{
    partial class BillingPage
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
            billingFlowPanel = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            billingFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // billingFlowPanel
            // 
            billingFlowPanel.AutoScroll = true;
            billingFlowPanel.BackColor = Color.FromArgb(241, 240, 233);
            billingFlowPanel.Controls.Add(kryptonLabel1);
            billingFlowPanel.ForeColor = Color.FromArgb(241, 240, 233);
            billingFlowPanel.Location = new Point(107, 90);
            billingFlowPanel.Margin = new Padding(0);
            billingFlowPanel.Name = "billingFlowPanel";
            billingFlowPanel.Size = new Size(1796, 880);
            billingFlowPanel.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(6, 2);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonBorderEdge1);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1906, 973);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateDisabled.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateDisabled.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(137, 73);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1743, 1);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(142, 138, 138);
            kryptonBorderEdge1.StateCommon.Color2 = Color.FromArgb(142, 138, 138);
            kryptonBorderEdge1.StateCommon.Width = 1;
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(129, 32);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(323, 34);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(52, 72, 100);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(52, 72, 100);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "BILLING AND DUE DATES";
            // 
            // BillingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1906, 973);
            ControlBox = false;
            Controls.Add(billingFlowPanel);
            Controls.Add(kryptonPanel1);
            ForeColor = Color.FromArgb(241, 240, 233);
            Name = "BillingPage";
            Text = "BillingPage";
            Load += BillingPage_Load;
            billingFlowPanel.ResumeLayout(false);
            billingFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel billingFlowPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}