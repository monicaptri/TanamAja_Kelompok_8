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

namespace TanamAja
{
    public partial class Form3 : Form
    {
        private string namaItem;
        public Form3(string item)
        {
            InitializeComponent();
            namaItem = item;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String koneksi ke PostgreSQL
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=TANAMAJA;";

            // Query SQL untuk insert data
            string query = "INSERT INTO Pesanan (nama_Item, Nama, Alamat, Nomor_Telepon, Luas_Lahan, Detail_Lainnya) " +
                           "VALUES (@nama_Item, @Nama, @Alamat, @Nomor_Telepon, @Luas_Lahan, @Detail_Lainnya)";

            try
            {
                // Koneksi ke PostgreSQL
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Mengatur parameter dengan nilai dari TextBox
                        cmd.Parameters.AddWithValue("@nama_Item", namaItem);
                        cmd.Parameters.AddWithValue("@Nama", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Alamat", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Nomor_Telepon", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Luas_Lahan", Convert.ToDouble(textBox4.Text));
                        cmd.Parameters.AddWithValue("@Detail_Lainnya", textBox5.Text);

                        // Membuka koneksi dan eksekusi query
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear TextBox setelah simpan
                        ClearTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}

