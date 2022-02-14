using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the products
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class ProductDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the product's codes and names
        /// </summary>
        /// <returns>list of all product's codes and names</returns>
        public List<ProductCodeAndName> GetAllProductCodeAndNames()
        {
            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM Products " +
                "ORDER BY Name";
            return ProcessCodeAndNameList(selectStatement);
        }

        private static List<ProductCodeAndName> ProcessCodeAndNameList(string sql)
        {
            List<ProductCodeAndName> productList = new List<ProductCodeAndName>();
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
                                ProductCodeAndName product = new ProductCodeAndName
                                {
                                    ProductCode = reader["ProductCode"].ToString(),
                                    Name = reader["Name"].ToString()
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
