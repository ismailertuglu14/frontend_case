
namespace Shop.Entity.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
