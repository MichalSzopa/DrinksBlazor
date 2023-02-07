using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksWebApp.Migrations
{
    public partial class userOpinionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Opinion",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IXFK_Opinion_User",
                table: "Opinion",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_User",
                table: "Opinion",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_User",
                table: "Opinion");

            migrationBuilder.DropIndex(
                name: "IXFK_Opinion_User",
                table: "Opinion");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Opinion");
        }
    }
}
