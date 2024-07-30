
namespace Shop.Core.DTOs.Cart
{
    public record struct RemoveFromCartDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
