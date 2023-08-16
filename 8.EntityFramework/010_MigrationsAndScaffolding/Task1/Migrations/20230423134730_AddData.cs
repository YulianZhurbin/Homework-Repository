using Microsoft.EntityFrameworkCore.Migrations;

namespace Task1.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "John" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bob" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BuyerId", "Name", "Price" },
                values: new object[] { 5, null, "Ship1", 50000m });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BuyerId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Car1", 5000m },
                    { 3, 1, "Helicopter1", 70000m },
                    { 2, 2, "Car2", 6000m },
                    { 4, 2, "Helicopter2", 80000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
