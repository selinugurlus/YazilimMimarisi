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

        static string constring = ("Data Source=DESKTOP-CFN2IQC;Initial Catalog=YazilimMimairsi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

       

        private void HepsiİptalButton_Click(object sender, EventArgs e)
        {


            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("diğer rezervasyonunda iptal edelmese istiyourmusunuz?", "UYARI!!!!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("delete from RezBilgileri  Where musteri_mail='" + RezİptalRezNotextBox.Text + "'", baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("iptal edilmiştir.");
                AnamenuForm an = new AnamenuForm();
               
                AnamenuForm anaf = new AnamenuForm();
                anaf.Show();
                this.Close();
            }
            else
            {
               
            }

            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnamenuForm ana = new AnamenuForm();
            ana.Show();
            this.Hide();
        }

        private void RezİptalEkranıForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
