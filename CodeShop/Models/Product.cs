﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeShop.Common.Interfaces;

namespace CodeShop.Data.Models
{
    internal class Product : IProduct
    {

        private IProductCreation data;

        public Product(IProductCreation data)
        {
            Id = Guid.NewGuid().ToString();
            Name = data.Name;
            Description = data.Description;
            Img = data.Img;
            IsPublic = data.IsPublic;
            CreatorId = data.CreatorId;
            CreatedTimestamp = DateTime.UtcNow;
        }


        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public bool IsPublic { get; set; }
        public string CreatorId { get; set; }
        public DateTime CreatedTimestamp { get; set; }
    }
}
