using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class Rezervasyon_yap
    {
        public string rezerva_tercih { get; set; }
        public AbstractGenerate_rezervasyon _abstractGenerate_rezervasyon;
        public IKonaklama _konaklama;
        public IUlasim _ulasim;

        public Rezervasyon_yap(AbstractGenerate_rezervasyon abstractGenerate_rezervasyon)
        {
            _abstractGenerate_rezervasyon = abstractGenerate_rezervasyon;
            _konaklama = _abstractGenerate_rezervasyon.CreatKonklama();
            _ulasim = _abstractGenerate_rezervasyon.CreatUlasim();
            rezerva_tercih = _abstractGenerate_rezervasyon.Tercih();

        }
        public void BuildRezervasyon()
        {
            _konaklama.konaklama_rezer();
            _ulasim.Ulasim_rezer();

        }
    }
}
