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
    public partial class FrmBankaHesapKarti : Form
    {
        public FrmBankaHesapKarti()
        {
            InitializeComponent();
        }

        private void FrmBankaHesapEkle_Load(object sender, EventArgs e)
        {
            if (FrmBankaHesaplari.Islem==1)
            {
                
            }else if (FrmBankaHesaplari.Islem == 2)
            {

            }
        }
    }
}
