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
    public partial class FrmOperasyonlar : Form
    {
        public FrmOperasyonlar()
        {
            InitializeComponent();
        }

        private void FrmOperasyonlar_Load(object sender, EventArgs e)
        {
            operasyonTanımınaGöreToolStripMenuItem.DropDownItems.Clear();
            List<OperasyonTanimi> operasyonTanimlari = FrmLogin.db.OperasyonTanimlari.ToList();
            foreach (OperasyonTanimi item in operasyonTanimlari)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = item.Aciklama;
                operasyonTanımınaGöreToolStripMenuItem.DropDownItems.Add(menuItem);
            }
            GridDoldur();
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperasyonEkle frmOperasyonEkle = new FrmOperasyonEkle();
            frmOperasyonEkle.ShowDialog();
        }
        public void GridDoldur()
        {
            gridControl1.DataSource = FrmLogin.db.Operasyonlar.ToList();
        }
    }
}
