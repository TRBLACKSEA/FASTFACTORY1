using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._4_Muhasebe
{
    public partial class FrmFaturalar : Form
    {
        public static int Islem;
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmFaturaKarti frmFaturaEkle = new FrmFaturaKarti();
            frmFaturaEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmFaturaKarti frmFaturaEkle = new FrmFaturaKarti();
            frmFaturaEkle.ShowDialog();
        }
    }
}
