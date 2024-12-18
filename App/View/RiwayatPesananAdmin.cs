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

namespace TanamAja.App.View
{
    public partial class RiwayatPesananAdmin : Form
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=perdani;Database=DatabaseTanamaja;";
        public RiwayatPesananAdmin()
        {
            InitializeComponent();
            LoadDataRiwayat();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            MelihatProfilAdmin melihatProfilAdmin = new MelihatProfilAdmin();
            melihatProfilAdmin.Show();
            this.Hide();
        }

        private void btnberanda_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                  "Konfirmasi Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                formLogin frmLogin = new formLogin();
                frmLogin.Show();
            }
        }

        private void RiwayatPesananAdmin_Load(object sender, EventArgs e)
        {
            LoadDataRiwayat();
        }

        private void LoadDataRiwayat()
        {
            try
            {
                // Query SQL untuk mengambil data transaksi
                string query = "SELECT id_pesanan,nama_Item, Nama, Alamat, Nomor_Telepon, Luas_Lahan, Detail_Lainnya FROM Pesanan ORDER BY id_pesanan ASC";

                // Membuka koneksi ke database PostgreSQL
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Membuat NpgsqlDataAdapter untuk menjalankan query dan mengisi data ke DataTable
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    // Mengisi DataTable dengan hasil query
                    adapter.Fill(dataTable);

                    // Menampilkan data di DataGridView
                    dataGridViewRiwayat.DataSource = dataTable;

                    // Mengatur header kolom dan visibilitas DataGridView
                    if (dataGridViewRiwayat.Columns.Contains("id_pesanan"))
                        dataGridViewRiwayat.Columns["id_pesanan"].Visible = false;

                    if (dataGridViewRiwayat.Columns.Contains("Nama"))
                        dataGridViewRiwayat.Columns["Nama"].HeaderText = "Nama";

                    if (dataGridViewRiwayat.Columns.Contains("Alamat"))
                        dataGridViewRiwayat.Columns["Alamat"].HeaderText = "Alamat";

                    if (dataGridViewRiwayat.Columns.Contains("Nomor_Telepon"))
                        dataGridViewRiwayat.Columns["Nomor_Telepon"].HeaderText = "Nomor Telepon";

                    if (dataGridViewRiwayat.Columns.Contains("Luas_Lahan"))
                        dataGridViewRiwayat.Columns["Luas_Lahan"].HeaderText = "Luas Lahan";

                    if (dataGridViewRiwayat.Columns.Contains("Detail_Lainnya"))
                        dataGridViewRiwayat.Columns["Detail_Lainnya"].HeaderText = "Detail Lainnya";

                    // Tambahkan nomor urut setelah data selesai di-bind
                    AddRowNumbers();
                }
            }
            catch (Exception ex)
            {
                // Menangkap error dan menampilkan pesan ke pengguna
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // button tukang kebun
        {
            FormTukangKebun formTukangKebun = new FormTukangKebun();
            formTukangKebun.Show();
            this.Hide();
        }

        private void AddRowNumbers()
        {
            // Tambahkan kolom "Nomor" jika belum ada
            if (!dataGridViewRiwayat.Columns.Contains("Nomor"))
            {
                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Nomor",
                    HeaderText = "No.",
                    Width = 50 // Lebar kolom nomor
                };
                dataGridViewRiwayat.Columns.Insert(0, nomorColumn); // Menambahkan kolom di posisi pertama
            }

            // Menambahkan nomor urut ke setiap baris
            foreach (DataGridViewRow row in dataGridViewRiwayat.Rows)
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

        private void dataGridViewRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRiwayat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
