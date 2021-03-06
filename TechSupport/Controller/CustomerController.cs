using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL for customer
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class CustomerController
    {
        #region Data Members

        private readonly CustomerDBDAL customerDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a CustomerController object
        /// </summary>
        public CustomerController()
        {
            customerDBSource = new CustomerDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get a customer
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>list of customer objects</returns>
        public List<Customer> GetCustomer(int customerID)
        {
            if (customerID < 1)
            {
                throw new ArgumentException("CustomerID cannot be less than 1");
            }
            return customerDBSource.GetCustomer(customerID);
        }

        /// <summary>
        /// method used to get/return all the customer id and names
        /// </summary>
        /// <returns>a list of all the customer ids and names</returns>
        public List<CustomerIDAndName> GetAllCustomerIDAndNames()
        {
            return customerDBSource.GetAllCustomerIDAndNames();
        }

        #endregion
    }
}
