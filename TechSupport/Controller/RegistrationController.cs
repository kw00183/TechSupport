using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to search registrations
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
        /// <returns>a list of all the registrations</returns>
        public List<Registration> GetAllRegistrations()
        {
            return registrationDBSource.GetAllRegistrations();
        }

        public Boolean IsCustomerProductRegistered(int customerID, string productCode)
        {
            return registrationDBSource.IsCustomerProductRegistered(customerID, productCode);
        }

        #endregion
    }
}
