using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Otobus_Cadir : AbstractGenerate_rezervasyon
    {
        public Otobus_Cadir()
        {
            
        }
        public override IKonaklama CreatKonklama()
        {
            return new Cadir();
        }

        public override IUlasim CreatUlasim()
        {
            return new Otobus();
        }
        public override string Tercih()
        {
            return "otobus-cadir";
        }
    }
}
