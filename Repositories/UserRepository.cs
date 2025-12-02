using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C969.Helpers;
using C969.Models;

namespace C969.Repositories
{
    public class UserRepository
    {
        public User GetByCredentials(string username, string password)
        {
            using var conn = DB.GetConnection();
            conn.Open();

            string sql = "SELECT userId, userName FROM user WHERE userName = @u AND password = @p";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32("userId"),
                    UserName = reader.GetString("userName")
                };
            }
            return null;
        }

    }
}
