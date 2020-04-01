using System;
using System.Linq;
using System.Linq.Expressions;
using ShoppingWebApp.Models;

namespace ShoppingWebApp.Services
{
    public interface IGenericService<TDocument> where TDocument:IDocument 
    {
        TDocument Get(int id);
        IQueryable<TDocument> GetAll();
        IQueryable<TDocument> Find(Expression<Func<TDocument, bool>> predicate);
        void Add(TDocument document);
        void Delete(TDocument document);
        void Edit(TDocument document);
    }
}
