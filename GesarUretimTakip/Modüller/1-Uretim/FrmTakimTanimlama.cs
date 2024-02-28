using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._1_Uretim
{
    public partial class FrmTakimTanimlama : Form
    {
        public FrmTakimTanimlama()
        {
            InitializeComponent();
        }

        private void FrmTakimTanimlama_Load(object sender, EventArgs e)
        {
            checkBoxAktifmi.Checked = true;
            if (FrmTakimlar.Islem == 1)
            {
                btnGuncelle.Enabled = false;
            }
            else if (FrmTakimlar.Islem == 2)
            {
                btnKaydet.Enabled = false;
            }
        }
    }
}
