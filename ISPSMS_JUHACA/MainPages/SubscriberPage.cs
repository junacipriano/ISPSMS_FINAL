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
using ISPSMS_JUHACA.Views.toPrintData;
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
        private readonly string _currentUsername;
        private readonly string _currentUserRole;
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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            _currentUsername = mainForm.GetUsername();
            _currentUserRole = mainForm.GetUserRole();

            bindingSource = new BindingSource();
            connectedsubscribersGridView.AutoGenerateColumns = false;

            materialComboBox1.Items.Add("All");
            materialComboBox1.Items.Add("Active");
            materialComboBox1.Items.Add("Past due");
            materialComboBox1.Items.Add("Overdue");


            materialComboBox1.SelectedIndex = 0;





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
            string selectedStatus = materialComboBox1.SelectedItem.ToString();
            originalSubscribers = dbContext.connectedSubscriberRepository.GetAll()
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

        private void connectedsubscribersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (connectedsubscribersGridView.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().Trim();

                Console.WriteLine($"Row {e.RowIndex}, Column {e.ColumnIndex}, Status Value: {status}");

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
                else if (status.Equals("Past Due", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
                else if (status.Equals("Overdue", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(connectedsubscribersGridView.Font, FontStyle.Bold);
                }
            }
        }



        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedSubscriber = connectedsubscribersGridView.Rows[e.RowIndex].DataBoundItem as Domain.Models.ConnectedSubscribers;
            if (selectedSubscriber == null) return;

            string columnName = connectedsubscribersGridView.Columns[e.ColumnIndex].Name;


            if (connectedsubscribersGridView.Columns[e.ColumnIndex].Name == "editButton")
            {
                isEdit = true;

                var addsubs = new addSubscribersForm(dbContext, this, _currentUsername, _currentUserRole, mainForm)
                {
                    EditedSubscriber = selectedSubscriber,
                    Text = "Edit Subscriber Information",

                };

                // Update the constructor call to include the required parameters 'currentUserName' and 'currentUserRole'
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
            connectedsubscribersGridView.CellFormatting += connectedsubscribersGridView_CellFormatting;

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

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = materialComboBox1.SelectedItem.ToString();

            // Call the filter method with the selected state
            getSubscribers();
        }



        private void AddActionButtons()
        {  // Remove existing action button columns if they exist
            if (connectedsubscribersGridView.Columns.Contains("editButton"))
            {
                connectedsubscribersGridView.Columns.Remove("editButton");
            }

            if (connectedsubscribersGridView.Columns.Contains("disconnectButton"))
            {
                connectedsubscribersGridView.Columns.Remove("disconnectButton");
            }

            // Create Edit Button Column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "editButton",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            // Create Disconnect Button Column
            DataGridViewButtonColumn disconnectButtonColumn = new DataGridViewButtonColumn
            {
                Name = "disconnectButton",
                HeaderText = "Disconnect",
                Text = "Disconnect",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            // Add columns at the end (last position)
            connectedsubscribersGridView.Columns.Add(editButtonColumn);
            connectedsubscribersGridView.Columns.Add(disconnectButtonColumn);
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
    }
}