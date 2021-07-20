using System;
using System.Collections.Generic;
using ASP.NETExercise1.Models;

namespace ASP.NETExercise1
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
