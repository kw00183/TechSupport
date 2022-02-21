using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// class controller used to access the DAL for products
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class ProductController
    {
        #region Data Members

        private readonly ProductDBDAL productDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a ProductController object
        /// </summary>
        public ProductController()
        {
            productDBSource = new ProductDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get a product by ProductCode
        /// </summary>
        /// <param name="productCode">product code</param>
        /// <returns>list of product objects</returns>
        public List<Product> GetProduct(string productCode)
        {
            if (string.IsNullOrEmpty(productCode))
            {
                throw new ArgumentNullException("ProductCode cannot be null or empty");
            }
            return productDBSource.GetProduct(productCode);
        }

        /// <summary>
        /// method used to get/return all the product codes and names
        /// </summary>
        /// <returns>a list of all the product objects with codes and names</returns>
        public List<ProductCodeAndName> GetAllProductCodeAndNames()
        {
            return productDBSource.GetAllProductCodeAndNames();
        }

        #endregion
    }
}
