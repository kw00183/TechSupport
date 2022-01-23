using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define incidents
    /// </summary>
    public class Incident
    {

        /// <summary>
        /// getter method for incident CustomerID
        /// </summary>
        public int CustomerID { get; }

        /// <summary>
        /// getter method for incident title
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// getter method for incident description
        /// </summary>
        public string Description { get; }
        
        /// <summary>
        /// constructor used to create incident
        /// </summary>
        /// <param name="customerID">the customer's ID</param>
        /// <param name="title">the title of the incident</param>
        /// <param name="description">the incident description</param>
        public Incident(int customerID, string title, string description)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Incident's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(title) || title.Length > 50)
            {
                throw new ArgumentException("Incident's Title cannot be null/empty or greater than 50", "title");

            }

            if (string.IsNullOrEmpty(description) || description.Length > 200)
            {
                throw new ArgumentException("Incident's description cannot be null/empty or greater than 200", "description");

            }

            this.CustomerID = customerID;
            this.Title = title;
            this.Description = description;
        }
    }
}
