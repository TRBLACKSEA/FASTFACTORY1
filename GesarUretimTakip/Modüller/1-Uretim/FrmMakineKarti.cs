using Core;
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
    public partial class FrmMakineKarti : Form
    {
        public FrmMakineKarti()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMakineKarti_Load(object sender, EventArgs e)
        {
            gridLookUpMakinaGrubu.Properties.DisplayMember = "Aciklama";
            gridLookUpMakinaGrubu.Properties.ValueMember = "ID";
            gridLookUpMakinaGrubu.Properties.DataSource = FrmLogin.db.TezgahGruplari.ToList();

            if (FrmMakineKartlari.Islem == 1)//Ekleme İşlemi Yapılacak
            {
                gridLookUpMakinaGrubu.EditValue = 1;
                btnGuncelle.Enabled = false;
            }
            else if (FrmMakineKartlari.Islem == 2) //Güncelleme İşlemi Yapılacak
            {
                btnKaydet.Enabled = false;
            }
            txtKodu.Select();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MakineKarti makineKarti = new MakineKarti();
            makineKarti.Kodu = txtKodu.Text;
            makineKarti.IP = txtIP.Text;
            makineKarti.MakineAdi = txtAdi.Text;
            makineKarti.Markasi = txtMarkasi.Text;
            makineKarti.Modeli = txtModeli.Text;
            makineKarti.TezgahGrupID = Convert.ToInt32(gridLookUpMakinaGrubu.EditValue);
            makineKarti.KontrolUnitesi = txtKontrolUnitesi.Text;
            makineKarti.PortName = txtPortName.Text;
            makineKarti.BaundRate = Convert.ToInt32(txtBaudRate.Text);
            makineKarti.Priority = Convert.ToDecimal(txtPriority.Text);
            FrmLogin.db.MakineKartlari.Add(makineKarti);
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Makine Kartı Eklendi");
            this.Close();
        }

        private void FrmMakineKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMakineKartlari frmMakineKartlari = (FrmMakineKartlari)Application.OpenForms["FrmMakineKartlari"];
            frmMakineKartlari.GridDoldur();
        }
    }
}
