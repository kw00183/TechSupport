using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define customer id and name
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class CustomerIDAndName
    {
        #region Data Members

        /// <summary>
        /// getter method for customer CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// getter method for customer Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public CustomerIDAndName()
        {
        }

        /// <summary>
        /// constructor used to create product
        /// </summary>
        /// <param name="customerID">customer's ID</param>
        /// <param name="name">customer's name</param>
        public CustomerIDAndName(int customerID, string name)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Customer's Name cannot be null/empty or greater than 50", "name");

            }

            this.CustomerID = customerID;
            this.Name = name;
        }

        #endregion
    }
}
