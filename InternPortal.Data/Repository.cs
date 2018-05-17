using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InternPortal.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private bool _disposed = false;

        public readonly IInternPortalContext _context;

        protected Repository(IInternPortalContext context)
        {
            _context = context;
        }

        public IInternPortalContext Context()
        {
            return _context;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            SetEntryModified(entity);
        }

        public virtual void SetEntryModified(T entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}

