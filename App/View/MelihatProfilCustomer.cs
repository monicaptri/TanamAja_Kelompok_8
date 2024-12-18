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
using TanamAja.App.Core;

namespace TanamAja.App.View
{
    public partial class MelihatProfilCustomer : Form
    {
        private string username; // Menyimpan username customer
        public MelihatProfilCustomer(string username)
        {
            InitializeComponent();
            this.username = UC_Login.LoggedInUsername; // Ambil username dari UC_Login
        }

        private void MelihatProfilCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerProfile();
        }

        private void LoadCustomerProfile()
        {
            try
            {
                string query = "SELECT username, alamat, email, nomor_telepon FROM users WHERE username = @username";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Text) { Value = username }
                };

                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    tbusernamecus.Text = row["username"].ToString();
                    tbalamatcus.Text = row["alamat"].ToString();
                    tbemailcus.Text = row["email"].ToString();
                    tbnotelcus.Text = row["nomor_telepon"].ToString();
                }
                else
                {
                    MessageBox.Show("Data customer tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnberandacus_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnriwayatcus_Click(object sender, EventArgs e)
        {
            RiwayatCustomer riwayatCustomer = new RiwayatCustomer();
            riwayatCustomer.Show();
            this.Hide();
        }

        private void btnlogoutcus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                 "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kembali ke form login
                formLogin frmLogin = new formLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            MengubahProfilCustomer formUbah = new MengubahProfilCustomer(username);
            formUbah.ShowDialog();
            LoadCustomerProfile(); // Refresh data setelah mengubah profil
        }
    }
}
