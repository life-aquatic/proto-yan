using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace recipe.Migrations
{
    public partial class AddedCook2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cooks",
                columns: table => new
                {
                    CookId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooks", x => x.CookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cooks");
        }
    }
}
