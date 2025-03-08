using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Modified_Tools
{
    internal class CustomWinForm : Control
    {
        public CustomWinForm()
        {
            // Set default properties
            this.Dock = DockStyle.Fill; // Fill the entire parent container
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int cornerRadius = 20; // Adjust the corner radius as needed

            using (GraphicsPath path = new GraphicsPath())
            {
                // Create a rounded rectangle
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
                path.AddArc(this.ClientSize.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right corner
                path.AddArc(this.ClientSize.Width - cornerRadius, this.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
                path.AddArc(0, this.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Fill the rounded rectangle with the background color
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redraw the control when resized
        }
    }
}