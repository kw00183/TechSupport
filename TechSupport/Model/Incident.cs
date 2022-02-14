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
        /// getter method for incident CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// getter method for incident ProductCode
        /// </summary>
        public string ProductCode { get; set; }

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
        /// <param name="customerID">incident customerID</param>
        /// <param name="productCode">incident product code</param>
        /// <param name="title">incident title</param>
        /// <param name="description">incident description</param>
        public Incident(int customerID, string productCode, string title, string description)
        {
            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Incident's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Incident's Product Code cannot be null/empty or greater than 10", "productCode");

            }

            if (string.IsNullOrEmpty(title) || title.Length > 50)
            {
                throw new ArgumentException("Incident's Title cannot be null/empty or greater than 50", "title");

            }

            if (string.IsNullOrEmpty(description) || description.Length > 2000)
            {
                throw new ArgumentException("Incident's description cannot be null/empty or greater than 200", "description");

            }

            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.Title = title;
            this.Description = description;
        }

        #endregion
    }
}
