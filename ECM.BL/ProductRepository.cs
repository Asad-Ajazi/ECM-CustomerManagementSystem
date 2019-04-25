using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class ProductRepository
    {

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create an instance of the product class.
            // pass in the id.
            Product product = new Product(productId);

            // code that retrieves the specified product.

            // Temporary Hard Coded Product.
            if (productId == 2)
            {
                product.ProductName = "Roses";
                product.ProductDescription = "A set of 6 Roses.";
                product.CurrentPrice = 15.15M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
