using CuoreUI.Controls;
using Infastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages.SubPages
{
    public partial class ActivityForm : Form
    {
        private IUnitOfWork dbContext;
        private MainForm mainForm;

        public ActivityForm(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();

            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));

            // Set DateFilter to today's date
            DateFilter.Value = DateTime.Today;

            // Load activities for today by default
            getActivity(DateTime.Today);

            // Attach event handler for formatting
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            // Ensure DataGridView headers are visible
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false; // Optional: Hide row headers
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Better selection visibility

            DateFilter.BackColor = Color.LightGray;
        }

        public void getActivity(DateTime? selectedDate = null)
        {
            try
            {
                var activities = dbContext.activityRepository.GetAll();

                // Ensure activities is not null
                if (activities == null || !activities.Any())
                {
                    dataGridView1.DataSource = null;
                    return;
                }

                // Filter by date if a date is selected
                if (selectedDate.HasValue)
                {
                    activities = activities.Where(a => a.ActivitiesDateTime.Date == selectedDate.Value.Date).ToList();
                }

                dataGridView1.DataSource = activities;
 

                // Force refresh to apply formatting
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateFilter_ValueChanged(object sender, EventArgs e)
        {
            // Call getActivity with the selected date from the DateTimePicker
            getActivity(DateFilter.Value);
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "ActivitiesDone") // Ensure it's the correct column
            {
                if (e.Value != null && e.Value.ToString().StartsWith("Deleted subscriber:"))
                {
                    // Change the text color to red
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    // Reset to default color
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
