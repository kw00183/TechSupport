using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class IncidentSearchController
    {
        private readonly IncidentDAL incidentSource;

        /// <summary>
        /// Create an IncidentController object.
        /// 
        /// </summary>
        public IncidentSearchController()
        {
            this.incidentSource = new IncidentDAL();

        }

        /// <summary>
        /// Getting the incident
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetSearchIncidents()
        {
            return incidentSource.GetSearchIncidents();
        }

        public void Search(int customerID)
        {
            if (customerID < 0)
            {
                throw new ArgumentNullException("CustomerID cannot be less than 0");
            }
            this.incidentSource.Search(customerID);
        }
    }
}
