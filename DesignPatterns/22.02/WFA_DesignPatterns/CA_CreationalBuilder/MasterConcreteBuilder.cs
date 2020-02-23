using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalBuilder
{
    public class MasterConcreteBuilder : KrediKartiBuilder
    {

        public MasterConcreteBuilder()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Türkiye İş Bankası";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 7500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Master";
        }

        public override void TaksitImkani()
        {
            kart.TaksitImkani = true;
        }
    }
}
