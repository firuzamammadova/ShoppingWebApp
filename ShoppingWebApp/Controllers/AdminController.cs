using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using ShoppingWebApp.Models;
using ShoppingWebApp.Services;
using ShoppingWebApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingWebApp.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitofWork;

        public AdminController(IUnitOfWork _unitofWork)
        {
            unitofWork = _unitofWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditCategory(string id)
        {
            
            ObjectId objectId = new ObjectId(id);
            AdminEditCategoryModel model = new AdminEditCategoryModel()
            {
                CategoryId = objectId,
                CategoryName = unitofWork.Categories.Get(objectId).CategoryName,
                Products = unitofWork.ProductCategories.GetAll().Where(i => i.CategoryId == objectId)
                .Select(a => new AdminEditCategoryProduct()
                {
                    ProductId = a.ProductId,
                    ProductName = a.Product.ProductName,
                    Image = a.Product.Image,
                    IsApproved = a.Product.IsApproved,
                    IsFeatured = a.Product.IsFeatured,
                    IsHome = a.Product.IsHome
                }).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitofWork.Categories.Edit(entity);

                return RedirectToAction("CatalogList");
            }

            return View("Error");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(string ProductId, string CategoryId)
        {
            if (ModelState.IsValid)
            {
                ObjectId cid = new ObjectId(CategoryId);
                ObjectId pid = new ObjectId(ProductId);

                //silme
               // unitofWork.Categories.RemoveFromCategory(ProductId, CategoryId);
                var model = unitofWork.ProductCategories.GetAll().Where(i => i.ProductId == pid && i.CategoryId == cid).FirstOrDefault();
                unitofWork.ProductCategories.Delete(model);
                return Ok();
            }
            return BadRequest();
        }


        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = unitofWork.Categories.GetAll().ToList(),
                Products = unitofWork.Products.GetAll().ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitofWork.Categories.Add(entity);

                return Ok(entity);
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", file.FileName);
                    var path_tn = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products/tn", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }

                    using (var stream = new FileStream(path_tn, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                entity.DateAdded = DateTime.Now;
                unitofWork.Products.Add(entity);
                return RedirectToAction("CatalogList");
            }

            return View(entity);
        }
    }
}
