
namespace Shop.Entity.Entities
{
    public class CartItem : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }

    }
}
