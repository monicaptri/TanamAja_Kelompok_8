using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanamAja.App.View;

namespace TanamAja
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaItem = "Biji Kopi Arabica";

            Form3 form3 = new Form3(namaItem);
            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //MelihatProfilCustomer profil = new MelihatProfilCustomer();
            //profil.Show();
            //this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RiwayatCustomer riwayatCustomer = new RiwayatCustomer();
            this.Hide();
            riwayatCustomer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
