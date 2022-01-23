using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to search incidents in the all incidents list
    /// </summary>
    public class IncidentSearchController
    {
        private readonly IncidentDAL incidentSource;

        /// <summary>
        /// create an IncidentController object to search incidents
        /// </summary>
        public IncidentSearchController()
        {
            this.incidentSource = new IncidentDAL();
        }

        /// <summary>
        /// method used to get/return all the incidents with a specific CustomerID
        /// </summary>
        /// <returns>list of all the incidents searched</returns>
        public List<Incident> GetSearchIncidents()
        {
            return this.incidentSource.GetSearchIncidents();
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
            this.incidentSource.Search(customerID);
        }
    }
}
