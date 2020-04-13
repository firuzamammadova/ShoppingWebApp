using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace ShoppingWebApp.ViewModels
{
    public class AdminEditCategoryModel
    {
        public ObjectId CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<AdminEditCategoryProduct> Products { get; set; }
    }

    public class AdminEditCategoryProduct
    {
        public ObjectId ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
    }
}
