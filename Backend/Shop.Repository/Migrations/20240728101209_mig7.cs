using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7976), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7979), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7980), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7981), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7983), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7984), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7985), 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7986), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7988), 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 7, 28, 13, 12, 9, 34, DateTimeKind.Local).AddTicks(7989), 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 28, 12, 16, 41, 757, DateTimeKind.Local).AddTicks(3890));
        }
    }
}
