﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFactory.Modüller._4_Muhasebe
{
    public partial class FrmIrsaliyeKarti : Form
    {
        public FrmIrsaliyeKarti()
        {
            InitializeComponent();
        }

        private void FrmIrsaliyeEkle_Load(object sender, EventArgs e)
        {
            if (FrmIrsaliyeler.Islem==1)
            {

            }else if(FrmIrsaliyeler.Islem==2)
            {

            }
        }
    }
}
