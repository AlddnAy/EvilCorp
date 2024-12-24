using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvilCorp;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VTS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static class KullaniciBilgileri
        {
            public static int HesapID { get; set; }


        }
        public int OyuncuId { get; set; } // Giriş yapan oyuncunun ID'si


        public static class YapimciBilgileri
        {
            public static int YapimciID { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            YapimciGiris yapimciGiris = new YapimciGiris();
            yapimciGiris.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=5432;Database=EvilCorp.;user ID=postgres;password=kepler10b";


            string email = e_mask.Text.Trim();
            string parola = par_mask.Text.Trim();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kullanıcı doğrulama sorgusu
                    string query = "SELECT  magaza.hesap_id_bul(@mail, @parola)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@parola", parola);

                        var hesapId = cmd.ExecuteScalar();
                        if (hesapId != null)
                        {
                            // Giriş başarılı, hesap_id'yi alın
                            int hesapID = Convert.ToInt32(hesapId);


                            // Yeni formları açın ve hesap_id'yi aktarın
                            Magaza magaza1 = new Magaza(hesapID);
                            magaza1.Show();

                            Magaza2 magaza2 = new Magaza2(hesapID);
                            magaza2.Show();

                            this.Hide(); // Giriş formunu gizle
                        }
                        else
                        {
                            MessageBox.Show("E-posta veya parola hatalı!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YapimciEkrani yapimciEkrani = new YapimciEkrani();
            yapimciEkrani.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog(); 
        }
    }
}
