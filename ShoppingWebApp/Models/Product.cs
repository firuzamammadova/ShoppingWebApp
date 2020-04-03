using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingWebApp.Models
{
    [BsonCollection("Products")]
    public class Product : Document
    {
       

        [BsonElement("Name")]
        public string ProductName { get; set; }
        public double Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductAttribute> Attributes { get; set; }


    }
}
