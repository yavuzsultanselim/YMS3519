using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class VisaconcreteBuilder : KrediKartiBuilder
    {
        public VisaconcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void Bankadi(string bankAdi)//garanti bankasi
        {
            kart.BankaAdi = bankAdi;
        }

        public override void KartLimit(decimal kartLimit)
        {
            kart.KartLimiti = kartLimit;
        }

        public override void KartTip(string kartTipi)
        {
            kart.KartTip = kartTipi;
        }

        public override void TaksitImkani(bool taksitImkani)
        {
            kart.TaksitImkani = taksitImkani;
        }
        public void Ornek()
        {

        }
    }
}
