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
    public partial class FrmFaturaKarti : Form
    {
        public FrmFaturaKarti()
        {
            InitializeComponent();
        }

        private void FrmFaturaEkle_Load(object sender, EventArgs e)
        {
            if (FrmFaturalar.Islem==1)
            {

            }else if (FrmFaturalar.Islem ==2)
            {

            }
        }
    }
}
