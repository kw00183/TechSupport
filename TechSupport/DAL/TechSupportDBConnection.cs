using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// get a connection object for TechSupport database
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public static class TechSupportDBConnection
    {
        #region Methods

        /// <summary>
        /// method used to connect to TechSupport database
        /// </summary>
        /// <returns>return connection to database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        #endregion
    }
}
