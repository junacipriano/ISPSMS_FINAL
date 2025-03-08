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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // billingFlowPanel
            // 
            billingFlowPanel.AutoScroll = true;
            billingFlowPanel.BackColor = Color.FromArgb(241, 240, 233);
            billingFlowPanel.ForeColor = Color.FromArgb(241, 240, 233);
            billingFlowPanel.Location = new Point(75, 64);
            billingFlowPanel.Margin = new Padding(0);
            billingFlowPanel.Name = "billingFlowPanel";
            billingFlowPanel.Size = new Size(1812, 867);
            billingFlowPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(-2, -2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1896, 942);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(241, 240, 233);
            kryptonPanel1.TabIndex = 1;
            // 
            // BillingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 240, 233);
            ClientSize = new Size(1890, 934);
            ControlBox = false;
            Controls.Add(billingFlowPanel);
            Controls.Add(kryptonPanel1);
            Name = "BillingPage";
            Text = "BillingPage";
            Load += BillingPage_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel billingFlowPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}