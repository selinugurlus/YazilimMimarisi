using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public abstract class AbstractGenerate_rezervasyon
    {
        public abstract IUlasim CreatUlasim();
        public abstract IKonaklama CreatKonklama();
    }
}
