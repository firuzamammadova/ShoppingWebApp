using System;
using System.Collections.Generic;
using MongoDB.Bson;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> GetTop5Products();
        public List<Product> GetProductsByCategory(Category category);
    }
}
