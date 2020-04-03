using System;
using MongoDB.Bson;

namespace ShoppingWebApp.ViewModels
{
    public class CategoryModel
    {
        public ObjectId CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Count { get; set; }
    }
}
