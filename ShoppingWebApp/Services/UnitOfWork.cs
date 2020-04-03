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
        private ICategoryService _categories;
        private IGenericService<Image> _images;
        private IGenericService<ProductAttribute> _attributes;
        private IGenericService<ProductCategory> _prdctgrys;
        private IGenericService<Order> _orders;

        public IProductService Products
        {
            get
            {
                return _products ?? (_products = new ProductService(settings));
            }
        }

        public ICategoryService Categories
        {
            get
            {
                return _categories ?? (_categories = new CategoryService(settings));
            }
        }
        public IGenericService<Image> Images
        {
            get
            {
                return _images ?? (_images = new GenericService<Image>(settings));
            }
        }
        public IGenericService<ProductAttribute> Attributes
        {
            get
            {
                return _attributes ?? (_attributes = new GenericService<ProductAttribute>(settings));
            }
        }
        public IGenericService<ProductCategory> ProductCategories
        {
            get
            {
                return _prdctgrys ?? (_prdctgrys = new GenericService<ProductCategory>(settings));
            }
        }
        public IGenericService<Order> Orders
        {
            get
            {
                return _orders ?? (_orders = new GenericService<Order>(settings));
            }
        }
    }
}
