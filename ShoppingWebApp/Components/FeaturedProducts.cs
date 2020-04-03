using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Services;

namespace ShoppingWebApp.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductService service;

        public FeaturedProducts(IProductService _service)
        {
            service = _service;
        }

        public IViewComponentResult Invoke()
        {
            return View(service
                .GetAll()
                .Where(i => i.IsApproved && i.IsFeatured)
                .ToList());
        }
    }
}
