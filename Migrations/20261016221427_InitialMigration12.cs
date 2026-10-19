using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeMap.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "timeSlots",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "timeSlots",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "timeSlots");

            migrationBuilder.DropColumn(
                name: "name",
                table: "timeSlots");
        }
    }
}
