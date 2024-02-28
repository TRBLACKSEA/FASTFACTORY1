using Core.Entities;
using Cores.Entities;
using Cores.Entities.Uretim;
using Cores.Tools;
using ExcelDataReader;
using FastFactory.Modüller._1_Uretim;
using FastFactory.Properties;
using GesarUretimTakip;
using Spire.Xls;
using Spire.Xls.Core.Spreadsheet.Shapes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Tools
{
    public static class ImportManager
    {
        static DataTableCollection dtc;
        static DataTable dt;
        public static List<ExcelPicture> Pictures = new List<ExcelPicture>();
        static Ayarlar ayarlar;
        public static IsEmriParametresi ısEmriParametresi;
        static OpenFileDialog openFileDialog1;
        
        public static void BOMListImport()
        {

            openFileDialog1 = new OpenFileDialog();
            ayarlar = FrmLogin.db.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();
            ısEmriParametresi = FrmLogin.db.IsEmriParametreleri.Where(q => q.ID ==ayarlar.VarsayılanIsEmriParametresi).FirstOrDefault();
            openFileDialog1.Filter = " Xlsx Dosyaları |*.xlsx| Bütün Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
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
                }
                dt = dtc[0];

                Form1.ParcaListesi.Clear();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Worksheet sheet = workbook.Worksheets[0];
                    ExcelPicture picture;
                    if (sheet.Pictures[i]!=null)
                    {
                       picture  = sheet.Pictures[i];
                       Pictures.Add(picture);
                    }
                    else
                    {
                        
                    }

                    

                    Parca parca = new Parca();
                    parca.ProjeID = FrmProjeler.SecilenID;
                    if (dt.Rows[i][ısEmriParametresi.ParcaKodu] != null)
                    {
                        parca.ParcaKodu = dt.Rows[i][ısEmriParametresi.ParcaKodu].ToString();
                    }
                    else
                    {
                        parca.ParcaKodu = "";
                    }

                    if (dt.Rows[i][ısEmriParametresi.ParcaAdi] != null)
                    {
                        parca.ParcaAdi = dt.Rows[i][ısEmriParametresi.ParcaAdi].ToString();
                    }
                    else
                    {
                        parca.ParcaAdi = "";
                    }
                    if (dt.Rows[i][ısEmriParametresi.Malzeme] != null)
                    {
                        parca.Malzeme = dt.Rows[i][ısEmriParametresi.Malzeme].ToString();
                    }
                    else
                    {
                        parca.Malzeme = "";
                    }
                    if (dt.Rows[i][ısEmriParametresi.Marka] != null)
                    {
                        parca.Marka = dt.Rows[i][ısEmriParametresi.Marka].ToString();
                    }
                    else
                    {
                        parca.Marka = "";
                    }
                    if (dt.Rows[i][ısEmriParametresi.Adet] != null)
                    {
                        parca.Adet = Convert.ToInt32(dt.Rows[i][ısEmriParametresi.Adet]);
                    }
                    else
                    {
                        parca.Adet = 0;
                    }

                    parca.UretilenAdet = 0;//Parça İlk Defa Eklenirken Üretilen Adet 0 Olarak Girilir

                    if(Pictures[i].Picture!=null)
                    {
                        Image image = Pictures[i].Picture;
                        parca.ParcaResmi = MyImageConverter.ConvertToByte(image);
                    }
                    else
                    {
                        Image image = Resources.placeholder;
                        parca.ParcaResmi = MyImageConverter.ConvertToByte(image);
                    }

                    Form1.ParcaListesi.Add(parca);

                    parca.ParcaDepoID = 1;//Tanımsız Depo
                    
                }


                try
                {
                    FrmLogin.db.Parcalar.AddRange(Form1.ParcaListesi);
                    FrmLogin.db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        MessageBox.Show("Entity of type" + eve.Entry.Entity.GetType().Name + " in state" + eve.Entry.State + " has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show("- Property:" + ve.PropertyName + ", Error:" + ve.ErrorMessage);
                        }
                    }
                }
                MessageBox.Show("BOM Listesi İçeri Aktarıldı");
            }
        }
    }
}
