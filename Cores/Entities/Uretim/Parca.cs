using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;
using Xamarin.Forms;

namespace Core.Entities
{
    public class Parca
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _ProjeID;

        public int ProjeID
        {
            get { return _ProjeID; }
            set { _ProjeID = value; }
        }

        private byte[] _ParcaResmi;

        public byte[] ParcaResmi
        {
            get { return _ParcaResmi; }
            set { _ParcaResmi = value; }
        }

        [NotMapped]
        private ImageSource _ImageSource;
        [NotMapped]
        public ImageSource ImageSource
        {
            get { return _ImageSource; }
            set { _ImageSource = value; }
        }
        [NotMapped]
        private Xamarin.Forms.Color _BGColor;
        [NotMapped]
        public Xamarin.Forms.Color BGColor
        {
            get { return _BGColor; }
            set { _BGColor = value; }
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

        private int _Adet;

        public int Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }
        private int _UretilenAdet;

        public int UretilenAdet
        {
            get { return _UretilenAdet; }
            set { _UretilenAdet = value; }
        }

        private int _Durum; //OperasyonID

        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        private int _ParcaDepoID;

        public int ParcaDepoID
        {
            get { return _ParcaDepoID; }
            set { _ParcaDepoID = value; }
        }
    }
}
