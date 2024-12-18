using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamAja.App.Models;

namespace TanamAja.App.Context
{
    internal class C_TukangKebun
    {
        private static string table = "TukangKebun";

        // Metode untuk mengambil semua data Tukang Kebun
        public static DataTable All()
        {
            string query = @"
                SELECT 
                    t.id_tukangkebun,
                    t.nama,
                    t.alamat,
                    t.notelefon,
                    t.jeniskelamin,
                    t.kondisi;
                FROM 
                    TukangKebun t";

            DataTable dataTukangKebun = queryExecutor(query);
            return dataTukangKebun;
        }

        // Metode untuk mengambil data Tukang Kebun berdasarkan ID
        public static DataTable getTukangKebunById(int id)
        {
            string query = @"
                SELECT 
                    t.id_tukangkebun,
                    t.nama,
                    t.alamat,
                    t.notelefon,
                    t.jeniskelamin,
                    t.kondisi;
                FROM 
                    TukangKebun t;
                WHERE 
                    t.id_tukangkebun = @id_tukangkebun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_tukangkebun", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataTukangKebun = queryExecutor(query, parameters);
            return dataTukangKebun;
        }
        
        // Metode untuk menambahkan data Tukang Kebun baru
        public static void AddTukangKebun(M_TukangKebun TukangKebunBaru)
        {
            string query = $@"
                INSERT INTO {table} 
                (nama, alamat, notelefon, jeniskelamin, kondisi) 
                VALUES (@nama, @alamat, @notelefon, @jeniskelamin, @kondisi)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", TukangKebunBaru.nama),
                new NpgsqlParameter("@alamat", TukangKebunBaru.alamat),
                new NpgsqlParameter("@notelefon", TukangKebunBaru.notelefon),
                new NpgsqlParameter("@jeniskelamin", TukangKebunBaru.jeniskelamin),
                new NpgsqlParameter("@kondisi", TukangKebunBaru.kondisi),
            };

            commandExecutor(query, parameters);
        }

        // Metode untuk memperbarui data Tukang Kebun
        public static void UpdateTukangKebun(M_TukangKebun tukangKebun)
        {
            string query = $@"
                UPDATE {table} 
                SET 
                    nama = @nama, 
                    alamat = @alamat, 
                    notelefon = @notelefon, 
                    jeniskelamin = @jeniskelamin
                    kondisi = @kondisi
                WHERE 
                    id_tukangkebun = @id_tukangkebun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", tukangKebun.nama),
                new NpgsqlParameter("@alamat", tukangKebun.alamat),
                new NpgsqlParameter("@notelefon", tukangKebun.notelefon),
                new NpgsqlParameter("@jeniskelamin", tukangKebun.jeniskelamin),
                new NpgsqlParameter("@id_tukangkebun", tukangKebun.id_tukangkebun),
                new NpgsqlParameter("@kondisi", tukangKebun.kondisi)
            };

            commandExecutor(query, parameters);
        }

        // Metode untuk menghapus data Tukang Kebun berdasarkan ID
        public static void DeleteTukangKebun(int id)
        {
            string query = $@"
                DELETE id_tukangkebun, nama, alamat, notelefon, jeniskelamin, kondisi FROM {table} 
                WHERE id_tukangkebun = @id_tukangkebun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_tukangkebun", id)
            };

            commandExecutor(query, parameters);
        }

        // Metode eksekusi query untuk SELECT
        private static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=perdani;Database=DatabaseTanamaja"))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Metode eksekusi query untuk INSERT, UPDATE, DELETE
        private static void commandExecutor(string query, NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection("your_connection_string"))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



