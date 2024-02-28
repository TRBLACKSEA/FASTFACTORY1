using Core.Entities;
using Cores.Entities;
using Cores.Entities.Uretim;
using FastFactory.Loading_Screens;
using FastFactory.Tools;
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
    public partial class FrmProjeler : Form
    {
        public static int Islem;
        public static int SecilenID;
        public static FrmLoadingScreen1 frmLoadingScreen1 = new FrmLoadingScreen1();
        public FrmProjeler()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void tamamlandıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmProjeKarti frmProjeKarti = new FrmProjeKarti();
            frmProjeKarti.ShowDialog();
        }

        private void FrmProjeler_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            List<Proje> Projeler = FrmLogin.db.Projeler.ToList();
            gridControl1.DataSource = Projeler;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmProjeKarti frmProjeKarti = new FrmProjeKarti();
            frmProjeKarti.ShowDialog();
        }

        private void bOMListesiAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = FrmLogin.db.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();

            if (ayarlar.VarsayılanIsEmriParametresi == 0)
            {
                MessageBox.Show("BOM Listesi Aktarabilmek İçin İlk Önce Varsayılan İş Emri Parametresini Belirlemelisiniz");
            }
            else
            {
                List<Parca> parcaKontrolListesi = FrmLogin.db.Parcalar.Where(q => q.ProjeID == SecilenID).ToList();
                if (parcaKontrolListesi.Count == 0)
                {
                    ImportManager.BOMListImport();
                    Proje proje = FrmLogin.db.Projeler.Where(q => q.ID == SecilenID).FirstOrDefault();
                    proje.Durum = 1;
                    proje.DurumAciklamasi = "BOM Listesi Aktarıldı";
                    FrmLogin.db.SaveChanges();
                    GridDoldur();
                }
                else if (parcaKontrolListesi.Count > 0)
                {
                    MessageBox.Show("Projeye BOM Listesi Aktarılmış,Tekrar Aktaramazsınız");
                }

            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                SecilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
            }
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParcalar frmParcalar = new FrmParcalar();
            frmParcalar.Show();
        }

        private void parçaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParcaEkle frmParcaEkle = new FrmParcaEkle();
            frmParcaEkle.Text = FrmLogin.db.Projeler.Where(q => q.ID == SecilenID).FirstOrDefault().ProjeKodu;
            frmParcaEkle.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
