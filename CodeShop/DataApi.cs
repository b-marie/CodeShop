using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CodeShop.Common.Interfaces;
using CodeShop.Data.Models;
using CodeShop.Data.Repositories;

namespace CodeShop.Data
{
    public sealed class DataApi
    {
        //Make the class sealed so no one can create a wrapper for it.
        private readonly ProductRepository _productRepo;

        public DataApi(IDbConnection db)
        {
            _productRepo = new ProductRepository(db);
        }

        public IEnumerable<IProduct> GetProducts()
        {
           return  _productRepo.GetProducts();
        }

        public IProduct CreateProduct(IProductCreation data)
        {
            return _productRepo.Create(data);
        }

    }
}
