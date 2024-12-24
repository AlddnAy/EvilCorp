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
    public partial class YoneticiEkranı : Form
    {
        private int yapimciId;

        public YoneticiEkranı(int yapimciId)
        {
            InitializeComponent();
            this.yapimciId = yapimciId;
        }

        private void indirim_btn_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan verileri text boxlardan alıyoruz
            int oyunId = Convert.ToInt32(txt_oyunid.Text);  // Oyun ID
            string basarimIsim = txt_bas.Text;  // Başarım İsmi

            // PostgreSQL bağlantısı için gerekli bağlantı dizesi
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=kepler10b;Database=EvilCorp.";

            try
            {
                // PostgreSQL bağlantısı oluşturuluyor
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();  // Bağlantı açılıyor

                    // Fonksiyon çağrısı için SQL komutu hazırlanıyor
                    string sql = "SELECT basarim_ekle(@oyun_id, @basarim_isim);";

                    // SQL komutu için NpgsqlCommand nesnesi oluşturuluyor
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Parametreler ekleniyor
                        cmd.Parameters.AddWithValue("@oyun_id", oyunId);
                        cmd.Parameters.AddWithValue("@basarim_isim", basarimIsim);

                        // Fonksiyon çalıştırılıyor
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarım başarıyla eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan değerler
            string isim = txt_oyunisim.Text.Trim();
            int yasSiniri = Convert.ToInt16(txt_yas.Text.Trim());
            decimal fiyat = Convert.ToDecimal(txt_fiyat.Text.Trim());
            decimal indirimliFiyat = Convert.ToDecimal(txt_indirim.Text.Trim());
            bool oyunMu = chkOyunMu.Checked; // Checkbox: True (oyun), False (dlc)

            // PostgreSQL bağlantısı
            string connectionString = "Host=localhost;Username=postgres;Password=kepler10b;Database=EvilCorp.";
            string query = "SELECT magaza.magaza_urun_ekle1(@isim, @yas_siniri, @fiyat, @indirimli_fiyat, @yapimci_id, @oyun_mu)";


            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@yas_siniri", yasSiniri);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@indirimli_fiyat", indirimliFiyat);
                        cmd.Parameters.AddWithValue("@yapimci_id", yapimciId); // Formda tutulan yapimci_id
                        cmd.Parameters.AddWithValue("@oyun_mu", oyunMu);

                        // Fonksiyonu çalıştır
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ürün başarıyla eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }





        }
   
    }
}
