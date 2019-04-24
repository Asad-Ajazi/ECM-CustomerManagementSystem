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
                return LastName + ", " + FirstName;
            }
        }

    }
}
