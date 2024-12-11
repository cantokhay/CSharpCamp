using Bootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace Bootcamp.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
