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

            DateFilter.Value = DateTime.Today;

            getActivity(DateTime.Today);
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
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79);
                }
            }
        }
    }
}
