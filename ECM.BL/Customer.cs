using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Customer
    {
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

    }
}
