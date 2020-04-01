using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public class GenericService<TDocument> :IGenericService<TDocument> where TDocument: IDocument
    {
        private readonly IMongoCollection<TDocument> _collection;

        public GenericService(IShoppingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }
        public IQueryable<TDocument> GetAll() =>
            _collection.Find(book => true).ToList().AsQueryable();

        public TDocument Get(string id) {
            var objectId = new ObjectId(id);
            return _collection.Find<TDocument>(book => book.Id == objectId).FirstOrDefault();
        }

        public void Add(TDocument book)
        {
            _collection.InsertOne(book);
        }

        public void Edit(string id, TDocument bookIn)
        {
            var objectId = new ObjectId(id);
            _collection.ReplaceOne(book => book.Id == objectId, bookIn);
        }

        public void Delete(TDocument bookIn) =>
            _collection.DeleteOne(book => book.Id == bookIn.Id);

        public void Delete(string id)
        {
            var objectId = new ObjectId(id);
            _collection.DeleteOne(book => book.Id == objectId);
        }

        public TDocument Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TDocument> Find(Expression<Func<TDocument, bool>> predicate)
        {
            return _collection.Find(predicate).ToList().AsQueryable();
        }

        public void Edit(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            _collection.FindOneAndReplace(filter, document);
        }
    }
}
