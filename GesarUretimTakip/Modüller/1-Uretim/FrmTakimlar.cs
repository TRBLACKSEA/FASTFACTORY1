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
    public partial class FrmTakimlar : Form
    {
        public static int Islem;
        public FrmTakimlar()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 1;
            FrmTakimTanimlama frmTakimTanimlama = new FrmTakimTanimlama();
            frmTakimTanimlama.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Islem = 2;
            FrmTakimTanimlama frmTakimTanimlama = new FrmTakimTanimlama();
            frmTakimTanimlama.ShowDialog();
        }

        private void FrmTakimlar_Load(object sender, EventArgs e)
        {

        }
    }
}
