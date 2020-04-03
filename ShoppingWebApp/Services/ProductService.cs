using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IMongoCollection<Product> _collection;
        private readonly IMongoCollection<Category> _categorycollection;
        private readonly IMongoCollection<ProductCategory> _prdctgrycollection;


        public ProductService(IShoppingDatabaseSettings settings) : base(settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Product>(GetCollectionName(typeof(Product)));
            _categorycollection = database.GetCollection<Category>(GetCollectionName(typeof(Category)));
            _prdctgrycollection = database.GetCollection<ProductCategory>(GetCollectionName(typeof(ProductCategory)));

        }


        public List<Product> GetTop5Products()
        {
            return _collection.AsQueryable()
                 .OrderByDescending(i => i.Id)
                 .Take(5)
                 .ToList();
        }
        public List<Product> GetProductsByCategory(Category category)
        {

            return _collection.Find(i => i.ProductCategories.Any(i => i.Category == category)).ToList();
            // products = products.ToList()
            //     .Include(i => i.ProductCategories)
            //     .ThenInclude(i => i.Category)
            //     .Where(i => i.ProductCategories.Any(a => a.Category.CategoryName == category));
        }
    }
}
