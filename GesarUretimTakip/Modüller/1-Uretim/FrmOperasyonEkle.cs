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
    public partial class FrmOperasyonEkle : Form
    {
        public FrmOperasyonEkle()
        {
            InitializeComponent();
        }

        private void FrmOperasyonEkle_Load(object sender, EventArgs e)
        {
            gridLookUpEditOperasyonTanimi.Properties.DisplayMember = "Aciklama";
            gridLookUpEditOperasyonTanimi.Properties.ValueMember = "ID";
            gridLookUpEditOperasyonTanimi.Properties.DataSource = FrmLogin.db.OperasyonTanimlari.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Operasyon operasyon = new Operasyon();
            if (!string.IsNullOrEmpty(txtOperayonAdi.Text))
            {
                operasyon.OperasyonAdi = txtOperayonAdi.Text;
            }
            else
            {
                MessageBox.Show("Operasyon Adı Boş Geçilemez");
            }
            operasyon.OperasyonTanimID = Convert.ToInt32(gridLookUpEditOperasyonTanimi.EditValue);
            FrmLogin.db.Operasyonlar.Add(operasyon);
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Operasyon Eklendi");
            this.Close();
        }

        private void FrmOperasyonEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmOperasyonlar frmOperasyonlar = (FrmOperasyonlar)Application.OpenForms["FrmOperasyonlar"];
            frmOperasyonlar.GridDoldur();
        }

        private void gridLookUpEdit1View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }
    }
}
