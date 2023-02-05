using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksWebApp.Migrations
{
    public partial class foreign_keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlcoholIngredientDrink_AlcoholIngredient_AlcoholIngredientId",
                table: "AlcoholIngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_AlcoholIngredientDrink_Drink_DrinkId",
                table: "AlcoholIngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDrink_Drink_DrinkId",
                table: "IngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDrink_Ingredient_IngredientId",
                table: "IngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_Drink_DrinkId",
                table: "Opinion");

            migrationBuilder.RenameIndex(
                name: "IX_Opinion_DrinkId",
                table: "Opinion",
                newName: "IXFK_Opinion_Drink");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientDrink_IngredientId",
                table: "IngredientDrink",
                newName: "IXFK_IngredientDrink_Ingredient");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientDrink_DrinkId",
                table: "IngredientDrink",
                newName: "IXFK_IngredientDrink_Drink");

            migrationBuilder.RenameIndex(
                name: "IX_AlcoholIngredientDrink_DrinkId",
                table: "AlcoholIngredientDrink",
                newName: "IXFK_AlcoholIngredientDrink_Drink");

            migrationBuilder.RenameIndex(
                name: "IX_AlcoholIngredientDrink_AlcoholIngredientId",
                table: "AlcoholIngredientDrink",
                newName: "IXFK_AlcoholIngredientDrink_Ingredient");

            migrationBuilder.CreateIndex(
                name: "UQ_IngredientDrink_IngredientDrinkId",
                table: "IngredientDrink",
                columns: new[] { "DrinkId", "IngredientId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_AlcoholIngredientDrink_IngredientDrinkId",
                table: "AlcoholIngredientDrink",
                columns: new[] { "DrinkId", "AlcoholIngredientId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AlcoholIngredientDrink_AlcoholIngredient",
                table: "AlcoholIngredientDrink",
                column: "AlcoholIngredientId",
                principalTable: "AlcoholIngredient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlcoholIngredientDrink_Drink",
                table: "AlcoholIngredientDrink",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDrink_Drink",
                table: "IngredientDrink",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDrink_Ingredient",
                table: "IngredientDrink",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_Drink",
                table: "Opinion",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlcoholIngredientDrink_AlcoholIngredient",
                table: "AlcoholIngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_AlcoholIngredientDrink_Drink",
                table: "AlcoholIngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDrink_Drink",
                table: "IngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDrink_Ingredient",
                table: "IngredientDrink");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_Drink",
                table: "Opinion");

            migrationBuilder.DropIndex(
                name: "UQ_IngredientDrink_IngredientDrinkId",
                table: "IngredientDrink");

            migrationBuilder.DropIndex(
                name: "UQ_AlcoholIngredientDrink_IngredientDrinkId",
                table: "AlcoholIngredientDrink");

            migrationBuilder.RenameIndex(
                name: "IXFK_Opinion_Drink",
                table: "Opinion",
                newName: "IX_Opinion_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IXFK_IngredientDrink_Ingredient",
                table: "IngredientDrink",
                newName: "IX_IngredientDrink_IngredientId");

            migrationBuilder.RenameIndex(
                name: "IXFK_IngredientDrink_Drink",
                table: "IngredientDrink",
                newName: "IX_IngredientDrink_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IXFK_AlcoholIngredientDrink_Ingredient",
                table: "AlcoholIngredientDrink",
                newName: "IX_AlcoholIngredientDrink_AlcoholIngredientId");

            migrationBuilder.RenameIndex(
                name: "IXFK_AlcoholIngredientDrink_Drink",
                table: "AlcoholIngredientDrink",
                newName: "IX_AlcoholIngredientDrink_DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlcoholIngredientDrink_AlcoholIngredient_AlcoholIngredientId",
                table: "AlcoholIngredientDrink",
                column: "AlcoholIngredientId",
                principalTable: "AlcoholIngredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlcoholIngredientDrink_Drink_DrinkId",
                table: "AlcoholIngredientDrink",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDrink_Drink_DrinkId",
                table: "IngredientDrink",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDrink_Ingredient_IngredientId",
                table: "IngredientDrink",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_Drink_DrinkId",
                table: "Opinion",
                column: "DrinkId",
                principalTable: "Drink",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
