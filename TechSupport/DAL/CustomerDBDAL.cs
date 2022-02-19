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
        /// method used to connect to the database and run a query to return the customer ids and names
        /// </summary>
        /// <returns>list of all customer's ids and names</returns>
        public List<CustomerIDAndName> GetAllCustomerIDAndNames()
        {
            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM Customers " +
                "ORDER BY Name";
            return ProcessIDAndNameList(selectStatement);
        }

        private static List<CustomerIDAndName> ProcessIDAndNameList(string sql)
        {
            List<CustomerIDAndName> customerList = new List<CustomerIDAndName>();
            string selectStatement = sql;
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerIDAndName customer = new CustomerIDAndName
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString()
                            };
                            customerList.Add(customer);
                        }
                    }
                }
            }
            return customerList;
        }

        #endregion
    }
}
