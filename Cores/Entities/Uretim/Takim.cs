using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities
{
    public class Takim
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _TakimNumarasi;

        public string TakimNumarasi
        {
            get { return _TakimNumarasi; }
            set { _TakimNumarasi = value; }
        }
        private string _Adi;

        public string Adi
        {
            get { return _Adi; }
            set { _Adi = value; }
        }
        private string _Markasi;

        public string Markasi
        {
            get { return _Markasi; }
            set { _Markasi = value; }
        }
        private string _Modeli;

        public string Modeli
        {
            get { return _Modeli; }
            set { _Modeli = value; }
        }
        private int _UcSayisi;

        public int UcSayisi
        {
            get { return _UcSayisi; }
            set { _UcSayisi = value; }
        }
        private decimal _UcOmru;

        public decimal UcOmru
        {
            get { return _UcOmru; }
            set { _UcOmru = value; }
        }
        private string _Aciklama;

        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }
        private bool _AktifMi;

        public bool AktifMi
        {
            get { return _AktifMi; }
            set { _AktifMi = value; }
        }

    }
}
