
namespace Shop.Core.DTOs.Category
{
    public record struct GetCategoryDto
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
