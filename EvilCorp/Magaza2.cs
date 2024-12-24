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
    public partial class Magaza2 : Form
    {


        private int hesapID; // Hesap ID'yi saklamak için alan

        public Magaza2(int hesapID)
        {
            InitializeComponent();
            this.hesapID = hesapID;
        }

        private void Magaza2_Load(object sender, EventArgs e)
        {

        }



        public Magaza2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hesapID'yi kullanarak gerekli işlemleri yapabilirsiniz
            MessageBox.Show($"Giriş yapan kullanıcının hesap ID'si: {hesapID}");



            // PostgreSQL veritabanı bağlantı dizesi
            string connectionString = "Host=localhost;Username=postgres;Password=kepler10b;Database=EvilCorp.";

            // SQL sorgusu
            string query = "SELECT * FROM magaza.urun";

            try
            {
                // Bağlantıyı oluştur
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL komutunu oluştur
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // DataAdapter oluştur
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            // DataTable oluştur ve verileri yükle
                            DataSet dataTable = new DataSet();
                            adapter.Fill(dataTable);

                            // DataGridView'e verileri bind et
                            dataGridView1.DataSource = dataTable.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
