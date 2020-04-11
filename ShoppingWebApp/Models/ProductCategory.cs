using System;
using MongoDB.Bson;

namespace ShoppingWebApp.Models
{
    [BsonCollection("ProductCategories")]
    public class ProductCategory : Document
    {
        public ObjectId CategoryId { get; set; }
        public Category Category { get; set; }

        public ObjectId ProductId { get; set; }
        public Product Product { get; set; }
    }
}
