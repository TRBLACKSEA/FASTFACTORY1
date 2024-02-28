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
    public partial class FrmCariler : Form
    {
        public static int Islem;
        public FrmCariler()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmCariEkle frmCariEkle = new FrmCariEkle();
            frmCariEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmCariEkle frmCariEkle = new FrmCariEkle();
            frmCariEkle.ShowDialog();
        }
        private void FrmCariler_Load(object sender, EventArgs e)
        {

        }
    }
}
