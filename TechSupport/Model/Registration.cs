using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define registration
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class Registration
    {
        #region Data Members

        /// <summary>
        /// getter method for registration CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// getter method for registration ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// getter method for registration RegistrationDate
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Registration()
        {
        }

        /// <summary>
        /// constructor used to create registration
        /// </summary>
        /// <param name="customerID">registration's customerID</param>
        /// <param name="productCode">registration's product code</param>
        /// <param name="registrationDate">registration's date</param>
        public Registration(int customerID, string productCode, DateTime registrationDate)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Registration's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Registration's Product Code cannot be null/empty or greater than 10", "productCode");

            }

            if (registrationDate.Year < 2000 || registrationDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("registrationDate", "Registration's Date has to occur after 2000 and <= current datetime");

            }

            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.RegistrationDate = registrationDate;
        }

        #endregion
    }
}
