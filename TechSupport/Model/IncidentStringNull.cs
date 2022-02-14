using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define incidents with string nulls
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class IncidentStringNull
    {
        #region Data Members

        /// <summary>
        /// getter method for incident IncidentID
        /// </summary>
        public int IncidentID { get; set; }

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
        public string TechID { get; set; }

        /// <summary>
        /// getter method for incident DateOpened
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// getter method for incident DateClosed
        /// </summary>
        public string DateClosed { get; set; }

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
        public IncidentStringNull()
        {
        }

        /// <summary>
        /// constructor used to create incident
        /// </summary>
        /// <param name="incidentID">incident incidentID</param>
        /// <param name="customerID">incident customerID</param>
        /// <param name="productCode">incident product code</param>
        /// <param name="techID">incident techID</param>
        /// <param name="dateOpened">incident date opened</param>
        /// <param name="dateClosed">incident date closed</param>
        /// <param name="title">incident title</param>
        /// <param name="description">incident description</param>
        public IncidentStringNull(int incidentID, int customerID, string productCode, string techID, DateTime dateOpened, string dateClosed, string title, string description)
        {

            if (incidentID < 0)
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

            if (dateOpened.Year < 2000 || dateOpened > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("dateOpened", "Product's Date Opened has to occur after 2000 and <= current datetime");

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
