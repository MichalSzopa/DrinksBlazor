using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksWebApp.Migrations
{
    public partial class userDrinkField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Drink",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IXFK_Drink_User",
                table: "Drink",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drink_User",
                table: "Drink",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drink_User",
                table: "Drink");

            migrationBuilder.DropIndex(
                name: "IXFK_Drink_User",
                table: "Drink");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Drink");
        }
    }
}
