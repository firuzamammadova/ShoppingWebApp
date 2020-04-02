using System;
namespace ShoppingWebApp.Services
{
    public interface IUnitOfWork
    {
        IProductService Products { get; }
    }
}
