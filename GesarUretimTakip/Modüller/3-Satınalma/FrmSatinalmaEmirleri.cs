using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._3_Satınalma
{
    public partial class FrmSatinalmaEmirleri : Form
    {
        public static int Islem;
        public FrmSatinalmaEmirleri()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmSatınalmaEmri frmSatınalmaEmri = new FrmSatınalmaEmri();
            frmSatınalmaEmri.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmSatınalmaEmri frmSatınalmaEmri = new FrmSatınalmaEmri();
            frmSatınalmaEmri.ShowDialog();
        }
    }
}
