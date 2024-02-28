using Cores.Entities.Depo;
using GesarUretimTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._5_Depo
{
    public partial class FrmDepoKarti : Form
    {
        Depo secilenDepo;
        public FrmDepoKarti()
        {
            InitializeComponent();
        }

        private void FrmDepoKarti_Load(object sender, EventArgs e)
        {
            if (FrmDepolar.Islem == 1)//Ekleme
            {
                btnGuncelle.Enabled = false;
            }else if (FrmDepolar.Islem == 2)//Güncelleme
            {
                btnKaydet.Enabled = true;
                secilenDepo = FrmLogin.db.Depolar.Where(q => q.ID == FrmDepolar.secilenID).FirstOrDefault();
                txtDepoKodu.Text = secilenDepo.DepoKodu;
                txtDepoAdi.Text = secilenDepo.DepoAdi;
            }
        }

        private void FrmDepoKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDepolar frmDepolar = (FrmDepolar)Application.OpenForms["FrmDepolar"];
            frmDepolar.GridDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Depo depo = new Depo();
            depo.DepoKodu = txtDepoKodu.Text;
            depo.DepoAdi = txtDepoAdi.Text;
            FrmLogin.db.Depolar.Add(depo);
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Depo Eklendi");
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenDepo.DepoKodu = txtDepoKodu.Text;
            secilenDepo.DepoAdi = txtDepoAdi.Text;
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Depo Güncellendi");
            this.Close();
        }
    }
}
