using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
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
        private readonly IConnectedSubscribersRepository _connectedSubscribersRepository;


        public DashboardPage(IConnectedSubscribersRepository connectedSubscribersRepository, IUnitOfWork dbContext, MainForm mainForm)

        {
            InitializeComponent();
            _connectedSubscribersRepository = connectedSubscribersRepository ?? throw new ArgumentNullException(nameof(connectedSubscribersRepository));
        }

        private void dologonPanel_MouseEnter(object sender, EventArgs e)
        {
            dologon.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\DOLOGON.png");
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
            colambugon.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\COLAMBUGON.png");
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
            danggawan.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\DANGGAWAN.png");
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
            sanmiguel.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\SANMIGUEL.png");
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
            basecamp.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\BASECAMP.png");
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
            panadtalan.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\PANADTALAN.png");
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
            anahawon.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\ANAHAWON.png");
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
            north.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\NORTH.png");
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
            camp1.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\CAMP1.png");
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
            south.StateCommon.Image = Image.FromFile("D:\\ISPSMS_FINAL\\Image_Resources\\SOUTH.png");
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


    }
}