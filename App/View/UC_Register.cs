using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanamAja.App.Context;
using TanamAja.App.Models;

namespace TanamAja.App.View
{
    public partial class UC_Register : UserControl
    {
        public event EventHandler LoginClicked;
        public UC_Register()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void klikLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validasi input data
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi password: minimal 6 karakter dan tidak boleh mengandung spasi
            if (password.Length < 6)
            {
                MessageBox.Show("Password harus minimal 6 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Contains(" "))
            {
                MessageBox.Show("Password tidak boleh mengandung spasi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buat instance dari kelas C_Users
                C_Users userContext = new C_Users();

                // Periksa apakah username sudah ada
                if (userContext.IsUsernameExist(username))
                {
                    MessageBox.Show("Username sudah terdaftar. Silakan gunakan username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Periksa apakah password sudah digunakan
                if (userContext.IsPasswordExist(password))
                {
                    MessageBox.Show("Password sudah digunakan. Silakan gunakan password lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Buat objek pengguna baru
                Users newUser = new Users
                {
                    username = username,
                    password = password,
                    role = "customer"
                };

                // Panggil metode AddUsers untuk menyimpan data
                userContext.AddUsers(newUser);

                MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan form setelah berhasil registrasi
                textUsername.Clear();
                textPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }
        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


      
    }
}
    
