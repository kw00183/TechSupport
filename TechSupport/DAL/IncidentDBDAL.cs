using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data access layer used to access database TechSupport
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class IncidentDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to add incident
        /// </summary>
        public void AddIncident(int customerID, string productCode, string title, string description)
        {
            
            string insertStatement =
                "INSERT Incidents " +
                  "(CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description) " +
                "VALUES (@customerID, @productCode, @techID, @dateOpened, @dateClosed, @title, @description)";

            try
            {
                using (SqlConnection connection = TechSupportDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@customerID"].Value = customerID;
                        insertCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@productCode"].Value = productCode;
                        insertCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@techID"].Value = DBNull.Value;
                        insertCommand.Parameters.Add("@dateOpened", System.Data.SqlDbType.DateTime);
                        insertCommand.Parameters["@dateOpened"].Value = DateTime.Now;
                        insertCommand.Parameters.Add("@dateClosed", System.Data.SqlDbType.DateTime);
                        insertCommand.Parameters["@dateClosed"].Value = DBNull.Value;
                        insertCommand.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@title"].Value = title;
                        insertCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@description"].Value = description;
                        insertCommand.ExecuteNonQuery();
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
        }

        /// <summary>
        /// method used to connect to the database and run a query to return search incidents by customerID
        /// </summary>
        /// <returns>search incidents list</returns>
        public List<Incident> GetSearchIncidents(int customerID)
        {
            List<Incident> searchIncidentList = new List<Incident>();

            string selectStatement =
                "SELECT " +
                "CustomerID" +
                ", ProductCode" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "WHERE " +
                "CustomerID = @customerID " +
                "ORDER BY IncidentID";

            try
            {
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
                                Incident incident = new Incident
                                {
                                    CustomerID = (int)reader["CustomerID"],
                                    ProductCode = reader["ProductCode"].ToString(),
                                    Title = reader["Title"].ToString(),
                                    Description = reader["Description"].ToString()
                                };
                                searchIncidentList.Add(incident);
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
            return searchIncidentList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return all incidents
        /// </summary>
        /// <returns>all incidents list</returns>
        public List<Incident> GetAllIncidents()
        {
            List<Incident> allIncidentList = new List<Incident>();

            string selectStatement =
                "SELECT " +
                "CustomerID" +
                ", ProductCode" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "ORDER BY IncidentID";

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
                                Incident incident = new Incident
                                {
                                    CustomerID = (int)reader["CustomerID"],
                                    ProductCode = reader["ProductCode"].ToString(),
                                    Title = reader["Title"].ToString(),
                                    Description = reader["Description"].ToString()
                                };
                                allIncidentList.Add(incident);
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
            return allIncidentList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return the open incidents
        /// </summary>
        /// <returns>list of open incidents</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> openIncidentList = new List<OpenIncident>();

            string selectStatement =
                "SELECT " +
                "INC.ProductCode" +
                ", INC.DateOpened" +
                ", ISNULL(CUS.Name, '') AS Customer" +
                ", ISNULL(TEC.Name, '') AS Technician" +
                ", INC.Title " +
                "FROM Incidents INC " +
                "LEFT JOIN Customers CUS " +
                "    ON INC.CustomerID = CUS.CustomerID " +
                "LEFT JOIN Technicians TEC " +
                "    ON INC.TechID = TEC.TechID " +
                "WHERE " +
                "INC.DateClosed IS NULL " +
                "AND INC.DateOpened IS NOT NULL " +
                "ORDER BY INC.DateOpened";

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
                                OpenIncident openIncident = new OpenIncident
                                {
                                    ProductCode = reader["ProductCode"].ToString(),
                                    DateOpened = (DateTime)reader["DateOpened"],
                                    Customer = reader["Customer"].ToString(),
                                    Technician = reader["Technician"].ToString(),
                                    Title = reader["Title"].ToString()
                                };
                                openIncidentList.Add(openIncident);
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
            return openIncidentList;
        }

        #endregion
    }
}
