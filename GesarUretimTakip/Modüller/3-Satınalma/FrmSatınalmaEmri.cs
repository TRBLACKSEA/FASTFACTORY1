using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._3_Satınalma
{
    public partial class FrmSatınalmaEmri : Form
    {
        public FrmSatınalmaEmri()
        {
            InitializeComponent();
        }

        private void FrmSatınalmaEmri_Load(object sender, EventArgs e)
        {
            if (FrmSatinalmaEmirleri.Islem == 1)
            {
                simpleButton1.Enabled = false;
            }else if (FrmSatinalmaEmirleri.Islem == 2)
            {
                simpleButton2.Enabled = false;
            }
        }
    }
}
