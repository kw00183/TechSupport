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

        private readonly static List<Incident> _incidents = new List<Incident>
        {
            new Incident(1, "problem logging in", "when I try to log in, it gives an invalid error"),
            new Incident(2, "need to change username", "don't see an option to change the username"),
            new Incident(3, "need to change my password", "don't see an option to allow password change")
        };

        #endregion

        #region Methods

        /// <summary>
        /// method used to get/return all the incidents
        /// </summary>
        /// <returns>list of all the incidents</returns>
        public List<Incident> GetAllIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// method used to get/return all the incidents for a specific customerID
        /// </summary>
        /// <returns>list of searched incidents</returns>
        /// <param name="customerID">customerID to search</param>
        public List<Incident> GetSearchIncidents(int customerID)
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
        public void Add(Incident incident)
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
