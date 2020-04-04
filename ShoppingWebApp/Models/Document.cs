using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingWebApp.Models
{
    public class Document : IDocument
    {
        public string Id { get; set; }
    }

    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        string Id { get; set; }
    }
}
