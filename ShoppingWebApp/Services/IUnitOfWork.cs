using System;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public interface IUnitOfWork
    {
        IProductService Products { get; }
        ICategoryService Categories { get; }
        IGenericService<Image> Images { get; }
        IGenericService<ProductAttribute> Attributes { get; }
        IGenericService<ProductCategory> ProductCategories { get; }


    }
}
