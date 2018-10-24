using EPM.DAL.EF;
using EPM.DAL.Exceptions;
using EPM.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DataContext _context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(DataContext context)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public virtual TEntity GetdById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                return dbSet.Find(id);
            }
            else
            {
                throw new ExceptionHandler($"Объект с Id: {id} не найден в системе");
            }
        }

        public virtual void Create(TEntity item)
        {
            dbSet.Add(item);
        }

        public virtual void Remove(object id)
        {
            TEntity item = dbSet.Find(id);
            if (item != null)
            {
                Remove(item);
            }
            else
            {
                throw new ExceptionHandler($"Объект с Id: {id} не найден в системе");
            }
        }

        public virtual void Remove(TEntity item)
        {
            if (_context.Entry(item).State == EntityState.Detached)
            {
                dbSet.Attach(item);
            }
            dbSet.Remove(item);
        }
        
        public void Update(TEntity item)
        {
            dbSet.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
