
namespace Shop.Core.DTOs.User
{
    public record struct TokenDto
    {
        public Shop.Entity.Entities.User User { get; set; }
        public string AccessToken { get; set; }
    }
}
