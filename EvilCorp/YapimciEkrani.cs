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

namespace EvilCorp
{
    public partial class YapimciEkrani : Form
    {
        public YapimciEkrani()
        {
            InitializeComponent();
        }

        private void HesapSil(int hesapId)
        {
            // PostgreSQL bağlantı stringi
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=kepler10b;Database=EvilCorp.";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL fonksiyonunu çalıştırıyoruz
                    using (var cmd = new NpgsqlCommand("SELECT magaza.hesap_silme(@hesap_id);", connection))
                    {
                        cmd.Parameters.AddWithValue("@hesap_id", hesapId);

                        // Fonksiyonu çalıştır
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hesap ve bağlı veriler başarıyla silindi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txt_id.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }


            int hesapId = Convert.ToInt32(txt_id.Text); // TextBox'tan alınan oyuncu ID'si

            HesapSil(hesapId);

        }   
           
    }
}
