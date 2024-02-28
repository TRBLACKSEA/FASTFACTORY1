using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities.Uretim
{
    public class IsEmriParametresi
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _ParametreTanimi;

        public string ParametreTanimi
        {
            get { return _ParametreTanimi; }
            set { _ParametreTanimi = value; }
        }
        private string _ParcaResmi;

        public string ParcaResmi
        {
            get { return _ParcaResmi; }
            set { _ParcaResmi = value; }
        }
        private string _ParcaKodu;

        public string ParcaKodu
        {
            get { return _ParcaKodu; }
            set { _ParcaKodu = value; }
        }
        private string _ParcaAdi;

        public string ParcaAdi
        {
            get { return _ParcaAdi; }
            set { _ParcaAdi = value; }
        }
        private string _Malzeme;

        public string Malzeme
        {
            get { return _Malzeme; }
            set { _Malzeme = value; }
        }
        private string _Marka;

        public string Marka
        {
            get { return _Marka; }
            set { _Marka = value; }
        }
        private string _Adet;

        public string Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }

    }
}
