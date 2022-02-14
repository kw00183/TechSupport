using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class ProductDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the product's names
        /// </summary>
        /// <returns>list of all product's names</returns>
        public List<String> GetAllProductNames()
        {
            string selectStatement =
                "SELECT Name " +
                "FROM Products " +
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
                                if (column == "ProductCode")
                                {
                                    stringToAdd = reader["ProductCode"].ToString();
                                }
                                else if (column == "Name")
                                {
                                    stringToAdd = reader["Name"].ToString();
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

        private static List<Product> ProcessProductList(string sql)
        {
            List<Product> productList = new List<Product>();
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
                                Product product = new Product
                                {
                                    ProductCode = reader["ProductCode"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    Version = (decimal)reader["Version"],
                                    ReleaseDate = (DateTime)reader["ReleaseDate"]
                                };
                                productList.Add(product);
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
            return productList;
        }

        #endregion
    }
}
