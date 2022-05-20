using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    public class Ucak_Cadir : AbstractGenerate_rezervasyon
    {

        public Ucak_Cadir()
        {
            System.Windows.Forms.MessageBox.Show("Ucak-cadir rezervsyon olosturdu");
        }
        public override IKonaklama CreatKonklama()
        {
            return new Cadir();
        }

        public override IUlasim CreatUlasim()
        {
            return new Ucak();
        }


    }
}
