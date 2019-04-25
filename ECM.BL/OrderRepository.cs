using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class OrderRepository
    {


        /// <summary>
        /// Retrieves a specific order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // create an instance of the order class.
            Order order = new Order(orderId);

            // code that retrieves the defined order.

            // Temporary hard coded values.
            if (orderId == 3)
            {
                // order date with a timespan of 7hours
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 24, 10, 0, 0, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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

