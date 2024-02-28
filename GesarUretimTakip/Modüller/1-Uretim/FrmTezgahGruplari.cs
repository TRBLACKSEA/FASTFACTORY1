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
    public partial class FrmTezgahGruplari : Form
    {
        public static int Islem;
        public static int SecilenID;
        
        public FrmTezgahGruplari()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmTezgahGrubuEkle frmTezgahGrubuEkle = new FrmTezgahGrubuEkle();
            frmTezgahGrubuEkle.ShowDialog();
        }

        private void FrmTezgahGruplari_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        public void GridDoldur()
        {
            gridControl1.DataSource = FrmLogin.db.TezgahGruplari.ToList();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmTezgahGrubuEkle frmTezgahGrubuEkle = new FrmTezgahGrubuEkle();
            frmTezgahGrubuEkle.ShowDialog();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                SecilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
            }
        }
    }
}
