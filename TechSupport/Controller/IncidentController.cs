﻿using System;
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
        public List<IncidentStringNull> GetAllIncidents()
        {
            return incidentDBSource.GetAllIncidents();
        }

        /// <summary>
        /// method used to add an incident to the list
        /// </summary>
        /// <param name="incident">incident is customrID, title and description</param>
        public void AddIncident(int customerID, string productCode, string title, string description)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentNullException("ProductCode cannot be null or empty");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title cannot be null or empty");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("Description cannot be null or empty");
            }
            incidentDBSource.AddIncident(customerID, productCode, title, description);
        }

        /// <summary>
        /// method used to get/return all the incidents with a specific CustomerID
        /// </summary>
        /// <returns>list of all the incidents searched</returns>
        public List<IncidentStringNull> GetSearchIncidents(int customerID)
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
