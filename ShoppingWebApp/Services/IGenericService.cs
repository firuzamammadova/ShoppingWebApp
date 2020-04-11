using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public interface IGenericService<TDocument> where TDocument:IDocument 
    {
        TDocument Get(ObjectId id);
        IQueryable<TDocument> GetAll();
        IQueryable<TDocument> Find(Expression<Func<TDocument, bool>> predicate);
        void Add(TDocument document);
         void AddMany(IEnumerable<TDocument> documents);
        void Delete(TDocument document);
        void Edit(TDocument document);
    }
}
