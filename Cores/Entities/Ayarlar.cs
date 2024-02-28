using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities
{
    public class Ayarlar
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _VarsayılanIsEmriParametresi;

        public int VarsayılanIsEmriParametresi
        {
            get { return _VarsayılanIsEmriParametresi; }
            set { _VarsayılanIsEmriParametresi = value; }
        }


    }
}
