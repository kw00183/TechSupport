using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the customers
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class CustomerDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the customers names
        /// </summary>
        /// <returns>list of all customer's names</returns>
        public List<String> GetAllCustomerNames()
        {
            string selectStatement =
                "SELECT Name " +
                "FROM Customers " +
                "ORDER BY Name";
            return ProcessStringList(selectStatement, "Name");
        }

        private static List<String> ProcessStringList(string sql, string column)
        {
            List<String> stringList = new List<String>();
            string selectStatement = sql;
            try
            {
                using (SqlConnection connection = TechSupportDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string stringToAdd = "";
                                if (column == "Name")
                                {
                                    stringToAdd = reader["Name"].ToString();
                                }
                                else if (column == "Address")
                                {
                                    stringToAdd = reader["Address"].ToString();
                                }
                                else if (column == "City")
                                {
                                    stringToAdd = reader["City"].ToString();
                                }
                                else if (column == "State")
                                {
                                    stringToAdd = reader["State"].ToString();
                                }
                                else if (column == "ZipCode")
                                {
                                    stringToAdd = reader["ZipCode"].ToString();
                                }
                                else if (column == "Phone")
                                {
                                    stringToAdd = reader["Phone"].ToString();
                                }
                                else if (column == "Email")
                                {
                                    stringToAdd = reader["Email"].ToString();
                                }
                                stringList.Add(stringToAdd);
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return stringList;
        }

        #endregion
    }
}
