using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yazilim_mim
{
    public class Otobus_Otel : AbstractGenerate_rezervasyon
    {
        public Otobus_Otel()
        {
            System.Windows.Forms.MessageBox.Show("otobus-otel rezervsyon olosturdu");
        }
        public override IKonaklama CreatKonklama()
        {
            return new Otel();
        }

        public override IUlasim CreatUlasim()
        {
            return new Otobus();
        }

        
    }
}