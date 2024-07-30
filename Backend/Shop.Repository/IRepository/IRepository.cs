
using Microsoft.EntityFrameworkCore;
using Shop.Entity.Entities;
using System.Linq.Expressions;

namespace Shop.Repository.IRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        
        #region Read Operations
        Task<T?> GetByIdAsync(int id, Func<IQueryable<T>, IQueryable<T>> include = null);
        Task<T?> GetWhereAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IQueryable<T>> include = null, bool tracking = true);
        Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IQueryable<T>> include = null, bool tracking = true);
        #endregion

        #region Write Operations
        Task<T> InsertAsync(T entity);
       
        Task SaveChangesAsync();

        #endregion
    }
}
