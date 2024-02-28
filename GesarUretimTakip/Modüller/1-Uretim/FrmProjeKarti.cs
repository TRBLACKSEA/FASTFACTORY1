using Core.Entities;
using Cores.Entities.Uretim;
using GesarUretimTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._1_Uretim
{
    public partial class FrmProjeKarti : Form
    {
        Proje GuncellenecekProje;
        public FrmProjeKarti()
        {
            InitializeComponent();
        }

        private void FrmProjeKarti_Load(object sender, EventArgs e)
        {
            if(FrmProjeler.Islem==1)//Ekleme İşlemi Yapılacak
            {
                btnGuncelle.Enabled = false;
                txtProjeKodu.Text = "";
                txtProjeAdi.Text = "";
                txtAciklama.Text = "";
            }else if(FrmProjeler.Islem == 2)
            {
                btnKaydet.Enabled = false;
                GuncellenecekProje = FrmLogin.db.Projeler.Where(q => q.ID == FrmProjeler.SecilenID).FirstOrDefault();
                txtProjeKodu.Text = GuncellenecekProje.ProjeKodu;
                txtProjeAdi.Text = GuncellenecekProje.ProjeAdi;
                txtAciklama.Text = GuncellenecekProje.Aciklama;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Proje proje = new Proje();
            if (!string.IsNullOrEmpty(txtProjeKodu.Text))
            {
                proje.ProjeKodu = txtProjeKodu.Text;
            }
            else
            {
                MessageBox.Show("Proje Kodu Boş Geçilemez");
            }
            if(!string.IsNullOrEmpty(txtProjeAdi.Text))
            {
                proje.ProjeAdi = txtProjeAdi.Text;
            }
            else
            {
                MessageBox.Show("Proje Adı Boş Geçilemez");
            }
            proje.Aciklama = txtAciklama.Text;
            proje.Durum = 0;
            proje.DurumAciklamasi = "Proje Oluşturuldu";
            FrmLogin.db.Projeler.Add(proje);
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Proje Kaydedildi");
            this.Close();
        }

        private void FrmProjeKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProjeler frmProjeler = (FrmProjeler)Application.OpenForms["FrmPRojeler"];
            frmProjeler.GridDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string eskiProjeKodu = GuncellenecekProje.ProjeKodu;
            GuncellenecekProje.ProjeKodu = txtProjeKodu.Text;
            GuncellenecekProje.ProjeAdi = txtProjeAdi.Text;
            GuncellenecekProje.Aciklama = txtAciklama.Text;
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Proje Bilgileri Güncellendi");
            this.Close();
        }
    }
}
