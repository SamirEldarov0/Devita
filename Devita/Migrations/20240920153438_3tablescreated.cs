using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class _3tablescreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "ClName",
                table: "Colors",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtName",
                table: "Categories",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BName",
                table: "Brands",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClName",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "CtName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BName",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
