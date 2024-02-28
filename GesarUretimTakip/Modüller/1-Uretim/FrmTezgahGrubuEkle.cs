using Cores.Entities;
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
    public partial class FrmTezgahGrubuEkle : Form
    {
        public FrmTezgahGrubuEkle()
        {
            InitializeComponent();
        }
        TezgahGrubu GuncellenecekTezgahGrubu;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (FrmTezgahGruplari.Islem == 1)//Ekleme İşlemi Yapılacak
            {
                TezgahGrubu tezgahGrubu = new TezgahGrubu();
                tezgahGrubu.TezgahGrupKodu = txtTezgahGrubu.Text;
                tezgahGrubu.Aciklama = txtAciklama.Text;

                if (string.IsNullOrEmpty(tezgahGrubu.TezgahGrupKodu))
                {
                    MessageBox.Show("Tezgah Grubu Boş Geçilemez");
                }
                if (string.IsNullOrEmpty(tezgahGrubu.Aciklama))
                {
                    MessageBox.Show("Tezgah Açıklamasi Boş Geçilemez");
                }
                else
                {
                    FrmLogin.db.TezgahGruplari.Add(tezgahGrubu);
                    FrmLogin.db.SaveChanges();
                    MessageBox.Show("Tezgah Grubu Eklendi");
                    this.Close();
                }
            } else if (FrmTezgahGruplari.Islem == 2)//Güncelleme İşlemi Yapılacak
            {
                
                GuncellenecekTezgahGrubu.TezgahGrupKodu = txtTezgahGrubu.Text;
                GuncellenecekTezgahGrubu.Aciklama = txtAciklama.Text;
                FrmLogin.db.SaveChanges();
                MessageBox.Show("Tezgah Grubu Güncellendi");
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTezgahGrubuEkle_Load(object sender, EventArgs e)
        {
            if (FrmTezgahGruplari.Islem == 1)//Ekleme İşlemi İle Gelinmiş
            {
                txtTezgahGrubu.Text = "";
                txtAciklama.Text = "";
            }else if(FrmTezgahGruplari.Islem == 2)
            {
                GuncellenecekTezgahGrubu = FrmLogin.db.TezgahGruplari.Where(q => q.ID == FrmTezgahGruplari.SecilenID).FirstOrDefault();
                txtTezgahGrubu.Text = GuncellenecekTezgahGrubu.TezgahGrupKodu;
                txtAciklama.Text = GuncellenecekTezgahGrubu.Aciklama;
            }
        }

        private void FrmTezgahGrubuEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmTezgahGruplari frmTezgahGruplari = (FrmTezgahGruplari)Application.OpenForms["FrmTezgahGruplari"];
            frmTezgahGruplari.GridDoldur();
        }
    }
}
