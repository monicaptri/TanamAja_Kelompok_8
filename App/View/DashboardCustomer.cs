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
    public partial class DashboardCustomer : Form
    {
        private string username;
        public DashboardCustomer()
        {
            InitializeComponent();
            this.username = username; // Simpan username
        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnRiwayat_Click_1(object sender, EventArgs e)
        {
            RiwayatCustomer riwayatCustomer = new RiwayatCustomer();
            riwayatCustomer.Show();
            this.Hide();
        }

        private void btnProfilCustomer_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // button melihat profil
        {
            MelihatProfilCustomer melihatProfilCustomer = new MelihatProfilCustomer(username);
            melihatProfilCustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // button logout
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
    }
}
