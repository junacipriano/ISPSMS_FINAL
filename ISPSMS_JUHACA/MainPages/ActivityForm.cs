using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CuoreUI.Controls;
using Infastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class ActivityForm : Form
    {
        private IUnitOfWork dbContext;
        private MainForm mainForm;
        private System.Windows.Forms.Timer refreshTimer; // Explicitly specify Windows Forms Timer

        public ActivityForm(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();

            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            DateFilter.Value = DateTime.Today;
            getActivity(DateTime.Today);

            // Initialize and configure the timer
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 2000; // Refresh every 2 seconds
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start(); // Start refreshing automatically
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            getActivity(DateFilter.Value); // Refresh data every tick
        }

        public void getActivity(DateTime? selectedDate = null)
        {
            try
            {
                var activities = dbContext.activityRepository.GetAll();

                if (activities == null || !activities.Any())
                {
                    dataGridView1.DataSource = null;
                    return;
                }

                if (selectedDate.HasValue)
                {
                    activities = activities.Where(a => a.ActivitiesDateTime.Date == selectedDate.Value.Date).ToList();
                }

                dataGridView1.DataSource = null; // Clear to prevent flickering
                dataGridView1.DataSource = activities;
                dataGridView1.Refresh(); // Ensure UI updates
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateFilter_ValueChanged(object sender, EventArgs e)
        {
            getActivity(DateFilter.Value);
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "ActivitiesDone")
            {
                if (e.Value != null && e.Value.ToString().StartsWith("Deleted subscriber:"))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79);
                }
            }
        }

        // Stop the timer when the form closes to avoid memory leaks
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            refreshTimer.Stop();
            refreshTimer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
