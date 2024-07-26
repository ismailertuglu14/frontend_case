﻿
namespace Shop.Entity.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public ICollection<Cart> Carts { get; set; }

    }
}
