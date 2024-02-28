using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class SiparisBaslik
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _SiparisNumarasi;

        public string SiparisNumarasi
        {
            get { return _SiparisNumarasi; }
            set { _SiparisNumarasi = value; }
        }

        private string _SiparisAdi;

        public string SiparisAdi
        {
            get { return _SiparisAdi; }
            set { _SiparisAdi = value; }
        }
        private DateTime _SiparisTarihi;

        public DateTime SiparisTarihi
        {
            get { return _SiparisTarihi; }
            set { _SiparisTarihi = value; }
        }
        private string _SiparisSaati;

        public string SiparisSaati
        {
            get { return _SiparisSaati; }
            set { _SiparisSaati = value; }
        }
        
    }
}
