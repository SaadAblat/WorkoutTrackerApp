using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class migrationi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("120ba693-8166-4719-8418-d4a51270e828"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2074273c-7b6a-431f-b385-8fdceb71c520"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3486946f-7b5d-43b3-9cca-11395a732bc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("502ac232-20de-4ad5-a497-8fe5c762038f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5eb54154-3603-4b6d-842b-2e1a42e96f13"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b359918-b494-497e-88b5-d1cd3fea4b06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("935f456e-c312-477e-92cb-fba4721c1533"));

            migrationBuilder.CreateTable(
                name: "UsersAchievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeightLifted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalWorkoutSessions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAchievements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4a87fdac-3d62-4f74-9031-3105af861735"), "Pull-Ups" },
                    { new Guid("53a32f88-9134-4ed2-a071-ed0be1529c7c"), "Squat" },
                    { new Guid("70cd10d4-0aa4-428e-b91b-5260ec460faa"), "Deadlift" },
                    { new Guid("7c8c4df0-195d-42f1-ab6f-923da98bc85c"), "Overhead-Press" },
                    { new Guid("d386e49b-f0d7-44f2-82f7-3e13c3eaba19"), "Biceps-Curl" },
                    { new Guid("dca81899-5621-4dc7-8440-b0680cc65af0"), "Bench-Press" },
                    { new Guid("ed9a1345-dc03-4065-8e56-4e82f57c581a"), "Push-Ups" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersAchievements");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a87fdac-3d62-4f74-9031-3105af861735"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("53a32f88-9134-4ed2-a071-ed0be1529c7c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("70cd10d4-0aa4-428e-b91b-5260ec460faa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c8c4df0-195d-42f1-ab6f-923da98bc85c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d386e49b-f0d7-44f2-82f7-3e13c3eaba19"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dca81899-5621-4dc7-8440-b0680cc65af0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed9a1345-dc03-4065-8e56-4e82f57c581a"));

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("120ba693-8166-4719-8418-d4a51270e828"), "Bench-Press" },
                    { new Guid("2074273c-7b6a-431f-b385-8fdceb71c520"), "Squat" },
                    { new Guid("3486946f-7b5d-43b3-9cca-11395a732bc1"), "Biceps-Curl" },
                    { new Guid("502ac232-20de-4ad5-a497-8fe5c762038f"), "Push-Ups" },
                    { new Guid("5eb54154-3603-4b6d-842b-2e1a42e96f13"), "Pull-Ups" },
                    { new Guid("8b359918-b494-497e-88b5-d1cd3fea4b06"), "Deadlift" },
                    { new Guid("935f456e-c312-477e-92cb-fba4721c1533"), "Overhead-Press" }
                });
        }
    }
}
