using System;
namespace ShoppingWebApp.Models
{
    [BsonCollection("Images")]
    public class Image : Document
    {
       // public int ImageId { get; set; }

        public string ImageName { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
