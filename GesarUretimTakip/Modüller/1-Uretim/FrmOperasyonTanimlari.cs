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
    public partial class FrmOperasyonTanimlari : Form
    {
        public static int Islem;
        public static int SecilenID;
        public FrmOperasyonTanimlari()
        {
            InitializeComponent();
        }

        private void FrmOperasyonTanimlari_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            List<OperasyonTanimi> OperasyonTanimlari = FrmLogin.db.OperasyonTanimlari.ToList();
            gridControl1.DataSource = OperasyonTanimlari;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;//Ekleme
            FrmOperasyonTanimEkle frmOperasyonTanimEkle = new FrmOperasyonTanimEkle();
            frmOperasyonTanimEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;//Güncelleme
            FrmOperasyonTanimEkle frmOperasyonTanimEkle = new FrmOperasyonTanimEkle();
            frmOperasyonTanimEkle.ShowDialog();
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
