using Shop.Entity.Entities;
using Shop.Repository.IRepository;

namespace Shop.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ShopDbContext context) : base(context)
        {
        }
    }
}
