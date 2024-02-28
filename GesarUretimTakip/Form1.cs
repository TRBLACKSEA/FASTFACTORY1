using Core.Entities;
using Cores.Entities.Uretim;
using Cores.Tools;
using ExcelDataReader;
using FastFactory.Modüller._1_Uretim;
using FastFactory.Modüller._3_Satınalma;
using FastFactory.Modüller._4_Muhasebe;
using FastFactory.Modüller._5_Depo;
using FastFactory.Modüller._9_İSG;
using FastFactory.ParametreFormlari;
using GesarUretimTakip.Context;
using GesarUretimTakip.CRM;
using GesarUretimTakip.İnsan_Kaynakları;
using GesarUretimTakip.Modüller.Planlama;
using GesarUretimTakip.Muhasebe;
using GesarUretimTakip.Satınalma;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesarUretimTakip
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static List<Parca> ParcaListesi = new List<Parca>();
        
        public static string FirmaAdi = "Firma1";

        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Caption = FrmLogin.GirisYapanKullanici.KullaniciAdi;

            //Image imagefrompath = Image.FromFile(@"C:\Users\kursa\Desktop\esref.jpg");
            //byte[] imagebytestring = MyImageConverter.ConvertToByte(imagefrompath);
            //Parca p = FrmLogin.db.Parcalar.Where(q => q.ID == 1).FirstOrDefault();
            //string base64string = Convert.ToBase64String(imagebytestring);
            //p.ParcaResmi = base64string;
            //FrmLogin.db.SaveChanges();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FactoryLayout factoryLayout = new FactoryLayout();
            factoryLayout.MdiParent = this;
            factoryLayout.Show();
        }
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMakineKartlari frmMakineKartları = new FrmMakineKartlari();
            frmMakineKartları.MdiParent = this;
            frmMakineKartları.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYuklemePlani frmYuklemePlani = new FrmYuklemePlani();
            frmYuklemePlani.MdiParent = this;
            frmYuklemePlani.Show();
        }

        private void barButtonItem91_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem93_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel();
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void barButtonItem109_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGostergePaneli frmGostergePaneli = new FrmGostergePaneli();
            frmGostergePaneli.MdiParent = this;
            frmGostergePaneli.Show();
        }

        private void barButtonItem87_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelIzın frmPersonel = new FrmPersonelIzın();
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void barButtonItem132_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOlcuBirimleri frmOlcuBirimleri = new FrmOlcuBirimleri();
            frmOlcuBirimleri.Show();
        }

        private void barButtonItem81_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMalzeme frmMalzeme = new FrmMalzeme();
            frmMalzeme.MdiParent = this;
            frmMalzeme.Show();
        }

        private void barButtonItem79_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariler frmCariler = new FrmCariler();
            frmCariler.MdiParent = this;
            frmCariler.Show();
        }

        private void barButtonItem83_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasalar frmKasalar = new FrmKasalar();
            frmKasalar.MdiParent = this;
            frmKasalar.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmYeniSiparisEmri frmYeniSiparisEmri = new FrmYeniSiparisEmri();
            frmYeniSiparisEmri.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiparisEmirleri frmSiparisEmirleri = new FrmSiparisEmirleri();
            frmSiparisEmirleri.MdiParent = this;
            frmSiparisEmirleri.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
            frmLogin.Show();
        }

        private void barButtonItem146_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTezgahGruplari frmTezgahGruplari = new FrmTezgahGruplari();
            frmTezgahGruplari.MdiParent = this;
            frmTezgahGruplari.Show();
        }

        private void barButtonItem142_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTakimlar frmTakimlar = new FrmTakimlar();
            frmTakimlar.MdiParent = this;
            frmTakimlar.Show();
        }

        private void barButtonItem152_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem67_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMakineSaatMaliyetiHesapla frmMakineSaatMaliyetiHesapla = new FrmMakineSaatMaliyetiHesapla();
            frmMakineSaatMaliyetiHesapla.ShowDialog();
        }

        private void barButtonItem140_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatınalmaEmri frmSatınalmaEmri = new FrmSatınalmaEmri();
            frmSatınalmaEmri.ShowDialog();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatinalmaEmirleri frmSatınalmaEmirleri = new FrmSatinalmaEmirleri();
            frmSatınalmaEmirleri.MdiParent = this;
            frmSatınalmaEmirleri.Show();
        }

        private void barButtonItem84_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankalar frmBankalar = new FrmBankalar();
            frmBankalar.MdiParent = this;
            frmBankalar.Show();
        }

        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIrsaliyeler frmIrsaliyeler = new FrmIrsaliyeler();
            frmIrsaliyeler.MdiParent = this;
            frmIrsaliyeler.Show();
        }

        private void barButtonItem153_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturalar frmFaturalar = new FrmFaturalar();
            frmFaturalar.MdiParent = this;
            frmFaturalar.Show();
        }

        private void barButtonItem141_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankaHesaplari frmBankaHesaplari = new FrmBankaHesaplari();
            frmBankaHesaplari.MdiParent = this;
            frmBankaHesaplari.Show();
        }

        private void barButtonItem82_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStoklar frmStoklar = new FrmStoklar();
            frmStoklar.MdiParent = this;
            frmStoklar.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem156_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiparisParametreleri frmSiparisParametreleri = new FrmSiparisParametreleri();
            frmSiparisParametreleri.ShowDialog();
        }

        private void barButtonItem167_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOperasyonTanimlari frmOperasyonTanimlari = new FrmOperasyonTanimlari();
            frmOperasyonTanimlari.MdiParent = this;
            frmOperasyonTanimlari.Show();
        }

        private void barButtonItem166_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOperasyonlar frmOperasyonlar = new FrmOperasyonlar();
            frmOperasyonlar.MdiParent = this;
            frmOperasyonlar.Show();
        }

        private void barButtonItem172_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
        }

        private void barButtonItem171_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIsEmriParametreleri frmIsEmriParametreleri = new FrmIsEmriParametreleri();
            frmIsEmriParametreleri.MdiParent = this;
            frmIsEmriParametreleri.Show();
        }

        private void barButtonItem174_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProjeler frmProjeler = new FrmProjeler();
            frmProjeler.MdiParent = this;
            frmProjeler.Show();
        }

        private void barButtonItem168_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepolar frmDepolar = new FrmDepolar();
            frmDepolar.MdiParent = this;
            frmDepolar.Show();
        }

        private void barButtonItem170_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepoTransferFisleri frmDepoTransferFisleri = new FrmDepoTransferFisleri();
            frmDepoTransferFisleri.MdiParent = this;
            frmDepoTransferFisleri.Show();
        }

        private void barButtonItem173_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProjeler.Islem=1;
            FrmProjeKarti frmProjeKarti = new FrmProjeKarti();
            frmProjeKarti.ShowDialog();
        }

        private void barButtonItem122_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUyeEkle frmUyeEkle = new FrmUyeEkle();
            frmUyeEkle.MdiParent = this;
            frmUyeEkle.Show();

        }
    }
}
