using System;
namespace ShoppingWebApp.Models
{
    [BsonCollection("Attributes")]

    public class ProductAttribute : Document
    {
       

        public string Attribute { get; set; }
        public string Value { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
