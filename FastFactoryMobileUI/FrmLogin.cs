using Core.Entities;
using GesarUretimTakip.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactoryMobileUI
{
    public partial class FrmLogin : Form
    {
        public static FastFactoryContext db = new FastFactoryContext();
        public static  int KullaniciID;
        public static string KullaniciAdi;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            List<Kullanici> kullanici = db.Kullanicilar.Where(q => q.KullaniciAdi == txtKullaniciAdi.Text && q.Sifre == txtSifre.Text).ToList();
            if (kullanici.Count>0)
            {
                KullaniciAdi = kullanici[0].KullaniciAdi;
                KullaniciID = kullanici[0].ID;
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
