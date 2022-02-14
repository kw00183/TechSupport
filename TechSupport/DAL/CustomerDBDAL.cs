using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
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

        private static List<Customer> ProcessList(string sql)
        {
            List<Customer> customerList = new List<Customer>();
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
                                Customer customer = new Customer
                                {
                                    CustomerID = Convert.ToInt32(reader["CustomerID"]),
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
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return customerList;
        }

        #endregion
    }
}
