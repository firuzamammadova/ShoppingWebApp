using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Services;
using ShoppingWebApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingWebApp.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;
        private IUnitOfWork uow;
        private IProductService productService;

        public ProductController(IUnitOfWork _uow, IProductService _productService)
        {
            uow = _uow;
            productService = _productService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category, int page = 1)
        {
            var products = uow.Products.GetAll();
            var categories = uow.Categories.GetAll();
            if (!string.IsNullOrEmpty(category))
            {
                var categoryId = categories.FirstOrDefault(i => i.CategoryName == category);
                products = productService.GetProductsByCategory(categoryId).AsQueryable();
                // products = products.ToList()
                //     .Include(i => i.ProductCategories)
                //     .ThenInclude(i => i.Category)
                //     .Where(i => i.ProductCategories.Any(a => a.Category.CategoryName == category));

              // products= products.Where(a => a.ProductCategories.Any(a => a.Category.CategoryName == category));
            }
            var count = products.Count();

            products = products.Skip((page - 1) * PageSize).Take(PageSize);

            return View(
                new ProductListModel()
                {
                    Products = products,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = count
                    }
                }
                );
        }

  //      public IActionResult Details(int id)
   //     {
           // return View(uow.Products
            //    .GetAll()
           //     .Where(i => Convert.ToUInt32(i.Id) == id)
           //     .Include(i => i.Images)
            //    .Include(i => i.Attributes)
             //   .Include(i => i.ProductCategories)
             //   .ThenInclude(i => i.Category)
            //    .Select(i => new ProductDetailsModel()
             //   {
              //      Product = i,
              //      ProductImages = i.Images,
              //      ProductAttributes = i.Attributes,
              //      Categories = i.ProductCategories.Select(a => a.Category).ToList()
              //  })
              //  .FirstOrDefault());




//        }
    }
}
