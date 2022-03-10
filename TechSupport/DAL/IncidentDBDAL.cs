using System;
using System.Collections.Generic;
using System.Data;
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
        /// used to connect to the database and run a query to add incident
        /// </summary>
        /// <param name="incident">incident object</param>
        public void AddIncident(Incident incident)
        {
            string insertStatement =
                "INSERT Incidents " +
                  "(CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description) " +
                "VALUES (@customerID, @productCode, @techID, @dateOpened, @dateClosed, @title, @description)";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@customerID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@customerID"].Value = incident.CustomerID;
                    insertCommand.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@productCode"].Value = incident.ProductCode;
                    insertCommand.Parameters.Add("@techID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@techID"].Value = DBNull.Value;
                    insertCommand.Parameters.Add("@dateOpened", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@dateOpened"].Value = DateTime.Now;
                    insertCommand.Parameters.Add("@dateClosed", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@dateClosed"].Value = DBNull.Value;
                    insertCommand.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@title"].Value = incident.Title;
                    insertCommand.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@description"].Value = incident.Description;
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// method used to connect to the database and run a query to return incident by incidentID
        /// </summary>
        /// <param name="incidentID">incident id</param>
        /// <returns>single incident object in list</returns>
        public Incident GetIncident(int incidentID)
        {
            Incident incident = new Incident();

            string selectStatement =
                "SELECT * " +
                "FROM Incidents " +
                "WHERE " +
                "IncidentID = @incidentID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@incidentID"].Value = incidentID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            {
                                incident.IncidentID = (int)reader["IncidentID"];
                                incident.CustomerID = (int)reader["CustomerID"];
                                incident.ProductCode = reader["ProductCode"].ToString();
                                incident.TechID = reader["TechID"] as int? ?? default;
                                incident.DateOpened = (DateTime)reader["DateOpened"];
                                incident.DateClosed = reader["DateClosed"] as DateTime? ?? default;
                                incident.Title = reader["Title"].ToString();
                                incident.Description = reader["Description"].ToString();
                            };
                        }
                    }
                }
            }
            return incident;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return search incidents by customerID
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>list of searched incident objects</returns>
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
            return searchIncidentList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to update incident to closed
        /// </summary>
        /// <param name="oldIncident">old Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if incident was closed</returns>
        public bool CloseIncident(Incident oldIncident, Incident newIncident)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "CustomerID = @NewCustomerID " +
                ", ProductCode = @NewProductCode " +
                ", TechID = @NewTechID " +
                ", DateOpened = @NewDateOpened " +
                ", DateClosed = @NewDateClosed " +
                ", Title = @NewTitle " +
                ", Description = @NewDescription " +
                "WHERE IncidentID = @OldIncidentID " +
                "AND CustomerID = @OldCustomerID " +
                "AND ProductCode = @OldProductCode " +
                "AND (TechID = @OldTechID " +
                     "OR TechID IS NULL AND @OldTechID IS NULL) " +
                "AND DateOpened = @OldDateOpened " +
                "AND (DateClosed = @OldDateClosed " +
                     "OR DateClosed IS NULL AND @OldDateClosed IS NULL) " +
                "AND Title = @OldTitle " +
                "AND Description = @OldDescription";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@NewCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@NewCustomerID"].Value = newIncident.CustomerID;
                    updateCommand.Parameters.Add("@NewProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewProductCode"].Value = newIncident.ProductCode;

                    if (newIncident.TechID == null || newIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@NewTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@NewTechID"].Value = newIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@NewDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateOpened"].Value = newIncident.DateOpened;

                    updateCommand.Parameters.Add("@NewDateClosed", SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateClosed"].Value = DateTime.Now;

                    updateCommand.Parameters.Add("@NewTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewTitle"].Value = newIncident.Title;

                    updateCommand.Parameters.Add("@NewDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewDescription"].Value = newIncident.Description;

                    updateCommand.Parameters.Add("@OldIncidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@OldIncidentID"].Value = oldIncident.IncidentID;
                    updateCommand.Parameters.Add("@OldCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@OldCustomerID"].Value = oldIncident.CustomerID;
                    updateCommand.Parameters.Add("@OldProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldProductCode"].Value = oldIncident.ProductCode;

                    if (oldIncident.TechID == null || oldIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@OldTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@OldTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@OldTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@OldTechID"].Value = oldIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@OldDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@OldDateOpened"].Value = oldIncident.DateOpened;

                    if (oldIncident.DateClosed == null || oldIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@OldDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@OldDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@OldDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@OldDateClosed"].Value = oldIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@OldTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldTitle"].Value = oldIncident.Title;

                    updateCommand.Parameters.Add("@OldDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldDescription"].Value = oldIncident.Description;

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// method used to connect to the database and run a query to update specific fields of incident
        /// </summary>
        /// <param name="oldIncident">old Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if incident was updated</returns>
        public bool UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "CustomerID = @NewCustomerID " +
                ", ProductCode = @NewProductCode " +
                ", TechID = @NewTechID " +
                ", DateOpened = @NewDateOpened " +
                ", DateClosed = @NewDateClosed " +
                ", Title = @NewTitle " +
                ", Description = @NewDescription " +
                "WHERE IncidentID = @OldIncidentID " +
                "AND CustomerID = @OldCustomerID " +
                "AND ProductCode = @OldProductCode " +
                "AND (TechID = @OldTechID " +
                     "OR TechID IS NULL AND @OldTechID IS NULL) " +
                "AND DateOpened = @OldDateOpened " +
                "AND (DateClosed = @OldDateClosed " +
                     "OR DateClosed IS NULL AND @OldDateClosed IS NULL) " +
                "AND Title = @OldTitle " +
                "AND Description = @OldDescription";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@NewCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@NewCustomerID"].Value = newIncident.CustomerID;
                    updateCommand.Parameters.Add("@NewProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewProductCode"].Value = newIncident.ProductCode;

                    if (newIncident.TechID == null || newIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@NewTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@NewTechID"].Value = newIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@NewDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@NewDateOpened"].Value = newIncident.DateOpened;

                    if (newIncident.DateClosed == null || newIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@NewDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@NewDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@NewDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@NewDateClosed"].Value = newIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@NewTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewTitle"].Value = newIncident.Title;

                    updateCommand.Parameters.Add("@NewDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewDescription"].Value = newIncident.Description;

                    updateCommand.Parameters.Add("@OldIncidentID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@OldIncidentID"].Value = oldIncident.IncidentID;
                    updateCommand.Parameters.Add("@OldCustomerID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@OldCustomerID"].Value = oldIncident.CustomerID;
                    updateCommand.Parameters.Add("@OldProductCode", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldProductCode"].Value = oldIncident.ProductCode;

                    if (oldIncident.TechID == null || oldIncident.TechID == 0)
                    {
                        updateCommand.Parameters.Add("@OldTechID", SqlDbType.VarChar);
                        updateCommand.Parameters["@OldTechID"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@OldTechID", System.Data.SqlDbType.Int);
                        updateCommand.Parameters["@OldTechID"].Value = oldIncident.TechID;
                    }

                    updateCommand.Parameters.Add("@OldDateOpened", System.Data.SqlDbType.DateTime);
                    updateCommand.Parameters["@OldDateOpened"].Value = oldIncident.DateOpened;

                    if (oldIncident.DateClosed == null || oldIncident.DateClosed == DateTime.MinValue)
                    {
                        updateCommand.Parameters.Add("@OldDateClosed", SqlDbType.VarChar);
                        updateCommand.Parameters["@OldDateClosed"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@OldDateClosed", System.Data.SqlDbType.DateTime);
                        updateCommand.Parameters["@OldDateClosed"].Value = oldIncident.DateClosed;
                    }

                    updateCommand.Parameters.Add("@OldTitle", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldTitle"].Value = oldIncident.Title;

                    updateCommand.Parameters.Add("@OldDescription", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldDescription"].Value = oldIncident.Description;

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// method used to connect to the database and run a query to return all incidents
        /// </summary>
        /// <returns>all incident objects in list</returns>
        public List<Incident> GetAllIncidents()
        {
            List<Incident> allIncidentList = new List<Incident>();

            string selectStatement =
                "SELECT * " +
                "CustomerID" +
                ", ProductCode" +
                ", Title " +
                ", Description " +
                "FROM Incidents " +
                "ORDER BY IncidentID";

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
            return allIncidentList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return the open incidents
        /// </summary>
        /// <returns>list of open incident objects</returns>
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
            return openIncidentList;
        }

        #endregion
    }
}
