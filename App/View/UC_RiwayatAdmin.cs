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
using Npgsql;
using TanamAja.App.Context;

namespace TanamAja.App.View
{
    public partial class UC_RiwayatAdmin : UserControl
    {
        private static readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=DatabaseTanamaj;";
        public UC_RiwayatAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadDataRiwayat()
        {
            try
            {
                DataTable riwayatData = new DataTable();
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_Transaksi, Nama, Alamat_Lahan, Luas_Lahan, Nama_Bibit, Harga, Tanggal_Transaksi FROM Transaksi ORDER BY id_Transaksi ASC";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            riwayatData.Load(reader);
                        }
                    }
                }

                // Set DataSource ke DataGridView
                dataGridView1.DataSource = riwayatData;

                // Mengatur header kolom
                if (dataGridView1.Columns.Contains("id_Transaksi"))
                    dataGridView1.Columns["id_Transaksi"].Visible = false;
                if (dataGridView1.Columns.Contains("Nama"))
                    dataGridView1.Columns["Nama"].HeaderText = "Nama";
                if (dataGridView1.Columns.Contains("Alamat_Lahan"))
                    dataGridView1.Columns["Alamat_Lahan"].HeaderText = "Alamat Lahan";
                if (dataGridView1.Columns.Contains("Luas_Lahan"))
                    dataGridView1.Columns["Luas_Lahan"].HeaderText = "Luas Lahan";
                if (dataGridView1.Columns.Contains("Nama_Bibit"))
                    dataGridView1.Columns["Nama_Bibit"].HeaderText = "Nama Bibit";
                if (dataGridView1.Columns.Contains("Harga"))
                    dataGridView1.Columns["Harga"].HeaderText = "Harga";
                if (dataGridView1.Columns.Contains("Tanggal_Transaksi"))
                    dataGridView1.Columns["Tanggal_Transaksi"].HeaderText = "Tanggal Transaksi";

                // Tambahkan nomor urut setelah data selesai di-bind
                AddRowNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataRiwayat: {ex.Message}");
            }
        }

        private void AddRowNumbers()
        {
            // Tambahkan kolom "Nomor" jika belum ada
            if (!dataGridView1.Columns.Contains("Nomor"))
            {
                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Nomor",
                    HeaderText = "No.",
                    Width = 50 // Lebar kolom nomor
                };
                dataGridView1.Columns.Insert(0, nomorColumn); // Menambahkan kolom di posisi pertama
            }

            // Menambahkan nomor urut ke setiap baris
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Abaikan baris baru
                row.Cells["Nomor"].Value = row.Index + 1; // Nomor dimulai dari 1
            }
        }

        private void DataGridRiwayat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Menambahkan nomor urut setelah data selesai di-bind
            AddRowNumbers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_RiwayatAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataBindingComplete += DataGridRiwayat_DataBindingComplete;

            // Memanggil fungsi untuk memuat data
            loadDataRiwayat();
        }
    }
}
