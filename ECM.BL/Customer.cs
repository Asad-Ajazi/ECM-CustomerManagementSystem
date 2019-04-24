using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        // only this class can set the id. Any caller can get it.
        public int CustomerId { get; private set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        
        public string FullName
        {
            get
            {
                //updated get method to account for missing first or last name.
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        // belongs to the class itself.
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validated customer data and returns true or false.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            // last name and email address are required.
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieves a single customer associated with the customerId.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // code that retreives the specified customer.
            return new Customer();
        }

        /// <summary>
        /// Retrieves all customers into a list.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // code that retreives the specified customer.
            return new List<Customer>();
        }

        public bool Save()
        {
            // code that saves the speified customer.
            return true;
        }



    }
}
