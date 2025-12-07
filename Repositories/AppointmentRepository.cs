using C969.Helpers;
using C969.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Repositories
{
    public class AppointmentRepository
    {
        public List<Appointment> GetAll()
        { 
            var list = new List<Appointment>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
                "SELECT a.appointmentId, a.customerId, a.userId, a.title, a.description, " +
                "a.location, a.contact, a.type, a.url, a.start, a.end, " +
                "c.customerName, u.userName " +
                "FROM appointment a " +
                "JOIN customer c ON a.customerId = c.customerId " +
                "JOIN user u ON a.userId = u.userId";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Appointment
                {
                    AppointmentID = reader.GetInt32("appointmentId"),
                    CustomerID = reader.GetInt32("customerId"),
                    UserID = reader.GetInt32("userId"),
                    Title = reader.GetString("title"),
                    Description = reader.GetString("description"),
                    Location = reader.GetString("location"),
                    Contact = reader.GetString("contact"),
                    Type = reader.GetString("type"),
                    Url = reader.GetString("url"),
                    StartUtc = reader.GetDateTime("start"),
                    EndUtc = reader.GetDateTime("end"),
                    CustomerName = reader.GetString("customerName"),
                    UserName = reader.GetString("userName")
                });
            }

            return list;
        }

        public void Add(Appointment a)
        { 
            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
                "INSERT INTO appointment " +
                "(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@custId, @userId, @title, @desc, @loc, @contact, @type, @url, @start, @end, NOW(), 'app', NOW(), 'app');";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@custId", a.CustomerID);
            cmd.Parameters.AddWithValue("@userId", a.UserID);
            cmd.Parameters.AddWithValue("@title", a.Title);
            cmd.Parameters.AddWithValue("@desc", a.Description);
            cmd.Parameters.AddWithValue("@loc", a.Location);
            cmd.Parameters.AddWithValue("@contact", a.Contact);
            cmd.Parameters.AddWithValue("@type", a.Type);
            cmd.Parameters.AddWithValue("@url", a.Url);
            cmd.Parameters.AddWithValue("@start", a.StartUtc);
            cmd.Parameters.AddWithValue("@end", a.EndUtc);

            cmd.ExecuteNonQuery();
        }

        public void Update(Appointment a)
        {
            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
                "UPDATE appointment SET " +
                "customerId = @custId, userId = @userId, title = @title, " +
                "description = @desc, location = @loc, contact = @contact, " +
                "type = @type, url = @url, start = @start, end = @end, " +
                "lastUpdate = NOW(), lastUpdateBy = 'app' " +
                "WHERE appointmentId = @id;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@custId", a.CustomerID);
            cmd.Parameters.AddWithValue("@userId", a.UserID);
            cmd.Parameters.AddWithValue("@title", a.Title);
            cmd.Parameters.AddWithValue("@desc", a.Description);
            cmd.Parameters.AddWithValue("@loc", a.Location);
            cmd.Parameters.AddWithValue("@contact", a.Contact);
            cmd.Parameters.AddWithValue("@type", a.Type);
            cmd.Parameters.AddWithValue("@url", a.Url);
            cmd.Parameters.AddWithValue("@start", a.StartUtc);
            cmd.Parameters.AddWithValue("@end", a.EndUtc);
            cmd.Parameters.AddWithValue("@id", a.AppointmentID);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int appointmentID)
        {
            using var conn = DB.GetConnection();
            conn.Open();

            string sql = "DELETE FROM appointment WHERE appointmentId = @id;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", appointmentID);
            cmd.ExecuteNonQuery();
        }

        public List<Appointment> GetOverlappingForUser(int userID, DateTime startUtc, DateTime endUtc, int? ignoreAppointmentID = null)
        { 
            var list = new List<Appointment>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
                "SELECT * FROM appointment " +
                "WHERE userId = @uid " +
                "AND @start < end AND @end > start ";

            if (ignoreAppointmentID != null)
            {
                sql += "AND appointmentId <> @id";
            }

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", userID);
            cmd.Parameters.AddWithValue("@start", startUtc);
            cmd.Parameters.AddWithValue("@end", endUtc);
            if (ignoreAppointmentID.HasValue)
                cmd.Parameters.AddWithValue("@id", ignoreAppointmentID.Value);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Appointment
                {
                    AppointmentID = reader.GetInt32("appointmentId"),
                    UserID = reader.GetInt32("userId"),
                    CustomerID = reader.GetInt32("customerId"),
                    StartUtc = reader.GetDateTime("start"),
                    EndUtc = reader.GetDateTime("end"),
                    Type = reader.GetString("type")
                });
            }

            return list;
        }

        public List<Appointment> GetInRange(DateTime startUtc, DateTime endUtc)
        {
            var list = new List<Appointment>();

            using var conn = DB.GetConnection();
            conn.Open();

            string sql =
                "SELECT a.appointmentId, a.customerId, a.userId, a.title, a.description, " +
                "a.location, a.contact, a.type, a.url, a.start, a.end, " +
                "c.customerName, u.userName " +
                "FROM appointment a " +
                "JOIN customer c ON a.customerId = c.customerId " +
                "JOIN user u ON a.userId = u.userId " +
                "WHERE a.start >= @start AND a.start < @end;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@start", startUtc);
            cmd.Parameters.AddWithValue("@end", endUtc);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Appointment
                {
                    AppointmentID = reader.GetInt32("appointmentId"),
                    CustomerID = reader.GetInt32("customerId"),
                    UserID = reader.GetInt32("userId"),
                    Title = reader.GetString("title"),
                    Description = reader.GetString("description"),
                    Location = reader.GetString("location"),
                    Contact = reader.GetString("contact"),
                    Type = reader.GetString("type"),
                    Url = reader.GetString("url"),
                    StartUtc = reader.GetDateTime("start"),
                    EndUtc = reader.GetDateTime("end"),
                    CustomerName = reader.GetString("customerName"),
                    UserName = reader.GetString("userName")
                });
            }

            return list;
        }
    }
}
