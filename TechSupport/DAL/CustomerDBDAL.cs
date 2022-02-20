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
        /// method used to connect to the database and run a query to return customer by customerID
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>single customer in list</returns>
        public List<Customer> GetCustomer(int customerID)
        {
            List<Customer> customerList = new List<Customer>();

            string selectStatement =
                "SELECT * " +
                "FROM Customers " +
                "WHERE " +
                "CustomerID = @customerID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@customerID"].Value = customerID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerID = (int)reader["CustomerID"],
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                ZipCode = reader["ZipCode"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            customerList.Add(customer);
                        }
                    }
                }
            }
            return customerList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return the customer ids and names
        /// </summary>
        /// <returns>list of all customer's ids and names</returns>
        public List<CustomerIDAndName> GetAllCustomerIDAndNames()
        {
            List<CustomerIDAndName> customerList = new List<CustomerIDAndName>();

            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM Customers " +
                "ORDER BY Name";
            
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
