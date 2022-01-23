using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to add incidents to the all incidents list
    /// </summary>
    public class IncidentAddController
    {
        private readonly IncidentDAL incidentSource;
        
        /// <summary>
        /// create an IncidentController object to add incidents
        /// </summary>
        public IncidentAddController()
        {
            this.incidentSource = new IncidentDAL();
        }
        
        /// <summary>
        /// method used to get/return all the incidents
        /// </summary>
        /// <returns>a list of all the incidents</returns>
        public List<Incident> GetAllIncidents()
        {
            return this.incidentSource.GetAllIncidents();
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
            this.incidentSource.Add(incident);
        }
    }
}
