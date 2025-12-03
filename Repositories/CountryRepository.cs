using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C969.Models;
using C969.Helpers;
using System.Reflection.Metadata.Ecma335;

namespace C969.Repositories
{
    public class CountryRepository
    {
        public List<Country> GetAll()
        {
            var list = new List<Country>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql = "SELECT countryId, country FROM country";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Country
                {
                    CountryID = reader.GetInt32("countryId"),
                    CountryName = reader.GetString("country")
                });
            }
            return list;
        }
    }
}
