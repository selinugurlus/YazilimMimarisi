using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim_mim
{
    class Rezervasyon_Generat
    {
        public AbstractGenerate_rezervasyon _abstractGenerate_rezervasyon;
        public IKonaklama _konaklama;
        public IUlasim _ulasim;

        public  Rezervasyon_Generat(AbstractGenerate_rezervasyon abstractGenerate_rezervasyon)
        {
           _abstractGenerate_rezervasyon = abstractGenerate_rezervasyon;
           _konaklama = _abstractGenerate_rezervasyon.CreatKonklama();
           _ulasim = _abstractGenerate_rezervasyon.CreatUlasim();

        }
        public void BuildRezervasyon()
        {
            _konaklama.konaklama_rezer();
            _ulasim.Ulasim_rezer();

        }
    }
}
