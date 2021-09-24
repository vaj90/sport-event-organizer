using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.DbRepository
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private DbContext _context;
        private readonly DbSet<T> _dbset;
        public Repository(DbContext context)
        {
            _context = context; 
            _dbset = _context.Set<T>();
        }

        public IQueryable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>,
            IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            _context.ChangeTracker.DetectChanges();
            IQueryable<T> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = includeProperties
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query) : query;
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbset.Count() : _dbset.Count(filter);
        }

        public long LongCount(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbset.LongCount() : _dbset.LongCount(filter);
        }

        public T GetById(object id)
        {
            return _dbset.Find(id);
        }
        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbset.FindAsync(id);
        }
        public void Insert(T entity)
        {
            _dbset.Add(entity);
        }

        public void Delete(object id)
        {
            var entityToDelete = _dbset.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbset.Attach(entityToDelete);
            }
            _dbset.Remove(entityToDelete);
        }

        public void Update(T entityToUpdate)
        {
            _dbset.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void Update(T entityToUpdate, object[] keyValues)
        {
            if (entityToUpdate == null)
            {
                throw new ArgumentException("Entity is null");
            }

            var entry = _context.Entry(entityToUpdate);

            if (entry.State == EntityState.Detached)
            {
                var set = _context.Set<T>();

                T attachedEntity = set.Find(keyValues);
                if (attachedEntity != null)
                {
                    var attachedEntry = _context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entityToUpdate);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }  
}