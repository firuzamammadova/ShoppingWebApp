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

        private readonly IGenericService<Product> _bookService;

        public HomeController(IGenericService<Product> bookService)
        {
            _bookService = bookService;
        }

   
        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Product> Get(int id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
        public ActionResult<Product> Create()
        {
            Product book = new Product() { ProductName = "Test", Price = 111 };
            _bookService.Add(book);

            return CreatedAtRoute("GetBook", new { id = book.Id }, book);
        }

        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_bookService.GetAll());
        }
    }
}
