﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities
{
    public class TezgahGrubu
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _TezgahGrupKodu;

        public string TezgahGrupKodu
        {
            get { return _TezgahGrupKodu; }
            set { _TezgahGrupKodu = value; }
        }
        private string _Aciklama;

        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }

    }
}
