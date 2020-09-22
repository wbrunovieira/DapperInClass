using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperInClass
{
    public class DapperProductsRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductsRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        

        public IEnumerable<Products> GetAllProducts()
        {
            return _connection.Query<Products>("SELECT PRODUCTID, Name, Price FROM products");
        }
    }
}
