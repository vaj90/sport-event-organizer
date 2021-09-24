using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.DbRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        int Count(Expression<Func<TEntity, bool>> filter = null);

        long LongCount(Expression<Func<TEntity, bool>> filter = null);

        TEntity GetById(object id);

        Task<TEntity> GetByIdAsync(object id);

        void Insert(TEntity entity);

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);

        void Update(TEntity entityToUpdate, object[] keyValues);

        void Save();

        void Dispose();
    }  
}