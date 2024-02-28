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
    public partial class IsEmri : UserControl
    {
        public IsEmri()
        {
            InitializeComponent();
        }
        
        private void IsEmri_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void IsEmri_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void IsEmri_Paint(object sender, PaintEventArgs e)
        {


        }

        private void IsEmri_Load(object sender, EventArgs e)
        {
            
        }
    }
}
