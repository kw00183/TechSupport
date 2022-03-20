using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL for registration
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class RegistrationController
    {
        #region Data Members

        private readonly RegistrationDBDAL registrationDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a RegistrationController object
        /// </summary>
        public RegistrationController()
        {
            registrationDBSource = new RegistrationDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get/return all the registrations
        /// </summary>
        /// <returns>a list of all the registration objects</returns>
        public List<Registration> GetAllRegistrations()
        {
            return registrationDBSource.GetAllRegistrations();
        }

        /// <summary>
        /// method used to call stored procedure and return boolean value if record is registered
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <param name="productCode">product code</param>
        /// <returns>return boolean value if product is registered</returns>
        public Boolean IsCustomerProductRegistered(int customerID, string productCode)
        {
            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentNullException("ProductCode cannot be null or empty");
            }
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return registrationDBSource.IsCustomerProductRegistered(customerID, productCode);
        }

        #endregion
    }
}
