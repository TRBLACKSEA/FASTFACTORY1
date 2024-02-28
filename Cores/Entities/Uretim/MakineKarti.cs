using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class MakineKarti
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Kodu;

        public string Kodu
        {
            get { return _Kodu; }
            set { _Kodu = value; }
        }

        private string _IP;

        public string IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        private string _MakineAdi;

        public string MakineAdi
        {
            get { return _MakineAdi; }
            set { _MakineAdi = value; }
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
        private int _TezgahGrupID;

        public int TezgahGrupID
        {
            get { return _TezgahGrupID; }
            set { _TezgahGrupID = value; }
        }
        private string _KontrolUnitesi;

        public string KontrolUnitesi
        {
            get { return _KontrolUnitesi; }
            set { _KontrolUnitesi = value; }
        }
        private string _PortName;

        public string PortName
        {
            get { return _PortName; }
            set { _PortName = value; }
        }
        private int _BaundRate;

        public int BaundRate
        {
            get { return _BaundRate; }
            set { _BaundRate = value; }
        }
        private decimal _Priority;

        public decimal Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

    }
}
