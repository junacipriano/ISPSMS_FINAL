using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using Domain.Models;

namespace ISPSMS_JUHACA.Views.toPrintData
{
    internal class SubscribersPrintDocs
    {
        private PrintDocument printDocument = new PrintDocument();
        private List<ConnectedSubscribers> _subscribersToPrint;
        private int _printIndex = 0;

        public SubscribersPrintDocs(List<ConnectedSubscribers> subscribersToPrint)
        {
            _subscribersToPrint = subscribersToPrint;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private static string FormatDate(DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("MM/dd/yyyy") : string.Empty;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int marginTop = 50;
            int marginLeft = 43;
            int rowHeight = 30;
            int y = marginTop;
            int x = marginLeft;
            int maxWidth = e.MarginBounds.Width;
            int maxHeight = e.MarginBounds.Height;

            Font titleFont = new Font("Arial", 12, FontStyle.Regular);
            Font titleFont2 = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 8, FontStyle.Bold);
            Font rowFont = new Font("Arial", 8);

            Brush brush = Brushes.Black;
            Pen borderPen = new Pen(Color.Black, 1);

            // === Print Title Centered ===
            string title = "PC INTERNET SHOP";
            string address = "P-2 North Poblacion, Maramag, Bukidnon";
            string dateText = "As of " + DateTime.Now.ToString("MMMM dd, yyyy");

            float centerX;
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            SizeF addressSize = e.Graphics.MeasureString(address, titleFont);
            SizeF dateSize = e.Graphics.MeasureString(dateText, titleFont);

            centerX = e.MarginBounds.Left + (e.MarginBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(title, titleFont, brush, centerX, y);
            y += 30;

            centerX = e.MarginBounds.Left + (e.MarginBounds.Width - addressSize.Width) / 2;
            e.Graphics.DrawString(address, titleFont, brush, centerX, y);
            y += 20;

            centerX = e.MarginBounds.Left + (e.MarginBounds.Width - dateSize.Width) / 2;
            e.Graphics.DrawString(dateText, titleFont, brush, centerX, y);
            y += 40;

            // === Subscribers Data Title ===
            string subscribersTitle = "SUBSCRIBERS DATA";
            SizeF subscribersTitleSize = e.Graphics.MeasureString(subscribersTitle, titleFont2);
            centerX = e.MarginBounds.Left + (e.MarginBounds.Width - subscribersTitleSize.Width) / 2;
            e.Graphics.DrawString(subscribersTitle, titleFont2, brush, centerX, y);
            y += 40;

            // === Table Header ===
            string[] headers = { "ID #", "NAME", "PHONE #", "ADDRESS", "PLAN", "STATUS", "DUEDATE", "INSTALL DATE", "CHARGE" };
            int[] columnWidths = { 40, 150, 80, 160, 60, 50, 60, 90, 70 };

            int columnX = x;
            int tableTop = y;

            for (int i = 0; i < headers.Length; i++)
            {
                Rectangle headerRect = new Rectangle(columnX, y, columnWidths[i], rowHeight);
                e.Graphics.FillRectangle(Brushes.LightGray, headerRect);
                e.Graphics.DrawRectangle(borderPen, headerRect);

                // Center header text
                SizeF textSize = e.Graphics.MeasureString(headers[i], headerFont);
                float textX = columnX + (columnWidths[i] - textSize.Width) / 2;
                float textY = y + (rowHeight - textSize.Height) / 2;
                e.Graphics.DrawString(headers[i], headerFont, brush, textX, textY);

                columnX += columnWidths[i];
            }
            y += rowHeight;

            // === Calculate Rows Per Page ===
            int availableHeight = 1000 - (y - marginTop);
            int rowsThatFit = availableHeight / rowHeight;

            // === Print Table Rows ===
            int printedRows = 0;
            for (; printedRows < rowsThatFit && _printIndex < _subscribersToPrint.Count; _printIndex++, printedRows++)
            {
                columnX = x;
                var subscriber = _subscribersToPrint[_printIndex];

                string[] rowData = {
                    subscriber.subs_id.ToString(),
                    subscriber.Conn_Name,
                    subscriber.ContactNumber,
                    subscriber.Address,
                    subscriber.Plan,
                    subscriber.Status,
                    subscriber.Duedate,
                    FormatDate(subscriber.InstallationDate),
                    subscriber.MonthlyCharge.ToString()
                };

                for (int j = 0; j < rowData.Length; j++)
                {
                    Rectangle cellRect = new Rectangle(columnX, y, columnWidths[j], rowHeight);
                    e.Graphics.DrawRectangle(borderPen, cellRect);

                    // Center row text
                    SizeF textSize = e.Graphics.MeasureString(rowData[j], rowFont);
                    float textX = columnX + (columnWidths[j] - textSize.Width) / 2;
                    float textY = y + (rowHeight - textSize.Height) / 2;
                    e.Graphics.DrawString(rowData[j], rowFont, brush, textX, textY);

                    columnX += columnWidths[j];
                }
                y += rowHeight;
            }

            // === Fill Empty Space on Last Page ===
            while (printedRows < rowsThatFit)
            {
                columnX = x;
                for (int j = 0; j < headers.Length; j++)
                {
                    e.Graphics.DrawRectangle(borderPen, columnX, y, columnWidths[j], rowHeight);
                    columnX += columnWidths[j];
                }
                y += rowHeight;
                printedRows++;
            }

            // === Determine if More Pages Needed ===
            e.HasMorePages = _printIndex < _subscribersToPrint.Count;
        }

        public void Print()
        {
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument;
                preview.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                preview.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }
    }
}
