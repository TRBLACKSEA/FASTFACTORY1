using Cores.Entities.Uretim;
using ExcelDataReader;
using FastFactory.Loading_Screens;
using GesarUretimTakip;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._1_Uretim
{
    public partial class FrmIsEmriParametreKarti : Form
    {
        string DosyaYolu;
        string DosyaAdi;
        DataTableCollection dtc;
        DataTable dt;
        IsEmriParametresi GuncellenecekIsEmriParametresi;

        public FrmIsEmriParametreKarti()
        {
            InitializeComponent();
        }

        private void FrmIsEmriParametreKarti_Load(object sender, EventArgs e)
        {
            
            if (FrmIsEmriParametreleri.Islem == 1)//Ekleme İşlemi
            {
                txtIsEmriParametreTanimi.Text = "";
                txtDosyaYolu.Text = "";
                cmbParcaResmi.Text = "";
                cmbParcaKodu.Text = "";
                cmbParcaAdi.Text = "";
                cmbMarka.Text = "";
                cmbMalzeme.Text = "";
                cmbAdet.Text = "";
            }
            else if (FrmIsEmriParametreleri.Islem == 2)//Güncelleme İşlemi
            {
                GuncellenecekIsEmriParametresi = FrmLogin.db.IsEmriParametreleri.Where(q => q.ID == FrmIsEmriParametreleri.SecilenID).FirstOrDefault();
                txtIsEmriParametreTanimi.Text = GuncellenecekIsEmriParametresi.ParametreTanimi;
                cmbParcaResmi.Text = GuncellenecekIsEmriParametresi.ParcaResmi;
                cmbParcaKodu.Text = GuncellenecekIsEmriParametresi.ParcaKodu;
                cmbParcaAdi.Text = GuncellenecekIsEmriParametresi.ParcaAdi;
                cmbMarka.Text = GuncellenecekIsEmriParametresi.Marka;
                cmbMalzeme.Text = GuncellenecekIsEmriParametresi.Malzeme;
                cmbAdet.Text = GuncellenecekIsEmriParametresi.Adet;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            openFileDialog1.Title = "Excel Dosyası Seçiniz..";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DosyaYolu = openFileDialog1.FileName;
            DosyaAdi = openFileDialog1.SafeFileName;
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(openFileDialog1.FileName);
            using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (x) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    dtc = result.Tables;
                }
                dt = dtc[0];
            }
            txtDosyaYolu.Text = DosyaAdi;

            ComboBoxDoldur(dt, cmbParcaResmi, cmbParcaKodu, cmbParcaAdi, cmbMalzeme, cmbMarka,cmbAdet);
            

        }
        public void ComboBoxDoldur(DataTable dt,params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    comboBox.Items.Add(dt.Columns[i].ColumnName);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IsEmriParametresi ısEmriParametresi = new IsEmriParametresi();
            ısEmriParametresi.ParametreTanimi = txtIsEmriParametreTanimi.Text;
            if (!string.IsNullOrEmpty(txtIsEmriParametreTanimi.Text))
            {
                ısEmriParametresi.ParametreTanimi = txtIsEmriParametreTanimi.Text;
            }
            else
            {
                MessageBox.Show("Parametre Tanımı Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(cmbParcaResmi.Text))
            {
                ısEmriParametresi.ParcaResmi = cmbParcaResmi.Text;
            }
            else
            {
                MessageBox.Show("Parça Resmi Parametresi Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(cmbParcaKodu.Text))
            {
                ısEmriParametresi.ParcaKodu = cmbParcaKodu.Text;
            }
            else
            {
                MessageBox.Show("Parça Kodu Parametresi Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(cmbParcaAdi.Text))
            {
                ısEmriParametresi.ParcaAdi = cmbParcaAdi.Text;
            }
            else
            {
                MessageBox.Show("Parça Adı Parametresi Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(cmbMalzeme.Text))
            {
                ısEmriParametresi.Malzeme = cmbMalzeme.Text;
            }
            else
            {
                MessageBox.Show("Malzeme Parametresi Boş Geçilemez");
            }
            if(!string.IsNullOrEmpty(cmbMarka.Text))
            {
                ısEmriParametresi.Marka = cmbMarka.Text;
            }
            else
            {
                MessageBox.Show("Marka Parametresi Boş Geçilemez");
            }
            if (!string.IsNullOrEmpty(cmbAdet.Text))
            {
                ısEmriParametresi.Adet = cmbAdet.Text;
            }
            else
            {
                MessageBox.Show("Adet Parametresi Boş Geçilemez");
            }

            if (!string.IsNullOrEmpty(ısEmriParametresi.ParcaResmi) &&
                !string.IsNullOrEmpty(ısEmriParametresi.ParametreTanimi) &&
                !string.IsNullOrEmpty(ısEmriParametresi.ParcaKodu) &&
                !string.IsNullOrEmpty(ısEmriParametresi.ParcaAdi) &&
                !string.IsNullOrEmpty(ısEmriParametresi.Malzeme) &&
                !string.IsNullOrEmpty(ısEmriParametresi.Marka))
            {
                FrmLogin.db.IsEmriParametreleri.Add(ısEmriParametresi);
                FrmLogin.db.SaveChanges();
                MessageBox.Show("İş Emri Parametresi Kaydedildi");
                this.Close();
            }
        }

        private void FrmIsEmriParametreKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIsEmriParametreleri frmIsEmriParametreleri = (FrmIsEmriParametreleri)Application.OpenForms["FrmIsEmriParametreleri"];
            frmIsEmriParametreleri.GridDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GuncellenecekIsEmriParametresi.ParcaResmi = cmbParcaResmi.Text;
            GuncellenecekIsEmriParametresi.ParcaKodu = cmbParcaKodu.Text;
            GuncellenecekIsEmriParametresi.ParcaAdi = cmbParcaAdi.Text;
            GuncellenecekIsEmriParametresi.Marka = cmbMarka.Text;
            GuncellenecekIsEmriParametresi.Malzeme = cmbMalzeme.Text;
            FrmLogin.db.SaveChanges();
            MessageBox.Show("İş Emri Parametresi Güncellendi");
            this.Close();
        }
    }
}
