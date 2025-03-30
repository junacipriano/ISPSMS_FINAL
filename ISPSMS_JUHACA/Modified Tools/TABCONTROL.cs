using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Modified_Tools
{
    internal class TABCONTROL : MaterialTabControl
    {
        public TABCONTROL()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(120, 40); // Adjust tab size
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Parent != null)
            {
                Parent.Paint += (s, ev) => this.Invalidate(); // Force repainting
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle tabBounds = GetTabRect(e.Index);
            TabPage tabPage = TabPages[e.Index];

            Color defaultTabColor = Color.FromArgb(255, 254, 250);
            Color selectedTabColor = Color.FromArgb(94, 167, 178);
            Color defaultTextColor = Color.FromArgb(94, 167, 178);
            Color selectedTextColor = Color.FromArgb(255, 254, 250);

            bool isSelected = (e.Index == this.SelectedIndex);
            Color tabColor = isSelected ? selectedTabColor : defaultTabColor;
            Color textColor = isSelected ? selectedTextColor : defaultTextColor;

            tabBounds.Inflate(-2, -2);

            using (SolidBrush brush = new SolidBrush(tabColor))
            {
                g.FillRectangle(brush, tabBounds);
            }

            TextRenderer.DrawText(
                g,
                tabPage.Text,
                this.Font,
                tabBounds,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
