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
    public partial class RezervasyonEkraniForm : Form
    {
        public string  ulasim_konaklama_tercih { get; set; }
        public RezervasyonEkraniForm()
        {
            InitializeComponent();
        }
        
        static string constring = ("Data Source=DESKTOP-CFN2IQC;Initial Catalog=YazilimMimairsi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection baglan = new SqlConnection(constring);

        private void RezYapButton_Click(object sender, EventArgs e)
        {

            if (UlasimcomboBox.Text== "Otobüs" & KonaklamacomboBox.Text== "Otel")
            {
                Rezervasyon_yap ry = new Rezervasyon_yap(new Otobus_Otel());
                ry.BuildRezervasyon();
             
               ulasim_konaklama_tercih = ry.rezerva_tercih;
            }

            else if (UlasimcomboBox.Text == "Uçak" & KonaklamacomboBox.Text == "Otel")
            {
                Rezervasyon_yap ry = new Rezervasyon_yap(new Ucak_Otel());
                ry.BuildRezervasyon();
                ulasim_konaklama_tercih = ry.rezerva_tercih;
            }
            else if (UlasimcomboBox.Text == "Otobüs" & KonaklamacomboBox.Text == "Çadır")
            {
                Rezervasyon_yap ry = new Rezervasyon_yap(new Otobus_Cadir());
                ry.BuildRezervasyon();
                ulasim_konaklama_tercih = ry.rezerva_tercih;
            }
            else if (UlasimcomboBox.Text == "Uçak" & KonaklamacomboBox.Text == "Çadır")
            {
                Rezervasyon_yap ry = new Rezervasyon_yap(new Ucak_Cadir());
                ry.BuildRezervasyon();
                ulasim_konaklama_tercih = ry.rezerva_tercih;

            }
            else { MessageBox.Show("LÜTFEN!! KONAKLAMA VE ULAŞIM TERCİHLERİNİ ŞEÇ");}
           // MessageBox.Show(ulasim_konaklama_tercih);



            try
            {
                if(baglan.State==ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "insert into RezBilgileri (musteri_ad,musteri_soyad,musteri_tcno,musteri_telno,lokasyon,gidis_tarihi,donus_tarihi,gidis_saati,donus_saati,oda_sayisi,gun_sayisi,musteri_mail,ulasim_konaklama_tercih,odenecektutar)values(@musteri_ad,@musteri_soyad,@musteri_tcno,@musteri_telno,@lokasyon,@gidis_tarihi,@donus_tarihi,@gidis_saati,@donus_saati,@oda_sayisi,@gun_sayisi,@musteri_mail,@ulasim_konaklama_tercih,@odenecektutar)";

                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@musteri_ad", MusteriAdtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_soyad",MusteriSoyadtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_tcno", MusteriTCtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_telno", MusteriTelNotextBox.Text);
                    komut.Parameters.AddWithValue("@lokasyon", LokasyoncomboBox.Text);
                    //komut.Parameters.AddWithValue("@konaklama",KonaklamacomboBox.Text);
                    //komut.Parameters.AddWithValue("@ulasim", UlasimcomboBox.Text);
                    komut.Parameters.AddWithValue("@gidis_tarihi", GidisTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@donus_tarihi", DonusTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@gidis_saati", GidisSaaticomboBox.Text);
                    komut.Parameters.AddWithValue("@donus_saati",DonusSaaticomboBox.Text);
                    komut.Parameters.AddWithValue("@oda_sayisi", OdaSayısıtextBox.Text); 
                    komut.Parameters.AddWithValue("@gun_sayisi",GunSayisiTextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_mail", MusteriMailtextBox.Text);
                    komut.Parameters.AddWithValue("@ulasim_konaklama_tercih", ulasim_konaklama_tercih);
                    komut.Parameters.AddWithValue("@odenecektutar", OdenecekTutartextBox.Text);


                    komut.ExecuteNonQuery();

                    MessageBox.Show("Rezervasyonunuz yapılmıştır.");
                    AnamenuForm anam = new AnamenuForm();
                    anam.Show();
                    this.Hide(); 
                    
                }
            }
            catch(Exception hata)
            {
               MessageBox.Show("hata"+hata.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnamenuForm ana = new AnamenuForm();
            ana.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void RezervasyonEkranıForm_Load(object sender, EventArgs e)
        {

        }
    }
}
