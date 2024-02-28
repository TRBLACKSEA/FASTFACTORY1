using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Entities.Depo
{
    public class DepoTransferFisi
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _NeredenID;

        public int NeredenID
        {
            get { return _NeredenID; }
            set { _NeredenID = value; }
        }
        [NotMapped]
        private string _Nereden;
        [NotMapped]
        public string Nereden
        {
            get { return _Nereden; }
            set { _Nereden = value; }
        }

        private int _NereyeID;

        public int NereyeID
        {
            get { return _NereyeID; }
            set { _NereyeID = value; }
        }
        [NotMapped]
        private string _Nereye;
        [NotMapped]
        public string Nereye
        {
            get { return _Nereye; }
            set { _Nereye = value; }
        }

        private int _TransferEdenKullaniciID;

        public int TransferEdenKullaniciID
        {
            get { return _TransferEdenKullaniciID; }
            set { _TransferEdenKullaniciID = value; }
        }
        [NotMapped]
        private string _TransferEdenKullanici;
        [NotMapped]
        public string TransferEdenKullanici
        {
            get { return _TransferEdenKullanici; }
            set { _TransferEdenKullanici = value; }
        }
        private DateTime _TransferTarihi;

        public DateTime TransferTarihi
        {
            get { return _TransferTarihi; }
            set { _TransferTarihi = value; }
        }


        private DateTime _TransferSaati;

        public DateTime TransferSaati
        {
            get { return _TransferSaati; }
            set { _TransferSaati = value; }
        }

    }
}
