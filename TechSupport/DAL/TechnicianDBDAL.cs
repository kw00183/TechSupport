using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the technicians
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class TechnicianDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return the technician's ids and names
        /// </summary>
        /// <returns>list of all technician objects with id and name</returns>
        public List<TechnicianIDAndName> GetAllTechnicianIDAndNames()
        {
            List<TechnicianIDAndName> technicianList = new List<TechnicianIDAndName>();

            string selectStatement =
                "SELECT TechID, Name " +
                "FROM Technicians " +
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
                            TechnicianIDAndName technician = new TechnicianIDAndName
                            {
                                TechID = (int)reader["TechID"],
                                Name = reader["Name"].ToString()
                            };
                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }

        #endregion
    }
}
