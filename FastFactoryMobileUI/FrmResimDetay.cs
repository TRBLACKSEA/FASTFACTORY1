using Core.Entities;
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

namespace FastFactoryMobileUI
{
    public partial class FrmResimDetay : Form
    {
        MemoryStream ms;
        public FrmResimDetay()
        {
            InitializeComponent();
        }

        private void FrmResimDetay_Load(object sender, EventArgs e)
        {
            

            Parca parca = FrmLogin.db.Parcalar.Where(q => q.ID == FrmProjeDetay.secilenID).FirstOrDefault();
            this.Text = "Parça No: " + parca.ParcaKodu;
            byte[] resimbyte = parca.ParcaResmi;
            ms = new MemoryStream(resimbyte, 0, resimbyte.Length);
            ms.Write(resimbyte, 0, resimbyte.Length);
            Image parcaResmi = Image.FromStream(ms, true);
            
            pictureBox1.Image = parcaResmi;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
