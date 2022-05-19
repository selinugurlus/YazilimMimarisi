using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yazilim_mim
{
    public abstract class AbstractGenerate_rezervasyon
    {
        public abstract IUlasim CreatUlasim();
        public abstract IKonaklama CreatKonklama();
    }
}