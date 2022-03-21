using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// class used to define open incident assigned
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class OpenIncidentAssigned
    {
        #region Data Members

        private DateTime TheDate;

        /// <summary>
        /// getter and setter for Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// getter and setter for DateOpened
        /// </summary>
        public DateTime DateOpened { get { return TheDate.Date; } set { TheDate = value; } }

        /// <summary>
        /// getter and setter for Customer name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// getter and setter for TechID
        /// </summary>
        public int TechID { get; set; }

        /// <summary>
        /// getter and setter for Title of incident
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// getter and setter for Technician name
        /// </summary>
        public string TechnicianName { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// constructor that takes no parameters
        /// </summary>
        public OpenIncidentAssigned()
        {
        }

        /// <summary>
        /// constuctor that accepts open incidents assigned parameters and makes them available to getter/setters
        /// </summary>
        /// <param name="productName">incident product name</param>
        /// <param name="dateOpened">incident date opened</param>
        /// <param name="customerName">customer name</param>
        /// <param name="techID">technician id</param>
        /// <param name="title">incident title</param>
        /// <param name="technicianName">technician name</param>
        public OpenIncidentAssigned(string productName, DateTime dateOpened, string customerName, 
            int techID, string title, string technicianName)
        {
            this.ProductName = productName;
            this.DateOpened = dateOpened;
            this.CustomerName = customerName;
            this.TechID = techID;
            this.Title = title;
            this.TechnicianName = technicianName;
        }

        #endregion
    }
}
