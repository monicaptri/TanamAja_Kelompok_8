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
    public partial class MengubahProfilCustomer : Form
    {
        private string username;
        public MengubahProfilCustomer(string username)
        {
            InitializeComponent();
            tbusernamecus.Text = username;
            this.username = username;
        }

        private void MengubahProfilCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                // Query untuk mengambil data customer berdasarkan username
                string query = "SELECT alamat, email, nomor_telepon FROM users WHERE username = @username";

                // Parameter untuk query
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@username", username)
                };

                // Eksekusi query menggunakan DatabaseWrapper
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Isi TextBox dengan data customer dari database
                    tbalamatcus.Text = row["alamat"].ToString();
                    tbemailcus.Text = row["email"].ToString();
                    tbnotelcus.Text = row["nomor_telepon"].ToString();
                }
                else
                {
                    MessageBox.Show("Data customer tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            // Tutup form jika tombol Batal ditekan
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Query untuk mengupdate data customer
                string query = @"UPDATE users 
                                 SET alamat = @alamat, 
                                     email = @email, 
                                     nomor_telepon = @nomor_telepon 
                                 WHERE username = @username";

                // Parameter query
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@alamat", tbalamatcus.Text),
                    new NpgsqlParameter("@email", tbemailcus.Text),
                    new NpgsqlParameter("@nomor_telepon", tbnotelcus.Text),
                    new NpgsqlParameter("@username", username)
                };

                // Eksekusi query menggunakan DatabaseWrapper
                DatabaseWrapper.commandExecutor(query, parameters);

                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Tutup form setelah menyimpan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memperbarui data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
