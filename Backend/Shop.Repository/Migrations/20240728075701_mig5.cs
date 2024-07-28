using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Path", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5286), false, "Electronics", "electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5301), false, "Books", "books", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5302), false, "Clothing", "clothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5303), false, "Home & Kitchen", "home-kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5303), false, "Toys", "toys", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "IsDeleted", "Price", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5450), "Latest smartphone", false, 699m, "Smartphone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5453), "High performance laptop", false, 999m, "Laptop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5454), "Interesting fiction book", false, 19m, "Fiction Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5455), "Informative science book", false, 29m, "Science Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5457), "Comfortable cotton t-shirt", false, 15m, "T-Shirt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5458), "Stylish jeans", false, 40m, "Jeans", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5459), "Powerful blender", false, 55m, "Blender", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5460), "Non-stick cookware set", false, 75m, "Cookware Set", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5461), "Cool action figure", false, 25m, "Action Figure", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2024, 7, 28, 10, 57, 1, 85, DateTimeKind.Local).AddTicks(5463), "Fun board game", false, 30m, "Board Game", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
