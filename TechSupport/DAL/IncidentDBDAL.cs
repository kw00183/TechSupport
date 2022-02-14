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
                "INSERT Incidents (CustomerID, ProductCode, DateOpened, Title, Description) " +
                "VALUES (" + @customerID + ", " + @productCode + ", " + DateTime.Now + ", " + @title + ", " + description + ")";

            try
            {
                using (SqlConnection connection = TechSupportDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(insertStatement, connection))
                    {
                        selectCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                        selectCommand.Parameters["@customerID"].Value = customerID;
                        selectCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                        selectCommand.Parameters["@productCode"].Value = productCode;
                        selectCommand.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                        selectCommand.Parameters["@title"].Value = title;
                        selectCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                        selectCommand.Parameters["@description"].Value = description;
                    }
                    connection.Close();
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
        public List<IncidentStringNull> GetSearchIncidents(int customerID)
        {
            List<IncidentStringNull> searchIncidentList = new List<IncidentStringNull>();

            string selectStatement =
                "SELECT " +
                "IncidentID" +
                ", CustomerID" +
                ", ProductCode" +
                ", TechID" +
                ", DateOpened" +
                ", DateClosed" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "WHERE " +
                "CustomerID = " + @customerID + " " +
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
                                IncidentStringNull incident = new IncidentStringNull
                                {
                                    IncidentID = (int)reader["IncidentID"],
                                    CustomerID = (int)reader["CustomerID"],
                                    ProductCode = reader["ProductCode"].ToString(),
                                    TechID = reader["TechID"].ToString(),
                                    DateOpened = (DateTime)reader["DateOpened"],
                                    DateClosed = reader["DateClosed"].ToString(),
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
        public List<IncidentStringNull> GetAllIncidents()
        {
            List<IncidentStringNull> allIncidentList = new List<IncidentStringNull>();

            string selectStatement =
                "SELECT " +
                "IncidentID" +
                ", CustomerID" +
                ", ProductCode" +
                ", CAST(TechID AS VARCHAR(10)) AS TechID" +
                ", DateOpened" +
                ", CAST(FORMAT(DateClosed, 'MM/dd/yyyy') AS VARCHAR(10)) AS DateClosed" +
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
                                IncidentStringNull incident = new IncidentStringNull
                                {
                                    IncidentID = (int)reader["IncidentID"],
                                    CustomerID = (int)reader["CustomerID"],
                                    ProductCode = reader["ProductCode"].ToString(),
                                    TechID = reader["TechID"].ToString(),
                                    DateOpened = (DateTime)reader["DateOpened"],
                                    DateClosed = reader["DateClosed"].ToString(),
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
