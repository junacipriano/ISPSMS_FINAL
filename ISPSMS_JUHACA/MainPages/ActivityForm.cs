using CuoreUI.Controls;
using Infastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            getActivity();
        }


        public void getActivity()
        {
            try
            {
                var Activity = dbContext.activityRepository.GetAll();
                dataGridView1.DataSource = Activity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
