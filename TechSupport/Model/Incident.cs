using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    public class Incident
    {
        /// <summary>
        /// The Incident model class.
        /// </summary>
        public string CustomerID { get; }

        public string Title { get; }

        public string Description { get; }
        
        /// <summary>
        /// Incident constructor.
        /// </summary>
        /// <param name="customerID">the customer's ID</param>
        /// <param name="title">the title of the incident</param>
        /// <param name="description">the incident description</param>
        public Incident(string customerID, string title, string description)
        {

            if (string.IsNullOrEmpty(customerID) || customerID.Length > 50)
            {
                throw new ArgumentException("Incident's CustomerID cannot be null/empty or greater than 50", "customerID");

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
