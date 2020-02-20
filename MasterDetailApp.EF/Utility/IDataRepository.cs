using MasterDetailApp.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MasterDetailApp.EF.Utility
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll(Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        T GetById(long id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }

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
            _dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public List<T> GetAll(Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            var query = _dbSet.Where(where);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return query.ToList();
        }

        public T GetById(long id)
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

    public interface IUnitOfWork
    {
        void SaveChanges();
    }

    public interface IMasterDetailUnitOfWork : IUnitOfWork
    {
        IRepository<Article> ArticleRepository { get; }
        IRepository<Category> CategoryRepository { get; }
    }

    public class MasterDetailUnitOfWork : IMasterDetailUnitOfWork
    {
        private MasterDetailContext _db;

        public IRepository<Article> ArticleRepository { get; private set; }
        public IRepository<Category> CategoryRepository { get; private set; }

        public MasterDetailUnitOfWork(MasterDetailContext db)
        {
            _db = db;

            ArticleRepository = new GenericRepository<Article>(db);
            CategoryRepository = new GenericRepository<Category>(db);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
