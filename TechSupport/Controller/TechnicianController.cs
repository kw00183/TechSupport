using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL to search technicians
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class TechnicianController
    {
        #region Data Members

        private readonly TechnicianDBDAL technicianDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a TechnicianController object
        /// </summary>
        public TechnicianController()
        {
            technicianDBSource = new TechnicianDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get/return all the technician ids and names
        /// </summary>
        /// <returns>a list of all the technician ids and names</returns>
        public List<TechnicianIDAndName> GetAllTechnicianIDAndNames()
        {
            return technicianDBSource.GetAllTechnicianIDAndNames();
        }

        #endregion
    }
}
