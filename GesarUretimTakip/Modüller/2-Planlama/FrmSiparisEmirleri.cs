using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesarUretimTakip.Modüller.Planlama
{
    public partial class FrmSiparisEmirleri : Form
    {
        public static int Islem;
        public FrmSiparisEmirleri()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmYeniSiparisEmri frmYeniSiparisEmri = new FrmYeniSiparisEmri();
            frmYeniSiparisEmri.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmYeniSiparisEmri frmYeniSiparisEmri = new FrmYeniSiparisEmri();
            frmYeniSiparisEmri.ShowDialog();
        }
    }
}

