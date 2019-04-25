﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retriece one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create an instance of the customer class.
            // pass in the id.
            Customer customer = new Customer(customerId);

            // code that retrieves the specified customer.

            // Temporary Hard Coded Customer.
            if (customerId == 1)
            {
                customer.EmailAddress = "JSmith@gmail.com";
                customer.FirstName = "John";
                customer.LastName = "Smith";
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves a customer.
            return true;
        }
    }
}
