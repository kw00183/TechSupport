using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// get a connection object for TechSupport database
    /// </summary>
    public static class TechSupportDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
