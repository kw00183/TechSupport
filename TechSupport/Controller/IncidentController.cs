using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL for incident
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
        /// create an IncidentController object
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
        /// <returns>a list of all the incident objects</returns>
        public List<Incident> GetAllIncidents()
        {
            return incidentDBSource.GetAllIncidents();
        }

        /// <summary>
        /// method used to add an incident to the list
        /// </summary>
        /// <param name="incident">incident object</param>
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
        /// <param name="incidentID">incident id</param>
        /// <returns>incident object</returns>
        public Incident GetIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID cannot be less than 1");
            }
            return incidentDBSource.GetIncident(incidentID);
        }

        /// <summary>
        /// method used to update specific fields of incident
        /// </summary>
        /// <param name="oldIncident">old Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if Incident object was updated</returns>
        public bool UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            if (oldIncident.IncidentID < 1)
            {
                throw new ArgumentException("Old IncidentID cannot be less than 1");
            }
            if (oldIncident.Description.Length > 2000)
            {
                throw new ArgumentException("Old Description cannot be greater than 2000");
            }
            if (newIncident.IncidentID < 1)
            {
                throw new ArgumentException("New IncidentID cannot be less than 1");
            }
            if (newIncident.Description.Length > 2000)
            {
                throw new ArgumentException("New Description cannot be greater than 2000");
            }
            return incidentDBSource.UpdateIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// method used to close the incident with a specific IncidentID
        /// </summary>
        /// <param name="oldIncident">old Incident object</param>
        /// <param name="newIncident">new Incident object</param>
        /// <returns>boolean if Incident object was closed</returns>
        public bool CloseIncident(Incident oldIncident, Incident newIncident)
        {
            if (oldIncident.IncidentID < 1)
            {
                throw new ArgumentException("Old IncidentID cannot be less than 1");
            }
            if (oldIncident.Description.Length > 2000)
            {
                throw new ArgumentException("Old Description cannot be greater than 2000");
            }
            if (newIncident.IncidentID < 1)
            {
                throw new ArgumentException("New IncidentID cannot be less than 1");
            }
            if (newIncident.Description.Length > 2000)
            {
                throw new ArgumentException("New Description cannot be greater than 2000");
            }
            return incidentDBSource.CloseIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// method used to get/return all the incidents with a specific CustomerID
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>list of all the incident objects searched</returns>
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
        /// <returns>return list of open incident objects</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            return incidentDBSource.GetOpenIncidents();
        }

        /// <summary>
        /// method used to return open incidents assigned from DAL
        /// </summary>
        /// <param name="techID">technician id</param>
        /// <returns>list of assigned open incident objects</returns>
        public List<OpenIncidentAssigned> GetTechnicianOpenIncidents(int techID)
        {
            return incidentDBSource.GetTechnicianOpenIncidents(techID);
        }

        #endregion
    }
}
