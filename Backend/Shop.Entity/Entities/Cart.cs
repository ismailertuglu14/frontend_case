

namespace Shop.Entity.Entities
{
    public class Cart : BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
