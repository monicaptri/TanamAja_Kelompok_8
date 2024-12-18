using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TanamAja.App.Context.C_Users;
using TanamAja.App.Core;
using TanamAja.App.Models;

namespace TanamAja.App.Context
{
    public class C_Users : DatabaseWrapper
    {
        private string table = "users";
        private string newpassword;
        private string newrole;

        public DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable Users = queryExecutor(query);
            return Users;
        }

        public void AddUsers(Users newUser)
        {
            string query = $"INSERT INTO {table} (username, password, role) VALUES (@username, @password, @role)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = newUser.username },
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = newUser.password },
                new NpgsqlParameter("@role", NpgsqlDbType.Varchar) { Value = newUser.role }
            };

            commandExecutor(query, parameters);
        }

        public Users AuthenticateUser(string username, string password)
        {
            string query = "SELECT id_user, username, role FROM users WHERE username = @username AND password = @password";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username },
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }
            };

            DataTable result = queryExecutor(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new Users
                {
                    id_user = Convert.ToInt32(row["id_user"]),
                    username = row["username"].ToString(),
                    role = row["role"].ToString()
                };
            }

            return null; // Tidak ditemukan
        }

        public bool IsUsernameExist(string username)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE username = @username";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = username }
            };

            DataTable result = queryExecutor(query, parameters);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                return true; // Username sudah ada
            }

            return false; // Username belum ada
        }

        public bool IsPasswordExist(string password)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE password = @password";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar) { Value = password }
            };

            DataTable result = queryExecutor(query, parameters);

            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
            {
                return true; // Password sudah ada
            }

            return false; // Password belum ada
        }
    }
}

