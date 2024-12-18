using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TanamAja.App.View
{
    public partial class RiwayatCustomer : Form
    {
        private string username;
        private static readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=TANAMAJA;";

        public RiwayatCustomer()
        {
            InitializeComponent();
            this.username = username; // Simpan username
        }
        

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void loadDataRiwayat()
        {
            try
            {
                DataTable riwayatData = new DataTable();
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_pesanan,nama_Item, Nama, Alamat, Nomor_Telepon, Luas_Lahan, Detail_Lainnya FROM Pesanan ORDER BY id_pesanan ASC";
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
                if (dataGridView1.Columns.Contains("id_pesanan"))
                    dataGridView1.Columns["id_pesanan"].Visible = false;
                if (dataGridView1.Columns.Contains("Nama"))
                    dataGridView1.Columns["Nama"].HeaderText = "Nama";
                if (dataGridView1.Columns.Contains("Alamat"))
                    dataGridView1.Columns["Alamat"].HeaderText = "Alamat";
                if (dataGridView1.Columns.Contains("Nomor_Telepon"))
                    dataGridView1.Columns["Nomor_Telepon"].HeaderText = "Nomor Telepon";
                if (dataGridView1.Columns.Contains("Luas_Lahan"))
                    dataGridView1.Columns["Luas_Lahan"].HeaderText = "Luas Lahan";
                if (dataGridView1.Columns.Contains("Detail_Lainnya"))
                    dataGridView1.Columns["Detail_Lainnya"].HeaderText = "Detail Lainya";

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

        private void RiwayatCustomer_Load(object sender, EventArgs e)
        {
            // Menangani event setelah data binding selesai
            dataGridView1.DataBindingComplete += DataGridRiwayat_DataBindingComplete;

            // Memanggil fungsi untuk memuat data
            loadDataRiwayat();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                 "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kembali ke form login
                formLogin loginForm = new formLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username))
            {
                // Kirim username ke form MelihatProfilCustomer
                MelihatProfilCustomer melihatProfilCustomer = new MelihatProfilCustomer(username);
                melihatProfilCustomer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
