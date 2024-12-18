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
using TanamAja.App.View;

namespace TanamAja
{
    public partial class Form4 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=perdani;Database=DatabaseTanamaja";

        public Form4()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk mengambil data
                    string query = "SELECT * FROM katalog";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);

                    // Isi DataTable
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Tampilkan data di DataGridView
                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nama");
            dt.Columns.Add("Stok");
            dt.Columns.Add("Deskripsi");


            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5((DataTable)dataGridView1.DataSource);
            this.Hide();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashboardAdmin admin = new DashboardAdmin();
            admin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTukangKebun form = new FormTukangKebun();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MelihatProfilAdmin admin = new MelihatProfilAdmin();
            this.Hide();
            admin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RiwayatPesananAdmin admin = new RiwayatPesananAdmin();
            admin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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
