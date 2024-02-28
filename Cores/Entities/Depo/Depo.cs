using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities.Depo
{
    public class Depo
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _DepoKodu;

        public string DepoKodu
        {
            get { return _DepoKodu; }
            set { _DepoKodu = value; }
        }

        private string _DepoAdi;

        public string DepoAdi
        {
            get { return _DepoAdi; }
            set { _DepoAdi = value; }
        }

    }
}
