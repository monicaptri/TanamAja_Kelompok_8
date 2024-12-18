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
using TanamAja.App.Core;

namespace TanamAja.App.View
{
    public partial class MelihatProfilAdmin : Form
    {
        private string role = "admin"; // Menyimpan role yang digunakan
        public MelihatProfilAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // katalog
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //tukangkebun
        {
            FormTukangKebun formTukangKebun = new FormTukangKebun();
            formTukangKebun.Show();
            this.Hide();
        }

        //private void AddUserControl(UserControl userControl)
        //{
        //    // Mengatur UserControl agar mengisi panel
        //    userControl.Dock = DockStyle.Fill;
        //    tempatriwayat.Controls.Clear();
        //    tempatriwayat.Controls.Add(userControl);
        //    userControl.BringToFront();
        //}

        private void button3_Click(object sender, EventArgs e) //riwayat admin
        {
            RiwayatPesananAdmin riwayatPesananAdmin = new RiwayatPesananAdmin();
            riwayatPesananAdmin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //Logout
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

        private void button5_Click(object sender, EventArgs e)// button ubah
        {
            // Panggil form MengubahProfilAdmin dan subscribe ke event DataUpdated
            MengubahProfilAdmin formUbah = new MengubahProfilAdmin();
            formUbah.DataUpdated += FormUbah_DataUpdated;  // Subscribe ke event DataUpdated
            formUbah.ShowDialog();  // Menampilkan form dalam mode dialog (modal)
        }

        // Method untuk menangani event DataUpdated
        private void FormUbah_DataUpdated(object sender, EventArgs e)
        {
            // Setelah data diubah, load ulang data admin
            LoadAdminProfile();
        }

        private void MelihatProfilAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminProfile();
        }

        private void LoadAdminProfile()
        {
            try
            {
                // Query untuk mengambil data admin dari database PostgreSQL
                string query = "SELECT username, alamat, email, nomor_telepon FROM users WHERE role = @role";

                // Parameter untuk query
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@role", role)
                };

                // Eksekusi query menggunakan DatabaseWrapper
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    // Ambil baris pertama hasil query
                    DataRow row = result.Rows[0];

                    // Isi TextBox di form dengan data dari database
                    textBox1.Text = row["username"].ToString();
                    textBox2.Text = row["alamat"].ToString();
                    textBox3.Text = row["email"].ToString();
                    textBox4.Text = row["nomor_telepon"].ToString();
                }
                else
                {
                    MessageBox.Show("Data admin tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
