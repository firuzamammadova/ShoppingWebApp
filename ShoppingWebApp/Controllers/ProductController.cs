using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
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
                //var categoryId = categories.FirstOrDefault(i => i.CategoryName == category);
                //var categoryy = uow.Categories.GetByName(category);
                products = uow.ProductCategories.GetAll().Where(i => i.Category.CategoryName == category).Select(i => i.Product);
               // products = productService.GetProductsByCategory(categoryId).AsQueryable();
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
        
        public IActionResult Details(string id)
       {
            ObjectId objectId = new ObjectId(id);
            var Product = uow.Products.GetAll().Where(i=>i.Id==objectId).FirstOrDefault();
            var a = new ProductDetailsModel();

            a.Product = Product;
            a.ProductImages = uow.Images.GetAll().Where(i => i.Product.Id == Product.Id).ToList();
            a.ProductAttributes = uow.Attributes.GetAll().Where(i => i.Product.Id == Product.Id).ToList();
            a.Categories = uow.ProductCategories.GetAll().Where(i=>i.Product.Id==Product.Id).Select(a => a.Category).ToList();
           return View(a);




       }
    }
}
