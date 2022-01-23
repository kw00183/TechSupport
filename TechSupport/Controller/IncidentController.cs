﻿using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL incidentSource;
        /// <summary>
        /// Create an IncidentController object.
        /// 
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();

        }
        /// <summary>
        /// Getting the incident
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetIncidents()
        {
            return this.incidentSource.GetIncidents();
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
            this.incidentSource.Add(incident);
        }
    }
}
