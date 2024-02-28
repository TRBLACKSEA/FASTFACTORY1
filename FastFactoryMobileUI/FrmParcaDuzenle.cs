using Core.Entities;
using Cores.Entities.Uretim;
using GesarUretimTakip.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactoryMobileUI
{
    public partial class FrmParcaDuzenle : Form
    {
        FastFactoryContext factoryContext = new FastFactoryContext();
        public FrmParcaDuzenle()
        {
            InitializeComponent();
        }

        private void FrmParcaDuzenle_Load(object sender, EventArgs e)
        {
            gridLookUpEditOperasyonlar.Properties.NullText = "Tanımsız";
            gridLookUpEditOperasyonlar.Properties.ValueMember = "ID";
            gridLookUpEditOperasyonlar.Properties.DisplayMember = "OperasyonAdi";
            gridLookUpEditOperasyonlar.Properties.DataSource = factoryContext.Operasyonlar.ToList();
            Proje proje = factoryContext.Projeler.Where(q => q.ID == Form1.SecilenProjeID).FirstOrDefault();
            this.Text = "Proje : " + proje.ProjeKodu + " - " + proje.ProjeAdi;
            Parca parca = factoryContext.Parcalar.Where(q => q.ID == FrmProjeDetay.secilenID).FirstOrDefault();
            lblParcaKodu.Text = parca.ParcaKodu;
            txtParcaAdi.Text = parca.ParcaAdi;
            txtMalzeme.Text = parca.Malzeme;
            txtMarka.Text = parca.Marka;
            lblAdet.Text = parca.Adet.ToString();
            numericUpDownUretilen.Value = Convert.ToDecimal(parca.UretilenAdet);
            gridLookUpEditOperasyonlar.EditValue = parca.Durum;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Parca parca = factoryContext.Parcalar.Where(q => q.ID == FrmProjeDetay.secilenID).FirstOrDefault();
            parca.UretilenAdet = Convert.ToInt32(numericUpDownUretilen.Value);
            parca.Durum = Convert.ToInt32(gridLookUpEditOperasyonlar.EditValue);
            factoryContext.SaveChanges();
            MessageBox.Show("Parça Bilgileri Güncellendi");
            this.Close();
        }

        private void FrmParcaDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProjeDetay frmProjeDetay = (FrmProjeDetay)Application.OpenForms["FrmProjeDetay"];
            frmProjeDetay.GridDoldur();
        }
    }
}
