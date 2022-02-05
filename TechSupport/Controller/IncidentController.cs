using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to search incidents in the incidents list
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentDAL incidentSource;
        private readonly IncidentDBDAL incidentDBSource;

        /// <summary>
        /// create an IncidentController object to add incidents
        /// </summary>
        public IncidentController()
        {
            incidentSource = new IncidentDAL();
            incidentDBSource = new IncidentDBDAL();
        }

        /// <summary>
        /// method used to get/return all the incidents
        /// </summary>
        /// <returns>a list of all the incidents</returns>
        public List<Incident> GetAllIncidents()
        {
            return incidentSource.GetAllIncidents();
        }

        /// <summary>
        /// method used to add an incident to the list
        /// </summary>
        /// <param name="incident">incident is customrID, title and description</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            incidentSource.Add(incident);
        }

        /// <summary>
        /// method used to get/return all the incidents with a specific CustomerID
        /// </summary>
        /// <returns>list of all the incidents searched</returns>
        public List<Incident> GetSearchIncidents()
        {
            return incidentSource.GetSearchIncidents();
        }

        /// <summary>
        /// method used to search for incidents by CustomerID
        /// </summary>
        /// <param name="customerID">CustomerID used to search incidents</param>
        public void Search(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentNullException("CustomerID cannot be less than 0");
            }
            incidentSource.Search(customerID);
        }

        public List<OpenIncident> GetOpenIncidents()
        {
            return incidentDBSource.GetOpenIncidents();
        }
    }
}
