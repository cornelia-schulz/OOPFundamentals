using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.ProductDescription = "Hm";
                product.ProductName = "My Product";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        /// <summary>
        /// Save current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.isValid)
                {
                    if (product.isNew)
                    {
                        // call an Insert Stored Procedure
                    }
                    else
                    {
                        // call an Update Stored Procedure
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
