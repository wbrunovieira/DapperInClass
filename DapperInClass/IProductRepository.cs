using System;
using System.Collections.Generic;

namespace DapperInClass
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
    }
}
