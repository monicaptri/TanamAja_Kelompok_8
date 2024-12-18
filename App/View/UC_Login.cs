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
    public partial class UC_Login : UserControl
    {
        public event EventHandler RegisterClicked;
        public static string LoggedInUsername { get; private set; } // Menyimpan username yang login
        public UC_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama pengguna dan kata sandi harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                C_Users userContext = new C_Users();
                Users loggedInUser = userContext.AuthenticateUser(username, password);

                if (loggedInUser != null)
                {
                    LoggedInUsername = loggedInUser.username; // Simpan username yang berhasil login

                    if (loggedInUser.role == "customer")
                    {
                        MessageBox.Show($"Login berhasil! Selamat datang, {LoggedInUsername}.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DashboardCustomer customerDashboard = new DashboardCustomer();
                        customerDashboard.Show();
                        this.FindForm()?.Hide();
                    }
                    else if (loggedInUser.role == "admin")
                    {
                        DashboardAdmin adminDashboard = new DashboardAdmin();
                        adminDashboard.Show();
                        this.FindForm()?.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Nama pengguna atau kata sandi salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void klikDaftar_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
