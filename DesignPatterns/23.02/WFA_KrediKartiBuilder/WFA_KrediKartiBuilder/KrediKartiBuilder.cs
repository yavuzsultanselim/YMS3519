using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public abstract class KrediKartiBuilder
    {
        protected KrediKarti kart;

        public KrediKarti Kart
        {
            get { return kart; }
        }

        public abstract void Bankadi(string bankAdi);
        public abstract void KartTip(string kartTipi);
        public abstract void KartLimit(decimal kartLimit);
        public abstract void TaksitImkani(bool taksitImkani);




    }
}
