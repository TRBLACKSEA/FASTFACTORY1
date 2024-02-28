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

namespace GesarUretimTakip.Modüller.Muhasebe
{
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            if (FrmStoklar.Islem==1)
            {
                btnGuncelle.Enabled = false;
            }else if (FrmStoklar.Islem == 2)
            {
                btnKaydet.Enabled = false;
            }
        }
    }
}
