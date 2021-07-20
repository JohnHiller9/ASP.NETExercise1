using System;
using System.Collections.Generic;
using System.Data;
using ASP.NETExercise1.Models;
using Dapper;

namespace ASP.NETExercise1
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * From Products;");
        }
    }
}
