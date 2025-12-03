using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C969.Models;
using C969.Helpers;

namespace C969.Repositories
{
    public class CityRepository
    {
        public List<City> GetByCountry(int countryID)
        {
            var list = new List<City>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql = "SELECT cityId, city, countryId FROM city WHERE countryId = @c";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", countryID);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new City
                {
                    CityID = reader.GetInt32("cityId"),
                    CityName = reader.GetString("city"),
                    CountryID = reader.GetInt32("countryId")
                });
            }
            return list;
        }

        public City GetById(int cityId)
        {
            using var conn = DB.GetConnection();
            conn.Open();

            string sql = "SELECT cityId, city, countryId FROM city WHERE cityId = @id";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", cityId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new City
                {
                    CityID = reader.GetInt32("cityId"),
                    CityName = reader.GetString("city"),
                    CountryID = reader.GetInt32("countryId")
                };
            }
            return null;

        }
    }
}
