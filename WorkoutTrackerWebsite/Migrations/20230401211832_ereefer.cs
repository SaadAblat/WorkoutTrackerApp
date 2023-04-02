using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class ereefer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutTemplateExercises_WorkoutTemplates_WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises");

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("256e02a1-9952-4256-89c4-b9c3aab3c9b9"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("4f2b684d-8d97-482d-81e2-1104f0b66667"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("4fc49537-5b93-4085-8760-062c919a2fbc"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("51470251-8810-434d-91bd-c29378124c28"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("647eace0-10b2-451a-86e7-77e7c59e13f4"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("91ac4dc5-47ba-442a-abc5-2a62d41234a4"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("c0cd50c3-45e8-47b5-a444-3445a5b9fe7d"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("c164168d-5d47-49af-9002-8846b15ddf77"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("ea7395ad-3608-4b4b-80ac-59123c6ef683"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("f7807e04-5572-4a2e-823e-fa4db289d35f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("021581e0-9e4b-47c5-b2a0-084e474c5dfb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("030161ea-5453-4600-99af-3ce0d79c767d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("030e0e2d-9566-453d-9d6b-47424441e7d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03af4669-0e9c-41f8-b96b-38e83905ea04"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04e2d027-ed33-4d8f-bea8-30df60240e5f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("06699595-240f-4fe2-a2fc-44536fc56ffb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("06b0fd5a-06f7-4e0f-88fd-4c2cc9998f3b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("095a8572-b65f-4592-bd2a-5ffb70a228d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bfc6297-adea-4547-8f86-530f46f93de6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0c0120da-95a2-49b4-ae34-7f2bc69c1d1d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0cf1ba6a-16ec-4ba9-bb34-fc5545788c9d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e5994a7-a4ca-436a-9143-626f29b15a46"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0ec49bc3-071e-49d5-b5d7-e320256d78d6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f4816b9-d837-4b33-be6b-8f9c16a37575"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0fe5fdaa-1a7e-4249-b0dc-7ec419e5b6c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("114de932-dc78-4f76-aca5-1e341f4054b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("11501a53-e81b-4902-89b9-360ea07181fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("116b5383-7c97-46d7-b5d9-56a7fc173ab5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("14169bfa-750f-4ff1-85d7-140fe84c8752"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("158d6689-d72e-47a2-82ae-24c5ab85ea83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1789769d-0675-4841-bba3-0dde6e2a264e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("17de7696-fda1-48f1-9ad4-c5a27055db67"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("192687e7-6282-4842-9dba-09caf394351e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1c0a258d-1473-4bdb-9583-cf50787ea39d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1c268c66-fec5-4b60-8ae2-39f1cf6019d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d00cceb-7ebd-4cbd-803e-a4a6834fa05b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d3f3374-c5e6-4d63-a0d0-8c050e9c2f39"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d99f93e-f7cc-4e43-8c93-19064c7cc808"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1e4caa16-2dcb-4f86-879e-13089fb03918"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f221ead-2348-4a6f-be9c-4cbbd8f07d55"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1fe75e49-ebf3-407f-9382-88bc0a069e3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("22c6f2a8-bfd6-41f3-a4bd-b1413fb1c592"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2418c53a-ce45-40fa-b3e3-1260c8be021d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26a0ca84-b434-4fec-8bcd-8d2cf8e3b137"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26a2858e-5950-4561-8bac-4da76fd11fbc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2773e332-88ab-427d-9fde-3776604d8a33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("28e74b3d-9fc0-4e58-98dc-c2e7b606353f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("29ad443d-c176-48e3-91e9-22380141e735"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a903302-1006-4202-9132-298715fae015"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b540669-3346-47c6-9a94-3332516e0d53"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b60df42-c1d7-42ef-a22a-2df23961689f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2d50ba36-5895-4fec-9666-6ae0c13b2072"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2f48037b-2c61-4a9b-be7b-b7bcb16d6722"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2fcff341-77f7-4512-914e-a4257a1aa32d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("328c70df-84c9-4f55-8ef3-e214fdbef80e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("33e51098-3db3-43f3-a46e-52b6ee3c9c40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36e62089-23b7-44f5-9993-95c918d2b029"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3722329c-8bca-41a8-bedd-f8852ca7b26a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("374545cc-a8a7-44d7-b1b3-3259bcb3eff2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38dac62c-1ab9-4185-82b1-d0b5f66bfc4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("395d14f2-f4e5-44ed-b0d4-a527d9684080"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("39c298ef-3290-4238-bba5-98af58d3fe91"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a44e2d6-2f78-4b66-9226-58d5d1cf5467"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3ab4ff9c-e4a5-4071-950a-c6a7fc01b699"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3c4d64e8-f858-4dd1-ae55-75d5df7d9c8e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d778049-81e5-4001-9d56-0c22f44f82d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f7b7445-9dc3-457b-bbca-4ccff472566f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f87c75b-992d-41cf-8701-f79d9127141a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40216c3c-8098-4aa3-8739-8de755fa10b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40292532-8401-40c3-8fa7-9ad9dc1d8b36"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42f9a4a2-6ab1-4a5d-b58b-676d2cbd0c85"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4380c7f3-d9f0-4ade-972b-a6eef747b679"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4726e823-0a0c-4baf-816a-bb73ee2d93d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("47894578-6264-4137-936b-7ecc8ef359fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("48ff5de8-cb51-484b-b291-fe0a5e60479f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("499d43f4-b966-496e-8b55-b66d548e7a17"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("49e20cce-72b5-4d49-857c-027fae5df2db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ad11402-5288-4e03-b15e-5bafcfc0bbaf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4c7c07ed-bd87-4b68-95e6-abc0f041a35c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4cae0e97-7921-4bb9-a4bc-36c3b002cae3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4d6d3722-6453-4e62-a4f7-94b0c1b1db3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4db0f4f5-b3a8-4a5f-b80d-3081e3f06715"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e068ec9-040d-4b5c-b347-5e230c304b1b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e76b04f-903c-4c68-bf5e-01207021afb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("51dd64eb-e9cb-48b4-8b3b-9da89c1a3cfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("52fbc033-e529-4878-b130-a30446c3e264"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("53e00257-f593-491b-868c-44c47fdf948f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("549d03f2-5dc3-4adc-b298-f9b153d97d0d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("56060e5c-9242-42a3-a03a-639647b4f2e3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("565d2f6e-d448-4401-aeb0-1a0aeb2f8a83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5a080304-294d-4e6e-ad49-95af0432e569"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ae0a95c-fb9b-43cf-a3b3-f7c5a0d18665"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b68f0fb-05b4-4012-916a-e44a21cf31df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bcf407b-9513-4c4d-8a41-63877b34b204"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d1e0948-c818-49e9-a2f9-cba4b9ff0039"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("622f3d6f-307e-4971-8b5d-6441265bc841"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("63d62cbf-8f4e-42de-b5db-344693c10a85"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6477152f-d712-4387-b641-afa63c66d4a5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6511705c-f81d-47f8-a354-4ba893b05a4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65bdae54-d80c-4952-bc47-d93b93dde2c7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65f62950-5f69-453c-aa47-58aa1a73e910"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("66891667-eeb6-4213-803e-24dbe3aa39b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("677ecc71-a704-464c-b1da-ec5b8bea52a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6973f1b9-79bb-49b6-9534-428aed7a750f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69e63ca3-cb4d-4519-828b-d43abcca8fb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a881204-b6d8-472c-9eef-dfe730672ad4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6c624761-a2be-4760-ad68-1c95e0a571c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e0566b8-630f-4df4-b4e6-4f42d2b2304f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ee086df-0d7f-4a23-adc6-8c20e96a5156"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f5d02aa-0aaa-4d37-9f59-88033d51be90"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ffb541b-d2d5-42dc-b800-be4e7b1a17db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7157eab9-056e-4601-9de8-d27127d34ec5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71ec8796-53da-44d3-b67f-9aa9f18fc43a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72257186-bf7e-4ac3-9db2-ca913a9ef29a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7513ed34-434f-48f7-9046-bca5560a07bd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7706091f-f614-435c-a0f1-6343d88d35ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77b26bd5-c3b3-48d0-828d-8f232cad732c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77d457ee-7ab9-448a-950d-8e86eb69de55"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a0a705e-2de8-4882-a247-ca5e1232e728"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7cda1969-c465-4ff8-a491-42ce9a2e6110"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e40ce8a-55a0-47f5-a456-9f83cd980335"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e9d741d-bd32-43a3-963e-b86a70059381"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ea31076-b6b6-45df-afaf-f7bc694a8815"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7eef08af-1280-4aa3-aff8-eb9456fae6b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7f55a034-8fe1-4578-b940-d7d835145fcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8015a5d9-69c4-4faa-879a-7f77ec5f3e1d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85eb16e6-87a4-4732-82fb-cc3fffd27345"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("879f83c5-8dba-48af-83dc-1c9e6bc01d1b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("880777ba-17cf-438c-ad71-ed21e2c85c99"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89784ca9-a737-4cf1-8e46-b134f0044171"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89e49a4a-06ab-4deb-b736-151d24319e6d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c951da8-1a0a-4d6c-85ae-5735a1b1c1ec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90d1bb5c-81ae-4ef7-abdd-438339a77792"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9221f55d-fddf-4c62-bfcd-a6380022fafe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("943f4400-9d5c-45f8-9b3b-228e26b9f0dd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("956cfbe5-da66-4f8b-a058-0dfad351d2b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("969907b4-ba1c-4917-b737-8470aecd1411"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("98ef8f65-de15-417e-ae3d-4bd18c458fb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("993557ac-e30f-4a50-9d45-ea5162df86bd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9970b4f6-e2bb-457b-a2c1-a30c18b2997c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99f2777e-4a17-4e7c-9144-6f66a723c9f3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b5e6b78-b494-4c05-a539-0621d9d9972b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9c58e78e-95f4-4da8-932c-0edfe6819311"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d5bcd0a-625e-4614-8885-5bc495e747c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d891c66-973f-444b-8475-0051232ebf87"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0a0e1f3-63db-4fd7-b7be-c79767f08ed3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1052b94-b6ff-4aca-af92-5f20bac7077c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1bc18f8-d4e4-4931-8702-50ec8a92a04a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a23b9394-2f68-4007-b5de-68fc20ffedb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a3e8af59-fb35-4b09-93b9-94ff5f01c076"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a524276a-6a00-4d22-a5aa-b7ddd566d8fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a525dbd1-9160-4f84-8eb3-7f74ddda053f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a58484b4-74ed-48e8-972e-760f5c807c02"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a61f0816-ca0e-4522-98cc-c2e593b00f81"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a7cb7a18-5495-4628-9f50-911237ed0d1b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a97c3364-f676-4a89-b8f0-df6a54184b96"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9eafef6-53dc-4a53-a02e-a5ad0bde195a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ab7aa4b3-06f9-4e87-bbf1-63623ed9a123"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad822fde-d51c-4b8b-b236-8dd65e12d3b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af151577-3914-4a54-81dd-663413f09bec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af5211f9-a8d8-4443-bc51-b3ccbfe2e795"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af773fea-f29e-4da2-8ab0-3e75768c0d4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b07acc50-60fa-4a54-82ed-e7336835282c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b1b90756-e4c2-4796-841a-141e0aa69f70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b322f8e0-7b3e-4782-b965-444dbb683185"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b5e42e61-bfa4-40e3-b6cc-6b0ca0aefcc2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b83be0e5-44b1-48b9-9f2f-0cd49ae26a40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8ab78e5-717b-4849-8f50-e6100c24fb2e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9e1d535-39fb-46ab-a296-c6718c6cffde"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba8e5134-c6c7-4279-a2b7-7687fa4fd30c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bb8855ac-2412-4f7a-8a5e-4de8821f278f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bcbfc3c7-bb24-495d-99a3-c2142d84336e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd0c6ded-f69c-4548-8e4e-4487f5b76089"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd869b7c-bd29-421e-a6e4-2eb98e243df0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be7a999c-501d-4875-991f-c4acab5eb74f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("befe4fda-5a2c-4aae-95a0-6be046ae6354"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c2076a34-c0fc-44da-9bcd-4351681b50e3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c26a70e0-f9d2-4e8b-bb27-226a67daacfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c37705b4-2276-4593-a825-dcf90db858d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c3e69135-57c4-46cd-a28e-c35a1efc0200"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c3f029cb-1385-4a22-8c94-158c2747463f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c83332c4-3117-4e68-8299-1abf2374107c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c85a5ec9-7c6b-419f-8540-17d24ccc025e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8b55609-8b84-40a8-8c92-12b7a5c40605"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cb1fb5a4-0e82-4ac8-bd7d-7c6d68140a83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cbb2534f-19f0-4448-8014-f420a9f9ce82"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce70b688-2ee5-4d1f-8883-3c84ef38a952"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cea7dff7-d5bd-464c-ab51-c11ed89cd6e3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d11d60c3-0113-425a-870f-22d83fe5c6b7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d1b138c2-ba13-443a-9522-29b85571c524"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d554fb80-c10f-405a-afbc-27aee4bd7379"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d63bd2df-1f58-4429-97fe-64371ca8d8b3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d690560a-57ac-49bd-9ddb-07a4ff7ad86e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d82d1d97-49ca-4f9b-8ad4-fd8e8007a37f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd9e2a6f-00c7-470f-9d59-15c799ba4877"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de1bd6a9-97a0-4ba0-b4e0-a5306b39cb83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e009d3e0-c3ce-489f-82c4-e6aa21321122"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0bb048d-9f12-41c4-92ad-ce4393020112"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0ff3b0e-f13d-41ed-bb23-e5960f244a50"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e1c76947-25f3-40c0-b39e-c9a3954463c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e25ba5b7-dd36-4b6c-9683-effc29587771"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e5f22252-8a99-4f50-834c-daf841030b0e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7d965a0-66cf-40d4-b36e-e4746d01fd6d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8457acc-ff4c-4dcd-b303-fe652d6e8302"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea96023a-3eff-4ee5-aa0e-9616a72cf9eb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ebdd77a4-8954-4703-a519-370559ec6113"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("efa9810a-1ae2-4caf-9c4c-2d9e13d76f35"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0b16f47-ec8f-4d34-81a5-85268955c31b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1bdd049-b815-4534-992c-ea4093c7a4ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f26406a1-c555-43bc-9c89-a7041ac936dd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f274e698-9024-4819-bcad-96533e259827"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f2d24fa3-61e5-4da5-a102-9a7ab1acc222"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f38731b0-5605-485a-b72d-8600f54c96c2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f5311e82-e833-4161-86b2-4eef8424599d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f7b4799a-8358-48bc-853c-5999a1f95d95"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f99b2c5b-dc57-422d-95ad-c9babb090655"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9e9fa2e-60c4-4f5b-8f51-bdda8afc526f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9f23034-d041-43c1-bd08-01c250e0bcff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa459783-eb9f-438c-b46b-98b49ccb806f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa66b112-de86-4040-9c87-5357e1243ba9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("facb8b8a-1bed-4f9b-9df5-b5da56a998fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc6f61bf-7405-44d7-8899-67e59f4e780d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fe882211-c0b7-497f-adce-2b01d6e73198"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff08fdc6-9bf1-48e8-96bc-b293b3718ef3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff5121f4-d8c9-4d0b-828b-2a9bf0f9b775"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ffce0bb6-a756-45c1-965b-ebd875a5e480"));

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20f107a2-45b8-447b-b633-850b9d78b881"), "Glutes" },
                    { new Guid("2a4c37b4-0613-4b02-a81b-a47237a8d2f2"), "Calves" },
                    { new Guid("39036824-50ba-4c4a-843a-0164186b8be5"), "Chest" },
                    { new Guid("7b6cec60-5311-4c0a-a055-d12fcb5e60fe"), "Legs" },
                    { new Guid("a22e987a-eb04-4f49-a43e-5237f272f2dc"), "Abs" },
                    { new Guid("a2fe4b34-1c04-425e-bd44-7bf91c903c89"), "Forearms" },
                    { new Guid("a4fb0d0b-ca5f-4a1d-8496-3dfc3334ea08"), "Bicep" },
                    { new Guid("cd8b2cd2-f3b9-41a7-9604-5095cc6ff181"), "Shoulder" },
                    { new Guid("f509ac44-7919-4678-8d91-65f670248900"), "Back" },
                    { new Guid("fc212817-89a0-4c0d-8885-a111f717fad4"), "Tricep" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("0140e0d2-216e-4bb3-a5eb-ada3a809a7db"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("01d2621e-4ed1-44f7-82a1-60172b76d26c"), "Legs", "Hack Squat Machine" },
                    { new Guid("0217b5f7-5f14-41f6-a148-f4b170f9eb9a"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("043ae2a7-82bf-4590-81e7-071a32fa5d1d"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("0453760b-4f55-49fd-9491-c6dd8a30038e"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("04d6f5c2-27fe-4744-bb2b-74b86169ccf4"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("04f6eb4a-a91a-470a-bc57-9fd28c6450a8"), "Bicep", "Barbell Curl" },
                    { new Guid("058ad914-7c7c-432b-ab04-af494a071921"), "Glutes", "Glute Bridge" },
                    { new Guid("072886c6-9d6e-4ba7-a09d-3b4525641f3f"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("0bbaedc6-17fa-402f-841a-4de7e9b3fdac"), "Glutes", "Hip Thrust" },
                    { new Guid("0bfbb46a-cce8-479a-9fbe-fef677481304"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("0e34aacc-b870-4876-9804-6b737c56a9f4"), "Chest", "Push-Up Against Wall" },
                    { new Guid("0e94731e-9cab-4e21-97a2-6ef515ec70cf"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("0e9bc83c-fb54-4ff3-b17d-0ddac3e45a03"), "Shoulder", "Face Pull" },
                    { new Guid("10f98948-170d-40f8-9abd-981b7d7abb82"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("1300f97a-9718-4498-b405-2a58df6c3205"), "Legs", "Lying Leg Curl" },
                    { new Guid("162c1380-aa94-470d-9cbf-cbf8a26d46f9"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("17dc0d60-1787-4396-9a1b-2aa75619bfc0"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("1bd236e8-cb9f-4122-9ee5-512ac4568d81"), "Legs", "Box Squat" },
                    { new Guid("1ca10c07-613f-41a0-9e7c-3e4aa97c999a"), "Chest", "Machine Chest Fly" },
                    { new Guid("20746ccc-7c5f-4f63-860c-16a5cea0264e"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("20b5a1a9-adb3-4f06-8748-ceae5d363649"), "Abs", "Mountain Climbers" },
                    { new Guid("241a8b38-23da-45a5-a629-3d7d061ce059"), "Abs", "Sit-Up" },
                    { new Guid("24984147-6324-4892-bcdb-9e8ae53c2959"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("26809a3b-e29c-401b-8fb7-ab222745e85c"), "Bicep", "Bodyweight Curl" },
                    { new Guid("27f840dd-8e55-438c-bf7d-6c2ca4da8114"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("28419a72-70a4-4a92-ae30-8c8b6b225e53"), "Abs", "Kneeling Plank" },
                    { new Guid("2ac83365-ff57-42f1-80d8-b037658bf3e9"), "Abs", "Plank" },
                    { new Guid("2ad777e0-a404-4133-95ab-98ca66393f2f"), "Back", "Deadlift" },
                    { new Guid("2aeba067-d5f8-4f77-bca7-c2749c90136f"), "Chest", "Incline Push-Up" },
                    { new Guid("2b4e4178-9f33-428a-9199-2a541ce2db40"), "Legs", "Hip Adduction Machine" },
                    { new Guid("2bab4a78-ffc9-4472-acec-0b90c5196165"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("2cacd7ae-2dbf-49fb-89d2-8c04c5c13fcc"), "Abs", "Kneeling Side Plank" },
                    { new Guid("2dbbc80d-6726-4d3c-ab5a-1da9ecef8ff1"), "Legs", "Goblet Squat" },
                    { new Guid("2fea7a4d-c744-42ea-ba6b-a91ee7810620"), "Back", "Pendlay Row" },
                    { new Guid("303ed8f2-71a9-4fdf-9c52-9dfe1fd22f62"), "Forearms", "Bar Hang" },
                    { new Guid("31e89461-ced6-48df-8dbc-7ac36ac571b0"), "Legs", "Leg Press" },
                    { new Guid("3217b8b1-095d-4c44-b208-5c6cfedf0375"), "Legs", "Landmine Squat" },
                    { new Guid("321b8e30-3f0e-41f3-82b2-83adbb1cc3fd"), "Abs", "Side Plank" },
                    { new Guid("32aba767-2a48-4117-914d-d192fa34d5dd"), "Glutes", "Frog Pumps" },
                    { new Guid("32cd4df6-1d22-4a45-99ad-ffb182182cfb"), "Legs", "Leg Extension" },
                    { new Guid("34ddb40c-242d-40e6-8d56-c4996ab147e1"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("353d71a8-06f7-4f7f-80ee-a32f02e73d5d"), "Chest", "Cable Chest Press" },
                    { new Guid("3573e25d-dc4c-4aeb-962c-2be3a9973baf"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("36abeb9f-6418-4b52-ab34-c4ec5163c15d"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("381807f6-0a2b-463e-b08e-31a7f8fc082a"), "Shoulder", "Power Jerk" },
                    { new Guid("3c44e412-9bd1-42ae-ab1b-d542a7385eef"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("3dac1c23-e82a-4d53-aff1-e680099b0c85"), "Abs", "Crunch" },
                    { new Guid("3effb9c3-d0fc-4670-af51-7a0651d29b27"), "Abs", "Lying Leg Raise" },
                    { new Guid("419d0ff9-b09d-479d-910d-2af00f34147b"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("453eb767-10b7-479a-8705-cb563a300c8e"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("46aeed83-6d1d-4939-8659-d18f9880e3fd"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("49415011-250d-4da1-9c35-22cf9756f3c4"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("4a5acfc9-c63d-46dc-a050-78e545a93549"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("4be58f4e-539e-4d09-8da5-30cecb1a523c"), "Abs", "Hanging Leg Raise" },
                    { new Guid("4bf5eeb9-d215-4751-b24b-9b1252fef8d2"), "Legs", "Romanian Deadlift" },
                    { new Guid("4c330e3b-e1ed-4b85-8702-111e26722a58"), "Back", "Hang Snatch" },
                    { new Guid("4ca88971-83a5-4686-924a-e3163428590c"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("51b86da0-25bf-4438-98c8-88632fb09113"), "Forearms", "Plate Pinch" },
                    { new Guid("53e2ff83-b856-428f-9126-20bdba49309d"), "Back", "Hang Power Snatch" },
                    { new Guid("55dbbf2f-c740-4e29-831f-3ca4f0f48e80"), "Glutes", "Banded Side Kicks" },
                    { new Guid("5672cb1c-cbfb-45e3-9874-dcdbf4de2795"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("569ea0b9-93c2-46b2-a14b-856d7d299437"), "Chest", "Dumbbell Pullover" },
                    { new Guid("597552ff-f995-487f-a236-cd68703baf98"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("59e85aa8-694e-428f-8bfb-c319c671f6fa"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("5afdff00-fed7-4f12-aab0-31d9f2663d10"), "Back", "Block Snatch" },
                    { new Guid("5b98242d-1c2e-4118-9746-d2da18e1cb67"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("5e665e42-5912-4fab-a7c8-1db0a0993d2a"), "Glutes", "Clamshells" },
                    { new Guid("5e8582c0-718e-45b6-b259-ad2a0f0dbfd3"), "Abs", "Hanging Knee Raise" },
                    { new Guid("5fdb9207-701d-48f7-b4b2-383cb31bb304"), "Back", "Seated Machine Row" },
                    { new Guid("6126dca7-13b2-4db7-b6fc-d86044439232"), "Calves", "Heel Raise" },
                    { new Guid("61319a81-0ead-4255-a711-8d7fea409b36"), "Tricep", "Bench Dip" },
                    { new Guid("61af778f-5307-4d35-aa68-ff7919892655"), "Back", "Deficit Deadlift" },
                    { new Guid("62596019-c971-41ab-9ea9-3f7b034c11e8"), "Legs", "Body Weight Lunge" },
                    { new Guid("6301dd36-0e27-41a0-9b54-58c6757204f1"), "Glutes", "Cable Pull Through" },
                    { new Guid("63d5839a-2c44-4e49-bfa4-87234c0f4ebc"), "Chest", "Incline Bench Press" },
                    { new Guid("662fbf6e-e269-4b24-a749-4a54f9502948"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("6682bdbf-8a0d-42d3-b469-36d7ae087ad6"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("68826f3d-afe8-4816-b2d7-56bc5fc5f4f6"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("68fd1e00-736f-4d5b-88e7-734c6e63ffc3"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("69c1c462-2dbc-4e96-a05f-4865ad053fe1"), "Legs", "Barbell Lunge" },
                    { new Guid("6afce898-4a83-4be5-9f7e-b09a6a80ea88"), "Chest", "Bar Dip" },
                    { new Guid("6c883121-35e9-4b78-94a4-87f574faa92f"), "Chest", "Machine Chest Press" },
                    { new Guid("6ca9f2ca-ee42-45b3-a91d-4e4398a05dad"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("6f0913d1-1aee-4dfa-9e0b-4073c1082bb6"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("6f4a1d08-40c1-4bbb-8934-be7632e6adcb"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("72f330e1-52f0-4836-8c81-a4080286076e"), "Back", "Back Extension" },
                    { new Guid("748f7a69-8c05-42ee-be74-3b2f024a116b"), "Back", "Dumbbell Row" },
                    { new Guid("74b8bb4f-e02e-474f-b920-7bb7a8695e9d"), "Chest", "Floor Press" },
                    { new Guid("75fe4c5a-20b3-4310-8bb2-abb6116a0dcc"), "Back", "Power Clean" },
                    { new Guid("77191b68-928c-4156-bbdb-46baa75b0d04"), "Abs", "Hanging Sit-Up" },
                    { new Guid("77ed1865-c59f-4a10-adc3-a44a656e2634"), "Abs", "Cable Crunch" },
                    { new Guid("7849d7f2-a2fb-4ddc-a6d4-21ae02dfc424"), "Shoulder", "Plate Front Raise" },
                    { new Guid("79b9223e-6b46-4141-b6c1-f17a9f7eaa31"), "Chest", "Push-Up" },
                    { new Guid("7df7aa14-3669-41f5-a950-3a27d4cd03b1"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("7dfacf4b-2031-4eb9-99d9-10580e4b9e4c"), "Legs", "Barbell Hack Squat" },
                    { new Guid("80bb27b5-c0a7-4d0e-9211-028747706e8a"), "Chest", "Bench Press" },
                    { new Guid("81d4126a-18e6-49e6-98a3-0fc57fbadff8"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("8555a8a6-a016-4c00-83c7-ec84fc16bb06"), "Legs", "Air Squat" },
                    { new Guid("85ef6b01-f291-4bcd-a063-e60497daa11b"), "Chest", "Kneeling Push-Up" },
                    { new Guid("86678d1d-e190-4730-bf39-2dc146e71cce"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("86bc0028-db1d-43fb-a7be-6104c2c5f73c"), "Abs", "Oblique Crunch" },
                    { new Guid("876fed5b-3229-401f-b366-dc8d7fc88f68"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("8812017c-33fa-4d6c-8598-28582afec2ce"), "Back", "Good Morning" },
                    { new Guid("89bfe619-ef96-44ae-90ed-967cb906730b"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("8a688345-5eb2-464d-b9a2-4893cb897602"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("8bb042be-dce3-4f65-99cb-d6cc13fc78e7"), "Back", "Clean" },
                    { new Guid("8deb1612-5c9d-46b1-b117-6f79fc33c033"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("8f5a8cec-bba4-4f19-9d91-5ef8b0745e92"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("8fb3d3b4-7582-468b-89fe-c6bae6f1b449"), "Forearms", "Farmers Walk" },
                    { new Guid("8fbacbd5-50ab-4ac3-b4a2-65f8d983478a"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("90aa7d92-cf1d-4e2b-981e-2beff3db83ab"), "Back", "Clean and Jerk" },
                    { new Guid("91059aa4-e2cc-4b90-8875-74de89a0209c"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("912451c3-0ee2-4650-9c0f-f1c5c3a5567b"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("931aef9f-d9e0-4128-9529-d6a7cd1c49d9"), "Abs", "Oblique Sit-Up" },
                    { new Guid("9360332d-12c7-4c67-9ba8-bfb57b9ea319"), "Back", "Barbell Shrug" },
                    { new Guid("93f2976c-931d-41a1-9d3e-9b02ee987f29"), "Back", "Pause Deadlift" },
                    { new Guid("947367af-c68c-4931-8ca0-f54cc3387bd1"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("94afafe4-836b-4bcd-920c-16071c16d072"), "Back", "Power Snatch" },
                    { new Guid("94d19da1-3d67-4bf6-9908-4a63fea69896"), "Legs", "Half Air Squat" },
                    { new Guid("98165bf9-e52b-4258-81ba-7378db84a677"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("9855fee4-2122-4e85-8d7d-3489bd8e71bb"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("99963de4-e65a-456b-9f66-7c3203fef966"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("99b206c0-f161-412f-94c2-ad18b3448911"), "Legs", "Chair Squat" },
                    { new Guid("99d36afb-6cae-49c7-aaf4-1289817f10fc"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("9abad6ae-2d02-45db-8c9a-fc7db25783d5"), "Chest", "Decline Bench Press" },
                    { new Guid("9bc5c4ee-7fbc-4041-a84e-9ca89577c050"), "Shoulder", "Monkey Row" },
                    { new Guid("9d02b266-9707-49da-bf96-ddb77f5eabf4"), "Back", "Floor Back Extension" },
                    { new Guid("9e3a095e-70dd-4bd9-a3e4-fd205d7a0bcc"), "Back", "Dumbbell Shrug" },
                    { new Guid("9e53100b-3742-4386-92b3-5f1ef93757b8"), "Back", "Hang Clean" },
                    { new Guid("9ff11236-4c3d-4ce6-a7b9-ff9de3e93a41"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("a04cfab5-fda7-459c-b933-4206aa790171"), "Legs", "Step Up" },
                    { new Guid("a1b0ae8b-6435-43c9-a8e7-50f2127efe15"), "Shoulder", "Front Hold" },
                    { new Guid("a2638e88-efa1-413f-8220-3f8deb11bf38"), "Chest", "Pec Deck" },
                    { new Guid("a2bb1b46-6208-4a4e-8598-210c54f8d298"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("a3d4e805-7db8-4b1a-9e5e-21c21c3d9e3a"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("a4d0869f-8279-492c-8ca8-4cfe938f20ab"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("a516c9fa-f730-4a7c-894f-1c164a1ddf73"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("a5783e50-a976-4373-9bfd-a7b262218a3c"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("a5e56aef-41b5-409e-a2db-b204a8f91725"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("a6444cad-b940-462a-9ac6-d51dc70e3753"), "Forearms", "Towel Pull-Up" },
                    { new Guid("aac41c18-e61a-4c87-a87d-7cd9246a792f"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("ab5c07ba-be24-446e-95bf-d1c16c96aabd"), "Abs", "Machine Crunch" },
                    { new Guid("ae5f45fc-e2e3-4aeb-9629-d49610221157"), "Back", "Pull-Up" },
                    { new Guid("aea16826-1f42-4c58-988b-e2a9fe2f1875"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("aed14bd6-5a0a-485c-bf78-6a039f1f1e19"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("af1c8782-9714-4efc-b18f-23c3b09a7b01"), "Glutes", "Fire Hydrants" },
                    { new Guid("afe0bb2e-a4ba-4075-9f70-73fe4eb72235"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("b02e0b56-2e75-44d1-90bd-aef9d1cbf44c"), "Legs", "Seated Leg Curl" },
                    { new Guid("b1a36a1c-cef9-486d-8f9e-250de17b31cd"), "Legs", "Front Squat" },
                    { new Guid("b3d36afa-5565-4e7a-9661-bf50b7bb95d1"), "Back", "Barbell Row" },
                    { new Guid("b5934b3e-ebd0-4e9e-9b37-61fee92fc294"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("b66a81b6-371c-4c60-8fe2-30a834efb4b6"), "Back", "Chin-Up" },
                    { new Guid("ba17dc86-221b-413f-b77a-55d3f2485354"), "Legs", "Dumbbell Lunge" },
                    { new Guid("bdc0399b-dae6-4705-be97-b52ad67d1ed8"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("be36346b-59f4-49b2-b4b3-6494e9d0f8ac"), "Shoulder", "Overhead Press" },
                    { new Guid("c0295f7a-c65e-4770-bb21-3bd9a271e866"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("c0cb4217-38bc-4a57-8c3a-19ce5b1cdf33"), "Legs", "Smith Machine Squat" },
                    { new Guid("c301e743-e00a-439c-853d-9572acadd3ab"), "Bicep", "Spider Curl" },
                    { new Guid("c49803d2-0699-4bbd-89ad-2cca256cc5cc"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("c5392c91-9d57-4a1d-9683-0f7d3895ad19"), "Back", "Kettlebell Swing" },
                    { new Guid("c5446e39-521f-4986-87fe-380c2ca05159"), "Back", "T-Bar Row" },
                    { new Guid("c5b28700-6c90-4116-b87e-32e8337eeeb0"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("c6356db5-68e1-4cfb-8165-615b11fa4469"), "Calves", "Standing Calf Raise" },
                    { new Guid("c70f1009-4d72-4d70-9913-9604502ef6b8"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("c7b9531b-b21a-49c8-a2db-ef289bd44b78"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("c9ca3dfd-a7e6-4473-9899-5a4abe29b57f"), "Legs", "Pause Squat" },
                    { new Guid("ca2267b2-ce6f-4994-abdf-1a2f2ab2dde0"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("cd2e50be-22ea-4b5e-a7bb-2c5b18896750"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("cdffa117-7275-46fa-b733-cc9e1f584cd4"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("ce26e72c-f2fb-4fc7-ac8d-0af416030e4c"), "Legs", "Safety Bar Squat" },
                    { new Guid("cf53fe30-cabd-4540-adb8-60a1310e7b83"), "Back", "Rack Pull" },
                    { new Guid("cfd9307f-165e-4222-ba45-42486ba13522"), "Back", "Dumbbell Deadlift" },
                    { new Guid("d0f5d20d-5223-42ca-b8d1-f9adb0f063d0"), "Bicep", "Concentration Curl" },
                    { new Guid("d0fe12b8-cd56-42bb-8a8d-f186bfbd7e2a"), "Shoulder", "Squat Jerk" },
                    { new Guid("d4bf6847-6bf8-4378-ab95-2558126cb4a1"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("d4eac848-77d5-4684-9f07-d76d3e0e2621"), "Bicep", "Hammer Curl" },
                    { new Guid("d5aae64e-ed7b-416c-89f5-79556f612fef"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("d8f7ccde-9728-4422-88b2-8b6fedc2c10a"), "Legs", "Landmine Hack Squat" },
                    { new Guid("dbb44126-7bc5-431d-b7a0-8ec6936d9404"), "Back", "Sumo Deadlift" },
                    { new Guid("dc3fa2e4-8438-40f4-9e1b-c8bdf04a607e"), "Shoulder", "Push Press" },
                    { new Guid("de1e8521-d1a1-4f38-81a8-499b60c65306"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("de263917-0a73-4f90-b8cd-91629d505f79"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("dec56a2a-9c00-4312-bcaf-a9c0d0903556"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("df01acbf-3512-4bfc-b35d-9475c054c7ea"), "Abs", "Dead Bug" },
                    { new Guid("e133df6e-0e1a-4aef-9017-b5e6f9c2b981"), "Forearms", "Gripper" },
                    { new Guid("e169958a-ab10-43f4-be4e-37a594f62c16"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("e1d9148b-8d26-4bde-925c-7e7d1161640a"), "Shoulder", "Split Jerk" },
                    { new Guid("e260ea48-1900-48d8-a699-53fe5c688dc1"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("e50e1e87-680d-4b39-be61-16ff05a90661"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("e689ba8e-c260-4f3e-9c60-238c63b775c6"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("e6be3a09-db61-4a04-90a8-58c253a15444"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("e6d2e238-f5de-4d42-8321-14a8165d2bf3"), "Bicep", "Dumbbell Curl" },
                    { new Guid("eaa859f5-e43d-4d69-adf9-0b7edce7d3e7"), "Calves", "Seated Calf Raise" },
                    { new Guid("eaac8d79-eaf8-4589-b6ad-dcb0bc72cb6b"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("eac2d680-d19a-415c-bf5d-285cae44b671"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("eb34351d-978a-419f-bec1-d0745796e5b8"), "Back", "Hang Power Clean" },
                    { new Guid("ebb047ba-4e76-421f-a766-25a5270f8634"), "Back", "Seal Row" },
                    { new Guid("ee6e1670-41ec-4652-95af-457d5b1d947e"), "Legs", "Step Up" },
                    { new Guid("eedad161-aee4-46ef-b3e9-588925c9612b"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("f0c497e1-cc45-4661-8e85-0ab277941673"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("f1917ab6-c174-4f15-b614-40cc9d45e299"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("f2649630-d01d-4335-b879-93719a9a054f"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("f2a965af-af12-473b-89ae-676550f4f94f"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("f55fa00e-f3d4-4591-82b7-25b133403867"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("f6367d95-af15-4827-bf2b-fb0cebd820eb"), "Legs", "Squat" },
                    { new Guid("fa528921-c93f-4704-b26d-814616766d26"), "Back", "Snatch" },
                    { new Guid("fa834d8c-6c10-4c0b-923c-cfe5b5fc6de8"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("fa8875a2-0068-468e-9588-aaaaf7db1d3b"), "Legs", "Dumbbell Squat" },
                    { new Guid("fc1404a5-5d71-4dcb-8552-faa1db2bdeb8"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("fc2f351b-0ea8-4a18-8f0a-396c43910013"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("fc956753-e771-4d92-8a28-343c75e57150"), "Back", "One-Handed Cable Row" },
                    { new Guid("fd264459-5dba-425d-a394-5f7f88abffb7"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("fda619d4-dc9e-4a77-9b57-cb61f9b4b921"), "Glutes", "Step Up" },
                    { new Guid("ff71b1df-ec7d-4d4e-b22c-c9a832b0eb01"), "Legs", "Belt Squat" },
                    { new Guid("ffb5473e-a635-4de6-9601-b5726c2a3129"), "Back", "Inverted Row" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutTemplateExercises_WorkoutTemplates_WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises",
                column: "WorkoutTemplateModelId",
                principalTable: "WorkoutTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutTemplateExercises_WorkoutTemplates_WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises");

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("20f107a2-45b8-447b-b633-850b9d78b881"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("2a4c37b4-0613-4b02-a81b-a47237a8d2f2"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("39036824-50ba-4c4a-843a-0164186b8be5"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("7b6cec60-5311-4c0a-a055-d12fcb5e60fe"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("a22e987a-eb04-4f49-a43e-5237f272f2dc"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("a2fe4b34-1c04-425e-bd44-7bf91c903c89"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("a4fb0d0b-ca5f-4a1d-8496-3dfc3334ea08"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("cd8b2cd2-f3b9-41a7-9604-5095cc6ff181"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("f509ac44-7919-4678-8d91-65f670248900"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("fc212817-89a0-4c0d-8885-a111f717fad4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0140e0d2-216e-4bb3-a5eb-ada3a809a7db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("01d2621e-4ed1-44f7-82a1-60172b76d26c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0217b5f7-5f14-41f6-a148-f4b170f9eb9a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("043ae2a7-82bf-4590-81e7-071a32fa5d1d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0453760b-4f55-49fd-9491-c6dd8a30038e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04d6f5c2-27fe-4744-bb2b-74b86169ccf4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04f6eb4a-a91a-470a-bc57-9fd28c6450a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("058ad914-7c7c-432b-ab04-af494a071921"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("072886c6-9d6e-4ba7-a09d-3b4525641f3f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bbaedc6-17fa-402f-841a-4de7e9b3fdac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bfbb46a-cce8-479a-9fbe-fef677481304"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e34aacc-b870-4876-9804-6b737c56a9f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e94731e-9cab-4e21-97a2-6ef515ec70cf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e9bc83c-fb54-4ff3-b17d-0ddac3e45a03"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("10f98948-170d-40f8-9abd-981b7d7abb82"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1300f97a-9718-4498-b405-2a58df6c3205"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("162c1380-aa94-470d-9cbf-cbf8a26d46f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("17dc0d60-1787-4396-9a1b-2aa75619bfc0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1bd236e8-cb9f-4122-9ee5-512ac4568d81"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ca10c07-613f-41a0-9e7c-3e4aa97c999a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20746ccc-7c5f-4f63-860c-16a5cea0264e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20b5a1a9-adb3-4f06-8748-ceae5d363649"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("241a8b38-23da-45a5-a629-3d7d061ce059"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("24984147-6324-4892-bcdb-9e8ae53c2959"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26809a3b-e29c-401b-8fb7-ab222745e85c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("27f840dd-8e55-438c-bf7d-6c2ca4da8114"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("28419a72-70a4-4a92-ae30-8c8b6b225e53"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ac83365-ff57-42f1-80d8-b037658bf3e9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ad777e0-a404-4133-95ab-98ca66393f2f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2aeba067-d5f8-4f77-bca7-c2749c90136f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b4e4178-9f33-428a-9199-2a541ce2db40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2bab4a78-ffc9-4472-acec-0b90c5196165"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2cacd7ae-2dbf-49fb-89d2-8c04c5c13fcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2dbbc80d-6726-4d3c-ab5a-1da9ecef8ff1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2fea7a4d-c744-42ea-ba6b-a91ee7810620"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("303ed8f2-71a9-4fdf-9c52-9dfe1fd22f62"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("31e89461-ced6-48df-8dbc-7ac36ac571b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3217b8b1-095d-4c44-b208-5c6cfedf0375"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("321b8e30-3f0e-41f3-82b2-83adbb1cc3fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("32aba767-2a48-4117-914d-d192fa34d5dd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("32cd4df6-1d22-4a45-99ad-ffb182182cfb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34ddb40c-242d-40e6-8d56-c4996ab147e1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("353d71a8-06f7-4f7f-80ee-a32f02e73d5d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3573e25d-dc4c-4aeb-962c-2be3a9973baf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36abeb9f-6418-4b52-ab34-c4ec5163c15d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("381807f6-0a2b-463e-b08e-31a7f8fc082a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3c44e412-9bd1-42ae-ab1b-d542a7385eef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3dac1c23-e82a-4d53-aff1-e680099b0c85"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3effb9c3-d0fc-4670-af51-7a0651d29b27"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("419d0ff9-b09d-479d-910d-2af00f34147b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("453eb767-10b7-479a-8705-cb563a300c8e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("46aeed83-6d1d-4939-8659-d18f9880e3fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("49415011-250d-4da1-9c35-22cf9756f3c4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a5acfc9-c63d-46dc-a050-78e545a93549"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4be58f4e-539e-4d09-8da5-30cecb1a523c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4bf5eeb9-d215-4751-b24b-9b1252fef8d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4c330e3b-e1ed-4b85-8702-111e26722a58"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ca88971-83a5-4686-924a-e3163428590c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("51b86da0-25bf-4438-98c8-88632fb09113"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("53e2ff83-b856-428f-9126-20bdba49309d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55dbbf2f-c740-4e29-831f-3ca4f0f48e80"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5672cb1c-cbfb-45e3-9874-dcdbf4de2795"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("569ea0b9-93c2-46b2-a14b-856d7d299437"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("597552ff-f995-487f-a236-cd68703baf98"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("59e85aa8-694e-428f-8bfb-c319c671f6fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5afdff00-fed7-4f12-aab0-31d9f2663d10"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b98242d-1c2e-4118-9746-d2da18e1cb67"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e665e42-5912-4fab-a7c8-1db0a0993d2a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e8582c0-718e-45b6-b259-ad2a0f0dbfd3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5fdb9207-701d-48f7-b4b2-383cb31bb304"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6126dca7-13b2-4db7-b6fc-d86044439232"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61319a81-0ead-4255-a711-8d7fea409b36"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61af778f-5307-4d35-aa68-ff7919892655"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("62596019-c971-41ab-9ea9-3f7b034c11e8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6301dd36-0e27-41a0-9b54-58c6757204f1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("63d5839a-2c44-4e49-bfa4-87234c0f4ebc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("662fbf6e-e269-4b24-a749-4a54f9502948"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6682bdbf-8a0d-42d3-b469-36d7ae087ad6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("68826f3d-afe8-4816-b2d7-56bc5fc5f4f6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("68fd1e00-736f-4d5b-88e7-734c6e63ffc3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69c1c462-2dbc-4e96-a05f-4865ad053fe1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6afce898-4a83-4be5-9f7e-b09a6a80ea88"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6c883121-35e9-4b78-94a4-87f574faa92f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ca9f2ca-ee42-45b3-a91d-4e4398a05dad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f0913d1-1aee-4dfa-9e0b-4073c1082bb6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f4a1d08-40c1-4bbb-8934-be7632e6adcb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72f330e1-52f0-4836-8c81-a4080286076e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("748f7a69-8c05-42ee-be74-3b2f024a116b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74b8bb4f-e02e-474f-b920-7bb7a8695e9d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("75fe4c5a-20b3-4310-8bb2-abb6116a0dcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77191b68-928c-4156-bbdb-46baa75b0d04"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77ed1865-c59f-4a10-adc3-a44a656e2634"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7849d7f2-a2fb-4ddc-a6d4-21ae02dfc424"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("79b9223e-6b46-4141-b6c1-f17a9f7eaa31"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7df7aa14-3669-41f5-a950-3a27d4cd03b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7dfacf4b-2031-4eb9-99d9-10580e4b9e4c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("80bb27b5-c0a7-4d0e-9211-028747706e8a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("81d4126a-18e6-49e6-98a3-0fc57fbadff8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8555a8a6-a016-4c00-83c7-ec84fc16bb06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85ef6b01-f291-4bcd-a063-e60497daa11b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86678d1d-e190-4730-bf39-2dc146e71cce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86bc0028-db1d-43fb-a7be-6104c2c5f73c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("876fed5b-3229-401f-b366-dc8d7fc88f68"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8812017c-33fa-4d6c-8598-28582afec2ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89bfe619-ef96-44ae-90ed-967cb906730b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a688345-5eb2-464d-b9a2-4893cb897602"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8bb042be-dce3-4f65-99cb-d6cc13fc78e7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8deb1612-5c9d-46b1-b117-6f79fc33c033"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f5a8cec-bba4-4f19-9d91-5ef8b0745e92"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8fb3d3b4-7582-468b-89fe-c6bae6f1b449"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8fbacbd5-50ab-4ac3-b4a2-65f8d983478a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90aa7d92-cf1d-4e2b-981e-2beff3db83ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("91059aa4-e2cc-4b90-8875-74de89a0209c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("912451c3-0ee2-4650-9c0f-f1c5c3a5567b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("931aef9f-d9e0-4128-9529-d6a7cd1c49d9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9360332d-12c7-4c67-9ba8-bfb57b9ea319"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93f2976c-931d-41a1-9d3e-9b02ee987f29"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("947367af-c68c-4931-8ca0-f54cc3387bd1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94afafe4-836b-4bcd-920c-16071c16d072"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94d19da1-3d67-4bf6-9908-4a63fea69896"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("98165bf9-e52b-4258-81ba-7378db84a677"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9855fee4-2122-4e85-8d7d-3489bd8e71bb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99963de4-e65a-456b-9f66-7c3203fef966"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99b206c0-f161-412f-94c2-ad18b3448911"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99d36afb-6cae-49c7-aaf4-1289817f10fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9abad6ae-2d02-45db-8c9a-fc7db25783d5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9bc5c4ee-7fbc-4041-a84e-9ca89577c050"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d02b266-9707-49da-bf96-ddb77f5eabf4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e3a095e-70dd-4bd9-a3e4-fd205d7a0bcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e53100b-3742-4386-92b3-5f1ef93757b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9ff11236-4c3d-4ce6-a7b9-ff9de3e93a41"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a04cfab5-fda7-459c-b933-4206aa790171"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1b0ae8b-6435-43c9-a8e7-50f2127efe15"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2638e88-efa1-413f-8220-3f8deb11bf38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2bb1b46-6208-4a4e-8598-210c54f8d298"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a3d4e805-7db8-4b1a-9e5e-21c21c3d9e3a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a4d0869f-8279-492c-8ca8-4cfe938f20ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a516c9fa-f730-4a7c-894f-1c164a1ddf73"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a5783e50-a976-4373-9bfd-a7b262218a3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a5e56aef-41b5-409e-a2db-b204a8f91725"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a6444cad-b940-462a-9ac6-d51dc70e3753"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aac41c18-e61a-4c87-a87d-7cd9246a792f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ab5c07ba-be24-446e-95bf-d1c16c96aabd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ae5f45fc-e2e3-4aeb-9629-d49610221157"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aea16826-1f42-4c58-988b-e2a9fe2f1875"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aed14bd6-5a0a-485c-bf78-6a039f1f1e19"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af1c8782-9714-4efc-b18f-23c3b09a7b01"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("afe0bb2e-a4ba-4075-9f70-73fe4eb72235"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b02e0b56-2e75-44d1-90bd-aef9d1cbf44c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b1a36a1c-cef9-486d-8f9e-250de17b31cd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b3d36afa-5565-4e7a-9661-bf50b7bb95d1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b5934b3e-ebd0-4e9e-9b37-61fee92fc294"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b66a81b6-371c-4c60-8fe2-30a834efb4b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba17dc86-221b-413f-b77a-55d3f2485354"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bdc0399b-dae6-4705-be97-b52ad67d1ed8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be36346b-59f4-49b2-b4b3-6494e9d0f8ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0295f7a-c65e-4770-bb21-3bd9a271e866"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0cb4217-38bc-4a57-8c3a-19ce5b1cdf33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c301e743-e00a-439c-853d-9572acadd3ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c49803d2-0699-4bbd-89ad-2cca256cc5cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5392c91-9d57-4a1d-9683-0f7d3895ad19"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5446e39-521f-4986-87fe-380c2ca05159"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5b28700-6c90-4116-b87e-32e8337eeeb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6356db5-68e1-4cfb-8165-615b11fa4469"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c70f1009-4d72-4d70-9913-9604502ef6b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c7b9531b-b21a-49c8-a2db-ef289bd44b78"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c9ca3dfd-a7e6-4473-9899-5a4abe29b57f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ca2267b2-ce6f-4994-abdf-1a2f2ab2dde0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd2e50be-22ea-4b5e-a7bb-2c5b18896750"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cdffa117-7275-46fa-b733-cc9e1f584cd4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce26e72c-f2fb-4fc7-ac8d-0af416030e4c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cf53fe30-cabd-4540-adb8-60a1310e7b83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cfd9307f-165e-4222-ba45-42486ba13522"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0f5d20d-5223-42ca-b8d1-f9adb0f063d0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0fe12b8-cd56-42bb-8a8d-f186bfbd7e2a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4bf6847-6bf8-4378-ab95-2558126cb4a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4eac848-77d5-4684-9f07-d76d3e0e2621"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d5aae64e-ed7b-416c-89f5-79556f612fef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d8f7ccde-9728-4422-88b2-8b6fedc2c10a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dbb44126-7bc5-431d-b7a0-8ec6936d9404"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc3fa2e4-8438-40f4-9e1b-c8bdf04a607e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de1e8521-d1a1-4f38-81a8-499b60c65306"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de263917-0a73-4f90-b8cd-91629d505f79"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dec56a2a-9c00-4312-bcaf-a9c0d0903556"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df01acbf-3512-4bfc-b35d-9475c054c7ea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e133df6e-0e1a-4aef-9017-b5e6f9c2b981"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e169958a-ab10-43f4-be4e-37a594f62c16"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e1d9148b-8d26-4bde-925c-7e7d1161640a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e260ea48-1900-48d8-a699-53fe5c688dc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e50e1e87-680d-4b39-be61-16ff05a90661"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e689ba8e-c260-4f3e-9c60-238c63b775c6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6be3a09-db61-4a04-90a8-58c253a15444"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6d2e238-f5de-4d42-8321-14a8165d2bf3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eaa859f5-e43d-4d69-adf9-0b7edce7d3e7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eaac8d79-eaf8-4589-b6ad-dcb0bc72cb6b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eac2d680-d19a-415c-bf5d-285cae44b671"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb34351d-978a-419f-bec1-d0745796e5b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ebb047ba-4e76-421f-a766-25a5270f8634"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ee6e1670-41ec-4652-95af-457d5b1d947e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eedad161-aee4-46ef-b3e9-588925c9612b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0c497e1-cc45-4661-8e85-0ab277941673"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1917ab6-c174-4f15-b614-40cc9d45e299"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f2649630-d01d-4335-b879-93719a9a054f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f2a965af-af12-473b-89ae-676550f4f94f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f55fa00e-f3d4-4591-82b7-25b133403867"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f6367d95-af15-4827-bf2b-fb0cebd820eb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa528921-c93f-4704-b26d-814616766d26"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa834d8c-6c10-4c0b-923c-cfe5b5fc6de8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa8875a2-0068-468e-9588-aaaaf7db1d3b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc1404a5-5d71-4dcb-8552-faa1db2bdeb8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc2f351b-0ea8-4a18-8f0a-396c43910013"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc956753-e771-4d92-8a28-343c75e57150"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd264459-5dba-425d-a394-5f7f88abffb7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fda619d4-dc9e-4a77-9b57-cb61f9b4b921"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff71b1df-ec7d-4d4e-b22c-c9a832b0eb01"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ffb5473e-a635-4de6-9601-b5726c2a3129"));

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("256e02a1-9952-4256-89c4-b9c3aab3c9b9"), "Legs" },
                    { new Guid("4f2b684d-8d97-482d-81e2-1104f0b66667"), "Abs" },
                    { new Guid("4fc49537-5b93-4085-8760-062c919a2fbc"), "Tricep" },
                    { new Guid("51470251-8810-434d-91bd-c29378124c28"), "Forearms" },
                    { new Guid("647eace0-10b2-451a-86e7-77e7c59e13f4"), "Back" },
                    { new Guid("91ac4dc5-47ba-442a-abc5-2a62d41234a4"), "Bicep" },
                    { new Guid("c0cd50c3-45e8-47b5-a444-3445a5b9fe7d"), "Calves" },
                    { new Guid("c164168d-5d47-49af-9002-8846b15ddf77"), "Chest" },
                    { new Guid("ea7395ad-3608-4b4b-80ac-59123c6ef683"), "Shoulder" },
                    { new Guid("f7807e04-5572-4a2e-823e-fa4db289d35f"), "Glutes" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("021581e0-9e4b-47c5-b2a0-084e474c5dfb"), "Legs", "Step Up" },
                    { new Guid("030161ea-5453-4600-99af-3ce0d79c767d"), "Bicep", "Spider Curl" },
                    { new Guid("030e0e2d-9566-453d-9d6b-47424441e7d2"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("03af4669-0e9c-41f8-b96b-38e83905ea04"), "Back", "Clean and Jerk" },
                    { new Guid("04e2d027-ed33-4d8f-bea8-30df60240e5f"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("06699595-240f-4fe2-a2fc-44536fc56ffb"), "Forearms", "Farmers Walk" },
                    { new Guid("06b0fd5a-06f7-4e0f-88fd-4c2cc9998f3b"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("095a8572-b65f-4592-bd2a-5ffb70a228d2"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("0bfc6297-adea-4547-8f86-530f46f93de6"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("0c0120da-95a2-49b4-ae34-7f2bc69c1d1d"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("0cf1ba6a-16ec-4ba9-bb34-fc5545788c9d"), "Back", "Snatch" },
                    { new Guid("0e5994a7-a4ca-436a-9143-626f29b15a46"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("0ec49bc3-071e-49d5-b5d7-e320256d78d6"), "Chest", "Machine Chest Fly" },
                    { new Guid("0f4816b9-d837-4b33-be6b-8f9c16a37575"), "Shoulder", "Push Press" },
                    { new Guid("0fe5fdaa-1a7e-4249-b0dc-7ec419e5b6c8"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("114de932-dc78-4f76-aca5-1e341f4054b4"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("11501a53-e81b-4902-89b9-360ea07181fe"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("116b5383-7c97-46d7-b5d9-56a7fc173ab5"), "Bicep", "Concentration Curl" },
                    { new Guid("14169bfa-750f-4ff1-85d7-140fe84c8752"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("158d6689-d72e-47a2-82ae-24c5ab85ea83"), "Back", "Kettlebell Swing" },
                    { new Guid("1789769d-0675-4841-bba3-0dde6e2a264e"), "Back", "Pull-Up" },
                    { new Guid("17de7696-fda1-48f1-9ad4-c5a27055db67"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("192687e7-6282-4842-9dba-09caf394351e"), "Chest", "Bench Press" },
                    { new Guid("1c0a258d-1473-4bdb-9583-cf50787ea39d"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("1c268c66-fec5-4b60-8ae2-39f1cf6019d2"), "Legs", "Landmine Squat" },
                    { new Guid("1d00cceb-7ebd-4cbd-803e-a4a6834fa05b"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("1d3f3374-c5e6-4d63-a0d0-8c050e9c2f39"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("1d99f93e-f7cc-4e43-8c93-19064c7cc808"), "Glutes", "Frog Pumps" },
                    { new Guid("1e4caa16-2dcb-4f86-879e-13089fb03918"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("1f221ead-2348-4a6f-be9c-4cbbd8f07d55"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("1fe75e49-ebf3-407f-9382-88bc0a069e3c"), "Back", "Pause Deadlift" },
                    { new Guid("22c6f2a8-bfd6-41f3-a4bd-b1413fb1c592"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("2418c53a-ce45-40fa-b3e3-1260c8be021d"), "Chest", "Push-Up Against Wall" },
                    { new Guid("26a0ca84-b434-4fec-8bcd-8d2cf8e3b137"), "Chest", "Incline Push-Up" },
                    { new Guid("26a2858e-5950-4561-8bac-4da76fd11fbc"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("2773e332-88ab-427d-9fde-3776604d8a33"), "Forearms", "Plate Pinch" },
                    { new Guid("28e74b3d-9fc0-4e58-98dc-c2e7b606353f"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("29ad443d-c176-48e3-91e9-22380141e735"), "Abs", "Hanging Knee Raise" },
                    { new Guid("2a903302-1006-4202-9132-298715fae015"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("2b540669-3346-47c6-9a94-3332516e0d53"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("2b60df42-c1d7-42ef-a22a-2df23961689f"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("2d50ba36-5895-4fec-9666-6ae0c13b2072"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("2f48037b-2c61-4a9b-be7b-b7bcb16d6722"), "Glutes", "Clamshells" },
                    { new Guid("2fcff341-77f7-4512-914e-a4257a1aa32d"), "Bicep", "Dumbbell Curl" },
                    { new Guid("328c70df-84c9-4f55-8ef3-e214fdbef80e"), "Chest", "Floor Press" },
                    { new Guid("33e51098-3db3-43f3-a46e-52b6ee3c9c40"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("36e62089-23b7-44f5-9993-95c918d2b029"), "Abs", "Machine Crunch" },
                    { new Guid("3722329c-8bca-41a8-bedd-f8852ca7b26a"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("374545cc-a8a7-44d7-b1b3-3259bcb3eff2"), "Back", "Dumbbell Shrug" },
                    { new Guid("38dac62c-1ab9-4185-82b1-d0b5f66bfc4f"), "Bicep", "Bodyweight Curl" },
                    { new Guid("395d14f2-f4e5-44ed-b0d4-a527d9684080"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("39c298ef-3290-4238-bba5-98af58d3fe91"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("3a44e2d6-2f78-4b66-9226-58d5d1cf5467"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("3ab4ff9c-e4a5-4071-950a-c6a7fc01b699"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("3c4d64e8-f858-4dd1-ae55-75d5df7d9c8e"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("3d778049-81e5-4001-9d56-0c22f44f82d7"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("3f7b7445-9dc3-457b-bbca-4ccff472566f"), "Glutes", "Cable Pull Through" },
                    { new Guid("3f87c75b-992d-41cf-8701-f79d9127141a"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("40216c3c-8098-4aa3-8739-8de755fa10b2"), "Back", "Rack Pull" },
                    { new Guid("40292532-8401-40c3-8fa7-9ad9dc1d8b36"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("42f9a4a2-6ab1-4a5d-b58b-676d2cbd0c85"), "Chest", "Decline Bench Press" },
                    { new Guid("4380c7f3-d9f0-4ade-972b-a6eef747b679"), "Back", "Good Morning" },
                    { new Guid("4726e823-0a0c-4baf-816a-bb73ee2d93d3"), "Chest", "Kneeling Push-Up" },
                    { new Guid("47894578-6264-4137-936b-7ecc8ef359fe"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("48ff5de8-cb51-484b-b291-fe0a5e60479f"), "Abs", "Sit-Up" },
                    { new Guid("499d43f4-b966-496e-8b55-b66d548e7a17"), "Glutes", "Step Up" },
                    { new Guid("49e20cce-72b5-4d49-857c-027fae5df2db"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("4ad11402-5288-4e03-b15e-5bafcfc0bbaf"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("4c7c07ed-bd87-4b68-95e6-abc0f041a35c"), "Chest", "Cable Chest Press" },
                    { new Guid("4cae0e97-7921-4bb9-a4bc-36c3b002cae3"), "Back", "T-Bar Row" },
                    { new Guid("4d6d3722-6453-4e62-a4f7-94b0c1b1db3c"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("4db0f4f5-b3a8-4a5f-b80d-3081e3f06715"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("4e068ec9-040d-4b5c-b347-5e230c304b1b"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("4e76b04f-903c-4c68-bf5e-01207021afb5"), "Glutes", "Fire Hydrants" },
                    { new Guid("51dd64eb-e9cb-48b4-8b3b-9da89c1a3cfa"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("52fbc033-e529-4878-b130-a30446c3e264"), "Back", "Clean" },
                    { new Guid("53e00257-f593-491b-868c-44c47fdf948f"), "Legs", "Barbell Lunge" },
                    { new Guid("549d03f2-5dc3-4adc-b298-f9b153d97d0d"), "Glutes", "Glute Bridge" },
                    { new Guid("56060e5c-9242-42a3-a03a-639647b4f2e3"), "Legs", "Lying Leg Curl" },
                    { new Guid("565d2f6e-d448-4401-aeb0-1a0aeb2f8a83"), "Abs", "Crunch" },
                    { new Guid("5a080304-294d-4e6e-ad49-95af0432e569"), "Back", "Hang Clean" },
                    { new Guid("5ae0a95c-fb9b-43cf-a3b3-f7c5a0d18665"), "Legs", "Step Up" },
                    { new Guid("5b68f0fb-05b4-4012-916a-e44a21cf31df"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("5bcf407b-9513-4c4d-8a41-63877b34b204"), "Back", "Hang Snatch" },
                    { new Guid("5d1e0948-c818-49e9-a2f9-cba4b9ff0039"), "Back", "Hang Power Snatch" },
                    { new Guid("622f3d6f-307e-4971-8b5d-6441265bc841"), "Calves", "Heel Raise" },
                    { new Guid("63d62cbf-8f4e-42de-b5db-344693c10a85"), "Legs", "Body Weight Lunge" },
                    { new Guid("6477152f-d712-4387-b641-afa63c66d4a5"), "Forearms", "Bar Hang" },
                    { new Guid("6511705c-f81d-47f8-a354-4ba893b05a4f"), "Legs", "Box Squat" },
                    { new Guid("65bdae54-d80c-4952-bc47-d93b93dde2c7"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("65f62950-5f69-453c-aa47-58aa1a73e910"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("66891667-eeb6-4213-803e-24dbe3aa39b1"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("677ecc71-a704-464c-b1da-ec5b8bea52a6"), "Legs", "Front Squat" },
                    { new Guid("6973f1b9-79bb-49b6-9534-428aed7a750f"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("69e63ca3-cb4d-4519-828b-d43abcca8fb5"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("6a881204-b6d8-472c-9eef-dfe730672ad4"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("6c624761-a2be-4760-ad68-1c95e0a571c8"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("6e0566b8-630f-4df4-b4e6-4f42d2b2304f"), "Forearms", "Gripper" },
                    { new Guid("6ee086df-0d7f-4a23-adc6-8c20e96a5156"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("6f5d02aa-0aaa-4d37-9f59-88033d51be90"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("6ffb541b-d2d5-42dc-b800-be4e7b1a17db"), "Back", "One-Handed Cable Row" },
                    { new Guid("7157eab9-056e-4601-9de8-d27127d34ec5"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("71ec8796-53da-44d3-b67f-9aa9f18fc43a"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("72257186-bf7e-4ac3-9db2-ca913a9ef29a"), "Legs", "Air Squat" },
                    { new Guid("7513ed34-434f-48f7-9046-bca5560a07bd"), "Shoulder", "Squat Jerk" },
                    { new Guid("7706091f-f614-435c-a0f1-6343d88d35ed"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("77b26bd5-c3b3-48d0-828d-8f232cad732c"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("77d457ee-7ab9-448a-950d-8e86eb69de55"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("7a0a705e-2de8-4882-a247-ca5e1232e728"), "Back", "Pendlay Row" },
                    { new Guid("7cda1969-c465-4ff8-a491-42ce9a2e6110"), "Legs", "Safety Bar Squat" },
                    { new Guid("7e40ce8a-55a0-47f5-a456-9f83cd980335"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("7e9d741d-bd32-43a3-963e-b86a70059381"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("7ea31076-b6b6-45df-afaf-f7bc694a8815"), "Shoulder", "Front Hold" },
                    { new Guid("7eef08af-1280-4aa3-aff8-eb9456fae6b2"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("7f55a034-8fe1-4578-b940-d7d835145fcc"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("8015a5d9-69c4-4faa-879a-7f77ec5f3e1d"), "Abs", "Kneeling Side Plank" },
                    { new Guid("85eb16e6-87a4-4732-82fb-cc3fffd27345"), "Back", "Power Clean" },
                    { new Guid("879f83c5-8dba-48af-83dc-1c9e6bc01d1b"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("880777ba-17cf-438c-ad71-ed21e2c85c99"), "Legs", "Dumbbell Lunge" },
                    { new Guid("89784ca9-a737-4cf1-8e46-b134f0044171"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("89e49a4a-06ab-4deb-b736-151d24319e6d"), "Back", "Sumo Deadlift" },
                    { new Guid("8c951da8-1a0a-4d6c-85ae-5735a1b1c1ec"), "Legs", "Barbell Hack Squat" },
                    { new Guid("90d1bb5c-81ae-4ef7-abdd-438339a77792"), "Shoulder", "Plate Front Raise" },
                    { new Guid("9221f55d-fddf-4c62-bfcd-a6380022fafe"), "Legs", "Leg Extension" },
                    { new Guid("943f4400-9d5c-45f8-9b3b-228e26b9f0dd"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("956cfbe5-da66-4f8b-a058-0dfad351d2b8"), "Back", "Hang Power Clean" },
                    { new Guid("969907b4-ba1c-4917-b737-8470aecd1411"), "Back", "Barbell Row" },
                    { new Guid("98ef8f65-de15-417e-ae3d-4bd18c458fb5"), "Legs", "Pause Squat" },
                    { new Guid("993557ac-e30f-4a50-9d45-ea5162df86bd"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("9970b4f6-e2bb-457b-a2c1-a30c18b2997c"), "Abs", "Dead Bug" },
                    { new Guid("99f2777e-4a17-4e7c-9144-6f66a723c9f3"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("9b5e6b78-b494-4c05-a539-0621d9d9972b"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("9c58e78e-95f4-4da8-932c-0edfe6819311"), "Back", "Dumbbell Row" },
                    { new Guid("9d5bcd0a-625e-4614-8885-5bc495e747c8"), "Back", "Seated Machine Row" },
                    { new Guid("9d891c66-973f-444b-8475-0051232ebf87"), "Legs", "Seated Leg Curl" },
                    { new Guid("a0a0e1f3-63db-4fd7-b7be-c79767f08ed3"), "Legs", "Chair Squat" },
                    { new Guid("a1052b94-b6ff-4aca-af92-5f20bac7077c"), "Abs", "Hanging Sit-Up" },
                    { new Guid("a1bc18f8-d4e4-4931-8702-50ec8a92a04a"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("a23b9394-2f68-4007-b5de-68fc20ffedb3"), "Glutes", "Banded Side Kicks" },
                    { new Guid("a3e8af59-fb35-4b09-93b9-94ff5f01c076"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("a524276a-6a00-4d22-a5aa-b7ddd566d8fa"), "Shoulder", "Overhead Press" },
                    { new Guid("a525dbd1-9160-4f84-8eb3-7f74ddda053f"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("a58484b4-74ed-48e8-972e-760f5c807c02"), "Legs", "Hack Squat Machine" },
                    { new Guid("a61f0816-ca0e-4522-98cc-c2e593b00f81"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("a7cb7a18-5495-4628-9f50-911237ed0d1b"), "Legs", "Dumbbell Squat" },
                    { new Guid("a97c3364-f676-4a89-b8f0-df6a54184b96"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("a9eafef6-53dc-4a53-a02e-a5ad0bde195a"), "Abs", "Plank" },
                    { new Guid("ab7aa4b3-06f9-4e87-bbf1-63623ed9a123"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("ad822fde-d51c-4b8b-b236-8dd65e12d3b4"), "Chest", "Bar Dip" },
                    { new Guid("af151577-3914-4a54-81dd-663413f09bec"), "Legs", "Romanian Deadlift" },
                    { new Guid("af5211f9-a8d8-4443-bc51-b3ccbfe2e795"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("af773fea-f29e-4da2-8ab0-3e75768c0d4f"), "Calves", "Seated Calf Raise" },
                    { new Guid("b07acc50-60fa-4a54-82ed-e7336835282c"), "Legs", "Smith Machine Squat" },
                    { new Guid("b1b90756-e4c2-4796-841a-141e0aa69f70"), "Forearms", "Towel Pull-Up" },
                    { new Guid("b322f8e0-7b3e-4782-b965-444dbb683185"), "Legs", "Hip Adduction Machine" },
                    { new Guid("b5e42e61-bfa4-40e3-b6cc-6b0ca0aefcc2"), "Legs", "Squat" },
                    { new Guid("b83be0e5-44b1-48b9-9f2f-0cd49ae26a40"), "Bicep", "Barbell Curl" },
                    { new Guid("b8ab78e5-717b-4849-8f50-e6100c24fb2e"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("b9e1d535-39fb-46ab-a296-c6718c6cffde"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("ba8e5134-c6c7-4279-a2b7-7687fa4fd30c"), "Back", "Block Snatch" },
                    { new Guid("bb8855ac-2412-4f7a-8a5e-4de8821f278f"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("bcbfc3c7-bb24-495d-99a3-c2142d84336e"), "Chest", "Incline Bench Press" },
                    { new Guid("bd0c6ded-f69c-4548-8e4e-4487f5b76089"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("bd869b7c-bd29-421e-a6e4-2eb98e243df0"), "Abs", "Oblique Crunch" },
                    { new Guid("be7a999c-501d-4875-991f-c4acab5eb74f"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("befe4fda-5a2c-4aae-95a0-6be046ae6354"), "Back", "Inverted Row" },
                    { new Guid("c2076a34-c0fc-44da-9bcd-4351681b50e3"), "Chest", "Pec Deck" },
                    { new Guid("c26a70e0-f9d2-4e8b-bb27-226a67daacfa"), "Chest", "Push-Up" },
                    { new Guid("c37705b4-2276-4593-a825-dcf90db858d2"), "Shoulder", "Power Jerk" },
                    { new Guid("c3e69135-57c4-46cd-a28e-c35a1efc0200"), "Abs", "Oblique Sit-Up" },
                    { new Guid("c3f029cb-1385-4a22-8c94-158c2747463f"), "Legs", "Goblet Squat" },
                    { new Guid("c83332c4-3117-4e68-8299-1abf2374107c"), "Legs", "Belt Squat" },
                    { new Guid("c85a5ec9-7c6b-419f-8540-17d24ccc025e"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("c8b55609-8b84-40a8-8c92-12b7a5c40605"), "Abs", "Cable Crunch" },
                    { new Guid("cb1fb5a4-0e82-4ac8-bd7d-7c6d68140a83"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("cbb2534f-19f0-4448-8014-f420a9f9ce82"), "Abs", "Mountain Climbers" },
                    { new Guid("ce70b688-2ee5-4d1f-8883-3c84ef38a952"), "Back", "Chin-Up" },
                    { new Guid("cea7dff7-d5bd-464c-ab51-c11ed89cd6e3"), "Glutes", "Hip Thrust" },
                    { new Guid("d11d60c3-0113-425a-870f-22d83fe5c6b7"), "Abs", "Kneeling Plank" },
                    { new Guid("d1b138c2-ba13-443a-9522-29b85571c524"), "Legs", "Leg Press" },
                    { new Guid("d554fb80-c10f-405a-afbc-27aee4bd7379"), "Bicep", "Hammer Curl" },
                    { new Guid("d63bd2df-1f58-4429-97fe-64371ca8d8b3"), "Back", "Seal Row" },
                    { new Guid("d690560a-57ac-49bd-9ddb-07a4ff7ad86e"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("d82d1d97-49ca-4f9b-8ad4-fd8e8007a37f"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("dd9e2a6f-00c7-470f-9d59-15c799ba4877"), "Tricep", "Bench Dip" },
                    { new Guid("de1bd6a9-97a0-4ba0-b4e0-a5306b39cb83"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("e009d3e0-c3ce-489f-82c4-e6aa21321122"), "Chest", "Machine Chest Press" },
                    { new Guid("e0bb048d-9f12-41c4-92ad-ce4393020112"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("e0ff3b0e-f13d-41ed-bb23-e5960f244a50"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("e1c76947-25f3-40c0-b39e-c9a3954463c8"), "Calves", "Standing Calf Raise" },
                    { new Guid("e25ba5b7-dd36-4b6c-9683-effc29587771"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("e5f22252-8a99-4f50-834c-daf841030b0e"), "Back", "Deficit Deadlift" },
                    { new Guid("e7d965a0-66cf-40d4-b36e-e4746d01fd6d"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("e8457acc-ff4c-4dcd-b303-fe652d6e8302"), "Shoulder", "Monkey Row" },
                    { new Guid("ea96023a-3eff-4ee5-aa0e-9616a72cf9eb"), "Back", "Barbell Shrug" },
                    { new Guid("ebdd77a4-8954-4703-a519-370559ec6113"), "Back", "Power Snatch" },
                    { new Guid("efa9810a-1ae2-4caf-9c4c-2d9e13d76f35"), "Abs", "Hanging Leg Raise" },
                    { new Guid("f0b16f47-ec8f-4d34-81a5-85268955c31b"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("f1bdd049-b815-4534-992c-ea4093c7a4ac"), "Back", "Floor Back Extension" },
                    { new Guid("f26406a1-c555-43bc-9c89-a7041ac936dd"), "Back", "Deadlift" },
                    { new Guid("f274e698-9024-4819-bcad-96533e259827"), "Legs", "Half Air Squat" },
                    { new Guid("f2d24fa3-61e5-4da5-a102-9a7ab1acc222"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("f38731b0-5605-485a-b72d-8600f54c96c2"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("f5311e82-e833-4161-86b2-4eef8424599d"), "Abs", "Side Plank" },
                    { new Guid("f7b4799a-8358-48bc-853c-5999a1f95d95"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("f99b2c5b-dc57-422d-95ad-c9babb090655"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("f9e9fa2e-60c4-4f5b-8f51-bdda8afc526f"), "Shoulder", "Split Jerk" },
                    { new Guid("f9f23034-d041-43c1-bd08-01c250e0bcff"), "Shoulder", "Face Pull" },
                    { new Guid("fa459783-eb9f-438c-b46b-98b49ccb806f"), "Abs", "Lying Leg Raise" },
                    { new Guid("fa66b112-de86-4040-9c87-5357e1243ba9"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("facb8b8a-1bed-4f9b-9df5-b5da56a998fd"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("fc6f61bf-7405-44d7-8899-67e59f4e780d"), "Chest", "Dumbbell Pullover" },
                    { new Guid("fe882211-c0b7-497f-adce-2b01d6e73198"), "Legs", "Landmine Hack Squat" },
                    { new Guid("ff08fdc6-9bf1-48e8-96bc-b293b3718ef3"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("ff5121f4-d8c9-4d0b-828b-2a9bf0f9b775"), "Back", "Back Extension" },
                    { new Guid("ffce0bb6-a756-45c1-965b-ebd875a5e480"), "Back", "Dumbbell Deadlift" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutTemplateExercises_WorkoutTemplates_WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises",
                column: "WorkoutTemplateModelId",
                principalTable: "WorkoutTemplates",
                principalColumn: "Id");
        }
    }
}
