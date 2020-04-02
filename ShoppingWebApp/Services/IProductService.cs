using System;
using System.Collections.Generic;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> GetTop5Products();
    }
}
