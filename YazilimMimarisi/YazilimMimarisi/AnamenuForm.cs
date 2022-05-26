using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class AnamenuForm : Form
    {
        public AnamenuForm()
        {
            InitializeComponent();
        }

        private void RezYapbutton_Click(object sender, EventArgs e)
        {
            RezervasyonEkraniForm rez = new RezervasyonEkraniForm();
            rez.Show(); 
            this.Hide();
        }

        private void Rezİptalbutton_Click(object sender, EventArgs e)
        {
            RezİptalEkranıForm reziptl = new RezİptalEkranıForm();
            reziptl.Show();
            this.Hide();
        }

        private void RaporAlbutton_Click(object sender, EventArgs e)
        {
            RaporForm rpr = new RaporForm();
            rpr.Show();
            this.Hide();
        }
    }
}
