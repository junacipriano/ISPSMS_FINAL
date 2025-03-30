using Infastructure.Data.Repositories.IRepositories;
using MaterialSkin;
using MaterialSkin.Controls;
using Domain.Models;
using ISPSMS_JUHACA.Views;
using System.Collections.Generic;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.Views.IVews;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Krypton.Toolkit;
using System.Linq;
using System.Data;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System.Windows.Media.TextFormatting;
using System.Drawing.Drawing2D;
using ISPSMS_JUHACA.toPrintData;
namespace ISPSMS_JUHACA.MainPages
{
    public partial class SubscriberPage : MaterialForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        internal bool isEdit;
        private MainForm mainForm;
        private MaterialButton activeButton;
        public readonly string _currentUsername;
        public readonly string _currentUserRole;
        private DisconnectedPresenter disc;

        private int currentPage = 1;
        private int pageSize = 30;  // Number of items per page
        private int totalPages;

        private IEnumerable<ConnectedSubscribers> originalSubscribers;

        public BindingSource BindingSource => bindingSource;

        public SubscriberPage(IUnitOfWork dbContext, MainForm mainForm)  // Change parameter name to match usage
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.mainForm = mainForm;  // Assign the passed instance to the class-level variable
            this.BackColor = Color.FromArgb(241, 240, 233);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            _currentUsername = mainForm.GetUsername();
            _currentUserRole = mainForm.GetUserRole();

