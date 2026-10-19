using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeMap.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "decision",
                table: "habits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "exercise",
                table: "habits",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "exerciseTime",
                table: "habits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "food",
                table: "habits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mood",
                table: "habits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "sleep",
                table: "habits",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "decision",
                table: "habits");

            migrationBuilder.DropColumn(
                name: "exercise",
                table: "habits");

            migrationBuilder.DropColumn(
                name: "exerciseTime",
                table: "habits");

            migrationBuilder.DropColumn(
                name: "food",
                table: "habits");

            migrationBuilder.DropColumn(
                name: "mood",
                table: "habits");

            migrationBuilder.DropColumn(
                name: "sleep",
                table: "habits");
        }
    }
}
