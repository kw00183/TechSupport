using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the registrations
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class RegistrationDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the registrations
        /// </summary>
        /// <returns>list of all registration objects</returns>
        public List<Registration> GetAllRegistrations()
        {
            List<Registration> registrationList = new List<Registration>();

            string selectStatement =
                "SELECT * " +
                "FROM Registrations " +
                "ORDER BY CustomerID, ProductCode";
            
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Registration registration = new Registration
                            {
                                CustomerID = (int)reader["CustomerID"],
                                ProductCode = reader["ProductCode"].ToString(),
                                RegistrationDate = (DateTime)reader["RegistrationDate"]
                            };
                            registrationList.Add(registration);
                        }
                    }
                }
            }
            return registrationList;
        }

        /// <summary>
        /// method used to call the stored procedure spIsCustomerProductRegistered
        /// </summary>
        /// <param name="customerID">customer ID</param>
        /// <param name="productCode">product code</param>
        /// <returns>boolean of true/false if customer is registered</returns>
        public Boolean IsCustomerProductRegistered(int customerID, string productCode)
        {
            Boolean registered;
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            SqlCommand selectCommand = new SqlCommand
            {
                Connection = connection,
                CommandText = "spIsCustomerProductRegistered",
                CommandType = CommandType.StoredProcedure
            };
            selectCommand.Parameters.Add("@CustomerID", SqlDbType.Int);
            selectCommand.Parameters["@CustomerID"].Value = customerID;
            selectCommand.Parameters.Add("@ProductCode", SqlDbType.VarChar);
            selectCommand.Parameters["@ProductCode"].Value = productCode;
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            if (reader.HasRows)
            {
                registered = true;
            }
            else
            {
                registered = false;
            }
            reader.Close();
            connection.Close();
            return registered;
        }

        #endregion
    }
}
