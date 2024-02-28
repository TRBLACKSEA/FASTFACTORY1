using Core.Entities;
using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using FastFactory.Properties;
using GesarUretimTakip;
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
    public partial class FrmParcalar : Form
    {
        List<Parca> secilenProjeParcalari;
        MemoryStream ms;
        public FrmParcalar()
        {
            InitializeComponent();
        }

        private void FrmParcalar_Load(object sender, EventArgs e)
        {
            int secilenProjeID = FrmLogin.db.Parcalar.Where(q => q.ProjeID == FrmProjeler.SecilenID).FirstOrDefault().ProjeID;
            string secilenProjeAdi = FrmLogin.db.Projeler.Where(q => q.ID == secilenProjeID).FirstOrDefault().ProjeKodu;
            this.Text = "Proje Adı: " + secilenProjeAdi;
            gridView1.RowHeight = 300;
            secilenProjeParcalari = FrmLogin.db.Parcalar.Where(q => q.ProjeID == FrmProjeler.SecilenID).ToList();
            gridControl1.DataSource = secilenProjeParcalari;
            repositoryItemPictureEdit2.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            //gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;


            //gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            //GridColumn colImage = new GridColumn();
            //colImage.FieldName = "ParcaResmi";
            //colImage.Caption = "Parça Resmi";
            //colImage.UnboundType = UnboundColumnType.Object;
            //colImage.OptionsColumn.AllowEdit = false;
            //colImage.Visible = true;
            //gridView1.Columns.Add(colImage);
            //flowLayoutPanel1.Controls.Clear();

            //for (int i = 0; i < secilenProjeParcalari.Count; i++)
            //{
            //    byte[] parcaResmiByteArray = Convert.FromBase64String(secilenProjeParcalari[i].ParcaResmi);
            //    ms = new MemoryStream(parcaResmiByteArray, 0, parcaResmiByteArray.Length);
            //    ms.Write(parcaResmiByteArray, 0, parcaResmiByteArray.Length);
            //    Image parcaResmi = Image.FromStream(ms, true);
            //    ParcaKartiUserControl parcaKartiUserControl = new ParcaKartiUserControl();
            //    if(parcaResmi!=null)
            //    {
            //        parcaKartiUserControl.picParcaResmi.Image = parcaResmi;
            //    }
            //    else
            //    {
            //        parcaKartiUserControl.picParcaResmi.Image = Resources.placeholder;
            //    }

            //    parcaKartiUserControl.lblParcaNumarasi.Text = secilenProjeParcalari[i].ParcaKodu;
            //flowLayoutPanel1.Controls.Add(parcaKartiUserControl);

        }

        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData && e.Column.FieldName == "ParcaResmi")
            {
                foreach (var item in secilenProjeParcalari)
                {
                    //byte[] parcaResmiByteArray = Convert.FromBase64String(item.ParcaResmi);
                    // ms = new MemoryStream(parcaResmiByteArray, 0, parcaResmiByteArray.Length);
                    //ms.Write(parcaResmiByteArray, 0, parcaResmiByteArray.Length);
                    //Image parcaResmi = Image.FromStream(ms, true);
                    e.Value = ms;
                }
            }
        }

        public void GridDoldur()
        {

        }
    }
}
