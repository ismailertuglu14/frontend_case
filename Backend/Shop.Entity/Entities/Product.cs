
namespace Shop.Entity.Entities
{
    public class Product : BaseEntity
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }
}
