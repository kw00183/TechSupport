using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    public class OpenIncident
    {
        public string ProductCode { get; set; }

        public DateTime DateOpened { get; set; }

        public string Customer { get; set; }

        public string Technician { get; set; }

        public string Title { get; set; }

        public OpenIncident()
        {
        }

        public OpenIncident(string productCode, DateTime dateOpened, string customer, string technician, string title)
        {

            this.ProductCode = productCode;
            this.DateOpened = dateOpened;
            this.Customer = customer;
            this.Technician = technician;
            this.Title = title;
        }
    }
}
