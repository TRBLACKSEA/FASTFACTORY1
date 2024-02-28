using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities.Uretim
{
    public class Operasyon
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _OperasyonAdi;

        public string OperasyonAdi
        {
            get { return _OperasyonAdi; }
            set { _OperasyonAdi = value; }
        }
        private int _OperasyonTanimID;

        public int OperasyonTanimID
        {
            get { return _OperasyonTanimID; }
            set { _OperasyonTanimID = value; }
        }

    }
}
