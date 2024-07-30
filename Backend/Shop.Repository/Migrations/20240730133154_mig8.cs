using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image", "Title" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3953), "https://cdn.cimri.io/pictures/article/original/48/48330.jpg", "Iphone 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "Title" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3956), "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/114754-1-2_large.jpg", "Macbook air m1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image", "Title" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3957), "https://m.media-amazon.com/images/I/B1SgARaaNFL._AC_UF1000,1000_QL80_.jpg", "The Host" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image", "Title" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3959), "https://m.media-amazon.com/images/I/51E2055ZGUL._AC_UF1000,1000_QL80_.jpg", "Clean Code" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3960), "https://st-tommy.mncdn.com/mnpadding/1000/1335/FFFFFF/Content/media/ProductImg/original/638225199873500935.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3961), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIGQ4kPv_5xXW1c0A6Kek-gKYgz0v4QLI2LQ&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3963), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_qRpeFbOBczwAvah7I1P6MTkVzU-voGfz4w&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3964), "https://m.media-amazon.com/images/I/81JUxqQr4bL.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3966), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSviqIY1yGnyOdSv2y6uUSFpag06SPk9KWcKg&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 31, 53, 561, DateTimeKind.Local).AddTicks(3967), "https://www.lego.com/cdn/cs/set/assets/blt3a83606875d8dca3/40719_Box1_v39.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7976), "Smartphone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7979), "Laptop" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7980), "Fiction Book" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7981), "Science Book" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7989));
        }
    }
}
