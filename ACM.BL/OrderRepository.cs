using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// retrieve one order by id
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 1)
            {
                order.OrderDate = new DateTime(2008, 5, 1, 8, 30, 52);
            }
            return order;
        }

        /// <summary>
        /// save current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
