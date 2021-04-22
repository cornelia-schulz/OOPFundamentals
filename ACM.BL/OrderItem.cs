using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // code that retrieves defined order
            return new OrderItem();
        }
        /// <summary>
        /// Saves the current order item
        /// </summary>
        public bool Save()
        {
            // code that saves the defined product
            return true;
        }

        /// <summary>
        /// Validates the order item data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
