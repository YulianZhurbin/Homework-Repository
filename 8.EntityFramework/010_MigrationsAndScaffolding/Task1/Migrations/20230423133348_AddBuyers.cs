using Microsoft.EntityFrameworkCore.Migrations;

namespace Task1.Migrations
{
    public partial class AddBuyers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BuyerId",
                table: "Vehicles",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Buyers_BuyerId",
                table: "Vehicles",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Buyers_BuyerId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BuyerId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Vehicles");
        }
    }
}
