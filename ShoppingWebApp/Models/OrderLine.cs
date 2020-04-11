using MongoDB.Bson;

namespace ShoppingWebApp.Models
{
    public class OrderLine : Document
    {
        public ObjectId OrderId { get; set; }
        public virtual Order Order { get; set; }

        public ObjectId ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}