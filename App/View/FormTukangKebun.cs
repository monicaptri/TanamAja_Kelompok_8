using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using TanamAja.App.Models;

namespace TanamAja.App.View
{
    public partial class FormTukangKebun : Form
    {
        private static readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=perdani;Database=DatabaseTanamaja;";

        public FormTukangKebun()
        {
            InitializeComponent();
            LoadDataTukangKebun();
            SetButtonHoverStyles();
        }

        private void SetButtonHoverStyles()
        {
            SetButtonHoverStyle(btnProfilAdmin);
            SetButtonHoverStyle(btnKatalogAdmin);
            SetButtonHoverStyle(btnRiwayatAdmin);
            SetButtonHoverStyle(btnLogoutAdmin);
        }

        private void SetButtonHoverStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Peru;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#BB8A52");
        }

        private void FormTukangKebun_Load(object sender, EventArgs e)
        {
            LoadDataTukangKebun();
        }

        private void LoadDataTukangKebun()
        {
            try
            {
                DataTable tukangKebunData = new DataTable();
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_tukangkebun, nama, alamat, notelefon, jeniskelamin, kondisi FROM TukangKebun ORDER BY id_tukangkebun ASC";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            tukangKebunData.Load(reader);
                        }
                    }
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = tukangKebunData;

                dataGridView1.Columns["id_tukangkebun"].Visible = false;
                dataGridView1.Columns["nama"].HeaderText = "Nama";
                dataGridView1.Columns["alamat"].HeaderText = "Alamat";
                dataGridView1.Columns["notelefon"].HeaderText = "No. Telefon";
                dataGridView1.Columns["jeniskelamin"].HeaderText = "Jenis Kelamin";
                dataGridView1.Columns["kondisi"].HeaderText = "Kondisi";

                if (dataGridView1.Columns["Update"] == null)
                {
                    AddButtonColumn("Update", "Edit");
                }

                if (dataGridView1.Columns["Delete"] == null)
                {
                    AddButtonColumn("Delete", "Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataTukangKebun: {ex.Message}");
            }
        }

        private void AddButtonColumn(string name, string text)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = name,
                Text = text,
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                HandleUpdateButton(e.RowIndex);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                HandleDeleteButton(e.RowIndex);
            }
        }

        private void HandleUpdateButton(int rowIndex)
        {
            try
            {
                int tukangkebunId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_tukangkebun"].Value);
                M_TukangKebun tukangKebun = GetTukangKebunById(tukangkebunId);

                if (tukangKebun != null)
                {
                    FormTambahTukang formTambahTukang = new FormTambahTukang
                    {
                        TukangKebun = tukangKebun
                    };

                    this.Hide();
                    if (formTambahTukang.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataTukangKebun();
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengedit data: {ex.Message}");
            }
        }

        private void HandleDeleteButton(int rowIndex)
        {
            try
            {
                int tukangkebunId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_tukangkebun"].Value);

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                      "Konfirmasi Hapus",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM TukangKebun WHERE id_tukangkebun = @id";

                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", tukangkebunId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil dihapus.");
                    LoadDataTukangKebun();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menghapus data: {ex.Message}");
            }
        }

        private M_TukangKebun GetTukangKebunById(int id)
        {
            M_TukangKebun tukangKebun = null;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_tukangkebun, nama, alamat, notelefon, jeniskelamin, kondisi FROM TukangKebun WHERE id_tukangkebun = @id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tukangKebun = new M_TukangKebun
                            {
                                id_tukangkebun = reader.GetInt32(0),
                                nama = reader.GetString(1),
                                alamat = reader.IsDBNull(2) ? null : reader.GetString(2),  // Cek apakah alamat null
                                notelefon = reader.IsDBNull(3) ? null : reader.GetString(3),  // Cek apakah no telepon null
                                jeniskelamin = reader.IsDBNull(4) ? null : reader.GetString(4),  // Cek apakah jenis kelamin null
                                kondisi = reader.IsDBNull(5) ? null : reader.GetString(5)  // Cek apakah kondisi null
                            };
                        }
                    }
                }
            }

            return tukangKebun;
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
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

        private void btnRiwayatAdmin_Click(object sender, EventArgs e)
        {
            RiwayatPesananAdmin riwayatPesananAdmin = new RiwayatPesananAdmin();
            riwayatPesananAdmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahTukang tambahTukang = new FormTambahTukang();
            this.Hide();
            if (tambahTukang.ShowDialog() == DialogResult.OK)
            {
                LoadDataTukangKebun();
            }
            this.Show();
        }

        private void btnProfilAdmin_Click(object sender, EventArgs e)
        {
            MelihatProfilAdmin melihatProfilAdmin = new MelihatProfilAdmin();
            melihatProfilAdmin.Show();
            this.Hide();
        }

        private void btnKatalogAdmin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
