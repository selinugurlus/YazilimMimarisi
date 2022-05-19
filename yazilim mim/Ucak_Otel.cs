using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yazilim_mim
{
    public class Ucak_Otel : AbstractGenerate_rezervasyon
        
    {
        public Ucak_Otel()
        {
            System.Windows.Forms.MessageBox.Show("Ucak-otel rezervsyon olosturdu");
        }
        public override IKonaklama CreatKonklama()
        {
            return new Otel();
        }

        public override IUlasim CreatUlasim()
        {
            return new Ucak();
        }

       

        
    }
}