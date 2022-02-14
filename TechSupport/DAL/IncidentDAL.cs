using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the incidents
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class IncidentDAL
    {
        #region Data Members

        private readonly static List<IncidentStringNull> _incidents = new List<IncidentStringNull>();

        #endregion

        #region Methods

        /// <summary>
        /// method used to get/return all the incidents
        /// </summary>
        /// <returns>list of all the incidents</returns>
        public List<IncidentStringNull> GetAllIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// method used to get/return all the incidents for a specific customerID
        /// </summary>
        /// <returns>list of searched incidents</returns>
        /// <param name="customerID">customerID to search</param>
        public List<IncidentStringNull> GetSearchIncidents(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return _incidents.FindAll(item => item.CustomerID == customerID);
        }

        /// <summary>
        /// method used to add an incident to the list of all incidents
        /// </summary>
        /// <param name="incident">the inicident object</param>
        public void Add(IncidentStringNull incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            _incidents.Add(incident);
        }

        #endregion
    }
}
