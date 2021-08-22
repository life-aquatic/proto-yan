using Microsoft.EntityFrameworkCore.Migrations;

namespace recipe.Migrations
{
    public partial class Koshering2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsKosher",
                table: "Recipes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKosher",
                table: "Recipes");
        }
    }
}
