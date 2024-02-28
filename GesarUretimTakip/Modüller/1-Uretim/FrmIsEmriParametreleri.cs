using Cores.Entities;
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
    public partial class FrmIsEmriParametreleri : Form
    {
        public static int Islem;
        public static int SecilenID;
        string ParametreTanimi;
        public FrmIsEmriParametreleri()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;//Ekleme İşlemi
            FrmIsEmriParametreKarti frmIsEmriParametreKarti = new FrmIsEmriParametreKarti();
            frmIsEmriParametreKarti.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;//Ekleme İşlemi
            FrmIsEmriParametreKarti frmIsEmriParametreKarti = new FrmIsEmriParametreKarti();
            frmIsEmriParametreKarti.ShowDialog();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                SecilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
                ParametreTanimi = gridView1.GetRowCellValue(e.FocusedRowHandle, "ParametreTanimi").ToString();
            }
        }

        private void FrmIsEmriParametreleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            List<IsEmriParametresi> ısEmriParametreleri = FrmLogin.db.IsEmriParametreleri.ToList();
            gridControl1.DataSource = ısEmriParametreleri;
        }

        private void varsayılanİşEmriOlarakAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = FrmLogin.db.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();
            ayarlar.VarsayılanIsEmriParametresi = SecilenID;
            FrmLogin.db.SaveChanges();
            MessageBox.Show( ParametreTanimi +" Varsayılan İş Emri Olarak Ayarlandı");
        }
    }
}
