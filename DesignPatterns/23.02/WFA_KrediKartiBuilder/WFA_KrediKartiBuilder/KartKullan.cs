using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class KartKullan
    {
        public void KartiKullan(KrediKartiBuilder kart, string bankaAdi, string kartTipi, decimal kartlimiti, bool taksit )
        {
            kart.Bankadi(bankaAdi);
            kart.KartLimit(kartlimiti);
            kart.TaksitImkani(taksit);
            kart.KartTip(kartTipi);
        }
    }
}
