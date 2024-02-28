using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace GesarUretimTakip
{

    static class Program
    {
        static bool AgDurumu;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com", 80);
                kontrol_client.Close();
                AgDurumu = true;
            }
            catch (Exception)
            {
                AgDurumu = false;
            }

            if (!AgDurumu)
            {
                MessageBox.Show("Programı Kullanabilmek için İnternet Bağlantısına İhtiyaç Vardır.");
                Application.Exit();
            }
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 White");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin());
            }

        }
    }
}
