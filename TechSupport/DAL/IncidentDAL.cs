using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private readonly static List<Incident> _incidents = new List<Incident>
        {
            new Incident(1, "problem logging in", "when I try to log in, it gives an invalid error"),
            new Incident(2, "need to change username", "don't see an option to change the username"),
            new Incident(3, "need to change my password", "don't see an option to allow password change")
        };

        private readonly static List<Incident> _results = new List<Incident>
        {
        };

        public List<Incident> GetAllIncidents()
        {
            return _incidents;
        }

        public List<Incident> GetSearchIncidents()
        {
            return _results;
        }

        /// <summary>
        /// Add an incident to the list 
        /// </summary>
        /// <param name="incident"></param>

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            _incidents.Add(incident);
        }

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
