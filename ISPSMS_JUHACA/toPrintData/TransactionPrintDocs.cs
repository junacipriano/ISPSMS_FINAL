using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using Domain.Models;

namespace ISPSMS_JUHACA.toPrintData
{
    internal class TransactionPrintDocs
    {
        private PrintDocument printDocument = new PrintDocument();
        private List<Transactions> _transactionsToPrint;
        private int _printIndex = 0;
        private DateTime _selectedDate;

        public TransactionPrintDocs(List<Transactions> transactionsToPrint, DateTime selectedDate)
        {
            _transactionsToPrint = transactionsToPrint;
            _selectedDate = selectedDate;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int marginTop = 50;
            int marginLeft = 75;
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
            string dateText = "Date: " + _selectedDate.ToString("MMMM dd, yyyy");

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
            string[] headers = { "TRANS. #", "NAME", "AMOUNT", "BALANCE", "NOTE", "DUEDATE", "DATE & TIME" };
            int[] columnWidths = { 60, 220, 70, 70, 70, 60, 150 };

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
            for (; printedRows < rowsThatFit && _printIndex < _transactionsToPrint.Count; _printIndex++, printedRows++)
            {
                columnX = x;
                var transaction = _transactionsToPrint[_printIndex];

                string[] rowData = {
                    transaction.trans_id.ToString(),
                    transaction.Trans_Name,
                    transaction.PaidAmount.ToString(),
                    transaction.Balance.ToString(),
                    transaction.Note,
                    transaction.Duedate,
                    transaction.TransactionDateTime.ToString()
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
            e.HasMorePages = _printIndex < _transactionsToPrint.Count;
        }

        public void Print()
        {
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument;
                preview.StartPosition = FormStartPosition.CenterScreen;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }
    }
}
