using Microsoft.EntityFrameworkCore;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using System.Linq.Expressions;

namespace Shop.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ShopDbContext _context;

        public Repository(ShopDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> TableNoTracking => _context.Set<T>().AsNoTracking();

     
        public async Task<T?> GetByIdAsync(int id, Func<IQueryable<T>, IQueryable<T>> include = null)
        {
            IQueryable<T> query = Table;

            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IQueryable<T>> include = null, bool tracking = true)
        {
            try
            {
                IQueryable<T> query = tracking ? Table : TableNoTracking;

                if (include != null)
                {
                    query = include(query);
                }

                return await Task.FromResult(query.Where(expression));
            }
            catch
            {
                throw;
            }
        }

        public async Task<T?> GetWhereAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IQueryable<T>> include = null, bool tracking = true)
        {

            IQueryable<T> query = Table;

            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> InsertAsync(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                return entity;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
