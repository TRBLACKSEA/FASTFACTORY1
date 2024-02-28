using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesarUretimTakip.Muhasebe
{
    public partial class FrmMalzeme : Form
    {
        public static int Islem;
        public FrmMalzeme()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmMalzemeEkle frmMalzemeEkle = new FrmMalzemeEkle();
            frmMalzemeEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmMalzemeEkle frmMalzemeEkle = new FrmMalzemeEkle();
            frmMalzemeEkle.ShowDialog();
        }
    }
}
