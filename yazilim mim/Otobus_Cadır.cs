using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yazilim_mim
{
    public class Otobus_Cadir : AbstractGenerate_rezervasyon
    {
        public Otobus_Cadir()
        {
            System.Windows.Forms.MessageBox.Show("otobus-cadir rezervsyon olosturdu");
        }
        public override IKonaklama CreatKonklama()
        {
            return new Cadir();
        }

        public override IUlasim CreatUlasim()
        {
            return new Otobus();
        }

        
    }
}