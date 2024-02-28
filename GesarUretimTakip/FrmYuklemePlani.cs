using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesarUretimTakip
{
    public partial class FrmYuklemePlani : Form
    {
        ChromiumWebBrowser chromiumWebBrowser1;
        CefSettings settings = new CefSettings();
        public FrmYuklemePlani()
        {
            InitializeComponent();
            //settings = new CefSettings();
        }

        private void FrmYuklemePlani_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + @"\src\LoadingPlan.html");
            

            //settings.RemoteDebuggingPort = 8088;
            settings.CefCommandLineArgs.Add("disable-web-security");
            

            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.Javascript = CefState.Enabled;
            if (Cef.IsInitialized==false)
            {
                Cef.Initialize(settings);
            }
            chromiumWebBrowser1 = new ChromiumWebBrowser(Application.StartupPath + @"\src\LoadingPlan.html");
            this.Controls.Add(chromiumWebBrowser1);
            chromiumWebBrowser1.Dock = DockStyle.Fill;
        }

        private void FrmYuklemePlani_FormClosing(object sender, FormClosingEventArgs e)
        {
            //chromiumWebBrowser1.Delete();
            //settings.Dispose();
        }
    }
}
