using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace YOTD.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly QuoteDbContext _context;
        protected DbSet<T> DbSet { get; }

        public Repository(QuoteDbContext context)
        {
            this._context = context;
            DbSet = this._context.Set<T>();
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public int SaveChanges()
        {
            return this._context.SaveChanges();
        }
    }
}