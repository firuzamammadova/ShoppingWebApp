using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebApp.Models;
using ShoppingWebApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork uow;

        public HomeController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

   
        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Product> Get(int id)
        {
            var product = uow.Products.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        public ActionResult<Product> Create()
        {
            Product product = new Product() { ProductName = "Test", Price = 111 };
            uow.Products.Add(product);

            return CreatedAtRoute("GetProduct", new { id = product.Id }, product);
        }

        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(uow.Products.GetAll());
        }
    }
}
