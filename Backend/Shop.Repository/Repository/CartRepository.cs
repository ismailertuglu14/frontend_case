using Shop.Entity.Entities;
using Shop.Repository.IRepository;

namespace Shop.Repository.Repository
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(ShopDbContext context) : base(context)
        {
        }
    }
}
