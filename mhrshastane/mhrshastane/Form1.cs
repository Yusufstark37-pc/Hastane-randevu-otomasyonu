using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mhrshastane
{
    public partial class Form1 : Form
    {
        string connStr = "Server=localhost;Database=hastane;Uid=root;Pwd=mysqlroot37;";
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKlinik.Items.AddRange(new string[] { "KBB", "Psikoloji", "Dahiliye" });
            cmbDoktor.Items.AddRange(new string[] { "Dr. Ayþe Demir", "Dr. Mehmet Can", "Dr. Elif Yýlmaz" });

            RandevulariListele();
        }

        private void RandevulariListele()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT * FROM Randevular";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatasý: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnRandevuAl_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "INSERT INTO Randevular (HastaAdSoyad, TcNo, Telefon, KlinikAdi, DoktorAdi, RandevuTarihi) " +
                               "VALUES (@ad, @tc, @tel, @klinik, @doktor, @tarih)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@tc", txtTC.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@klinik", cmbKlinik.Text);
                cmd.Parameters.AddWithValue("@doktor", cmbDoktor.Text);
                cmd.Parameters.AddWithValue("@tarih", dtpRandevu.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu baþarýyla alýndý.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            // Baðlantý kapatýldýktan sonra çaðýrmak güvenlidir
            RandevulariListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediðiniz randevuyu seçin.");
                    return;
                }

                int randevuId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "DELETE FROM Randevular WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", randevuId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Randevu baþarýyla silindi.");
                RandevulariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatasý: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}