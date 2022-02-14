using System;
using System.Collections.Generic;

namespace TechSupport.Model
{
    /// <summary>
    /// model class used to define customers
    /// Author: Kim Weible
    /// Version: Spring 2022
    /// </summary>
    public class Customer
    {
        #region Data Members

        /// <summary>
        /// getter method for customer CustomerID
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// getter method for customer Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// getter method for customer Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// getter method for customer City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// getter method for customer State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// getter method for customer ZipCode
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// getter method for customer Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// getter method for customer Email
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// constructor used to create product
        /// </summary>
        /// <param name="customerID">customer's ID</param>
        /// <param name="name">customer's name</param>
        /// <param name="address">customer's address</param>
        /// <param name="city">customer's city</param>
        /// <param name="state">customer's state</param>
        /// <param name="zipCode">customer's zip code</param>
        /// <param name="phone">customer's phone</param>
        /// <param name="email">customer's email</param>
        public Customer(int customerID, string name, string address, string city, string state, string zipCode, string phone, string email)
        {

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer's CustomerID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 50)
            {
                throw new ArgumentException("Customer's Name cannot be null/empty or greater than 50", "name");

            }

            if (string.IsNullOrEmpty(address) || address.Length > 50)
            {
                throw new ArgumentException("Customer's address cannot be null/empty or greater than 50", "address");

            }

            if (string.IsNullOrEmpty(city) || city.Length > 20)
            {
                throw new ArgumentException("Customer's city cannot be null/empty or greater than 20", "city");

            }

            if (string.IsNullOrEmpty(state) || state.Length > 2)
            {
                throw new ArgumentException("Customer's state cannot be null/empty or greater than 2", "state");

            }

            if (string.IsNullOrEmpty(zipCode) || zipCode.Length > 9)
            {
                throw new ArgumentException("Customer's zip code cannot be null/empty or greater than 9", "zipCode");

            }

            if (string.IsNullOrEmpty(phone) || phone.Length > 20)
            {
                throw new ArgumentException("Customer's phone cannot be null/empty or greater than 20", "phone");

            }

            if (string.IsNullOrEmpty(email) || email.Length > 50)
            {
                throw new ArgumentException("Customer's email cannot be null/empty or greater than 50", "email");

            }

            this.CustomerID = customerID;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Phone = phone;
            this.Email = email;
        }

        #endregion
    }
}
