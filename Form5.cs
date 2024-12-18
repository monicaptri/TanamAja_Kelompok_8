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
    public partial class Form5 : Form
    {
        public Form5(DataTable dataSource)
        {
            InitializeComponent();
            LoadData();
        }
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=perdani;Database=DatabaseTanamaja";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan kita mengklik di dalam baris (bukan header)
            if (e.RowIndex >= 0)
            {
                // Ambil data dari baris yang dipilih
                string nama = dataGridView1.Rows[e.RowIndex].Cells["nama_katalog"].Value?.ToString() ?? "N/A";
                string stok = dataGridView1.Rows[e.RowIndex].Cells["stok"].Value?.ToString() ?? "0";
                string deskripsi = dataGridView1.Rows[e.RowIndex].Cells["deskripsi"].Value?.ToString() ?? "Tidak ada deskripsi";


                // Tampilkan data di TextBox atau lakukan aksi lainnya
                textBox1.Text = nama;
                textBox2.Text = stok;
                textBox3.Text = deskripsi;
            }
        }
        private void UpdateDatabase(string newNama, int newStok, string newDeskripsi, int rowIndex)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=perdani;Database=DatabaseTanamaja";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Membuat query UPDATE untuk memperbarui data
                string query = "UPDATE Katalog SET id = @newid, nama_katalog = @newNama, stok = @newStok, deskripsi = @newDeskripsi WHERE id_katalog = @id";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    // Mengganti parameter dengan nilai yang dimasukkan
                    cmd.Parameters.AddWithValue("newNama", newNama);
                    cmd.Parameters.AddWithValue("newStok", newStok);
                    cmd.Parameters.AddWithValue("newDeskripsi", newDeskripsi);
                    cmd.Parameters.AddWithValue("id", dataGridView1.Rows[rowIndex].Cells["id"].Value); // Gunakan ID untuk mencari baris yang sesuai

                    cmd.ExecuteNonQuery(); // Menjalankan query
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count == 1)
        //    {
        //        try
        //        {
        //            // Ambil indeks baris yang dipilih
        //            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

        //            // Validasi kolom 'id_katalog'
        //            if (!dataGridView1.Columns.Contains("id_katalog"))
        //            {
        //                MessageBox.Show("Kolom 'id_katalog' tidak ditemukan di DataGridView.");
        //                return;
        //            }

        //            // Ambil data baru dari TextBox
        //            string newNama = textBox1.Text;
        //            int newStok;
        //            if (!int.TryParse(textBox2.Text, out newStok))
        //            {
        //                MessageBox.Show("Stok harus berupa angka yang valid.");
        //                return; // Keluar dari fungsi jika input tidak valid
        //            }
        //            string newDeskripsi = textBox3.Text;

        //            // Ambil ID dari data yang dipilih
        //            int id = int.TryParse(dataGridView1.Rows[rowIndex].Cells["id_katalog"].Value?.ToString(), out int tempId) ? tempId : 0;


        //            // Update database
        //            using (var conn = new NpgsqlConnection(connectionString))
        //            {
        //                conn.Open();
        //                string query = "UPDATE katalog SET nama_katalog = @newNama, stok = @newStok, deskripsi = @newDeskripsi WHERE id_katalog = @id";
        //                using (var cmd = new NpgsqlCommand(query, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("newNama", newNama);
        //                    cmd.Parameters.AddWithValue("newStok", newStok);
        //                    cmd.Parameters.AddWithValue("newDeskripsi", newDeskripsi);
        //                    cmd.Parameters.AddWithValue("id", id);

        //                    int rowsAffected = cmd.ExecuteNonQuery();
        //                    if (rowsAffected > 0)
        //                    {
        //                        MessageBox.Show("Data berhasil diperbarui di database.");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Tidak ada baris yang diperbarui.");
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Pilih baris untuk diperbarui.");
        //    }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToResizeColumns = true;

            if (e.RowIndex == 1) // Pastikan baris valid
            {
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells["nama_katalog"].Value?.ToString() ?? "Data tidak tersedia";
                MessageBox.Show($"You clicked on: {cellValue}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    // Ambil indeks baris yang dipilih
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    // Validasi kolom 'id_katalog'
                    if (!dataGridView1.Columns.Contains("id_katalog"))
                    {
                        MessageBox.Show("Kolom 'id_katalog' tidak ditemukan di DataGridView.");
                        return;
                    }

                    // Ambil data baru dari TextBox
                    string newNama = textBox1.Text;
                    int newStok;
                    if (!int.TryParse(textBox2.Text, out newStok))
                    {
                        MessageBox.Show("Stok harus berupa angka yang valid.");
                        return; // Keluar dari fungsi jika input tidak valid
                    }
                    string newDeskripsi = textBox3.Text;

                    // Ambil ID dari data yang dipilih
                    int id = int.TryParse(dataGridView1.Rows[rowIndex].Cells["id_katalog"].Value?.ToString(), out int tempId) ? tempId : 0;


                    // Update database
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE katalog SET nama_katalog = @newNama, stok = @newStok, deskripsi = @newDeskripsi WHERE id_katalog = @id";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("newNama", newNama);
                            cmd.Parameters.AddWithValue("newStok", newStok);
                            cmd.Parameters.AddWithValue("newDeskripsi", newDeskripsi);
                            cmd.Parameters.AddWithValue("id", id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diperbarui di database.");
                            }
                            else
                            {
                                MessageBox.Show("Tidak ada baris yang diperbarui.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Pilih baris untuk diperbarui.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); 
            this.Hide();
            form4.Show();
        }
    }
}
