using Shop.Entity.Entities;
using Shop.Repository.IRepository;

namespace Shop.Repository.Repository
{
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShopDbContext context) : base(context)
        {
        }
    }
}
