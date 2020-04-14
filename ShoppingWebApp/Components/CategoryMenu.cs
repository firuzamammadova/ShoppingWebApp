using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Services;
using ShoppingWebApp.ViewModels;

namespace ShoppingWebApp.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryService repository;
        private IUnitOfWork uow;

        public CategoryMenu(ICategoryService _repository, IUnitOfWork _uow)
        {
            repository = _repository;
            uow = _uow;
        }

        public IViewComponentResult Invoke()
        {
             var list =uow.Categories.GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.Id,
                CategoryName = i.CategoryName,
                Count = uow.ProductCategories.GetAll().Where(a=>a.CategoryId==i.Id).Count()
            });
            return View(list);
        }
    }
}
