using Shop.Entity.Entities;
using Shop.Repository.IRepository;

namespace Shop.Repository.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopDbContext context) : base(context)
        {
        }
    }
}
