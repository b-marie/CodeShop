using System;
using CodeShop.Common.Interfaces;
using CodeShop.Core.Validators;
using CodeShop.Data;

namespace CodeShop.Core
{
    public class CoreApi
    {
        private readonly DataApi api = new DataApi(DBConnectionOptions.ConnectToMySQL("someconnection"));

        public IProduct CreateProduct(IProductCreation data)
        {
            try
            {
                ProductValidator.Validate(data);
                return api.CreateProduct(data);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
