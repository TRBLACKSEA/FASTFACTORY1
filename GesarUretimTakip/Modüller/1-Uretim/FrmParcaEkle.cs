using Core.Entities;
using Cores.Tools;
using FastFactory.Properties;
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
    public partial class FrmParcaEkle : Form
    {
        
        Image ımage=null;
        public FrmParcaEkle()
        {
            InitializeComponent();
        }

        private void btnParcaResmiSec_Click(object sender, EventArgs e)
        {
            string File;
            openFileDialog1.Title = "Parça Resmini Seçiniz";
            openFileDialog1.Filter = "Jpg Dosyası| *.Jpg | Jpeg Dosyası | *.Jpeg | Png Dosyası | *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File = openFileDialog1.FileName;
                ımage = Image.FromFile(File);
                pictureBoxParcaResmi.Image = ımage;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Parca parca = new Parca();
            parca.ProjeID = FrmProjeler.SecilenID;
            
            if (!string.IsNullOrEmpty(txtParcaNo.Text))
            {
                parca.ParcaKodu = txtParcaNo.Text;
            }
            else
            {
                MessageBox.Show("Parça Kodu Boş Geçilemez");
            }

            if (!string.IsNullOrEmpty(txtParçaAdi.Text))
            {
                parca.ParcaAdi = txtParçaAdi.Text;
            }
            else
            {
                MessageBox.Show("Parça Adı Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(txtMalzeme.Text))
            {
                parca.Malzeme = txtMalzeme.Text;
            }
            else
            {
                MessageBox.Show("Malzeme Boş Geçilemez");
            }
            parca.Marka = txtMarka.Text;
            if (Convert.ToInt32(numericUpDownAdet.Value) != 0)
            {
                parca.Adet = Convert.ToInt32(numericUpDownAdet.Value);
            }
            else
            {
                MessageBox.Show("Adet 0'dan Büyük Olmalı");
            }
            parca.ParcaDepoID = FrmLogin.db.Depolar.Where(q => q.ID == 1).FirstOrDefault().ID;//Tanımsız Depo,Parça İlk Eklendiğinde Depo Bilgisi Tanımsız Depo Olarak Kaydedilecek
            
            if (ımage!=null)
            {
                parca.ParcaResmi = MyImageConverter.ConvertToByte(ımage);
            }
            else
            {
                parca.ParcaResmi = MyImageConverter.ConvertToByte(Resources.placeholder);
            }
            //Parça Numarası Daha Önce Kayıt Deilmiş mi Kontrolü
            Parca kontrolEdilecekParca = FrmLogin.db.Parcalar.Where(q => q.ParcaKodu == txtParcaNo.Text && parca.ProjeID==FrmProjeler.SecilenID).FirstOrDefault();
            if (kontrolEdilecekParca != null)
            {
                FrmLogin.db.Parcalar.Add(parca);
                FrmLogin.db.SaveChanges();
                MessageBox.Show(parca.ParcaKodu + "No lu Parça Kayıt Edildi");
                this.Close();
            }
            else
            {
                MessageBox.Show(this.Text + " Nolu Proje İçin "+ parca.ParcaKodu + "No lu Parça Daha Önce Kayıt Edilmiş Tekrar Kayıt Edilemez","Çakışan Parça Uyarısı");
                //DialogResult dialogResult = MessageBox.Show(parca.ParcaKodu + "No lu Parça Daha Önce Kayıt Edilmiş Tekrar Kayıt Edilemez,Adet Bilgisini Güncellemek İster misiniz?", "Çakışan Parça Hatası", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    Parca guncellencekParca = FrmLogin.db.Parcalar.Where(q => q.ParcaKodu == txtParcaNo.Text && parca.ProjeID == FrmProjeler.SecilenID).FirstOrDefault();
                //    if (guncellencekParca.Adet <= Convert.ToInt32(numericUpDownAdet.Value))
                //    {
                //        MessageBox.Show("Girilen Parçanın Adedi Güncellenecek Parça Adedinden Farklı Olmalıdır");
                //    }
                //}
            }
        }

        private void FrmParcaEkle_Load(object sender, EventArgs e)
        {
            numericUpDownAdet.Value = 1;
        }
    }
}
