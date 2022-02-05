using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data access layer used to access database TechSupport
    /// </summary>
    public class IncidentDBDAL
    {
        public List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> openIncidentList = new List<OpenIncident>();

            string selectStatement =
                "SELECT" +
                "INC.ProductCode" +
                ", FORMAT(INC.DateOpened, 'MM/dd/yyyy') AS DateOpened" +
                ", ISNULL(CUS.Name, '') AS Customer" +
                ", ISNULL(TEC.Name, '') AS Technician" +
                ", INC.Title" +
                "FROM Incidents INC" +
                "LEFT JOIN Customers CUS" +
                "    ON INC.CustomerID = CUS.CustomerID" +
                "LEFT JOIN Technicians TEC" +
                "    ON INC.TechID = TEC.TechID" +
                "WHERE" +
                "INC.DateClosed IS NULL" +
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
                catch (SqlException ex)
            {
                throw ex;
            }
                catch (Exception ex)
            {
                throw ex;
            }

            return openIncidentList;
        }
    }
}
