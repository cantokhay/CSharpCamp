﻿using Bootcamp.DataAccessLayer.Abstract;
using Bootcamp.DataAccessLayer.Context;
using Bootcamp.DataAccessLayer.Repositories;
using Bootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new BootcampContext();
            var values = context.Products.Select(x => new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
