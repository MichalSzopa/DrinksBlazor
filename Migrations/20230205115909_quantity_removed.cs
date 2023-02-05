using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksWebApp.Migrations
{
    public partial class quantity_removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "AlcoholIngredientDrink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "AlcoholIngredientDrink",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
