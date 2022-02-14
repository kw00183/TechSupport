using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define product code and name
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class ProductCodeAndName
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

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public ProductCodeAndName()
        {
        }

        /// <summary>
        /// constructor used to create product code and name
        /// </summary>
        /// <param name="productCode">product's code</param>
        /// <param name="name">product's name</param>
        public ProductCodeAndName(string productCode, string name)
        {

            if (string.IsNullOrEmpty(productCode) || productCode.Length > 10)
            {
                throw new ArgumentException("Product's Product Code cannot be null/empty or greater than 10", "productCode");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Product's Name cannot be null/empty or greater than 50", "name");

            }

            this.ProductCode = productCode;
            this.Name = name;
        }

        #endregion
    }
}
