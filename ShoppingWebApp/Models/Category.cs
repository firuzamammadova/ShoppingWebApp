using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingWebApp.Models
{
    [BsonCollection("Categories")]
    public class Category : Document
    {
       
        public string CategoryName { get; set; }

        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}
