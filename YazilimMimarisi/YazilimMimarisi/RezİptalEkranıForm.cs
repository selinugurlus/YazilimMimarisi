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
    public partial class RezİptalEkranıForm : Form
    {
        public RezİptalEkranıForm()
        {
            InitializeComponent();
        }

        static string constring = ("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=YazilimMimairsi;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        
        

        private void RezGetirButton_Click(object sender, EventArgs e)
        {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * From RezBilgileri Where musteri_mail='" + RezİptalRezNotextBox.Text + "'", baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Update RezBilgileri Set konaklama='NULL',oda_sayisi='NULL',gun_sayisi='NULL' Where musteri_mail='" + RezİptalRezNotextBox.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Konaklama rezervasyonunuz iptal edilmiştir.");
        }

        private void UlasımRezİptalbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Update RezBilgileri Set ulasim='NULL',gidis_saat='NULL',donus_saat='NULL' Where musteri_mail='" + RezİptalRezNotextBox.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ulaşım rezervasyonunuz iptal edilmiştir.");
        }

        private void HepsiİptalButton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from RezBilgileri  Where musteri_mail='" + RezİptalRezNotextBox.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Konaklama ve ulaşım rezervasyonunuz iptal edilmiştir.");
        }
    }
    }
