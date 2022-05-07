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
    public partial class RezervasyonEkranıForm : Form
    {
        public RezervasyonEkranıForm()
        {
            InitializeComponent();
        }
        
        static string constring = ("Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=YazilimMimairsi;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        private void RezYapButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglan.State==ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "insert into RezBilgileri (musteri_ad,musteri_soyad,musteri_tcno,musteri_telno,lokasyon,konaklama,ulasim,gidis_tarihi,donus_tarihi,gidis_saati,donus_saati,oda_sayisi,gun_sayisi)values(@musteri_ad,@musteri_soyad,@musteri_tcno,@musteri_telno,@lokasyon,@konaklama,@ulasim,@gidis_tarihi,@donus_tarihi,@gidis_saati,@donus_saati,@oda_sayisi,@gun_sayisi)";

                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@musteri_ad", MusteriAdtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_soyad",MusteriSoyadtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_tcno", MusteriTCtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_telno", MusteriTelNotextBox.Text);
                    komut.Parameters.AddWithValue("@lokasyon", LokasyoncomboBox.Text);
                    komut.Parameters.AddWithValue("@konaklama",KonaklamacomboBox.Text);
                    komut.Parameters.AddWithValue("@ulasim", UlasimcomboBox.Text);
                    komut.Parameters.AddWithValue("@gidis_tarihi", GidisTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@donus_tarihi", DonusTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@gidis_saati", GidisSaaticomboBox.Text);
                    komut.Parameters.AddWithValue("@donus_saati",DonusSaaticomboBox.Text);
                    komut.Parameters.AddWithValue("@oda_sayisi", OdaSayısıtextBox.Text);
                    komut.Parameters.AddWithValue("@gun_sayisi",GunSayisiTextBox.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Rezervasyonunuz yapılmıştır.");                    
                }
            }
            catch(Exception hata)
            {
               MessageBox.Show("hata"+hata.Message);

            }
        }
    }
}
