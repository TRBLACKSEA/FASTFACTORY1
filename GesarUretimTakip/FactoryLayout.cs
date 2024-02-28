using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using FastFactory.Properties;
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
using Microsoft.Office.Interop.Excel;

namespace GesarUretimTakip
{
    public partial class FactoryLayout : DevExpress.XtraEditors.XtraForm
    {
        public FactoryLayout()
        {
            InitializeComponent();
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        private void FactoryLayout_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Form1.ParcaListesi.Count; i++)
            {
                IsEmri ısEmri = new IsEmri();
                ısEmri.lblParcaAdi.Text = Form1.ParcaListesi[i].ParcaAdi;
                ısEmri.lblParcaKodu.Text = Form1.ParcaListesi[i].ParcaKodu;
                //ısEmri.picParcaResmi.Image = Form1.Pictures[i].Picture;
                //flowLayoutPanel1.Controls.Add(ısEmri);
            }
            lblTumu.Text = Form1.ParcaListesi.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TezgahDetay tezgahDetay = new TezgahDetay();
            tezgahDetay.ShowDialog();
        }
    }
}