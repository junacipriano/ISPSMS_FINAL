using System;
using System.Collections.Generic;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Krypton.Toolkit;
using Microsoft.Graph.Models;
using LiveCharts.WinForms;
using Infastructure.Repositories;
using Timer = System.Windows.Forms.Timer;
using MaterialSkin.Controls;

namespace ISPSMS_JUHACA.MainPages
{
    public partial class DashboardPage : KryptonForm
    {
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public readonly IUnitOfWork dbContext;
        private MainForm mainForm;
        private readonly IConnectedSubscribersRepository _connectedSubscribersRepository;
        private int lastUpdatedMonth = DateTime.Now.Month;
        private readonly Timer updateTimer = new Timer { Interval = 86400000 };
        public DashboardPage(IConnectedSubscribersRepository connectedSubscribersRepository, IUnitOfWork dbContext, MainForm mainForm)

        {
            InitializeComponent();
            this.dbContext = dbContext;
            _connectedSubscribersRepository = connectedSubscribersRepository ?? throw new ArgumentNullException(nameof(connectedSubscribersRepository));
            this.Load += DashboardPage_Load;
        }

        private void dologonPanel_MouseEnter(object sender, EventArgs e)
        {
            dologon.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\dol.png");
            dologon.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            dologon.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Dologon";
            int dologonCount = _connectedSubscribersRepository.CountDologonSubscribers();
            subscribersTextbox.Text = dologonCount.ToString();
        }

