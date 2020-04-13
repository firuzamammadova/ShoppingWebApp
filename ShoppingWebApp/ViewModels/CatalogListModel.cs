using System;
using System.Collections.Generic;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.ViewModels
{
    public class CatalogListModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
