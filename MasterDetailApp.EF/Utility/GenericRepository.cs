using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MasterDetailApp.EF.Utility
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private DbContext _db;
        private DbSet<T> _dbSet;

        public GenericRepository(DbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.AddAsync(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public List<T> GetAll(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip != null)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null)
            {
                query = query.Take(take.Value);
            }

            return query.ToList();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            IQueryable<T> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip != null)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null)
            {
                query = query.Take(take.Value);
            }

            return await query.ToListAsync();
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            var count = _dbSet.Where(where).Count();

            return count;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> where)
        {
            var count = await _dbSet.Where(where).CountAsync();

            return count;
        }

        public T GetById(int id)
        {
            var entity = _dbSet.SingleOrDefault(e => e.Id == id);

            return entity;
        }

        public void Update(T entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
