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
    public partial class FrmOperasyonTanimEkle : Form
    {
        public FrmOperasyonTanimEkle()
        {
            InitializeComponent();
        }
        OperasyonTanimi SecilenOperasyonTanimi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (FrmOperasyonTanimlari.Islem == 1)//Ekleme İşlemi İle Gelindi
            {
                if (!string.IsNullOrEmpty(txtAciklama.Text))
                {
                    OperasyonTanimi operasyonTanimi = new OperasyonTanimi { Aciklama = txtAciklama.Text };
                    FrmLogin.db.OperasyonTanimlari.Add(operasyonTanimi);
                    FrmLogin.db.SaveChanges();
                    MessageBox.Show("Operasyon Tanımı Eklendi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Açıklama Boş Geçilemez");
                }
            }
            else if(FrmOperasyonTanimlari.Islem == 2)//Güncelleme İşlemi İle Gelindi
            {
                
                SecilenOperasyonTanimi.Aciklama = txtAciklama.Text;
                FrmLogin.db.SaveChanges();
                MessageBox.Show("Operasyon Tanımı Güncellendi");
                this.Close();
            }
        }

        private void FrmOperasyonTanimEkle_Load(object sender, EventArgs e)
        {
            SecilenOperasyonTanimi = FrmLogin.db.OperasyonTanimlari.Where(q => q.ID == FrmOperasyonTanimlari.SecilenID).FirstOrDefault();
            if (FrmOperasyonTanimlari.Islem == 1)//Ekleme İşlemi İle Gelindi
            {
                txtAciklama.Text = "";
            }
            else if (FrmOperasyonTanimlari.Islem == 2)//Güncelleme İşlemi İle Gelindi
            {
                txtAciklama.Text = SecilenOperasyonTanimi.Aciklama;
            }
        }

        private void FrmOperasyonTanimEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmOperasyonTanimlari frmOperasyonTanimlari = (FrmOperasyonTanimlari)Application.OpenForms["FrmOperasyonTanimlari"];
            frmOperasyonTanimlari.GridDoldur();
        }
    }
}
