using System;
using System.Collections.Generic;
using ShoppingWebApp.Models;
using ShoppingWebApp.ViewModels;

namespace ShoppingWebApp.Services
{
    public interface ICategoryService: IGenericService<Category>
    {
        Category GetByName(string name);
        IEnumerable<CategoryModel> GetAllWithProductCount();
    }
}
