using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace buithanhthang_2121110129.DataAccessLayer
{
    internal static class Config
    {
        private static string serverName = "THANG\\SQLEXPRESS";
        private static string databaseName = "QLBH";


        public static string getSQLConnectionString()
        {
            return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }

        public static string getSQLConnectionStringWithUser()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString["Server"] = serverName;
            connectionString["Database"] = databaseName;
            return connectionString.ToString();
            //return $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
        }
    }
}
