using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL for technician
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
        /// <returns>a list of all the technician objects with id and name</returns>
        public List<TechnicianIDAndName> GetAllTechnicianIDAndNames()
        {
            return technicianDBSource.GetAllTechnicianIDAndNames();
        }

        /// <summary>
        /// method used to get/return all the technicians
        /// </summary>
        /// <returns>a list of all the technician objects</returns>
        public List<Technician> GetAllTechnicians()
        {
            return technicianDBSource.GetAllTechnicians();
        }

        #endregion
    }
}
