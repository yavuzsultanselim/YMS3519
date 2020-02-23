using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalBuilder
{
    public class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder kart)
        {
            kart.BankaAdi();
            kart.KartTipi();
            kart.KartLimiti();
            kart.TaksitImkani();
        }
    }
}
