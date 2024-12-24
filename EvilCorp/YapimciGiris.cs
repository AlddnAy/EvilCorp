using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VTS
{
    public partial class YapimciGiris : Form
    {
        public YapimciGiris()
        {
            InitializeComponent();
        }


        public static class YapimciBilgileri
        {
            public static int YapimciID { get; set; }
        }


        string connectionString = "Host=localhost;Username=postgres;Password=kepler10b;Database=EvilCorp.";

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                string connectionString = "server=localhost;port=5432;Database=EvilCorp.;user ID=postgres;password=kepler10b";


                string isim = txt_isim.Text.Trim();
                string parola = mas_par.Text.Trim();

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Kullanıcı doğrulama sorgusu
                    string query = "SELECT yapimci_id FROM magaza.yapimci WHERE isim = @isim AND parola = @parola";


                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@parola", parola);

                        var yapimciID = cmd.ExecuteScalar();
                        if (yapimciID != null)
                        {
                            int YapimciId = Convert.ToInt32(yapimciID);
                            MessageBox.Show("Giriş başarılı!");
                            YoneticiEkranı yoneticiEkranı = new YoneticiEkranı(YapimciId);
                            yoneticiEkranı.ShowDialog();
                            this.Hide();

                        }

                        else
                        {
                            MessageBox.Show("E-posta veya parola hatalı!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }







        }
    }
}
