using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Modified_Tools
{
    public class BUTTON : Button
    {
        public int CornerRadius { get; set; } = 15;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Create a rounded rectangle path
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                // Draw the background
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                // Draw the text
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    pevent.Graphics.DrawString(this.Text, this.Font, Brushes.White, ClientRectangle, sf);
                }
            }
        } 
    }
}
