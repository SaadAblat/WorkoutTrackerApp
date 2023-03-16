using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SetNumber",
                table: "Set",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoundNumber",
                table: "Rounds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SetNumber",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "RoundNumber",
                table: "Rounds");
        }
    }
}
