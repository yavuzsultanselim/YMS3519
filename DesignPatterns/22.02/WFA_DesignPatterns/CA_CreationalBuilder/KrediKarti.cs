using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalBuilder
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public decimal KartLimiti { get; set; }
        public bool TaksitImkani { get; set; }

        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müşteri {KartTipi} ni kullanmakta ve {KartLimiti} limiti vardır ayrıca taksit imkanı ise {TaksitImkani}";
        }



    }
}
