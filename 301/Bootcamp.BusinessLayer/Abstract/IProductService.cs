using Bootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace Bootcamp.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Object> TGetProductsWithCategory();
    }
}