            bindingSource = new BindingSource();
            connectedsubscribersGridView.AutoGenerateColumns = false;
            connectedsubscribersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            filterCombobox.SelectedIndex = 0;
        }

        private void SetActiveButton(MaterialButton clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.UseAccentColor = false;
            }

            activeButton = clickedButton;
            activeButton.UseAccentColor = true;
        }

        public void getSubscribers()
        {
            string selectedStatus = filterCombobox.SelectedItem.ToString();
            originalSubscribers = dbContext.connectedSubscriberRepository
                .GetAll()
                .OrderByDescending(s => s.subs_id)
                .ToList();


            if (selectedStatus != "All")
            {
                originalSubscribers = originalSubscribers
                    .Where(s => s.Status.Trim().Equals(selectedStatus.Trim(), StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Calculate total pages
            totalPages = (int)Math.Ceiling((double)originalSubscribers.Count() / pageSize);

            // Ensure the current page is within the correct range
            currentPage = Math.Max(1, Math.Min(currentPage, totalPages));

            var pagedSubscribers = originalSubscribers.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            bindingSource.DataSource = pagedSubscribers;
            connectedsubscribersGridView.DataSource = bindingSource;

            MoveButtonsToLastColumn();
            AddActionButtons();
            UpdateStatuses();
            connectedsubscribersGridView.Refresh();

            // Manage button states
            Previous.Enabled = currentPage > 1;
            Next.Enabled = currentPage < totalPages; // Disable if on the last page


        }

        private void MoveToDisconnectedList(ConnectedSubscribers subscriber)
        {
            try
            {
                // Create new Disconnected Subscriber
                var disconnectedSubscriber = new DisconnectedSubscribers
                {
                    Disconn_Name = subscriber.Conn_Name,
                    ContactNumber = subscriber.ContactNumber,
                    Address = subscriber.Address,
                    Plan = subscriber.Plan,
                    Status = "Disconnected",
                    Duedate = subscriber.Duedate,
                    CurrentDuedate = DateTime.Now,
                    InstallationDate = subscriber.InstallationDate,
                    MonthlyCharge = subscriber.MonthlyCharge,
                    Balance = subscriber.Balance,
                    Charge = subscriber.Charge,
                };

                // Add to disconnected list and remove from connected list
                dbContext.disconnectedSubscriberRepository.Add(disconnectedSubscriber);
                dbContext.connectedSubscriberRepository.Remove(subscriber);
                dbContext.Save();

                // Optionally, update the UI
                bindingSource.Remove(subscriber);
                MessageBox.Show("Subscriber automatically disconnected due to Prepaid plan and overdue date.", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while disconnecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void disconnectedbtn_Click(object sender, EventArgs e)
        {


            var disconnectedForm = new Disconnected(dbContext, this);
            disconnectedForm.ShowDialog();
        }

        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedSubscriber = connectedsubscribersGridView.Rows[e.RowIndex].DataBoundItem as Domain.Models.ConnectedSubscribers;
            if (selectedSubscriber == null) return;

            string columnName = connectedsubscribersGridView.Columns[e.ColumnIndex].Name;


            if (columnName == "editButton")
            {
                isEdit = true;

                var addsubs = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm)
                {
                    EditedSubscriber = selectedSubscriber,
                    Text = "Edit Subscriber Information",

                };

                var presenter = new AddSubscriberPresenter(addsubs, dbContext, this, _currentUsername, mainForm);

                presenter.EditLoad();

                addsubs.ShowDialog();
            }
            else if (columnName == "disconnectButton")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to disconnect this subscriber?",
                                                      "Confirm Disconnection",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var subscriberToDelete = dbContext.connectedSubscriberRepository
                                                          .Get(s => s.subs_id == selectedSubscriber.subs_id, tracked: true);

                        if (subscriberToDelete == null)
                        {
                            MessageBox.Show("Subscriber not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var disconnectedSubscriber = new DisconnectedSubscribers
                        {
                            Disconn_Name = subscriberToDelete.Conn_Name,
                            ContactNumber = subscriberToDelete.ContactNumber,
                            Address = subscriberToDelete.Address,
                            Plan = subscriberToDelete.Plan,
                            Status = "Disconnected",
                            Duedate = subscriberToDelete.Duedate,
                            CurrentDuedate = DateTime.Now,
                            InstallationDate = subscriberToDelete.InstallationDate,
                            MonthlyCharge = subscriberToDelete.MonthlyCharge,
                            Balance = subscriberToDelete.Balance,
                            Charge = subscriberToDelete.Charge,
                        };

                        dbContext.disconnectedSubscriberRepository.Add(disconnectedSubscriber);
                        dbContext.connectedSubscriberRepository.Remove(subscriberToDelete);
                        dbContext.Save();

                        LogActivity($"Disconnected subscriber: {subscriberToDelete.Conn_Name}");

                        bindingSource.Remove(selectedSubscriber);
                        getSubscribers(); // Refresh grid

                        MessageBox.Show("Subscriber successfully disconnected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while disconnecting: {ex.InnerException?.Message ?? ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void SubscriberPage_Load(object sender, EventArgs e)
        {
            getSubscribers();
            //connectedsubscribersGridView.CellFormatting += connectedsubscribersGridView_CellFormatting;

        }

        private void FilterSubscribersByAddress(string address)
        {
            var filteredSubscribers = originalSubscribers
             .Where(s => s.Address.Contains(address, StringComparison.OrdinalIgnoreCase))
             .ToList();

            if (filteredSubscribers.Any())
            {
                bindingSource.DataSource = filteredSubscribers;
            }
            else
            {

                bindingSource.DataSource = new List<ConnectedSubscribers>();
            }

            connectedsubscribersGridView.DataSource = bindingSource;
        }

        public void FilterData(string searchText)
        {
            if (originalSubscribers == null || !originalSubscribers.Any())
            {
                Console.WriteLine("No subscribers loaded in memory.");
                return;
            }


            if (string.IsNullOrEmpty(searchText))
            {
                bindingSource.DataSource = originalSubscribers.ToList();  // Convert to list if needed for DataGridView
            }
            else
            {
                var filteredList = originalSubscribers
                    .Where(sub => !string.IsNullOrEmpty(sub.Conn_Name) && sub.Conn_Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  !string.IsNullOrEmpty(sub.Address) && sub.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                  !string.IsNullOrEmpty(sub.ContactNumber) && sub.ContactNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();  // Convert to list after filtering

                Console.WriteLine($"Filtered Count: {filteredList.Count}");
                bindingSource.DataSource = filteredList.Any() ? filteredList : new List<ConnectedSubscribers>();
            }

            connectedsubscribersGridView.DataSource = bindingSource;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            getSubscribers();
        }


        private void anahawonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Anahawon");
        }

        private void baseCampBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Base Camp");
        }

        private void camp1Btn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Camp 1");
        }

        private void colambugonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Colambugon");


        }

        private void danggawanBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Danggawan");
        }
        private void dologonBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Dologon");
        }
        private void northPobBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("North Poblacion");
        }

        private void panadtalanBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("Panadtalan");
        }
        private void sanMiguelBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("San Miguel");
        }
        private void southPobBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((MaterialButton)sender);
            FilterSubscribersByAddress("South Poblacion");
        }
        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUsername,
                AccountRole = _currentUserRole,
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            dbContext.activityRepository.Update(activity); // Use Add instead of Update for new records
            dbContext.Save();
        }
        private void filterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = filterCombobox.SelectedItem.ToString();

            // Call the filter method with the selected state
            getSubscribers();
            this.ActiveControl = null;
        }
        private void AddActionButtons()
        {
            // Remove existing action button columns if they exist
            if (connectedsubscribersGridView.Columns.Contains("editButton"))
            {
                connectedsubscribersGridView.Columns.Remove("editButton");
            }

            if (connectedsubscribersGridView.Columns.Contains("disconnectButton"))
            {
                connectedsubscribersGridView.Columns.Remove("disconnectButton");
            }

            // Add Edit Button Column
            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn
            {
                Name = "editButton",
                HeaderText = "",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Width = 50,
                DividerWidth = 10
            };

            // Add Disconnect Button Column
            DataGridViewImageColumn disconnectButtonColumn = new DataGridViewImageColumn
            {
                Name = "disconnectButton",
                HeaderText = "",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Width = 50,
                DividerWidth = 10
            };

            connectedsubscribersGridView.Columns.Add(editButtonColumn);
            connectedsubscribersGridView.Columns.Add(disconnectButtonColumn);
        }

        private void ConnectedsubscribersGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == connectedsubscribersGridView.Columns["editButton"].Index ||
                    e.ColumnIndex == connectedsubscribersGridView.Columns["disconnectButton"].Index)
                {
                    // Prevent default paint
                    e.Handled = true;

                    // Set your custom background color
                    Color bgColor = Color.FromArgb(255, 255, 252);
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    // Draw the image
                    Image image = null;
                    if (e.ColumnIndex == connectedsubscribersGridView.Columns["editButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\edit.png");
                    }
                    else if (e.ColumnIndex == connectedsubscribersGridView.Columns["disconnectButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\minus-circle.png");
                    }

                    if (image != null)
                    {
                        var imageSize = new Size(25, 25); // Desired size
                        var x = e.CellBounds.Left + (e.CellBounds.Width - imageSize.Width) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - imageSize.Height) / 2;
                        e.Graphics.DrawImage(image, new Rectangle(new Point(x, y), imageSize));
                    }
                }
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == connectedsubscribersGridView.Columns["editButton"].Index ||
                    e.ColumnIndex == connectedsubscribersGridView.Columns["disconnectButton"].Index)
                {
                    e.Handled = true;

                    Color bgColor = Color.FromArgb(255, 255, 252);
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    Image image = null;
                    if (e.ColumnIndex == connectedsubscribersGridView.Columns["editButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\edit.png");
                    }
                    else if (e.ColumnIndex == connectedsubscribersGridView.Columns["disconnectButton"].Index)
                    {
                        image = Image.FromFile(@"D:\ISPSMS_FINAL\Icons\minus-circle.png");
                    }

                    if (image != null)
                    {
                        var imageSize = new Size(25, 25);
                        var x = e.CellBounds.Left + (e.CellBounds.Width - imageSize.Width) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - imageSize.Height) / 2;
                        e.Graphics.DrawImage(image, new Rectangle(new Point(x, y), imageSize));
                    }
                }
            }

            ApplyStatusStyle(e, "Status");
        }

        private void ApplyStatusStyle(DataGridViewCellPaintingEventArgs e, string columnName)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (connectedsubscribersGridView.Columns[e.ColumnIndex].DataPropertyName != columnName)
                return;

            string status = e.FormattedValue?.ToString()?.Trim();
            if (string.IsNullOrEmpty(status))
                return;

            // Colors
            Color backColor;
            Color textColor = Color.Black;
            Color borderColor;

            switch (status.ToLower())
            {
                case "active":
                    backColor = Color.FromArgb(206, 255, 176);
                    borderColor = Color.FromArgb(75, 121, 47);
                    textColor = Color.FromArgb(75, 121, 47);
                    break;
                case "past due":
                    backColor = Color.FromArgb(247, 229, 174);
                    borderColor = Color.FromArgb(160, 122, 4);
                    textColor = Color.FromArgb(160, 122, 4);
                    break;
                case "overdue":
                    backColor = Color.FromArgb(237, 203, 202);
                    borderColor = Color.FromArgb(178, 59, 46);
                    textColor = Color.FromArgb(178, 59, 46);
                    break;
                default:
                    backColor = Color.FromArgb(241, 240, 233);
                    borderColor = Color.Gray;
                    textColor = Color.Gray;
                    break;
            }

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            using (SolidBrush brush = new SolidBrush(backColor))
            using (Pen borderPen = new Pen(borderColor, 1)) // thicker border
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                SizeF textSize = e.Graphics.MeasureString(status, e.CellStyle.Font);
                int paddingX = 15;
                int paddingY = 5;
                int badgeWidth = (int)textSize.Width + paddingX * 2;
                int badgeHeight = (int)textSize.Height + paddingY;

                int badgeX = e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2;
                int badgeY = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
                Rectangle rect = new Rectangle(badgeX, badgeY, badgeWidth, badgeHeight);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = GetRoundedRectanglePath(rect, badgeHeight / 1);

                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(borderPen, path);
                e.Graphics.DrawString(status, e.CellStyle.Font, textBrush, rect, sf);
            }
        }


        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            return path;
        }



        private void UpdateStatuses()
        {
            DateTime currentDate = DateTime.Now;

            foreach (var subscriber in originalSubscribers)
            {
                DateTime dueDate = subscriber.CurrentDuedate.Date;

                if (subscriber.Plan == "Prepaid" && currentDate >= dueDate)
                {
                    subscriber.Status = "Disconnected";
                    MoveToDisconnectedList(subscriber);
                }
                else
                {
                    if (currentDate < dueDate)
                    {
                        subscriber.Status = "Active";
                    }
                    else if (currentDate >= dueDate && currentDate < dueDate.AddMonths(1))
                    {
                        subscriber.Status = "Past Due";
                    }
                    else
                    {
                        subscriber.Status = "Overdue";
                    }
                }


                var dbSubscriber = dbContext.connectedSubscriberRepository.Get(s => s.subs_id == subscriber.subs_id, tracked: true);
                if (dbSubscriber != null)
                {
                    dbSubscriber.Status = subscriber.Status;
                }
            }

            dbContext.Save(); // Save status changes to the database
        }


        private void MoveButtonsToLastColumn()
        {
            connectedsubscribersGridView.Columns["editButton"].DisplayIndex = connectedsubscribersGridView.Columns.Count - 1;
            connectedsubscribersGridView.Columns["disconnectButton"].DisplayIndex = connectedsubscribersGridView.Columns.Count - 1;
        }

        //public void GetColumnOrder()
        //{
        //    var columns = new[] { "subs_id", "ContactNumber", "Address", "Plan", "Status", "Duedate", "MonthlyCharge" };

        //    for (int i = 0; i < columns.Length; i++)
        //    {
        //        if (connectedsubscribersGridView.Columns.Contains(columns[i]))
        //        {
        //            connectedsubscribersGridView.Columns[columns[i]].DisplayIndex = i;
        //        }
        //    }
        //}


        private void AddButton_Click(object sender, EventArgs e)
        {

            isEdit = false;
            ConSubsEntity = (ConnectedSubscribers)bindingSource.Current;

            var AddForm = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm);
            AddForm.ShowDialog();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                getSubscribers();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                getSubscribers();
            }
        }

        private void transPrintBtn_Click(object sender, EventArgs e)
        {
            List<ConnectedSubscribers> Allsubscribers = dbContext.connectedSubscriberRepository.GetAll().ToList();
            SubscribersPrintDocs printDoc = new SubscribersPrintDocs(Allsubscribers);
            printDoc.Print();
        }

        private void exportSubsBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-AEJ6B24K\\SQLEXPRESS;Initial Catalog=connected_subscribers_db;User ID=ISPSMS_JUHACA;Password=OPTICALITSOLUTIONS2025;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string query = "SELECT * FROM dbo.connectedSubscribers";

            DataTable dt = GetDataTable(connectionString, query);
            if (dt.Rows.Count > 0)
            {
                SaveExcelFile(dt);
            }
            else
            {
                MessageBox.Show("No data to export.");
            }
        }
        private DataTable GetDataTable(string connectionString, string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        private void SaveExcelFile(DataTable dt)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = $"JUHACA {DateTime.Now:yyyy} SUBSCRIBERS AS OF {DateTime.Now:MMMM dd, yyyy}.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Transactions");
                        ws.Cells["A1"].LoadFromDataTable(dt, true);

                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("Exported successfully!");
                    }
                }
            }
        }

        private void bgPanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectedsubscribersGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}