        private void dologonPanel_MouseLeave(object sender, EventArgs e)
        {
            dologon.StateCommon.Image = null;
            dologon.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void colambugonPanel_MouseEnter(object sender, EventArgs e)
        {
            colambugon.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\col.png");
            colambugon.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            colambugon.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Colambugon";
            int ColambugonCount = _connectedSubscribersRepository.CountColambugonSubscribers();
            subscribersTextbox.Text = ColambugonCount.ToString();
        }

        private void colambugonPanel_MouseLeave(object sender, EventArgs e)
        {
            colambugon.StateCommon.Image = null;
            colambugon.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void danggawanPanel_MouseEnter(object sender, EventArgs e)
        {
            danggawan.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\dang.png");
            danggawan.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            danggawan.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Danggawan";
            int DanggawanCount = _connectedSubscribersRepository.CountDanggawanSubscribers();
            subscribersTextbox.Text = DanggawanCount.ToString();
        }

        private void danggawanPanel_MouseLeave(object sender, EventArgs e)
        {
            danggawan.StateCommon.Image = null;
            danggawan.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void sanmiguelPanel_MouseEnter(object sender, EventArgs e)
        {
            sanmiguel.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\san.png");
            sanmiguel.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            sanmiguel.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "San Miguel";
            int SanMiguelCount = _connectedSubscribersRepository.CountSanmiguelSubscribers();
            subscribersTextbox.Text = SanMiguelCount.ToString();
        }

        private void sanmiguelPanel_MouseLeave(object sender, EventArgs e)
        {
            sanmiguel.StateCommon.Image = null;
            sanmiguel.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void basecampPanel_MouseEnter(object sender, EventArgs e)
        {
            basecamp.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\base.png");
            basecamp.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            basecamp.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Base Camp";
            int BaseCampCount = _connectedSubscribersRepository.CountBasecampSubscribers();
            subscribersTextbox.Text = BaseCampCount.ToString();
        }

        private void basecampPanel_MouseLeave(object sender, EventArgs e)
        {
            basecamp.StateCommon.Image = null;
            basecamp.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;

        }

        private void panadtalanPanel_MouseEnter(object sender, EventArgs e)
        {
            panadtalan.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\pan.png");
            panadtalan.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            panadtalan.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Panadtalan";
            int PanadtalanCount = _connectedSubscribersRepository.CountPanadtalanSubscribers();
            subscribersTextbox.Text = PanadtalanCount.ToString();
        }

        private void panadtalanPanel_MouseLeave(object sender, EventArgs e)
        {
            panadtalan.StateCommon.Image = null;
            panadtalan.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void anahawonPanel_MouseEnter(object sender, EventArgs e)
        {
            anahawon.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\ana.png");
            anahawon.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            anahawon.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Anahawon";
            int AnahawonCount = _connectedSubscribersRepository.CountAnahawonSubscribers();
            subscribersTextbox.Text = AnahawonCount.ToString();
        }

        private void anahawonPanel_MouseLeave(object sender, EventArgs e)
        {
            anahawon.StateCommon.Image = null;
            anahawon.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void northPanel_MouseEnter(object sender, EventArgs e)
        {
            north.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\nor.png");
            north.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            north.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "North Poblacion";
            int northCount = _connectedSubscribersRepository.CountNorthSubscribers();
            subscribersTextbox.Text = northCount.ToString();
        }

        private void northPanel_MouseLeave(object sender, EventArgs e)
        {
            north.StateCommon.Image = null;
            north.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void camp1Panel_MouseEnter(object sender, EventArgs e)
        {
            camp1.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\cam.png");
            camp1.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            camp1.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "Camp 1";
            int Camp1Count = _connectedSubscribersRepository.CountCamp1Subscribers();
            subscribersTextbox.Text = Camp1Count.ToString();
        }

        private void camp1Panel_MouseLeave(object sender, EventArgs e)
        {
            camp1.StateCommon.Image = null;
            camp1.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }

        private void southPanel_MouseEnter(object sender, EventArgs e)
        {
            south.StateCommon.Image = System.Drawing.Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\sou.png");
            south.StateCommon.ImageStyle = PaletteImageStyle.Stretch;
            south.BringToFront();
            infoBox.Visible = true;
            areaLabel.Visible = true;
            areaTextbox.Visible = true;
            subscribersLabel.Visible = true;
            subscribersTextbox.Visible = true;
            locLogo.Visible = true;

            areaTextbox.Text = "South Poblacion";
            int southCount = _connectedSubscribersRepository.CountSouthSubscribers();
            subscribersTextbox.Text = southCount.ToString();
        }

        private void southPanel_MouseLeave(object sender, EventArgs e)
        {
            south.StateCommon.Image = null;
            south.SendToBack();
            infoBox.Visible = false;
            areaLabel.Visible = false;
            areaTextbox.Visible = false;
            subscribersLabel.Visible = false;
            subscribersTextbox.Visible = false;
            locLogo.Visible = false;
        }


        private void DashboardPage_Load(object sender, EventArgs e)
        {
            MonthlyLoadTotals();
            DailyLoadTotals();
            UpdateTextBox();
            updateTimer.Tick += (s, ev) => { if (DateTime.Now.Month != lastUpdatedMonth) { MonthlyLoadTotals(); lastUpdatedMonth = DateTime.Now.Month; } };
            updateTimer.Start();
        }

        private void MonthlyLoadTotals()
        {
            totalInstallationTextbox.Text = (dbContext.connectedSubscriberRepository.CountAllSubscriber() + dbContext.disconnectedSubscriberRepository.CountDisconnected()).ToString();
            totalCutTextbox.Text = dbContext.disconnectedSubscriberRepository.CountDisconnected().ToString();
        }
        private void DailyLoadTotals()
        {
            totalSubTextbox.Text = dbContext.connectedSubscriberRepository.CountAllSubscriber().ToString();
            totalDueTextbox.Text = dbContext.connectedSubscriberRepository.CountDue().ToString();
            overdueTextbox.Text = dbContext.connectedSubscriberRepository.CountOverDue().ToString();
            pastDueTextbox.Text = dbContext.connectedSubscriberRepository.CountPastDue().ToString();
            activeTextbox.Text = dbContext.connectedSubscriberRepository.CountActive().ToString();
        }
        private void UpdateTextBox()
        {
            forTheMonthTextbox1.Text = $"For the month of {DateTime.Now:MMMM}";
            forTheMonthTextbox2.Text = $"For the month of {DateTime.Now:MMMM}";
            asOfTextbox1.Text = $"As of {DateTime.Now:MMMM dd, yyyy}";
            asOfTextbox2.Text = $"As of {DateTime.Now:MMMM dd, yyyy}";
        }

    }

}