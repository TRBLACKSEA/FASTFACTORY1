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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            if (FrmCariler.Islem==1)
            {
                btnGuncelle.Enabled = false;
            }else if(FrmCariler.Islem==2)
            {
                btnKaydet.Enabled = false;
            }
        }
    }
}
