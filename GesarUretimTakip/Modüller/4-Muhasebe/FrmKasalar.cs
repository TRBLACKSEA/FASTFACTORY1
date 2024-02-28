using FastFactory.Modüller._4_Muhasebe;
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
    public partial class FrmKasalar : Form
    {
        public static int Islem;
        public FrmKasalar()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmKasaKarti frmKasaEkle = new FrmKasaKarti();
            frmKasaEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmKasaKarti frmKasaEkle = new FrmKasaKarti();
            frmKasaEkle.ShowDialog();
        }
    }
}
