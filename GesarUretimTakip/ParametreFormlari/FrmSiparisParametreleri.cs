using Cores.Entities.ParameterEntities;
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

namespace FastFactory.ParametreFormlari
{
    public partial class FrmSiparisParametreleri : Form
    {
        public FrmSiparisParametreleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SiparisParam siparisParam = new SiparisParam();
            siparisParam.Desc = txtSiparisKodParametresi.Text;
            FrmLogin.db.SiparisParametreleri.Add(siparisParam);
            FrmLogin.db.SaveChanges();
            MessageBox.Show("Sipariş Parametresi Eklendi");
            this.Close();

        }
    }
}
