using Infastructure.Data.Repositories.IRepositories;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class DashboardPage : KryptonForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private MainForm mainForm;
        public DashboardPage(IUnitOfWork dbContext, MainForm mainForm)
        {
            InitializeComponent();
            dologon.Visible = false;
            colambugon.Visible = false;
            danggawan.Visible = false;
            sanmiguel.Visible = false;
            basecamp.Visible = false;
            panadtalan.Visible = false;
            anahawon.Visible = false;
            north.Visible = false;
            southPanel.Visible = false;
            camp1.Visible = false;
        }

        private void dologonPanel_MouseEnter(object sender, EventArgs e)
        {
            dologon.Visible = true;
            dologon.BringToFront();
            dologonPanel.Visible = false;
        }

        private void dologonPanel_MouseLeave(object sender, EventArgs e)
        {
            dologon.Visible = false;
            dologonPanel.Visible = true;
        }


        private void colambugonPanel_MouseEnter(object sender, EventArgs e)
        {
            colambugon.Visible = true;
            colambugon.BringToFront();
            colambugonPanel.Visible = false;
        }

        private void colambugonPanel_MouseLeave(object sender, EventArgs e)
        {
            colambugon.Visible = false;
            colambugonPanel.Visible = true;
        }

        private void danggawanPanel_MouseEnter(object sender, EventArgs e)
        {
            danggawan.Visible = true;
            danggawan.BringToFront();
            danggawanPanel.Visible = false;
        }

        private void danggawanPanel_MouseLeave(object sender, EventArgs e)
        {
            danggawan.Visible = false;
            danggawanPanel.Visible = true;
        }

        private void sanmiguelPanel_MouseEnter(object sender, EventArgs e)
        {
            sanmiguel.Visible = true;
            sanmiguel.BringToFront();
            sanmiguelPanel.Visible = false;
        }

        private void sanmiguelPanel_MouseLeave(object sender, EventArgs e)
        {
            sanmiguel.Visible = false;
            sanmiguelPanel.Visible = true;
        }

        private void basecamp_MouseEnter(object sender, EventArgs e)
        {
            basecamp.Visible = true;
            basecamp.BringToFront();
            basecampPanel.Visible = false;
        }

        private void basecamp_MouseLeave(object sender, EventArgs e)
        {
            basecamp.Visible = false;
            basecampPanel.Visible = true;
        }

        private void panadtalanPanel_MouseEnter(object sender, EventArgs e)
        {
            panadtalan.Visible = true;
            panadtalan.BringToFront();
            panadtalanPanel.Visible = false;
        }

        private void panadtalanPanel_MouseLeave(object sender, EventArgs e)
        {
            panadtalan.Visible = false;
            panadtalanPanel.Visible = true;
        }

        private void anahawonPanel_MouseEnter(object sender, EventArgs e)
        {
            anahawon.Visible = true;
            anahawon.BringToFront();
            anahawonPanel.Visible = false;
        }

        private void anahawonPanel_MouseLeave(object sender, EventArgs e)
        {
            anahawon.Visible = false;
            anahawonPanel.Visible = true;
        }

        private void northPanel_MouseEnter(object sender, EventArgs e)
        {
            north.Visible = true;
            north.BringToFront();
            northPanel.Visible = false;
        }

        private void northPanel_MouseLeave(object sender, EventArgs e)
        {
            north.Visible = false;
            northPanel.Visible = true;
        }

        private void south_MouseEnter(object sender, EventArgs e)
        {
            south.Visible = true;
            south.BringToFront();
            southPanel.Visible = false;
        }

        private void south_MouseLeave(object sender, EventArgs e)
        {
            south.Visible = false;
            southPanel.Visible = true;
        }

        private void camp1Panel_MouseEnter(object sender, EventArgs e)
        {
            camp1.Visible = true;
            camp1.BringToFront();
            camp1Panel.Visible = false;
        }

        private void camp1Panel_MouseLeave(object sender, EventArgs e)
        {
            camp1.Visible = false;
            camp1Panel.Visible = true;
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
