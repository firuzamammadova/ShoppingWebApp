using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using ShoppingWebApp.Models;
using ShoppingWebApp.ViewModels;

namespace ShoppingWebApp.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly IMongoCollection<Category> _collection;

        public CategoryService(IShoppingDatabaseSettings settings) : base(settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Category>(GetCollectionName(typeof(Category)));
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId =i.Id,
                CategoryName = i.CategoryName,
                Count = 4
            });
        }

        public Category GetByName(string name)
        {
            return _collection.AsQueryable()
                 .Where(i => i.CategoryName == name)
                 .FirstOrDefault();
        }
    }
}
