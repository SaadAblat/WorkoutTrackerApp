using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class migrimigri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "LogMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogMessages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0570505f-581e-4d31-9eca-365b81e0b676"), "Squat" },
                    { new Guid("21e82843-faec-4e63-bd26-7d29f173406b"), "Biceps-Curl" },
                    { new Guid("2c24c020-a9ed-478d-a9a7-6c81f78966e8"), "Deadlift" },
                    { new Guid("3536e178-e60a-4f85-92d1-123f2e17020a"), "Overhead-Press" },
                    { new Guid("42657e8e-08b9-4b5c-a48d-0707a98e7e14"), "Push-Ups" },
                    { new Guid("7d6ad293-80f5-4694-9eba-48272b0f6237"), "Pull-Ups" },
                    { new Guid("9d8ee56c-67ff-44a9-83f0-cca5fa9cd228"), "Bench-Press" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogMessages");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0570505f-581e-4d31-9eca-365b81e0b676"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21e82843-faec-4e63-bd26-7d29f173406b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2c24c020-a9ed-478d-a9a7-6c81f78966e8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3536e178-e60a-4f85-92d1-123f2e17020a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42657e8e-08b9-4b5c-a48d-0707a98e7e14"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7d6ad293-80f5-4694-9eba-48272b0f6237"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d8ee56c-67ff-44a9-83f0-cca5fa9cd228"));

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
    }
}
