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
    public partial class FrmYeniSiparisEmri : Form
    {
        public FrmYeniSiparisEmri()
        {
            InitializeComponent();
        }

        private void FrmYeniSiparisEmri_Load(object sender, EventArgs e)
        {
            if(FrmLogin.db.SiparisParametreleri.ToList().Count>0)
            {
                
            }
            else
            {

                txtSiparisNo.Text = "00000000" + Convert.ToString(FrmLogin.db.SiparisParametreleri.ToList().Count + 1);
            }

            txtSiparisVeren.Text = FrmLogin.GirisYapanKullanici.KullaniciAdi;
            txtSiparisSaat.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

            if (FrmSiparisEmirleri.Islem == 1)
            {
                btnGuncelle.Enabled = false;
            }
            else if (FrmSiparisEmirleri.Islem == 2)
            {
                btnKaydet.Enabled = false;
            }

        }
    }
}
