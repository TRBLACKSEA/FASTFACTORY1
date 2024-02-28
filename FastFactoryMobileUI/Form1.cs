using Cores.Entities.Uretim;
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
    public partial class Form1 : Form
    {
        public static int SecilenProjeID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
            frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = FrmLogin.KullaniciAdi;
            List<Proje> projeler = FrmLogin.db.Projeler.ToList();
            foreach (Proje item in projeler)
            {
                Button button = new Button();
                button.Width = 310;
                button.Height = 250;
                button.Font = new Font(FontFamily.GenericSansSerif, 25);
                button.Text = item.ProjeKodu + "-" + item.ProjeAdi;
                button.Name = item.ID.ToString();
                button.Click += Button_Click;

                flowLayoutPanel1.Controls.Add(button);

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            SecilenProjeID = Convert.ToInt32(button.Name);
            FrmProjeDetay frmProjeDetay = new FrmProjeDetay();
            frmProjeDetay.Show();
        }
    }
}
