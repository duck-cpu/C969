using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using C969.Models;
using C969.Helpers;
using Google.Protobuf.Collections;

namespace C969.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
            "SELECT c.customerId, c.customerName, c.addressId, " +
            "a.address, a.address2, a.cityId, a.postalCode, a.phone " +
            "FROM customer c " +
            "JOIN address a ON c.addressId = a.addressId";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Customer
                {
                    CustomerID = reader.GetInt32("customerId"),
                    CustomerName = reader.GetString("customerName"),
                    AddressID = reader.GetInt32("addressId"),
                    Address = new Address
                    {
                        AddressId = reader.GetInt32("addressId"),
                        Address1 = reader.GetString("address"),
                        Address2 = reader.GetString("address2"),
                        CityID = reader.GetInt32("cityId"),
                        PostalCode = reader.GetString("postalCode"),
                        Phone = reader.GetString("phone")
                    }
                });
            }
            return list;
        }
    }
}
