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
    public partial class FrmBankaKarti : Form
    {
        public static int Islem;
        public FrmBankaKarti()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmBankaKarti frmBankaEkle = new FrmBankaKarti();
            frmBankaEkle.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmBankaKarti frmBankaEkle = new FrmBankaKarti();
            frmBankaEkle.ShowDialog();
        }
    }
}
