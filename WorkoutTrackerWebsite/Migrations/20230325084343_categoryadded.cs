using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class categoryadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExerciseCategoryModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategoryModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("42c6699f-c78b-4811-b615-c54373713b35"), "Legs" },
                    { new Guid("c64e519b-66e5-4937-ac46-7fe2ad88e569"), "Pull" },
                    { new Guid("cc7beae2-4455-4880-bd0a-26b9c89534e6"), "Push" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("29f2ed60-dd95-414d-ae97-00b558505969"), "Pull", "Deadlift" },
                    { new Guid("475c375a-2438-4229-8f20-c07e6d69aa4f"), "Push", "Bench-Press" },
                    { new Guid("626ce50e-aefb-4e7d-aad7-396faad49697"), "Push", "Overhead-Press" },
                    { new Guid("74a30290-545e-4f62-819b-e91e04c00251"), "Pull", "Pull-Ups" },
                    { new Guid("77236bef-d3b3-44d1-8e42-7ebcd6a3d69e"), "Legs", "Biceps-Curl" },
                    { new Guid("8f0fbf43-91a3-48c1-875d-23d5bb268171"), "Legs", "Squat" },
                    { new Guid("c86e5550-7701-45ba-ba8c-237ff563b3ae"), "Push", "Push-Ups" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseCategoryModels");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("29f2ed60-dd95-414d-ae97-00b558505969"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("475c375a-2438-4229-8f20-c07e6d69aa4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("626ce50e-aefb-4e7d-aad7-396faad49697"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74a30290-545e-4f62-819b-e91e04c00251"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77236bef-d3b3-44d1-8e42-7ebcd6a3d69e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f0fbf43-91a3-48c1-875d-23d5bb268171"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c86e5550-7701-45ba-ba8c-237ff563b3ae"));

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Exercises");

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
    }
}
