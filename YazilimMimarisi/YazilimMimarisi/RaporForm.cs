using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=YazilimMimairsi;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        private void RezGetirbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * From RezBilgileri Where musteri_mail='" + MailtextBox.Text + "'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnamenuForm ana = new AnamenuForm();
            ana.Show();
            this.Hide();
        }
    }
}
