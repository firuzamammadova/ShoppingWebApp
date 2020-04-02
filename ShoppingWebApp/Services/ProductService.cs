using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductService(IShoppingDatabaseSettings settings) : base(settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Product>(GetCollectionName(typeof(Product)));
        }
       

        public List<Product> GetTop5Products()
        {
            return _collection.AsQueryable()
                 .OrderByDescending(i => i.Id)
                 .Take(5)
                 .ToList();
        }
    }
}
