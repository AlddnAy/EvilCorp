using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VTS
{
    public partial class Magaza : Form
    {


        private int hesapID; // Hesap ID'yi saklamak için alan

        public Magaza(int hesapID)
        {
            InitializeComponent();
            this.hesapID = hesapID;


        }



        public void HesapBilgileriniGuncelle(int hesapId, string nickname, string parola)
        {
            string connectionString = "server=localhost;port=5432;Database=EvilCorp.;user ID=postgres;password=kepler10b";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL fonksiyonunu çağırma
                    string query = "SELECT magaza.hesap_bilgilerini_guncelle(@hesap_id, @nickname, @parola)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Parametreleri ekleme
                        cmd.Parameters.AddWithValue("@hesap_id", hesapId);
                        cmd.Parameters.AddWithValue("@nickname", nickname);
                        cmd.Parameters.AddWithValue("@parola", parola);

                        // Fonksiyonu çalıştırma
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hesap bilgileri başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }



        private void LoadKutuphane(int hesapId)
        {

            try
            {
                // PostgreSQL bağlantısı
                string connString = "Host=localhost;Username=postgres;Password=kepler10b;Database=EvilCorp.";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Fonksiyonu çağırmak
                    string query = "SELECT * FROM kutuphane_listele(@hesap_id)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("hesap_id", hesapId);

                        // Veriyi çekme
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Veriyi DataGridView'e aktar
                            kutuphane.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }






        private void Magaza_Load(object sender, EventArgs e)
        {
            // hesapID'yi kullanarak gerekli işlemleri yapabilirsiniz
            MessageBox.Show($"Giriş yapan kullanıcının hesap ID'si: {hesapID}");

            string connectionString = "server = localHost; port=5432; Database=EvilCorp.; user ID = postgres; password= kepler10b ";


            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT kartno FROM magaza.kart WHERE hesap_id = @hesap_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hesap_id", KullaniciBilgileri.HesapID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }





        }


        public Magaza()
        {
            InitializeComponent();
        }

        public static class KullaniciBilgileri
        {
            public static int HesapID { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                string kartNo = txt_kartNo.Text.Trim();
                string isimSoyisim = txt_isimsoy.Text.Trim();
                string cvv = txt_cvv.Text.Trim();
                DateTime sonKullanmaTarihi;

                bool tarihValid = DateTime.TryParse(mas_sonkul.Text, out sonKullanmaTarihi);

                if (string.IsNullOrEmpty(kartNo) || string.IsNullOrEmpty(isimSoyisim) || string.IsNullOrEmpty(cvv) || !tarihValid)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun ve geçerli bir tarih girin.");
                    return;
                }

                string connectionString = "server = localHost; port=5432; Database=EvilCorp.; user ID = postgres; password= kepler10b ";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string kartID;

                    // Kart ekle
                    string kartQuery = "INSERT INTO magaza.kart (kart_no, isim_soyisim, cvv, sonk) VALUES (@kartno, @isimSoyisim, @cvv, @sonTarih) RETURNING kart_no";
                    using (var cmd = new NpgsqlCommand(kartQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@kartno", kartNo);
                        cmd.Parameters.AddWithValue("@isimSoyisim", isimSoyisim);
                        cmd.Parameters.AddWithValue("@cvv", cvv);
                        cmd.Parameters.AddWithValue("@sonTarih", sonKullanmaTarihi);

                        kartID = (string)cmd.ExecuteScalar();

                        // Cüzdan tablosuna ekle
                        string cuzdanQuery = "INSERT INTO magaza.cuzdan (hesap_id, kart_no) VALUES (@hesapID, @kartID)";
                        using (var cmdCuzdan = new NpgsqlCommand(cuzdanQuery, conn))
                        {
                            cmdCuzdan.Parameters.AddWithValue("@hesapID", hesapID);
                            cmdCuzdan.Parameters.AddWithValue("@kartID", kartID);
                            cmdCuzdan.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Kart başarıyla eklendi!");
                comboBox1.Items.Add(kartNo); // Yeni kart numarasını ComboBox'a ekle



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        public void KullaniciKutuphanesiniGoster(int hesapId)
        {
            string connectionString = "server=localhost; port=5432; Database=EvilCorp.; user ID=postgres; password=kepler10b";
            string query = "SELECT u.isim AS oyun_adi, so.sure " +
                           "FROM magaza.sahip_olunan_oyun so " +
                           "JOIN magaza.urun u ON so.oyun_id = u.urun_id " +
                           "WHERE so.hesap_id = @hesap_id AND u.oyun_mu = TRUE";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // DataTable oluştur
                    DataTable dt = new DataTable();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Parametreyi ekle
                        cmd.Parameters.AddWithValue("@hesap_id", hesapId);

                        // Veriyi DataAdapter ile al ve DataTable'a aktar
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    // DataGridView'e veriyi yansıt
                    kutuphane.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciKutuphanesiniGoster(hesapID);


        }

        OyunAl o;
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int oyuncuid=Convert.ToInt32(txt_oyuncuid.Text);
            string isim = txt_isim.Text.Trim();
            string soyisim = txt_soyisim.Text.Trim();
            

            // Verileri kontrol etme
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) )
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }


            HesapBilgileriniGuncelle(oyuncuid, isim, soyisim);


        }

        public class OyunAl
        {
            private string connectionString = "Host=myhost;Username=postgres;Password=kepler10b;Database=EvilCorp.";

            public void OyunAlma(int hesapId, int oyunId)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT magaza.oyun_alma_fonksiyonu(@hesap_id, @oyun_id)", conn))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("hesap_id", hesapId);
                        cmd.Parameters.AddWithValue("oyun_id", oyunId);

                        try
                        {
                            // SQL fonksiyonunu çalıştır
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Oyun başarıyla alındı!");
                        }
                        catch (Exception ex)
                        {
                            // Hata durumunda kullanıcıya bildirim yap
                            Console.WriteLine("Hata: " + ex.Message);
                        }
                    }
                }
            }
        }


    }
}
