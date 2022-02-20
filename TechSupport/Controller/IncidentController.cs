using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to search incidents in the incidents list
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class IncidentController
    {
        #region Data Members

        private readonly IncidentDBDAL incidentDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create an IncidentController object to add incidents
        /// </summary>
        public IncidentController()
        {
            incidentDBSource = new IncidentDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get/return all the incidents
        /// </summary>
        /// <returns>a list of all the incidents</returns>
        public List<Incident> GetAllIncidents()
        {
            return incidentDBSource.GetAllIncidents();
        }

        /// <summary>
        /// method used to add an incident to the list
        /// </summary>
        /// <param name="incident">incident is customrID, productCode, title and description</param>
        public void AddIncident(Incident incident)
        {
            if (incident.CustomerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            if (string.IsNullOrEmpty(incident.ProductCode))
            {
                throw new ArgumentNullException("ProductCode cannot be null or empty");
            }
            if (string.IsNullOrEmpty(incident.Title))
            {
                throw new ArgumentNullException("Title cannot be null or empty");
            }
            if (string.IsNullOrEmpty(incident.Description))
            {
                throw new ArgumentNullException("Description cannot be null or empty");
            }
            incidentDBSource.AddIncident(incident);
        }

        /// <summary>
        /// method used to get/return the incident with a specific IncidentID
        /// </summary>
        /// <returns>list of incidents</returns>
        public List<Incident> GetIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID cannot be less than 1");
            }
            return incidentDBSource.GetIncident(incidentID);
        }

        /// <summary>
        /// method used to get/return all the incidents with a specific CustomerID
        /// </summary>
        /// <returns>list of all the incidents searched</returns>
        public List<Incident> GetSearchIncidents(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return incidentDBSource.GetSearchIncidents(customerID);
        }

        /// <summary>
        /// method used to return open incidents from DAL
        /// </summary>
        /// <returns>return list of open incidents</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            return incidentDBSource.GetOpenIncidents();
        }

        #endregion
    }
}
