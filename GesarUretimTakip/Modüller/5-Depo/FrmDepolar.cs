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

namespace FastFactory.Modüller._5_Depo
{
    public partial class FrmDepolar : Form
    {
        public static int Islem;
        public static int secilenID;
        public FrmDepolar()
        {
            InitializeComponent();
        }

        private void FrmDepolar_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;//Ekleme
            FrmDepoKarti frmDepoKarti = new FrmDepoKarti();
            frmDepoKarti.ShowDialog();
        }
        public void GridDoldur()
        {
            gridControl1.DataSource = FrmLogin.db.Depolar.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                secilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
            }
        }
    }
}
