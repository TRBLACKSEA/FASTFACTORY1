using Core.Entities;
using Cores.Entities;
using Cores.Entities.Depo;
using GesarUretimTakip.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesarUretimTakip
{
    public partial class FrmLogin : Form
    {
        public static FastFactoryContext db = new FastFactoryContext();

        public static Kullanici GirisYapanKullanici;
        public FrmLogin()
        {
            InitializeComponent();


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (!db.Database.Exists())
            {
                db.Database.Create();
                //MessageBox.Show("Veritabanı Oluşturuldu");
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = "login";
                kullanici.Sifre = "login";
                db.Kullanicilar.Add(kullanici);

                Ayarlar ayarlar = new Ayarlar();
                ayarlar.VarsayılanIsEmriParametresi = 0;
                db.Ayarlar.Add(ayarlar);

                Depo depo = new Depo();
                depo.DepoKodu = "Tanımsız Depo";
                depo.DepoAdi = "Tanımsız Depo";
                db.Depolar.Add(depo);

                db.SaveChanges();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYapanKullanici = db.Kullanicilar.Where(q => q.KullaniciAdi == txtKullaniciAdi.Text && q.Sifre == txtSifre.Text).FirstOrDefault();
            if (GirisYapanKullanici != null)
            {
                this.Hide();

                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void lblHesapOlustur_Click(object sender, EventArgs e)
        {

        }
    }
}
