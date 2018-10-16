using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace CodeShop.Data
{
    public class DBConnectionOptions
    {
        public static IDbConnection ConnectToMySQL(string connectionstring)
        {
            var connection = new MySqlConnection(connectionstring);
            connection.Open();
            return connection;
        }
    }
    
}
