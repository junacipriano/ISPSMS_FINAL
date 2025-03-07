using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.Modified_Tools
{
    public class CustomMaterialButton : MaterialButton
    {
        public int BorderRadius { get; set; } = 5;
        public int TopRightRadius { get; set; } = 0;
        public int BottomRightRadius { get; set; } = 0;
        public Color BorderColor { get; set; } = Color.FromArgb(166, 166, 166);
        public int BorderSize { get; set; } = 3;
        public Color TextColor { get; set; } = Color.FromArgb(166, 166, 166);
        public Font CustomFont { get; set; } = new Font("Arial", 10, FontStyle.Bold);
        public Color BackgroundColor { get; set; } = Color.FromArgb(255, 255, 252);
        public Color ClickedTextColor { get; set; } = Color.FromArgb(52, 72, 100);
        public Color ClickedBorderColor { get; set; } = Color.FromArgb(225, 111, 74); // Orange border (for bottom)
        public Color RightBorderColor { get; set; } = Color.FromArgb(255, 255, 252); // Separate right border color
        public Color HoverBackColor { get; set; } = Color.FromArgb(237, 237, 237);

        private static CustomMaterialButton activeButton = null;
        private bool isHovered = false;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (activeButton != null && activeButton != this)
            {
                activeButton.ResetAppearance();
            }

            activeButton = this;
            Invalidate();
        }

        private void ResetAppearance()
        {
            this.isHovered = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bool isActive = activeButton == this;
            Color currentTextColor = isActive ? ClickedTextColor : TextColor;
            Color currentBorderColor = isActive ? ClickedBorderColor : BorderColor;
            Color backgroundColor = isHovered ? HoverBackColor : BackgroundColor;

            Rectangle rect = new Rectangle(BorderSize, BorderSize, ClientRectangle.Width - BorderSize, ClientRectangle.Height - BorderSize);

            using (GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, BorderRadius, TopRightRadius, BottomRightRadius))
            {
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                using (Pen borderPen = new Pen(BorderColor, BorderSize))
                {
                    pevent.Graphics.DrawPath(borderPen, path);
                }

                // Lower Border (Only orange when active)
                using (Pen lowerBorderPen = new Pen(isActive ? ClickedBorderColor : BorderColor, BorderSize))
                {
                    PointF startPoint = new PointF(rect.Left - BorderRadius, rect.Bottom - BorderSize / 2f);
                    PointF endPoint = new PointF(rect.Right + TopRightRadius, rect.Bottom - BorderSize / 2f);
                    pevent.Graphics.DrawLine(lowerBorderPen, startPoint, endPoint);
                }

                // Right Border (Always RightBorderColor)
                using (Pen rightBorderPen = new Pen(RightBorderColor, BorderSize))
                {
                    float rightX = rect.Right - BorderSize / 3;
                    float topY = rect.Top - BorderSize / 2f;
                    float bottomY = rect.Bottom - BorderSize / 2f;
                    pevent.Graphics.DrawLine(rightBorderPen, new PointF(rightX, topY), new PointF(rightX, bottomY));
                }

                this.Region = new Region(path);
            }

            using (SolidBrush textBrush = new SolidBrush(currentTextColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                pevent.Graphics.DrawString(this.Text, CustomFont, textBrush, this.ClientRectangle, sf);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int leftRadius, int topRightRadius, int bottomRightRadius)
        {
            GraphicsPath path = new GraphicsPath();

            int leftDiameter = leftRadius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(leftDiameter, leftDiameter));
            path.AddArc(arcRect, 180, 90);

            if (topRightRadius > 0)
            {
                path.AddLine(rect.Left + leftRadius, rect.Top, rect.Right - topRightRadius, rect.Top);
                arcRect = new Rectangle(rect.Right - (topRightRadius * 2), rect.Top, topRightRadius * 2, topRightRadius * 2);
                path.AddArc(arcRect, 270, 90);
            }
            else
            {
                path.AddLine(rect.Left + leftRadius, rect.Top, rect.Right, rect.Top);
            }

            path.AddLine(rect.Right, rect.Top + (topRightRadius > 0 ? topRightRadius : 0), rect.Right, rect.Bottom - (bottomRightRadius > 0 ? bottomRightRadius : 0));

            if (bottomRightRadius > 0)
            {
                arcRect = new Rectangle(rect.Right - (bottomRightRadius * 2), rect.Bottom - (bottomRightRadius * 2), bottomRightRadius * 2, bottomRightRadius * 2);
                path.AddArc(arcRect, 0, 90);
                path.AddLine(rect.Right - bottomRightRadius, rect.Bottom, rect.Left + leftRadius, rect.Bottom);
            }
            else
            {
                path.AddLine(rect.Right, rect.Bottom, rect.Left + leftRadius, rect.Bottom);
            }

            arcRect = new Rectangle(rect.Left, rect.Bottom - leftDiameter, leftDiameter, leftDiameter);
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }
    }
}
