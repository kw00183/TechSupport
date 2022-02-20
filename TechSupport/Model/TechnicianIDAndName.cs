using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define technician id and name
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class TechnicianIDAndName
    {
        #region Data Members

        /// <summary>
        /// getter method for technician TechID
        /// </summary>
        public int TechID { get; set; }

        /// <summary>
        /// getter method for technician Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public TechnicianIDAndName()
        {
        }

        /// <summary>
        /// constructor used to create technician id and name
        /// </summary>
        /// <param name="techID">TechID</param>
        /// <param name="name">Name</param>
        public TechnicianIDAndName(int techID, string name)
        {

            if (techID < 0)
            {
                throw new ArgumentOutOfRangeException("techID", "Technician's TechID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Technician's Name cannot be null/empty or greater than 50", "name");

            }

            this.TechID = techID;
            this.Name = name;
        }

        #endregion
    }
}
