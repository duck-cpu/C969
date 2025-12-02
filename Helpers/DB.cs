using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C969.Helpers
{
    public static class DB
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["MySqlConnStr"].ConnectionString;

            return new MySqlConnection(connStr);
        }
    }
}
