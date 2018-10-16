using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CodeShop.Common.Interfaces;
using CodeShop.Data.Models;
using Dapper;

namespace CodeShop.Data.Repositories
{
    internal class ProductRepository
    {
        private IDbConnection _db;

        #region SQLCommands

        /**
         * CREATE
         * READ
         * UPDATE
         * DESTROY
         */

        internal IProduct Create(IProductCreation data)
        {
            var newProduct = new Product(data);

           var successful = _db.Execute(@"
                INSERT INTO products 
                    (id, name, description, img, ispublic, creatorid, createdtimestamp)
                    VALUES (@Id, @Name, @Description, @Img, @IsPublic, @CreatorId, @CreatedTimestamp);
                    
            ", newProduct);

            if (successful == 1)
            {
                return newProduct;
            }

            return null;
        }

        internal IEnumerable<IProduct> GetProducts()
        {
           return  _db.Query<Product>("SELECT * FROM products");
        }

        #endregion

        #region Constructor

        public ProductRepository(IDbConnection db)
        {
            _db = db;
        }
        #endregion

        
    }
}
