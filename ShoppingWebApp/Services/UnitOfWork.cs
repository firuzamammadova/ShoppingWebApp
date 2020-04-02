using System;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IShoppingDatabaseSettings settings;

        public UnitOfWork(IShoppingDatabaseSettings _settings)
        {
            settings = _settings ?? throw new ArgumentNullException("settings can not be null");
        }

        private IProductService _products;
        //private ICategoryRepository _categories;
        //private IOrderRepository _orders;

        public IProductService Products
        {
            get
            {
                return _products ?? (_products = new ProductService(settings));
            }
        }

    }
}
