using Core.Entities;
using Cores.Entities.Depo;
using Cores.Entities.Uretim;
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
    public partial class FrmDepoTransfer : Form
    {
        
        Parca parca;
        FastFactoryContext factoryContext = new FastFactoryContext();
        public FrmDepoTransfer()
        {
            InitializeComponent();
        }

        private void FrmDepoTransfer_Load(object sender, EventArgs e)
        {
            gridLookUpEdit1.Properties.NullText = "Seçiniz";
            parca = factoryContext.Parcalar.Where(q => q.ID == FrmProjeDetay.secilenID).FirstOrDefault();
            Proje proje = factoryContext.Projeler.Where(q => q.ID == parca.ProjeID).FirstOrDefault();

            lblProjeNo.Text = proje.ProjeKodu;
            lblParcaNo.Text = parca.ParcaKodu;


            gridLookUpEdit1.Properties.DataSource = factoryContext.Depolar.ToList();
            gridLookUpEdit2.Properties.DataSource = factoryContext.Depolar.ToList();

            gridLookUpEdit1.EditValue = parca.ParcaDepoID;
        }

        private void btnTasi_Click(object sender, EventArgs e)
        {
            DepoTransferFisi depoTransferFisi = new DepoTransferFisi();

            depoTransferFisi.NeredenID = Convert.ToInt32(gridLookUpEdit1.EditValue);
            depoTransferFisi.Nereden = gridLookUpEdit1.Properties.DisplayMember;

            if (!string.IsNullOrEmpty(gridLookUpEdit1.Text))
            {
                depoTransferFisi.NereyeID = Convert.ToInt32(gridLookUpEdit2.EditValue);
                depoTransferFisi.Nereye = gridLookUpEdit2.Properties.DisplayMember;
                parca.ParcaDepoID = depoTransferFisi.NereyeID;
                
            }
            else
            {
                MessageBox.Show("Gidiş Depo Seçilmelidir");
            }

            depoTransferFisi.TransferEdenKullaniciID = FrmLogin.KullaniciID;
            depoTransferFisi.TransferEdenKullanici = FrmLogin.KullaniciAdi;
            depoTransferFisi.TransferTarihi = DateTime.Now;
            depoTransferFisi.TransferSaati = DateTime.Now;
            factoryContext.DepoTransferFisleri.Add(depoTransferFisi);
            factoryContext.SaveChanges();
            MessageBox.Show("Depo Transferi Yapıldı");
            this.Close();
        }

        private void FrmDepoTransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmProjeDetay frmProjeDetay = (FrmProjeDetay)Application.OpenForms["FrmProjeDetay"];
            //frmProjeDetay.GridDoldur();
        }
    }
}
