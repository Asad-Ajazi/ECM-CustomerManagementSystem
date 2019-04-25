using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Customer : EntityBase
    {
        // this(0) calls the second constructor and passes a default 0 for the id.
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            // Initialise list to prevent null reference default value.
            AddresseList = new List<Address>();
        }

        // composition "Has a" relationship between customer and Address.
        public List<Address> AddresseList { get; set; }

        // only this class can set the id. Any caller can get it.
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
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


        public override string ToString() => FullName;

        /// <summary>
        /// Validated customer data and returns true or false.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            // last name and email address are required.
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
