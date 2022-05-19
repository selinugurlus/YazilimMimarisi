using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_mim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OtobusOtel.Checked)
            {
                Rezervasyon_Generat rg = new Rezervasyon_Generat(new Otobus_Otel() );
                rg.BuildRezervasyon();

            }

            else if (UcakOtel.Checked)
            {
                Rezervasyon_Generat rg = new Rezervasyon_Generat(new Ucak_Otel());
                rg.BuildRezervasyon();
            }
            else if (OtobusCadir.Checked)
            {
                Rezervasyon_Generat rg = new Rezervasyon_Generat(new Otobus_Cadir());
                rg.BuildRezervasyon();
            }
            else if (UcakCadir.Checked)
            {
                Rezervasyon_Generat rg = new Rezervasyon_Generat(new Ucak_Cadir());
                rg.BuildRezervasyon();

            }
        }

        private void OtobusCadir_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
