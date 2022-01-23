using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("kweib", "problem logging in", "when I try to log in, it gives an invalid error"),
            new Incident("jweib", "need to change username", "don't see an option to change the username"),
            new Incident("rweib", "need to change my password", "don't see an option to allow password change")
        };

        public List<Incident> GetIncidents()
        {
            return _incidents;
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
    }
}
