using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities.Uretim
{
    public class Proje
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _ProjeKodu;

        public string ProjeKodu
        {
            get { return _ProjeKodu; }
            set { _ProjeKodu = value; }
        }

        private string _ProjeAdi;

        public string ProjeAdi
        {
            get { return _ProjeAdi; }
            set { _ProjeAdi = value; }
        }
        private string _Aciklama;

        public string Aciklama
        {
            get { return _Aciklama; }
            set { _Aciklama = value; }
        }
        private int _Durum; //0=ProjeOluşturuldu,1=BOM Listesi Projeye Aktarıldı,2=Devam Ediyor,3=Tamamlandı,4=İptal Edildi,5=Askıya Alındı

        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        private string _DurumAciklamasi;

        public string DurumAciklamasi
        {
            get { return _DurumAciklamasi; }
            set { _DurumAciklamasi = value; }
        }

    }
}
