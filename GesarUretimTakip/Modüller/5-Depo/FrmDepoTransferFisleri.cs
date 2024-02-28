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
    public partial class FrmDepoTransferFisleri : Form
    {
        public FrmDepoTransferFisleri()
        {
            InitializeComponent();
        }

        private void FrmDepoTransferFisleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            List<DepoTransferFisi> depoTransferFisleri = FrmLogin.db.DepoTransferFisleri.ToList();
            foreach (DepoTransferFisi item in depoTransferFisleri)
            {
                item.Nereden = FrmLogin.db.Depolar.Where(q => q.ID == item.NeredenID).FirstOrDefault().DepoAdi;
                item.Nereye = FrmLogin.db.Depolar.Where(q => q.ID == item.NereyeID).FirstOrDefault().DepoAdi;
                item.TransferEdenKullanici = FrmLogin.db.Kullanicilar.Where(q => q.ID == item.TransferEdenKullaniciID).FirstOrDefault().KullaniciAdi;
            }
            gridControl1.DataSource = depoTransferFisleri;
        }
    }
}
