using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Ucak_Otel : AbstractGenerate_rezervasyon

    {
        public Ucak_Otel()
        {
            
        }
        public override IKonaklama CreatKonklama()
        {
            return new Otel();
        }

        public override IUlasim CreatUlasim()
        {
            return new Ucak();
        }
        public override string Tercih()
        {
            return "ucak-otel";
        }
       
    }
}
