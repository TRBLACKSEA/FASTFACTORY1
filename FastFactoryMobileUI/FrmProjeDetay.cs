using Core.Entities;
using Cores.Entities.Depo;
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
    public partial class FrmProjeDetay : Form
    {
        public static int secilenID;
        FastFactoryContext factoryContext = new FastFactoryContext();
        List<Parca> parcalar = new List<Parca>();
        public FrmProjeDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeDetay_Load(object sender, EventArgs e)
        {
            GridDoldur();
            string secilenProjeAdi = factoryContext.Projeler.Where(q => q.ID == Form1.SecilenProjeID).FirstOrDefault().ProjeKodu;
            this.Text = "Proje Adı: " + secilenProjeAdi;
            gridView1.RowHeight = 100;
        }
        public void GridDoldur()
        {
            var parcaDetaylari = from Parca in factoryContext.Parcalar.Where(q => q.ProjeID == Form1.SecilenProjeID).ToList()
                                 join Depo in factoryContext.Depolar
                                 on Parca.ParcaDepoID equals Depo.ID
                                 select new
                                 {
                                     Parca.ID,
                                     Parca.ProjeID,
                                     Parca.ParcaKodu,
                                     Parca.ParcaAdi,
                                     Parca.Malzeme,
                                     Parca.Marka,
                                     Parca.Adet,
                                     Parca.UretilenAdet,
                                     Parca.Durum,
                                     Parca.ParcaDepoID,
                                     Depo.DepoAdi
                                 };
            gridControl1.DataSource = parcaDetaylari;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                secilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
                //MessageBox.Show(secilenID.ToString());
            }
        }

        private void repositoryItemPictureEdit1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_Click_1(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            FrmResimDetay frmResimDetay = new FrmResimDetay();
            frmResimDetay.ShowDialog();
        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            FrmDepoTransfer frmDepoTransfer = new FrmDepoTransfer();
            frmDepoTransfer.ShowDialog();
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            FrmParcaDuzenle frmParcaDuzenle = new FrmParcaDuzenle();
            frmParcaDuzenle.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
