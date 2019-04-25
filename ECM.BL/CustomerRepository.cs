using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            // Collaborative "uses a" relationship between Customer repo and Address repo
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retriece one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create an instance of the customer class, passing id.
            Customer customer = new Customer(customerId);

            // code that retrieves the specified customer.

            // Temporary Hard Coded Customer.
            if (customerId == 1)
            {
                customer.EmailAddress = "JSmith@gmail.com";
                customer.FirstName = "John";
                customer.LastName = "Smith";
                // call the address repository to retrive addresses for the specified customer.
                customer.AddresseList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Make call to insert stored procedure.
                    }
                    else
                    {
                        // Make call to update stored procedure.
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }    
    }
}
