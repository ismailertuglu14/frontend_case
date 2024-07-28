using Shop.Entity.Entities;
using Shop.Repository.IRepository;

namespace Shop.Repository.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ShopDbContext context) : base(context)
        {
        }
    }
}
