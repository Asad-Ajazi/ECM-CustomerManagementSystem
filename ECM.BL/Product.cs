using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        // ? means nullable type. value type that allows value or null
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Validate the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Retrieve a single product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // code that retrieves specific product.
            return new Product();
        }

        /// <summary>
        /// Save the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the specified product.
            return true;
        }
    }
}
