using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define incidents
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class Incident
    {
        #region Data Members

        /// <summary>
        /// getter method for incident IncidentID
        /// </summary>
        public int? IncidentID { get; set; }

        /// <summary>
        /// getter method for incident CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// getter method for incident ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// getter method for incident TechID
        /// </summary>
        public int? TechID { get; set; }

        /// <summary>
        /// getter method for incident DateOpened
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// getter method for incident DateClosed
        /// </summary>
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// getter method for incident title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// getter method for incident description
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Incident()
        {
        }

        /// <summary>
        /// constructor used to create incident
        /// </summary>
        /// <param name="incidentID">Incident ID</param>
        /// <param name="customerID">Customer ID</param>
        /// <param name="productCode">Product Code</param>
        /// <param name="techID">Technician ID</param>
        /// <param name="dateOpened">Date Opened</param>
        /// <param name="dateClosed">Date Closed</param>
        /// <param name="title">Title</param>
        /// <param name="description">Description</param>
        public Incident(int? incidentID, int customerID, string productCode, int? techID
            , DateTime dateOpened, DateTime? dateClosed, string title, string description)
        {
            if (incidentID != null && incidentID < 0)
            {
                throw new ArgumentOutOfRangeException("incidentID", "Incident's IncidentID has to be number greater than 0");

            }

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Incident's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Incident's Product Code cannot be null/empty or greater than 10", "productCode");

            }

            if (techID != null && techID < 0)
            {
                throw new ArgumentOutOfRangeException("techID", "Incident's TechID has to be number greater than 0");

            }

            if (!DateTime.TryParse(dateOpened.ToString(), out _))
            {
                throw new ArgumentException("Incident's Date Opened is not valid", "dateOpened");

            }

            if (dateClosed != null && !DateTime.TryParse(dateClosed.ToString(), out _))
            {
                throw new ArgumentException("Incident's Date Closed is not valid", "dateClosed");

            }

            if (string.IsNullOrEmpty(title) || title.Length > 50)
            {
                throw new ArgumentException("Incident's Title cannot be null/empty or greater than 50", "title");

            }

            if (string.IsNullOrEmpty(description) || description.Length > 2000)
            {
                throw new ArgumentException("Incident's description cannot be null/empty or greater than 200", "description");

            }

            this.IncidentID = incidentID;
            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.TechID = techID;
            this.DateOpened = dateOpened;
            this.DateClosed = dateClosed;
            this.Title = title;
            this.Description = description;
        }

        #endregion
    }
}
