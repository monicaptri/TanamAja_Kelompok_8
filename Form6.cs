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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TanamAja
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk mengambil data
                    string query = "SELECT * FROM katalog";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);

                    // Isi DataTable
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Tampilkan data di DataGridView
                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=perdani;Database=DatabaseTanamaja";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Koneksi ke database PostgreSQL
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=perdani;Database=DatabaseTanamaja";

            // Ambil nilai dari TextBox
            string nama = textBox1.Text;
            string stok = textBox2.Text;
            string deskripsi = textBox3.Text;

            // Query SQL untuk insert data
            string query = "INSERT INTO katalog (nama_katalog, stok, deskripsi) VALUES (@nama_katalog, @stok, @deskripsi)";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Parameter untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@nama_katalog", nama);
                        cmd.Parameters.AddWithValue("@stok", int.Parse(stok)); // Pastikan stok berupa integer
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);

                        // Eksekusi query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} baris berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
