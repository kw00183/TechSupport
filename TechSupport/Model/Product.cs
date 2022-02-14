using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define products
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class Product
    {
        #region Data Members

        /// <summary>
        /// getter method for product ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// getter method for product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// getter method for product Version
        /// </summary>
        public decimal Version { get; set; }

        /// <summary>
        /// getter method for product ReleaseDate
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// constructor used to create product
        /// </summary>
        /// <param name="productCode">product's code</param>
        /// <param name="name">product's name</param>
        /// <param name="version">product's version</param>
        /// <param name="releaseDate">product's release date</param>
        public Product(string productCode, string name, decimal version, DateTime releaseDate)
        {

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Product's Product Code cannot be null/empty or greater than 10", "productCode");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Product's Name cannot be null/empty or greater than 50", "name");

            }

            if (version < 0)
            {
                throw new ArgumentOutOfRangeException("version", "Product's Version has to be number greater than or equal to  0.0");

            }

            if (releaseDate.Year < 2000 || releaseDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("releaseDate", "Product's Release Date has to occur after 2000 and <= current datetime");

            }

            this.ProductCode = productCode;
            this.Name = name;
            this.Version = version;
            this.ReleaseDate = releaseDate;
        }

        #endregion
    }
}
