using Microsoft.EntityFrameworkCore;
using Shop.Entity.Entities;
using System;

namespace Shop.Repository
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
            
        }
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=FullStackCase;User Id=SA;Password=ismailei123A+;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Path = "electronics" },
                new Category { Id = 2, Name = "Books", Path = "books" },
                new Category { Id = 3, Name = "Clothing", Path = "clothing" },
                new Category { Id = 4, Name = "Home & Kitchen", Path = "home-kitchen" },
                new Category { Id = 5, Name = "Toys", Path = "toys" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "Smartphone", Description = "Latest smartphone", Price = 699, CategoryId = 1 },
                new Product { Id = 2, Title = "Laptop", Description = "High performance laptop", Price = 999, CategoryId = 1 },
                new Product { Id = 3, Title = "Fiction Book", Description = "Interesting fiction book", Price = 19, CategoryId = 2 },
                new Product { Id = 4, Title = "Science Book", Description = "Informative science book", Price = 29, CategoryId = 2 },
                new Product { Id = 5, Title = "T-Shirt", Description = "Comfortable cotton t-shirt", Price = 15, CategoryId = 3 },
                new Product { Id = 6, Title = "Jeans", Description = "Stylish jeans", Price = 40, CategoryId = 3 },
                new Product { Id = 7, Title = "Blender", Description = "Powerful blender", Price = 55, CategoryId = 4 },
                new Product { Id = 8, Title = "Cookware Set", Description = "Non-stick cookware set", Price = 75, CategoryId = 4 },
                new Product { Id = 9, Title = "Action Figure", Description = "Cool action figure", Price = 25, CategoryId = 5 },
                new Product { Id = 10, Title = "Board Game", Description = "Fun board game", Price = 30, CategoryId = 5 }
            );
        }
    }
}
