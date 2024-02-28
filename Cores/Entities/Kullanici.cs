using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Kullanici
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _KullaniciAdi;

        public string KullaniciAdi
        {
            get { return _KullaniciAdi; }
            set { _KullaniciAdi = value; }
        }
        private string _Sifre;

        public string Sifre
        {
            get { return _Sifre; }
            set { _Sifre = value; }
        }
        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        private string _Telefon;

        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }

    }
}
