using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTS
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }


        public void OyuncuGuncelle(int oyuncuId, string isim, string soyisim, string telefon, string dogumTarihi, string eposta)
        {

            string connectionString = "server=localhost;port=5432;Database=EvilCorp.;user ID=postgres;password=kepler10b";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT magaza.oyuncu_guncelle(@oyuncu_id, @isim, @soyisim, @tel, @dg, @mail)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("oyuncu_id", oyuncuId);
                        cmd.Parameters.AddWithValue("isim", isim);
                        cmd.Parameters.AddWithValue("soyisim", soyisim);
                        cmd.Parameters.AddWithValue("tel", telefon);
                        cmd.Parameters.AddWithValue("dg", dogumTarihi); // Doğum tarihi
                        cmd.Parameters.AddWithValue("mail", eposta);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void KayitEkle(string isim, string soyisim, string telefon, string dogumTarihi, string eposta, string nickname, string parola1)
        {
            string connectionString = "server=localhost;port=5432;Database=EvilCorp.;user ID=postgres;password=kepler10b";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Oyuncu ekle fonksiyonunu çağır
                    string query1 = "SELECT magaza.oyuncu_ekle(@isim, @soyisim, @tel, @dg, @mail)";

                    int oyuncuId;
                    using (var cmd = new NpgsqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("isim", isim);
                        cmd.Parameters.AddWithValue("soyisim", soyisim);
                        cmd.Parameters.AddWithValue("tel", telefon);
                        cmd.Parameters.AddWithValue("dg", dogumTarihi);
                        cmd.Parameters.AddWithValue("mail", eposta);

                        oyuncuId = (int)cmd.ExecuteScalar();
                    }

                    // Hesap ekle fonksiyonunu çağır
                    string query2 = "SELECT magaza.hesap_ekle(nickname, parola, oyuncuId)";

                    using (var cmd = new NpgsqlCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("nickname", nickname);
                        cmd.Parameters.AddWithValue("parola", parola1);
                        cmd.Parameters.AddWithValue("oyuncuId", oyuncuId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Formdaki TextBox'lardan veri alma
            string isim = txt_isim.Text.Trim();
            string soyisim = txt_soyisim.Text.Trim();
            string telefon = mas_telefon.Text.Trim();  // MaskedTextBox'tan telefon
            string eposta = mas_eposta.Text.Trim();
            string nickname = txt_nick.Text.Trim();
            string parola1 = mas_eposta.Text.Trim();
            string parola2 = mas_eposta.Text.Trim();

            
            string dogumTarihi=mas_date.Text;

            // Verileri kontrol etme
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(eposta))
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }

           

            if (parola1 != parola2)
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil!");
                return;
            }

            KayitEkle(isim, soyisim, telefon, dogumTarihi, eposta, nickname, parola1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oyuncuid = Convert.ToInt32(txt_oyuncuid.Text);
            string isim = txt_isim.Text.Trim();
            string soyisim = txt_soyisim.Text.Trim();
            string telefon = mas_telefon.Text.Trim();  // MaskedTextBox'tan telefon
            string eposta = txt_mail.Text.Trim();
            string dogumTarihi= mas_date.Text;
            

            // Verileri kontrol etme
            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(eposta))
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }

            

            OyuncuGuncelle(oyuncuid, isim, soyisim, telefon, dogumTarihi, eposta);
        }
    }
}
