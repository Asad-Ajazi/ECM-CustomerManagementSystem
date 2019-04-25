using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        // nullable DateTimeOffset to account for different time zones.
        public DateTimeOffset? OrderDate { get; set; }


        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
