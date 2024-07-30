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
                new Product { Id = 1, Title = "Iphone 15", Description = "Latest smartphone", Price = 699, CategoryId = 1, Quantity = 10, Image = "https://cdn.cimri.io/pictures/article/original/48/48330.jpg" },
                new Product { Id = 2, Title = "Macbook air m1", Description = "High performance laptop", Price = 999, CategoryId = 1, Quantity = 10, Image = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/114754-1-2_large.jpg" },
                new Product { Id = 3, Title = "The Host", Description = "Interesting fiction book", Price = 19, CategoryId = 2, Quantity = 10, Image = "https://m.media-amazon.com/images/I/B1SgARaaNFL._AC_UF1000,1000_QL80_.jpg" },
                new Product { Id = 4, Title = "Clean Code", Description = "Informative science book", Price = 29, CategoryId = 2, Quantity = 10, Image = "https://m.media-amazon.com/images/I/51E2055ZGUL._AC_UF1000,1000_QL80_.jpg" },
                new Product { Id = 5, Title = "T-Shirt", Description = "Comfortable cotton t-shirt", Price = 15, CategoryId = 3, Quantity = 10, Image = "https://st-tommy.mncdn.com/mnpadding/1000/1335/FFFFFF/Content/media/ProductImg/original/638225199873500935.webp" },
                new Product { Id = 6, Title = "Jeans", Description = "Stylish jeans", Price = 40, CategoryId = 3, Quantity = 10, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIGQ4kPv_5xXW1c0A6Kek-gKYgz0v4QLI2LQ&s" },
                new Product { Id = 7, Title = "Blender", Description = "Powerful blender", Price = 55, CategoryId = 4, Quantity = 30, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_qRpeFbOBczwAvah7I1P6MTkVzU-voGfz4w&s" },
                new Product { Id = 8, Title = "Cookware Set", Description = "Non-stick cookware set", Price = 75, CategoryId = 4, Quantity = 10, Image = "https://m.media-amazon.com/images/I/81JUxqQr4bL.jpg" },
                new Product { Id = 9, Title = "Action Figure", Description = "Cool action figure", Price = 25, CategoryId = 5, Quantity = 10, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSviqIY1yGnyOdSv2y6uUSFpag06SPk9KWcKg&s" },
                new Product { Id = 10, Title = "Board Game", Description = "Fun board game", Price = 30, CategoryId = 5, Quantity = 20, Image = "https://www.lego.com/cdn/cs/set/assets/blt3a83606875d8dca3/40719_Box1_v39.png" }
            );
        }
    }
}
