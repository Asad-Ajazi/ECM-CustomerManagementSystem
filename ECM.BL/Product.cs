﻿using Extra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        // ? means nullable type. value type that allows value or null
        public decimal? CurrentPrice { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                // Inserts appropriate spaces in the name.

                //return StringHandler.InsertSpaces(_productName);
                // using a static extention method to call directly instead of code above.
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        // overriding the object class ToString method.
        public override string ToString() => ProductName;

        /// <summary>
        /// Validate the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
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


    }
}
