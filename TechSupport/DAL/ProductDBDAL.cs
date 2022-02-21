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
        /// method used to connect to the database and run a query to return product by productCode
        /// </summary>
        /// <param name="productCode">product code</param>
        /// <returns>single product object in list</returns>
        public List<Product> GetProduct(string productCode)
        {
            List<Product> productList = new List<Product>();

            string selectStatement =
                "SELECT * " +
                "FROM Products " +
                "WHERE " +
                "ProductCode = @productCode";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@productCode"].Value = productCode;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                Name = reader["Name"].ToString(),
                                Version = (Decimal)reader["Version"],
                                ReleaseDate = (DateTime)reader["ReleaseDate"]
                            };
                            productList.Add(product);
                        }
                    }
                }
            }
            return productList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return the product's codes and names
        /// </summary>
        /// <returns>list of all product objects with code and name</returns>
        public List<ProductCodeAndName> GetAllProductCodeAndNames()
        {
            List<ProductCodeAndName> productList = new List<ProductCodeAndName>();

            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM Products " +
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
            return productList;
        }

        #endregion
    }
}
