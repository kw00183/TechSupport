using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data layer class used to access the incidents
    /// </summary>
    public class IncidentDAL
    {
        private readonly static List<Incident> _incidents = new List<Incident>
        {
            new Incident(1, "problem logging in", "when I try to log in, it gives an invalid error"),
            new Incident(2, "need to change username", "don't see an option to change the username"),
            new Incident(3, "need to change my password", "don't see an option to allow password change")
        };
        private readonly List<Incident> _results = new List<Incident>();

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
        /// <returns></returns>
        public List<Incident> GetSearchIncidents()
        {
            return _results;
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

        /// <summary>
        /// method used to search the list of incidents by customerID and add them to a results list
        /// </summary>
        /// <param name="customerID">CustomerID of incident</param>
        public void Search(int customerID)
        {
            _results.Clear();
            if (customerID < 0)
            {
                throw new ArgumentNullException("CustomerID cannot be less than 0");
            }
            foreach (var incident in _incidents)
            {
                if (incident.CustomerID == customerID)
                {
                    _results.Add(incident);
                }
            }
        }
    }
}
