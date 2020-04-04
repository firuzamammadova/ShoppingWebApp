using System;
using System.Collections.Generic;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.ViewModels
{
    public class ProductDetailsModel
    {
        public ProductDetailsModel()
        {
        }

        public Product Product { get; set; }
        public List<Image> ProductImages { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
