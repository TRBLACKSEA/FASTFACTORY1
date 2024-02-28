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
    public partial class FrmMalzemeEkle : Form
    {
        public FrmMalzemeEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMalzemeEkle_Load(object sender, EventArgs e)
        {
            if (FrmMalzeme.Islem==1)
            {
                btnGuncelle.Enabled = false;
            }else if(FrmMalzeme.Islem==2)
            {
                btnKaydet.Enabled = false;
            }
        }
    }
}
