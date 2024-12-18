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
    public partial class MengubahProfilAdmin : Form
    {
        private string role = "admin"; // Menyimpan role yang digunakan
        public event EventHandler DataUpdated; // Event untuk memberi tahu perubahan data
        public MengubahProfilAdmin()
        {
            InitializeComponent();
        }


        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Query untuk update data admin
                string query = @"UPDATE users 
                                 SET alamat = @alamat, email = @email, nomor_telepon = @nomor_telepon 
                                 WHERE role = @role";


                // Parameter query
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                 {
                    new NpgsqlParameter("@alamat", tbalamat.Text),
                    new NpgsqlParameter("@email", tbemail.Text),
                    new NpgsqlParameter("@nomor_telepon", tbnotel.Text),
                    new NpgsqlParameter("@role", role)
                 };

                // Eksekusi query
                DatabaseWrapper.commandExecutor(query, parameters);

                // Memanggil event setelah data berhasil diperbarui
                DataUpdated?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Tutup form setelah menyimpan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            // Tutup form jika tombol Batal ditekan
            this.Close();
        }

        private void MengubahProfilAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            try
            {
                // Query untuk mengambil data admin berdasarkan role
                string query = "SELECT username, alamat, email, nomor_telepon FROM users WHERE role = @role";

                // Parameter query
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@role", role)
                };

                // Eksekusi query
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Isi TextBox dengan data dari database
                    tbusername.Text = row["username"].ToString();
                    tbalamat.Text = row["alamat"].ToString();
                    tbemail.Text = row["email"].ToString();
                    tbnotel.Text = row["nomor_telepon"].ToString();
                }
                else
                {
                    MessageBox.Show("Data admin tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
