using Microsoft.EntityFrameworkCore.Migrations;

namespace Devita.Migrations
{
    public partial class SettingTableChanged1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpeningTime",
                table: "Settings",
                newName: "OpeningTimeS");

            migrationBuilder.AlterColumn<string>(
                name: "NewsLetterTitle",
                table: "Settings",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "OpeningTimeF",
                table: "Settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningTimeF",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "OpeningTimeS",
                table: "Settings",
                newName: "OpeningTime");

            migrationBuilder.AlterColumn<int>(
                name: "NewsLetterTitle",
                table: "Settings",
                type: "int",
                maxLength: 30,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
