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
    public partial class FrmMakineKartlari : Form
    {
        public static int Islem;
        public FrmMakineKartlari()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islem = 1; //Ekleme işlemi yapılacak.

            FrmMakineKarti frmMakineKarti = new FrmMakineKarti();
            frmMakineKarti.ShowDialog();
        }

        private void FrmMakineKartlari_Load(object sender, EventArgs e)
        {
            GridDoldur();
            foreach (TezgahGrubu tezgahGrubu in FrmLogin.db.TezgahGruplari)
            {
                ToolStripMenuItem toolStripItem = new ToolStripMenuItem();
                toolStripItem.Text = tezgahGrubu.Aciklama;
                grubaGöreGörüntüleToolStripMenuItem.DropDownItems.Add(toolStripItem);
            }
            
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2; //Ekleme işlemi yapılacak.

            FrmMakineKarti frmMakineKarti = new FrmMakineKarti();
            frmMakineKarti.ShowDialog();
        }
        public void GridDoldur()
        {
            gridControl1.DataSource = FrmLogin.db.MakineKartlari.ToList();
        }
    }
}
