using System;
using System.Collections.Generic;
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
        /// method used to connect to the database and run a query to return the customers names
        /// </summary>
        /// <returns>list of all customer's names</returns>
        public List<Registration> GetAllRegistrations()
        {
            string selectStatement =
                "SELECT * " +
                "FROM Registrations " +
                "ORDER BY CustomerID, ProductCode";
            return ProcessList(selectStatement);
        }

        private static List<Registration> ProcessList(string sql)
        {
            List<Registration> registrationList = new List<Registration>();
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
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return registrationList;
        }

        #endregion
    }
}
