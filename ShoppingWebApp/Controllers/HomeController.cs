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
        public IActionResult Details(int id)
        {
            return View(uow.Products.Get(id));
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
          
                var products = new[]
                {
                    new Product(){ ProductName="Photo Camera", Price=153, Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>", DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ ProductName="Wood Chair", Price=99, Image="product2.jpg",IsHome=false,IsApproved=true,IsFeatured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>", DateAdded=DateTime.Now.AddDays(-20)},
                    new Product(){ ProductName="Comfortable Sofa", Price=526, Image="product3.jpg",IsHome=true,IsApproved=false,IsFeatured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>", DateAdded=DateTime.Now.AddDays(-30)},
                    new Product(){ ProductName="Hand Bag", Price=125, Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>", DateAdded=DateTime.Now.AddDays(-5)},
                    new Product(){ ProductName="Sofa", Price=250, Image="product3.jpg",IsHome=true,IsApproved=true,IsFeatured=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.", HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>", DateAdded=DateTime.Now.AddDays(-2)},
                };

                uow.Products.AddMany(products);

                var categories = new[]
                {
                    new Category(){ CategoryName="Electronics"},
                    new Category(){ CategoryName="Accessories"},
                    new Category(){ CategoryName="Furniture"}
                };

                uow.Categories.AddMany(categories);

                var productcategories = new[]
                {
                    new ProductCategory(){ Product=products[0],Category=categories[0]},
                    new ProductCategory(){ Product=products[1],Category=categories[0]},
                    new ProductCategory(){ Product=products[3],Category=categories[2]},
                    new ProductCategory(){ Product=products[2],Category=categories[1]}
                };

                uow.ProductCategories.AddMany(productcategories);


                var images = new[]
                {
                    new Image(){ ImageName="product1.jpg", Product=products[0]},
                    new Image(){ ImageName="product2.jpg", Product=products[0]},
                    new Image(){ ImageName="product3.jpg", Product=products[0]},
                    new Image(){ ImageName="product4.jpg", Product=products[0]},

                    new Image(){ ImageName="product1.jpg", Product=products[1]},
                    new Image(){ ImageName="product2.jpg", Product=products[1]},
                    new Image(){ ImageName="product3.jpg", Product=products[1]},
                    new Image(){ ImageName="product4.jpg", Product=products[1]},

                    new Image(){ ImageName="product1.jpg", Product=products[2]},
                    new Image(){ ImageName="product2.jpg", Product=products[2]},
                    new Image(){ ImageName="product3.jpg", Product=products[2]},
                    new Image(){ ImageName="product4.jpg", Product=products[2]},

                    new Image(){ ImageName="product1.jpg", Product=products[3]},
                    new Image(){ ImageName="product2.jpg", Product=products[3]},
                    new Image(){ ImageName="product3.jpg", Product=products[3]},
                    new Image(){ ImageName="product4.jpg", Product=products[3]},

                    new Image(){ ImageName="product1.jpg", Product=products[4]},
                    new Image(){ ImageName="product2.jpg", Product=products[4]},
                    new Image(){ ImageName="product3.jpg", Product=products[4]},
                    new Image(){ ImageName="product4.jpg", Product=products[4]},
                };

                uow.Images.AddMany(images);

                var attributes = new[]
                {
                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[0]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[0]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[0]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[0]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[0]},

                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[1]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[1]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[1]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[1]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[1]},


                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[2]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[2]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[2]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[2]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[2]},


                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[3]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[3]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[3]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[3]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[3]},


                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[4]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[4]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[4]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[4]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[4]},

                };

                uow.Attributes.AddMany(attributes);
                return View(uow.Products.GetAll());

        }
    }
}
