using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class newone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0439e40e-c770-49bd-8a89-c8fed1358a94"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a7cafd5-7dcd-4c76-b837-e2407032a8fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4d7f2576-edec-4876-b470-f5cbeb34d1a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e91059c-4a69-4137-8aba-e1c72394ba84"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("da63010c-1384-45c7-8e82-0c245cd2e824"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e479446b-b17a-4114-bca5-4439058e5c4b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f739ac07-148f-466b-b753-d15801a01b73"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0439e40e-c770-49bd-8a89-c8fed1358a94"), "Squat" },
                    { new Guid("2a7cafd5-7dcd-4c76-b837-e2407032a8fc"), "Overhead-Press" },
                    { new Guid("4d7f2576-edec-4876-b470-f5cbeb34d1a7"), "Deadlift" },
                    { new Guid("9e91059c-4a69-4137-8aba-e1c72394ba84"), "Biceps-Curl" },
                    { new Guid("da63010c-1384-45c7-8e82-0c245cd2e824"), "Push-Ups" },
                    { new Guid("e479446b-b17a-4114-bca5-4439058e5c4b"), "Pull-Ups" },
                    { new Guid("f739ac07-148f-466b-b753-d15801a01b73"), "Bench-Press" }
                });
        }
    }
}
