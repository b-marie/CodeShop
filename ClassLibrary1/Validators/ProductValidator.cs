using System;
using System.Collections.Generic;
using System.Text;
using CodeShop.Common.Interfaces;

namespace CodeShop.Core.Validators
{
    internal static class ProductValidator
    {

        public static bool Validate(IProductCreation data)
        {
            if (string.IsNullOrWhiteSpace(data.Name))
            {
                throw new Exception("Your product needs a name");
            }
            return true;
        }


    }
}
