using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// class used to define open incident
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class OpenIncident
    {
        #region Data Members

        /// <summary>
        /// getter and setter for ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// getter and setter for DateOpened
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// getter and setter for Customer name
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// getter and setter for Technician name
        /// </summary>
        public string Technician { get; set; }

        /// <summary>
        /// getter and setter for Title of incident
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// constructor that takes no parameters
        /// </summary>
        public OpenIncident()
        {
        }

        /// <summary>
        /// constuctor that accepts open incident parameters and makes them available to getter/setters
        /// </summary>
        /// <param name="productCode">product code</param>
        /// <param name="dateOpened">date incident opened</param>
        /// <param name="customer">customer name</param>
        /// <param name="technician">technician name</param>
        /// <param name="title">title of incident</param>
        public OpenIncident(string productCode, DateTime dateOpened, string customer, string technician, string title)
        {
            this.ProductCode = productCode;
            this.DateOpened = dateOpened;
            this.Customer = customer;
            this.Technician = technician;
            this.Title = title;
        }

        #endregion
    }
}
