using System;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Services;

namespace ShoppingWebApp.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryService repository;

        public CategoryMenu(ICategoryService _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetAllWithProductCount());
        }
    }
}
