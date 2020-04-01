using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingWebApp.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}
