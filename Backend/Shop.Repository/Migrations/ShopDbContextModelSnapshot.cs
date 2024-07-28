﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Repository;

#nullable disable

namespace Shop.Repository.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Entity.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Shop.Entity.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Shop.Entity.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3733),
                            IsDeleted = false,
                            Name = "Electronics",
                            Path = "electronics"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3742),
                            IsDeleted = false,
                            Name = "Books",
                            Path = "books"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3743),
                            IsDeleted = false,
                            Name = "Clothing",
                            Path = "clothing"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3744),
                            IsDeleted = false,
                            Name = "Home & Kitchen",
                            Path = "home-kitchen"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3745),
                            IsDeleted = false,
                            Name = "Toys",
                            Path = "toys"
                        });
                });

            modelBuilder.Entity("Shop.Entity.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3878),
                            Description = "Latest smartphone",
                            IsDeleted = false,
                            Price = 699m,
                            Title = "Smartphone"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3881),
                            Description = "High performance laptop",
                            IsDeleted = false,
                            Price = 999m,
                            Title = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3882),
                            Description = "Interesting fiction book",
                            IsDeleted = false,
                            Price = 19m,
                            Title = "Fiction Book"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3883),
                            Description = "Informative science book",
                            IsDeleted = false,
                            Price = 29m,
                            Title = "Science Book"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3884),
                            Description = "Comfortable cotton t-shirt",
                            IsDeleted = false,
                            Price = 15m,
                            Title = "T-Shirt"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3886),
                            Description = "Stylish jeans",
                            IsDeleted = false,
                            Price = 40m,
                            Title = "Jeans"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3887),
                            Description = "Powerful blender",
                            IsDeleted = false,
                            Price = 55m,
                            Title = "Blender"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3888),
                            Description = "Non-stick cookware set",
                            IsDeleted = false,
                            Price = 75m,
                            Title = "Cookware Set"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3889),
                            Description = "Cool action figure",
                            IsDeleted = false,
                            Price = 25m,
                            Title = "Action Figure"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3890),
                            Description = "Fun board game",
                            IsDeleted = false,
                            Price = 30m,
                            Title = "Board Game"
                        });
                });

            modelBuilder.Entity("Shop.Entity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shop.Entity.Entities.Cart", b =>
                {
                    b.HasOne("Shop.Entity.Entities.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shop.Entity.Entities.CartItem", b =>
                {
                    b.HasOne("Shop.Entity.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Entity.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Entity.Entities.Product", b =>
                {
                    b.HasOne("Shop.Entity.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop.Entity.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Shop.Entity.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shop.Entity.Entities.User", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
