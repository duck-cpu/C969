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
    public class AddressRepository
    {
        public int Add(Address a)
        {
            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
            "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
            "VALUES (@a1, @a2, @c, @pc, @p, NOW(), 'app', NOW(), 'app'); " +
            "SELECT LAST_INSERT_ID();";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@a1", a.Address1);
            cmd.Parameters.AddWithValue("@a2", a.Address2);
            cmd.Parameters.AddWithValue("@c", a.CityID);
            cmd.Parameters.AddWithValue("@pc", a.PostalCode);
            cmd.Parameters.AddWithValue("@p", a.Phone);

            return Convert.ToInt32(cmd.ExecuteScalar());


        }
    }
}
