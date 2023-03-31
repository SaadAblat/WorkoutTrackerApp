using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class goodorbad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("016568c5-3cd0-4f74-bb4b-2777a17f6ee0"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("23129d67-d0dd-4921-b53c-27a6e10578f4"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("3ec8aa57-67b1-49f4-a130-0c14e4a4cc52"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("48b4b092-2841-4a58-93f3-e85e6ace5fc6"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("6f9e6a2e-32cb-469f-9130-05db9586b5c2"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("725e852a-0d7e-46d3-b16e-14ec9f014c04"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("79fadf03-f577-4400-9f31-33b7a551fd4a"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("8dbffdbc-91ab-498e-bcd9-4bc7343aa64f"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("95e3d5c0-448c-438a-9a42-383ed5a4ef12"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("fca8cfe7-3b3e-48fa-9ab5-d0628ca163b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("033ea26b-8e97-4773-9995-74c06b80856e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("034c582e-174d-4fa8-bd67-63fa7a9ebefc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03b90fa2-2d3c-4c0a-8c0a-bef3c16f149c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04667907-b2db-4a75-b379-ed4c220e88d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("048dda5a-cdf5-4bac-952a-96ede565d1bb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("05757966-d938-4e31-b3db-a257d0a55c3a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("09720b48-ebf5-4ab4-adf3-ee5eec2401e9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b2d9408-029a-489e-9566-8d8778360260"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bb0b2af-bb64-4105-ab1c-ca8d50748b4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0dc12295-b063-4b53-bd1a-818a6327b721"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0df7b442-a226-45f5-a31c-9016ff57d6a9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0ed233d6-5fa5-4702-97e4-c0d7ac5c6bfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f3949b0-77ae-42ac-b352-deaf29484797"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("124b65b9-83d7-4f62-a66a-b156102309a2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19b8a8d3-4654-48f8-ad5e-45111686b3df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1bb9d39d-f99e-4b98-ac79-6581bf148212"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1e01f901-b753-4397-a218-fd05bc0d5396"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1edf5411-1cfb-4452-bed9-fa13b46cabe0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f520b11-b67b-4bd3-ba64-a77232b06f3e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f60eb90-a3cd-471b-a1cd-b1996197130b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("206a9441-00d3-49d5-901c-7debf49f81cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("218359e2-1ee9-4109-97d6-c61860f66df7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21efddf4-c150-4b31-b214-c83a803dd0d8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("258f7633-0ff1-4f19-a67b-6f9db481cff9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("25ad0412-0871-4fe8-a934-622129fe5c5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("25b83620-68a5-4cd9-9fe5-e906069c83e7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("25cdead0-8bfb-4253-b927-dae9ce61c903"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26906710-bdb8-4dc4-a47c-3f4e1a4ebf39"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("29533f69-8e20-435f-884d-fd827cbbf728"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a0a3c9c-8349-430f-98f1-1584ecbff42e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2c7fb9b3-4629-45ee-852d-619240112b99"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2d6aa6eb-6227-4fd5-8c12-534ad35a75d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2db58e3a-11b7-45c5-8bde-fae11476ecff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2e0ab3aa-47f3-48df-bc8e-5c78956f1310"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2e816f0e-dcc5-48f1-a7ee-79b562a810e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2f80a8aa-fbdc-41fe-964a-41b907d52bb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36426cd5-bed9-47fa-b74a-9e9b635469b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3665a6bb-29e3-45ac-ada1-c4946aa72ac7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("37b5ce94-34aa-4043-b522-937ffa265f83"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("37c40175-c70b-45e6-be3f-d6374989ee70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38d9d86e-7979-4d83-8f00-0c2c687f5576"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a7818d4-5cab-4cfd-8d2b-b43081a0b739"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a9de4a2-ac91-4fc1-88dd-72d3ccf71548"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b648218-ef48-4ad3-ae27-d2785b752062"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d02318d-3194-4e5a-b489-33a7e469f0fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d02b1e4-3ee9-44b0-8018-c2a5c59618b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d91b906-8d75-4c5d-843c-ff81153d449a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3df922e6-6502-4d15-a17a-b3cd51ac03b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f18edb2-e438-4546-bd2d-2b3acc421496"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3feb669b-d009-47fd-a323-92b4f0af0bc5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("41ed8105-7244-4b47-8f90-4589dc4cacfe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("43d541b3-3fa7-4159-8a4c-8e907d681276"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("458500f6-584c-4bc6-afd2-ca090b128b5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45c3456b-a996-4d1b-ae97-384b46230305"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4832df09-1273-4c15-b3cd-55b20af64b70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("484279b5-d57b-4e88-8850-c407696f9b86"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("48d83a48-1f2b-4f7d-b753-2f705c20a95a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ab14c44-b39c-4ef7-99e8-f11b3b042d3b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b3bcb38-8a47-4ab5-ac6b-3d94676fb77e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ba0f9b5-a4de-4494-ac90-b230b656b63c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4deb0b17-b59e-4a7a-861c-3b753258f715"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e56600b-ae9e-4028-a1c4-2ff53919af33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4eea2cd2-1004-404a-aff5-1b95c555930c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5282861f-f134-4f1c-bd7a-f6be087bbbfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("53a1baea-9e19-43c7-a726-ada7c4c71e9b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("555af316-f944-47ec-9aac-d05b2d96bc8e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55bcf651-0254-4e1a-88e6-b53c1747dcd4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55d325b8-ec65-43ab-8aef-7a2d51f2103e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("584fbaab-e3a0-43f4-aa59-afe5b3a825b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("58aba172-fc9b-4eab-af93-6a34d5896291"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5a28c87d-79ec-4e67-9772-d0fe5bda7635"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b4a0dae-a48f-4916-b199-cf3cdf14b527"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bbfc50f-745d-4d79-a11b-9e205c6ff5d5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bf730a3-5a0d-44a2-aa9d-355e724d5394"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c92f57d-1708-478d-b0c7-23b5a0846445"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d0dc4d1-1c4f-480a-b776-7bcc161279f0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d30c0e1-902d-4a95-8bef-9930c00f641e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61f31a23-9421-4c05-9f90-3722bca9b708"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("622bb426-3547-4b23-a09e-e2dcc5e4ca35"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("62a6d7ca-ee57-4bf0-8b5a-d3ba49aeccdd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("631f0896-3ef0-4f56-8629-69745140d9a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("678eb8be-d4db-41e5-ba92-fa067990e482"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6896320d-530a-47f0-8bf8-5e50f8ab4580"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a53bd78-769d-4da9-bdd2-ca40b7f05a17"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6cec8630-c0b5-4d04-9ea1-d1d5c033fadc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6db21f7a-61d6-4820-847c-4d0b3f897ded"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f926583-d634-45f9-86c4-5f4bde333162"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6fb6a522-f7ce-441d-a3d9-dff9241e4fe1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("714aae75-7c68-4d83-8534-22643eb63e98"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("746ee8f1-2285-4831-b4ec-ea587b672fb4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("754cdfb5-bf58-4f1e-abc2-1f6ab20c0a58"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7588af58-5ae3-4ad4-9d53-e016efcc7b55"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("765acc5c-5c61-4d96-a9f0-265dc40db623"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7952ef17-2ae3-45c2-8457-255985aad903"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a73307a-e44f-4187-beb2-041b2e12a385"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ca21ad2-1fd7-4680-a507-43af2c787357"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7dc4a4ec-f1fa-455d-b9f7-3a4f0aba2d1c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7f7e89fe-09f8-45ab-9288-506a12e06580"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("81d1ce73-9a94-4b99-944f-2196f486b678"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("82cbaafd-c3ab-448a-98c6-a9e1b182eee2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8376809d-040f-4ef5-83cf-8935c34a5a25"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("840a4b47-2907-41b5-b32b-925d0235ae88"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("84c6826d-df48-4bb2-a7d3-3ea0555c97e9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85b012ec-bb23-47f2-ae4f-57f3c6916e93"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85f85077-86c1-4a89-8b79-7cff5b42818d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86be765c-32c7-4295-a6e4-36264d510db3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88ab2c36-cd07-4f32-8a3a-284c7b4fd82d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a546453-e079-4022-80d2-a33cfbdb1f1e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c2d2323-f160-4829-9026-e5704b70c667"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8eaaf47c-01d3-4eb4-a017-437dc0bb18a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f205d9d-f293-435f-9ccf-4983fdb90d8b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("91e0f681-d564-4425-9ef9-387cc62df8ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94bab4b4-cc54-4670-9ba6-a067ce4c4570"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94dcb7e7-5a6b-4960-b202-ceb2bd2e66c4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("973dad7b-c969-42a3-91b4-b278a3c4a188"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99299933-b5fc-42ec-ba23-fbf6e7baf98a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99396d63-c2e3-4509-ad86-b0a845603528"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9beb2d3d-8ede-4fe8-98cd-5cd36d61b0db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9c08c21a-f80b-4eef-9265-c36ad1d43a0c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9c47b282-1eae-409a-9fb1-10937215059a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9f2653bc-2573-4517-b65d-896927470ed1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9fac6bf8-2c6c-47c9-be87-1c605e37302f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0b269c5-3d1a-4228-9c34-2dbdbe7a7da4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a44838bb-952d-478b-81d0-c991bf6b49a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a7fd1d1d-4895-4915-8f5b-1c1e275a4fbe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a8fcff19-8c5c-4181-819c-fea9a6aea94f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9d8d845-1dfe-43a6-a806-7f37101e5a50"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aaeafea7-26ac-49d2-8719-cfa32b6d8ee7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad789009-f30e-47ba-a1a6-d8ea5ef14604"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ae11b0e3-ac1b-4a29-8598-48ec5c95ba9e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aff381b5-ac9d-4eb5-9b34-fb72038bca23"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b061c779-0f91-4a94-8f18-f39808ac2c6b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b14a2fba-f2d4-4e4b-b974-3ff6743c2260"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b16dd8f7-ae6c-4adf-a74f-7f181446cdde"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b2c6a3e4-a4aa-4df5-b7cb-bd66f714268b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b37b3cbf-ff58-4950-9bba-3eba41688e1e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b44f2081-630c-461f-87c8-37b36159eec7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4c1ba1f-7aa0-4520-9fa4-e07e81b8533b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b6c48685-5b16-4ba6-92e8-8c0e10d1b304"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b6e12441-e648-47fa-84ea-d2d15a5ae084"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b70c7da1-3003-4e92-8039-fde27d5cc0c9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b7981448-5fc4-4a69-b912-7510d9f873e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b80c7f02-dfe7-47d7-bc10-648223c258ca"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9226601-0d61-458d-bd62-8240944d2895"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba1cbf6d-cd78-4a45-977e-7d94a95e1026"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba220896-0f4b-4453-8398-9959a8252682"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba44f835-96ff-4aed-b277-160dafc1242e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bba4b8d1-7fb8-4e9b-9ad5-10c522598fb1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc3f90d7-6569-4e23-9a4d-50417a594c35"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd9adfc4-0106-48cd-a139-0b3193f14813"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bddc552c-9750-4f52-98fb-87318d519e1a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be2d00ac-f580-40cb-be93-af43e65e1044"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bee9dfca-613c-4245-a51e-20424db428c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c0a24e3a-938d-4124-a398-339e0d2ebcaf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c404ec99-ca77-4d58-94cf-6e773a58925a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c4b34eae-1d4f-4ed5-8db7-f3fd9207fd51"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c611c960-c247-445b-acf8-bd72986f1c04"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6c3a193-0b4d-4bb3-9b69-49b63b259c68"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c7634cfe-0b08-499e-ba78-cc376f47397c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8abdce9-44a1-4e31-ba95-a9b4a684a3c0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8ad38b9-669b-4a59-a3c7-7efeb1468563"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8cada9f-84c7-4535-b849-9695d2468fcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ca5b661b-30ef-48f4-94cb-6d747f52e4e6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ca978095-edd1-4b87-913c-159eb3ad64f5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cab39b11-8f73-4aad-a06c-d1b04183c26c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce44921b-2c9b-4a6d-b490-84f884abd569"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce4e08af-b068-4dcb-bebc-3da8a8c866a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0313d5a-277c-4979-83ff-966326449f6d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0d8ec8b-7702-4078-ae7d-16c72770507f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d10e6cda-b13d-42db-b2f8-ac9425c90097"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d27515db-cb90-4010-a389-a47576099341"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d2d3e4c1-1091-4bda-96a3-3bb6f99fb3d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d38aa0ce-dce5-4afd-82ba-829236c4dd96"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d675d13c-721c-444f-925e-d73266bff284"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d704491d-10bf-4676-bfbc-a4afb8bb19bf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d759c60d-ad87-4291-b70d-e50d4dbf2f6b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc0624fd-2ac5-454c-9ca2-d9774598a9cd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc409030-66a4-42e4-bb3a-cab52f6953a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd45f168-d9fd-4d6f-b594-bcbed133e4c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de4e728c-a692-4854-b9f9-2acc52e9af5d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df074f77-97ca-4958-b94a-0f3f089aa1fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df2179ef-0e93-4b6a-93a4-c45997cc92f2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e27f67f9-b409-4d52-a4b6-7eaeee007b1f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e2847785-0830-4322-9582-2ad87ef6346c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e2e349a0-453e-486a-ab74-a0c4be5d97ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6a6b340-37c3-48b6-9de9-7db9c7528eba"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e769308f-f4f3-4948-8e3c-0bd2bff5d606"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7e29fea-c462-4928-89e0-4a4124c3700f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e85e458c-3bd4-4775-bb3d-f7cddb06f236"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e86d4ede-169a-4eac-9067-0b796b190e57"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8bb3813-e5bb-4198-8163-a5357155b3e3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8d7e280-3c1a-4313-8516-8028e9885412"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e9fd8912-265d-4bda-88af-4f641d32b4dd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea679a41-f27a-464d-b894-4a5c2a22ea70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eaafd368-215c-43be-bf35-0550a92420a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eded6391-79c3-4712-a589-d5a1d3c780fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ee609e86-3349-4017-915a-c04c1cfc2441"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0b94bbe-313a-4e28-8e2b-30dac0486aa3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f362557f-2e47-44a3-828d-75a0a3bd60b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f51de068-e2ea-4dc9-a655-4e1a9b426062"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f5b4d527-d974-4f14-94bc-a55781592710"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f5c683d9-7d43-40b1-9f9e-2fa251de569b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f6b9579d-0072-482d-a7b2-93195b383c92"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f80038eb-7458-49d0-9c9d-68a1aa4f8e71"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f852455c-330d-4afd-8db8-40632c1bedc3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f8b871a8-c7b9-4ac5-847e-3d15d5b02dfd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f8bcd84d-d72f-45dd-ad84-cf2733bc87f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f940fc24-96af-4a6f-a369-dc80b72465e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9aaaee7-967f-4c58-b461-243848fbe07c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9d0cd75-09e7-4e74-aed4-f251f67902f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa56c2bc-b1d4-4c5b-aa27-2b36e0cb25fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc21fd9b-bcac-4f50-9174-67ca13ee6208"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fcb537fd-62d4-493f-9062-57ef67b65538"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fef3d9f6-2d6c-46d5-9095-857ffe627bcb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff997f88-844b-49f7-8f88-3b80234a4ebe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ffea98c1-3374-4bc0-baae-a416182a37fa"));

            migrationBuilder.AddColumn<bool>(
                name: "IsGood",
                table: "LogMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("49cc7000-70a8-4c04-8c40-125905e3d4c1"), "Back" },
                    { new Guid("6044f227-3cfd-4f9b-ae75-f1170af72cbd"), "Chest" },
                    { new Guid("609eddf3-a658-4393-b922-db5ac206a7e8"), "Forearms" },
                    { new Guid("650c7799-d50c-4e74-bab8-a02048466682"), "Legs" },
                    { new Guid("6e00939f-73c8-467f-8c65-0ef7e24fb9cb"), "Abs" },
                    { new Guid("72b7028f-49bf-40c3-9365-407910b4d527"), "Calves" },
                    { new Guid("7e73d33a-aaeb-4269-bc78-f19fc1704998"), "Shoulder" },
                    { new Guid("936d15f5-cba1-4fcf-98f0-890d0e4041be"), "Glutes" },
                    { new Guid("a36ce8dc-90cd-4da7-aac5-8acdb909d59b"), "Bicep" },
                    { new Guid("eefe92f6-ebaa-4c73-9299-4eb894f7c051"), "Tricep" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("0041fb3a-5dc0-4d6c-9b8f-ec239ea01d06"), "Back", "Pull-Up" },
                    { new Guid("029e1fd9-f4fa-4a3d-8038-cd65fd76c014"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("05e68089-801c-4d4b-a2b1-d53dde6c3f12"), "Abs", "Dead Bug" },
                    { new Guid("07108d94-e307-4228-aba3-7daecc1a0c56"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("07847076-96e5-4369-8c1f-7dfb05d564b4"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("08b55824-6109-4372-8d39-f35e65c7c886"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("08cea3e2-7fbd-4e37-a2b3-d54bdd6362b9"), "Forearms", "Farmers Walk" },
                    { new Guid("08f05cf5-8305-4a6d-a418-604485cdec7c"), "Calves", "Standing Calf Raise" },
                    { new Guid("0a793c65-446a-4b09-b12a-5faffe10dd22"), "Shoulder", "Overhead Press" },
                    { new Guid("0b6b54a3-24d4-4ed3-b511-ea949e261688"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("0db66a5c-8c32-42d2-970b-a680ad7560ee"), "Legs", "Goblet Squat" },
                    { new Guid("0edf4d7a-9772-4d17-ba79-062e6230cb60"), "Chest", "Bench Press" },
                    { new Guid("0f784dc4-36c4-46d3-a9e5-e85bc01992d7"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("1227d273-8d40-439f-a0c5-f56b3f1e3f61"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("12482f73-8b91-406f-8078-9046792eeac7"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("12dabbe5-48b3-4719-8047-de1985f6aa8f"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("131f1a17-ad9e-43a0-8cfb-4febc1c44e80"), "Shoulder", "Split Jerk" },
                    { new Guid("13a96737-828a-46b2-8375-af359f79361c"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("149b25d0-c31f-4638-aee4-ce8be4680c31"), "Glutes", "Cable Pull Through" },
                    { new Guid("163b130f-c099-4bf0-9dbb-508094ebeed0"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("1658f996-1108-4377-a1ea-d7e40836b191"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("180d59c8-2b98-401b-9ceb-37f591a238a5"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("188ab3b0-29b1-4271-b41a-ef1da1ebd8fd"), "Shoulder", "Push Press" },
                    { new Guid("19335021-26bd-42fd-a4f7-6d4a0d3a338c"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("19ab5b69-c604-4f60-8fdc-7484cba124e2"), "Legs", "Front Squat" },
                    { new Guid("19d64060-7ea8-4531-9bc8-0dbf8639b326"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("19fba112-8872-4164-b0a6-d698d7bf1d32"), "Glutes", "Step Up" },
                    { new Guid("1a818793-57aa-4c0f-b5bc-deac638a8aa7"), "Tricep", "Bench Dip" },
                    { new Guid("1e5b0be8-fbb6-4a3b-92f6-d91d50071e12"), "Back", "Clean and Jerk" },
                    { new Guid("22f4fe07-586d-4ae7-a2a1-5dea6bfafc56"), "Bicep", "Bodyweight Curl" },
                    { new Guid("2623f9d5-e5b8-4ca1-85a6-337673e0ce90"), "Shoulder", "Front Hold" },
                    { new Guid("2a65fc6d-dabc-4163-a986-981ade9dd12e"), "Abs", "Sit-Up" },
                    { new Guid("2ca8d00d-8800-46c6-bc05-b857ced114d9"), "Chest", "Floor Press" },
                    { new Guid("2dc55bdd-e9ea-4057-adab-97b3712f3779"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("2efe0cb1-4b05-4c33-9423-ff995f862efa"), "Legs", "Squat" },
                    { new Guid("2fce68b6-5dd7-40fa-8994-f55619d2010d"), "Abs", "Machine Crunch" },
                    { new Guid("308f23d0-b6cf-4ee4-91f0-57ce01123fbf"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("34266793-ce80-4a0e-8299-32ee382fcd3e"), "Abs", "Lying Leg Raise" },
                    { new Guid("34a5978f-970e-47d2-811f-393e63b6d9ee"), "Glutes", "Fire Hydrants" },
                    { new Guid("3613c8b0-256d-495a-b756-30092c3447cf"), "Chest", "Bar Dip" },
                    { new Guid("38a49a2f-0429-48f1-9156-aebaf3bf3bd1"), "Legs", "Barbell Hack Squat" },
                    { new Guid("39749d3b-d734-4f1a-a159-b59c22c79cfa"), "Bicep", "Barbell Curl" },
                    { new Guid("3ae1e68a-477e-4262-a66e-e31cd3adb077"), "Chest", "Cable Chest Press" },
                    { new Guid("3b05da29-47a4-40a3-9b1c-4e386502f3bd"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("3b22650b-287f-4ecb-8cda-cc19e7b6514c"), "Legs", "Air Squat" },
                    { new Guid("3b6feb44-0c2d-4093-a65c-683e91926841"), "Bicep", "Spider Curl" },
                    { new Guid("3b9dd33b-558c-44bc-9e8c-bc63fe87ba08"), "Abs", "Cable Crunch" },
                    { new Guid("3d5a5372-fc1c-42af-a338-e6eda0348dc5"), "Glutes", "Banded Side Kicks" },
                    { new Guid("3d6318fe-2edb-450d-b6d8-f7440ff9b773"), "Calves", "Heel Raise" },
                    { new Guid("3e5584c9-eb22-44a9-9fc4-75464a18d16e"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("40500f2c-783d-4b55-881f-ac80e678541e"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("407a793b-10db-4d36-b962-cb038d87af6e"), "Shoulder", "Plate Front Raise" },
                    { new Guid("40dc6716-981b-4359-9255-5675f8218b5a"), "Back", "Dumbbell Row" },
                    { new Guid("424f6263-19f2-4a1f-8a26-b74719986fc0"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("42ce90d2-844a-465f-88b4-26b022ee98d7"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("439e7db5-c92b-456d-9e3a-888a86c3df9c"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("43e2d1f6-4c8b-4beb-893c-b24d63ee00f7"), "Abs", "Oblique Crunch" },
                    { new Guid("45d7658c-f2a0-48e3-868e-e820abe6864f"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("4688330e-7874-4e45-8000-9efc7d671121"), "Abs", "Oblique Sit-Up" },
                    { new Guid("47f7c32b-2b2d-4532-a1a0-592c33c95a65"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("482ef4a9-3a08-4969-8ef8-e54522ca0689"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("487a2173-1a1a-41c3-80bf-b85b898c17fa"), "Glutes", "Glute Bridge" },
                    { new Guid("495ce8a9-d210-4f5d-8271-272f1f543507"), "Legs", "Box Squat" },
                    { new Guid("495de907-f723-45e9-bc2c-16781e62aa36"), "Abs", "Kneeling Plank" },
                    { new Guid("4a857562-0e98-48d8-a91e-4aabca5fd3ed"), "Legs", "Romanian Deadlift" },
                    { new Guid("4d0ea263-0c27-4778-b2d0-2a518f81abc6"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("4e28e902-dd46-4570-b6fa-4ba7270fa706"), "Back", "Kettlebell Swing" },
                    { new Guid("4e993101-ea78-43b4-bc4c-3437ce34bfd0"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("4ee74951-85b6-4c23-99d9-144d24401e57"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("4f184b2f-e9ea-4a03-ab0a-b8524c5734fa"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("4fa41256-c50d-4aaa-a701-55ff50115c38"), "Abs", "Mountain Climbers" },
                    { new Guid("50ee5d09-20be-4aad-915f-6d5d06ef2404"), "Chest", "Kneeling Push-Up" },
                    { new Guid("526d5acb-895e-4a88-8881-4174e1e58f98"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("533c2f51-c323-4033-bdb0-12cb4c3e7c38"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("55598cef-fa0c-44c4-9359-08e6f66233df"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("55af9be8-2390-4f6c-8c74-4d04e9fe3920"), "Glutes", "Hip Thrust" },
                    { new Guid("565bbe8f-b0ba-4c86-b6fd-d963aa7af803"), "Abs", "Kneeling Side Plank" },
                    { new Guid("5870145d-924a-40f2-8683-b9e78c8257fb"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("5af55993-f90a-401e-b3ad-9232f7694524"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("5c4324b5-053a-469c-95db-40ef7297e9c5"), "Back", "Chin-Up" },
                    { new Guid("5c98f2f8-c5ea-4ebb-bc58-dc1ad2b12fb7"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("5e887fe0-8404-4668-b5f1-6937ec1f8f84"), "Shoulder", "Power Jerk" },
                    { new Guid("5ec3b754-2b94-4540-b188-f43fb649b118"), "Back", "T-Bar Row" },
                    { new Guid("6096f0b7-ed7d-4aea-b234-5f8b43a22235"), "Back", "Dumbbell Deadlift" },
                    { new Guid("61b747cc-1bcd-48a5-9ee4-aa15a21c097f"), "Abs", "Crunch" },
                    { new Guid("62f8b964-bd2f-4a85-a05c-22117a5c1956"), "Legs", "Dumbbell Squat" },
                    { new Guid("64f6b49e-dfdb-45cb-9e4d-0216bdec4dd7"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("678cfea0-e8fa-4221-9847-f1dee7d3d8b4"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("697a38bd-b80c-42e4-8f0d-84dfae8ade43"), "Back", "Hang Snatch" },
                    { new Guid("69a9318d-d6d4-4c8f-940a-8090865dbcf4"), "Legs", "Dumbbell Lunge" },
                    { new Guid("6a29d4b5-6c24-45c5-88c0-b53b7831b81a"), "Back", "Seated Machine Row" },
                    { new Guid("6add4412-c4a1-4200-82b5-a4ed701a3dc4"), "Legs", "Body Weight Lunge" },
                    { new Guid("6df7049a-9487-4667-8cce-c30ad06bb7c6"), "Legs", "Barbell Lunge" },
                    { new Guid("6e86b89d-f983-4029-8b1e-1471d441ed62"), "Chest", "Machine Chest Fly" },
                    { new Guid("7016341b-0a84-4438-8ec2-8e684745a458"), "Back", "Back Extension" },
                    { new Guid("70872b1f-f01b-410b-b7e2-6b9d2e11bc33"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("70b0ce15-698a-444c-b3ed-e88a994208c5"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("716d0bd9-8dc4-4cc4-8e30-752fd04084a8"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("71a4d279-835c-4d78-9904-6b8af1edc55e"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("71b4a2d8-4755-415c-ae2f-ee3a64955cf3"), "Bicep", "Concentration Curl" },
                    { new Guid("72ad5183-d6fa-4ca1-9374-be6cf1216921"), "Glutes", "Clamshells" },
                    { new Guid("786b8120-7b56-4a15-b762-99d09c706abf"), "Chest", "Push-Up" },
                    { new Guid("790bfde1-773f-4b75-9ced-7ad9d86adf55"), "Glutes", "Frog Pumps" },
                    { new Guid("79d6705f-2d9b-42de-8040-5a4d34905f30"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("7bda4894-b399-4160-911f-75a63a794ff7"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("7c1548b0-515f-49c8-9198-79deebb10010"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("7c92a5c0-e22c-4222-b9ca-3921d4c0ca0f"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("7d35909b-17db-4d23-80a4-dac91cafc41d"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("7e117529-2687-4788-a784-1e02b390c2f2"), "Legs", "Chair Squat" },
                    { new Guid("81dc49ff-c496-420e-b21b-b4483ed37111"), "Back", "Barbell Row" },
                    { new Guid("82561a21-ddcc-46b6-b9de-9d6ffbe04c7a"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("8303bfbe-8a56-4306-8423-2ba4ac6f7d0d"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("83f1231b-da17-47ff-bf6e-6131deab07b0"), "Shoulder", "Monkey Row" },
                    { new Guid("87de685b-b06c-4223-ac6e-cf9650f4d325"), "Abs", "Hanging Leg Raise" },
                    { new Guid("87f824ec-5171-4628-862f-edcf4ce94507"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("88c48307-0d6d-4313-ba2e-de6db7a2fb46"), "Shoulder", "Squat Jerk" },
                    { new Guid("892f22fa-6b1b-42c2-bc78-dee0e83374e2"), "Bicep", "Dumbbell Curl" },
                    { new Guid("8a3c5a5e-feab-4865-ba21-525b44d10b58"), "Legs", "Step Up" },
                    { new Guid("8a556523-0059-447c-92ac-3f444d3cc675"), "Back", "Clean" },
                    { new Guid("8a85b4ab-593d-4ce6-8ada-75bf38d4926d"), "Back", "Hang Power Clean" },
                    { new Guid("8aa0591a-1f0b-4aec-b7cc-c4012fc043e8"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("8aecb487-4b8d-4ecc-b297-8043672d7db6"), "Back", "One-Handed Cable Row" },
                    { new Guid("8baedd5e-53de-45de-b5a5-120398556c3a"), "Calves", "Seated Calf Raise" },
                    { new Guid("8c22e5e7-2a84-4ffc-b7b6-977e3b7895f3"), "Abs", "Plank" },
                    { new Guid("8c405160-9d44-4ab1-ad5c-de1282b202b2"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("8d7ec38c-11fe-4f40-8e19-d3d80b13044b"), "Legs", "Pause Squat" },
                    { new Guid("8ee3390f-1000-4f82-b710-be7a0b362dce"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("8fab89f8-2dbd-40ac-9f06-54a38ac508ad"), "Back", "Deadlift" },
                    { new Guid("903efb06-27d8-4614-9766-81efe0a07bee"), "Abs", "Side Plank" },
                    { new Guid("91d9ce83-de20-4416-a10f-d7b85b09156a"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("93956123-627c-440e-bf34-9d973760020c"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("94a5b562-d368-47f1-ab26-95bce9edc5d9"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("94f51fc8-de0b-403d-8dc0-4b951170336c"), "Legs", "Seated Leg Curl" },
                    { new Guid("956f2676-1435-4c83-bfa5-12057e02c46e"), "Back", "Pendlay Row" },
                    { new Guid("9adadd48-7107-466e-80e3-1657f41e69f6"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("9b19f84d-4629-4533-89e1-ad7820d084f8"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("9d4936d9-9bc4-4323-99fd-c60667115072"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("9f76e667-8ece-46a2-bbfc-aa10b6117281"), "Legs", "Safety Bar Squat" },
                    { new Guid("9fd9fcbf-1bc3-4e73-9a36-05d2f97e6b1d"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("a013216b-4944-458f-a346-32cd7c6bc4f0"), "Abs", "Hanging Sit-Up" },
                    { new Guid("a2394303-dc72-4994-b591-82d5815965c4"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("a27ca2f9-993c-484c-9cbc-a8e4e88cf0ed"), "Forearms", "Plate Pinch" },
                    { new Guid("a2cb10bd-fb30-44fd-acd6-6dee9e15aa5b"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("a44e5096-a6c7-4324-99d3-5fcb197c2fbe"), "Legs", "Lying Leg Curl" },
                    { new Guid("a5ca562a-f7db-40f3-93ed-205e74bf0252"), "Legs", "Leg Press" },
                    { new Guid("a78752ef-b254-4441-880c-a5615d9fd806"), "Legs", "Belt Squat" },
                    { new Guid("a92545f1-0889-4439-a2b3-ed9d46f2f25c"), "Back", "Snatch" },
                    { new Guid("a944c998-041e-4d28-beee-0c2b50d7dd3b"), "Chest", "Incline Push-Up" },
                    { new Guid("a9dd989e-42e6-4762-a26e-c8bb6bbc0a78"), "Chest", "Incline Bench Press" },
                    { new Guid("a9e0d951-5a11-4b10-9060-710516bf422c"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("aa8d988d-ee47-4eb5-9327-c06fe0733726"), "Back", "Dumbbell Shrug" },
                    { new Guid("abe004a2-c979-4109-92bd-e6b1b8576d7a"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("ac1701ee-8454-4219-8b1a-4b8421b3a3e6"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("acbb9f2e-da5b-489e-93ad-9d3196d3dd9b"), "Chest", "Push-Up Against Wall" },
                    { new Guid("ad17eaeb-3af0-4b7f-9022-30e835aed98a"), "Back", "Pause Deadlift" },
                    { new Guid("ad4c3dea-aa73-41cc-8638-8a51735e751b"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("af6325fd-5b6a-45a1-8dd4-bc0d41d8bcde"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("afff35dd-8f6f-44f6-8976-830a6ca06e08"), "Back", "Barbell Shrug" },
                    { new Guid("b22beb7e-35de-4ce9-8535-4c5e3018a170"), "Legs", "Step Up" },
                    { new Guid("b43f70a5-1a7b-411f-8d91-6c907a4b506d"), "Back", "Hang Power Snatch" },
                    { new Guid("b59827cb-533b-4bcd-8031-a29343b5f607"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("b5997514-1372-4f68-b240-8ff2c6ff363d"), "Shoulder", "Face Pull" },
                    { new Guid("b8fe536e-a3f3-4ace-a617-4a3fcb0e41b1"), "Back", "Hang Clean" },
                    { new Guid("b99f26f4-4a9e-48fb-b361-3e988bc792b0"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("b9e12429-f422-4fda-9e54-020c32556d74"), "Legs", "Hip Adduction Machine" },
                    { new Guid("bb4e65c1-7838-48f3-bbe4-95ebf74e7860"), "Chest", "Machine Chest Press" },
                    { new Guid("bb6fde02-9aea-4ad2-9084-9da790f3b5ac"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("bc976696-cbbd-42bd-b2b0-d68b79619734"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("bd4dc3eb-3b9a-4431-b356-0091507bb6b5"), "Back", "Deficit Deadlift" },
                    { new Guid("c11fe583-4f37-415f-b902-41fdd80eff31"), "Back", "Seal Row" },
                    { new Guid("c2f6633b-3a4a-43b8-9947-19bdee26b662"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("c4e08791-26b7-4c23-bc61-ea8eb00ee9f9"), "Back", "Power Snatch" },
                    { new Guid("c5d9b183-9d56-4a7f-8e6f-713325ea63d7"), "Back", "Power Clean" },
                    { new Guid("c630d392-b4f1-462c-9bdb-7c2d9324f528"), "Chest", "Decline Bench Press" },
                    { new Guid("c739ffee-f0fa-4c2d-b0b6-53edc1baf33b"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("c73b6abb-d41e-47f3-a853-f7ab889821c2"), "Chest", "Pec Deck" },
                    { new Guid("c74354f0-a58f-4fc4-a0a7-8254c9998737"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("ceb5871e-b02f-4fb4-8bd7-e7a0d1e5c6b0"), "Abs", "Hanging Knee Raise" },
                    { new Guid("ced02723-3548-400e-b2af-fc67aab1bd12"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("cf66f399-f4de-451c-a588-a30971975e2b"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("d2c0ddde-368f-42b0-9fab-8694198bff07"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("d49bcf8b-7e64-49bb-8d5a-86d8f5bb46ce"), "Legs", "Landmine Squat" },
                    { new Guid("d5a3606d-9141-4ed6-a541-0ba8bde25ff0"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("d72e0ca8-40c2-4c4a-ae96-2f893ba9415f"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("d9024d38-563a-4579-b4a8-743e596b9de0"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("d959e638-fffe-4a8c-ac43-c03834343d94"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("dd73057a-c5c4-44b0-906c-0470ce7e04d5"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("dec7548f-41c1-4559-b731-6f1885db8097"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("def4ff29-5df3-497b-9be7-12a9f0f27dc6"), "Back", "Floor Back Extension" },
                    { new Guid("e061499a-5738-4993-b57e-9118bd52242f"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("e09c67df-2dd0-4fda-9554-97f53925aec4"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("e0f0f6ac-5d8d-49b1-ac0f-3c021a7ad4d3"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("e53afb17-5d09-4e5e-8387-e6440cd4347e"), "Back", "Sumo Deadlift" },
                    { new Guid("e6ee7b66-1ec8-47ea-bcb8-87baa1fa213b"), "Forearms", "Towel Pull-Up" },
                    { new Guid("e88ea8a2-9e81-4666-97d7-4ae39e9f0db7"), "Legs", "Half Air Squat" },
                    { new Guid("e9517a56-f42d-4a48-bba3-d792b8b76c1f"), "Back", "Inverted Row" },
                    { new Guid("eb40f2ef-e1de-4abd-afb3-8d52d8576c06"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("ec8bfc2f-bb36-4bff-bdf6-a99051618db4"), "Legs", "Smith Machine Squat" },
                    { new Guid("ed0fcfb3-6b9d-44ed-ae3c-b63022c67d47"), "Bicep", "Hammer Curl" },
                    { new Guid("edc222a2-c342-41da-a8e4-3b90ddba3e2d"), "Legs", "Hack Squat Machine" },
                    { new Guid("eeefcac2-1ccc-492d-af82-68153305289b"), "Back", "Block Snatch" },
                    { new Guid("f07c366e-2da5-4247-9077-b210d5f16559"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("f124e591-7c77-49b9-a330-2071ed24afdc"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("f1a2b909-ebde-4660-964b-42b938256c57"), "Back", "Rack Pull" },
                    { new Guid("f341b504-01d0-4f45-adcc-5f12b3db6a8c"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("f3d27ef4-e3fc-48a3-a513-0b72379562b8"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("f3e35f40-3887-43d0-a890-b617bc6b1c0f"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("f43e2ea4-09fc-4924-be25-1ff6062c0ddb"), "Legs", "Leg Extension" },
                    { new Guid("f57aec81-a2bb-4f81-b2d2-8d0643b0a327"), "Forearms", "Bar Hang" },
                    { new Guid("f581c6a2-0c0f-408f-ada2-15c4163949a1"), "Forearms", "Gripper" },
                    { new Guid("f9b2edb2-95ed-434b-8e39-097b45707fb1"), "Chest", "Dumbbell Pullover" },
                    { new Guid("f9c34bfd-23ae-4bba-ba7e-5a1107a56044"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("fa1346de-cd16-4b88-a868-3b785f58191e"), "Legs", "Landmine Hack Squat" },
                    { new Guid("fcaa84af-d8ea-46a6-bbc5-da1c7806d991"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("fd993f7d-6b5a-4477-a13f-3f9ccac2ba34"), "Back", "Good Morning" },
                    { new Guid("fde9b6a4-5ae3-4974-98f2-a480d05f8538"), "Glutes", "Hip Thrust With Band Around Knees" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("49cc7000-70a8-4c04-8c40-125905e3d4c1"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("6044f227-3cfd-4f9b-ae75-f1170af72cbd"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("609eddf3-a658-4393-b922-db5ac206a7e8"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("650c7799-d50c-4e74-bab8-a02048466682"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("6e00939f-73c8-467f-8c65-0ef7e24fb9cb"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("72b7028f-49bf-40c3-9365-407910b4d527"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("7e73d33a-aaeb-4269-bc78-f19fc1704998"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("936d15f5-cba1-4fcf-98f0-890d0e4041be"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("a36ce8dc-90cd-4da7-aac5-8acdb909d59b"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("eefe92f6-ebaa-4c73-9299-4eb894f7c051"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0041fb3a-5dc0-4d6c-9b8f-ec239ea01d06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("029e1fd9-f4fa-4a3d-8038-cd65fd76c014"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("05e68089-801c-4d4b-a2b1-d53dde6c3f12"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07108d94-e307-4228-aba3-7daecc1a0c56"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07847076-96e5-4369-8c1f-7dfb05d564b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("08b55824-6109-4372-8d39-f35e65c7c886"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("08cea3e2-7fbd-4e37-a2b3-d54bdd6362b9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("08f05cf5-8305-4a6d-a418-604485cdec7c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0a793c65-446a-4b09-b12a-5faffe10dd22"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b6b54a3-24d4-4ed3-b511-ea949e261688"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0db66a5c-8c32-42d2-970b-a680ad7560ee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0edf4d7a-9772-4d17-ba79-062e6230cb60"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f784dc4-36c4-46d3-a9e5-e85bc01992d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1227d273-8d40-439f-a0c5-f56b3f1e3f61"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("12482f73-8b91-406f-8078-9046792eeac7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("12dabbe5-48b3-4719-8047-de1985f6aa8f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("131f1a17-ad9e-43a0-8cfb-4febc1c44e80"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("13a96737-828a-46b2-8375-af359f79361c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("149b25d0-c31f-4638-aee4-ce8be4680c31"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("163b130f-c099-4bf0-9dbb-508094ebeed0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1658f996-1108-4377-a1ea-d7e40836b191"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("180d59c8-2b98-401b-9ceb-37f591a238a5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("188ab3b0-29b1-4271-b41a-ef1da1ebd8fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19335021-26bd-42fd-a4f7-6d4a0d3a338c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19ab5b69-c604-4f60-8fdc-7484cba124e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19d64060-7ea8-4531-9bc8-0dbf8639b326"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19fba112-8872-4164-b0a6-d698d7bf1d32"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1a818793-57aa-4c0f-b5bc-deac638a8aa7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1e5b0be8-fbb6-4a3b-92f6-d91d50071e12"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("22f4fe07-586d-4ae7-a2a1-5dea6bfafc56"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2623f9d5-e5b8-4ca1-85a6-337673e0ce90"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a65fc6d-dabc-4163-a986-981ade9dd12e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ca8d00d-8800-46c6-bc05-b857ced114d9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2dc55bdd-e9ea-4057-adab-97b3712f3779"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2efe0cb1-4b05-4c33-9423-ff995f862efa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2fce68b6-5dd7-40fa-8994-f55619d2010d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("308f23d0-b6cf-4ee4-91f0-57ce01123fbf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34266793-ce80-4a0e-8299-32ee382fcd3e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34a5978f-970e-47d2-811f-393e63b6d9ee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3613c8b0-256d-495a-b756-30092c3447cf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38a49a2f-0429-48f1-9156-aebaf3bf3bd1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("39749d3b-d734-4f1a-a159-b59c22c79cfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3ae1e68a-477e-4262-a66e-e31cd3adb077"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b05da29-47a4-40a3-9b1c-4e386502f3bd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b22650b-287f-4ecb-8cda-cc19e7b6514c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b6feb44-0c2d-4093-a65c-683e91926841"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b9dd33b-558c-44bc-9e8c-bc63fe87ba08"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d5a5372-fc1c-42af-a338-e6eda0348dc5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d6318fe-2edb-450d-b6d8-f7440ff9b773"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3e5584c9-eb22-44a9-9fc4-75464a18d16e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40500f2c-783d-4b55-881f-ac80e678541e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("407a793b-10db-4d36-b962-cb038d87af6e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40dc6716-981b-4359-9255-5675f8218b5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("424f6263-19f2-4a1f-8a26-b74719986fc0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42ce90d2-844a-465f-88b4-26b022ee98d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("439e7db5-c92b-456d-9e3a-888a86c3df9c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("43e2d1f6-4c8b-4beb-893c-b24d63ee00f7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45d7658c-f2a0-48e3-868e-e820abe6864f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4688330e-7874-4e45-8000-9efc7d671121"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("47f7c32b-2b2d-4532-a1a0-592c33c95a65"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("482ef4a9-3a08-4969-8ef8-e54522ca0689"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("487a2173-1a1a-41c3-80bf-b85b898c17fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("495ce8a9-d210-4f5d-8271-272f1f543507"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("495de907-f723-45e9-bc2c-16781e62aa36"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a857562-0e98-48d8-a91e-4aabca5fd3ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4d0ea263-0c27-4778-b2d0-2a518f81abc6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e28e902-dd46-4570-b6fa-4ba7270fa706"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e993101-ea78-43b4-bc4c-3437ce34bfd0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ee74951-85b6-4c23-99d9-144d24401e57"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4f184b2f-e9ea-4a03-ab0a-b8524c5734fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4fa41256-c50d-4aaa-a701-55ff50115c38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("50ee5d09-20be-4aad-915f-6d5d06ef2404"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("526d5acb-895e-4a88-8881-4174e1e58f98"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("533c2f51-c323-4033-bdb0-12cb4c3e7c38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55598cef-fa0c-44c4-9359-08e6f66233df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55af9be8-2390-4f6c-8c74-4d04e9fe3920"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("565bbe8f-b0ba-4c86-b6fd-d963aa7af803"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5870145d-924a-40f2-8683-b9e78c8257fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5af55993-f90a-401e-b3ad-9232f7694524"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c4324b5-053a-469c-95db-40ef7297e9c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c98f2f8-c5ea-4ebb-bc58-dc1ad2b12fb7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e887fe0-8404-4668-b5f1-6937ec1f8f84"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ec3b754-2b94-4540-b188-f43fb649b118"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6096f0b7-ed7d-4aea-b234-5f8b43a22235"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61b747cc-1bcd-48a5-9ee4-aa15a21c097f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("62f8b964-bd2f-4a85-a05c-22117a5c1956"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("64f6b49e-dfdb-45cb-9e4d-0216bdec4dd7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("678cfea0-e8fa-4221-9847-f1dee7d3d8b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("697a38bd-b80c-42e4-8f0d-84dfae8ade43"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69a9318d-d6d4-4c8f-940a-8090865dbcf4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a29d4b5-6c24-45c5-88c0-b53b7831b81a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6add4412-c4a1-4200-82b5-a4ed701a3dc4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6df7049a-9487-4667-8cce-c30ad06bb7c6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e86b89d-f983-4029-8b1e-1471d441ed62"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7016341b-0a84-4438-8ec2-8e684745a458"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("70872b1f-f01b-410b-b7e2-6b9d2e11bc33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("70b0ce15-698a-444c-b3ed-e88a994208c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("716d0bd9-8dc4-4cc4-8e30-752fd04084a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71a4d279-835c-4d78-9904-6b8af1edc55e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71b4a2d8-4755-415c-ae2f-ee3a64955cf3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72ad5183-d6fa-4ca1-9374-be6cf1216921"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("786b8120-7b56-4a15-b762-99d09c706abf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("790bfde1-773f-4b75-9ced-7ad9d86adf55"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("79d6705f-2d9b-42de-8040-5a4d34905f30"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7bda4894-b399-4160-911f-75a63a794ff7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c1548b0-515f-49c8-9198-79deebb10010"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c92a5c0-e22c-4222-b9ca-3921d4c0ca0f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7d35909b-17db-4d23-80a4-dac91cafc41d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e117529-2687-4788-a784-1e02b390c2f2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("81dc49ff-c496-420e-b21b-b4483ed37111"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("82561a21-ddcc-46b6-b9de-9d6ffbe04c7a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8303bfbe-8a56-4306-8423-2ba4ac6f7d0d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("83f1231b-da17-47ff-bf6e-6131deab07b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("87de685b-b06c-4223-ac6e-cf9650f4d325"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("87f824ec-5171-4628-862f-edcf4ce94507"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88c48307-0d6d-4313-ba2e-de6db7a2fb46"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("892f22fa-6b1b-42c2-bc78-dee0e83374e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a3c5a5e-feab-4865-ba21-525b44d10b58"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a556523-0059-447c-92ac-3f444d3cc675"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a85b4ab-593d-4ce6-8ada-75bf38d4926d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8aa0591a-1f0b-4aec-b7cc-c4012fc043e8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8aecb487-4b8d-4ecc-b297-8043672d7db6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8baedd5e-53de-45de-b5a5-120398556c3a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c22e5e7-2a84-4ffc-b7b6-977e3b7895f3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c405160-9d44-4ab1-ad5c-de1282b202b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8d7ec38c-11fe-4f40-8e19-d3d80b13044b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8ee3390f-1000-4f82-b710-be7a0b362dce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8fab89f8-2dbd-40ac-9f06-54a38ac508ad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("903efb06-27d8-4614-9766-81efe0a07bee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("91d9ce83-de20-4416-a10f-d7b85b09156a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93956123-627c-440e-bf34-9d973760020c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94a5b562-d368-47f1-ab26-95bce9edc5d9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94f51fc8-de0b-403d-8dc0-4b951170336c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("956f2676-1435-4c83-bfa5-12057e02c46e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9adadd48-7107-466e-80e3-1657f41e69f6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b19f84d-4629-4533-89e1-ad7820d084f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d4936d9-9bc4-4323-99fd-c60667115072"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9f76e667-8ece-46a2-bbfc-aa10b6117281"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9fd9fcbf-1bc3-4e73-9a36-05d2f97e6b1d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a013216b-4944-458f-a346-32cd7c6bc4f0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2394303-dc72-4994-b591-82d5815965c4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a27ca2f9-993c-484c-9cbc-a8e4e88cf0ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2cb10bd-fb30-44fd-acd6-6dee9e15aa5b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a44e5096-a6c7-4324-99d3-5fcb197c2fbe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a5ca562a-f7db-40f3-93ed-205e74bf0252"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a78752ef-b254-4441-880c-a5615d9fd806"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a92545f1-0889-4439-a2b3-ed9d46f2f25c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a944c998-041e-4d28-beee-0c2b50d7dd3b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9dd989e-42e6-4762-a26e-c8bb6bbc0a78"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9e0d951-5a11-4b10-9060-710516bf422c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa8d988d-ee47-4eb5-9327-c06fe0733726"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("abe004a2-c979-4109-92bd-e6b1b8576d7a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ac1701ee-8454-4219-8b1a-4b8421b3a3e6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("acbb9f2e-da5b-489e-93ad-9d3196d3dd9b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad17eaeb-3af0-4b7f-9022-30e835aed98a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad4c3dea-aa73-41cc-8638-8a51735e751b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af6325fd-5b6a-45a1-8dd4-bc0d41d8bcde"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("afff35dd-8f6f-44f6-8976-830a6ca06e08"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b22beb7e-35de-4ce9-8535-4c5e3018a170"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b43f70a5-1a7b-411f-8d91-6c907a4b506d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b59827cb-533b-4bcd-8031-a29343b5f607"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b5997514-1372-4f68-b240-8ff2c6ff363d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8fe536e-a3f3-4ace-a617-4a3fcb0e41b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b99f26f4-4a9e-48fb-b361-3e988bc792b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9e12429-f422-4fda-9e54-020c32556d74"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bb4e65c1-7838-48f3-bbe4-95ebf74e7860"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bb6fde02-9aea-4ad2-9084-9da790f3b5ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc976696-cbbd-42bd-b2b0-d68b79619734"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd4dc3eb-3b9a-4431-b356-0091507bb6b5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c11fe583-4f37-415f-b902-41fdd80eff31"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c2f6633b-3a4a-43b8-9947-19bdee26b662"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c4e08791-26b7-4c23-bc61-ea8eb00ee9f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5d9b183-9d56-4a7f-8e6f-713325ea63d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c630d392-b4f1-462c-9bdb-7c2d9324f528"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c739ffee-f0fa-4c2d-b0b6-53edc1baf33b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c73b6abb-d41e-47f3-a853-f7ab889821c2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c74354f0-a58f-4fc4-a0a7-8254c9998737"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ceb5871e-b02f-4fb4-8bd7-e7a0d1e5c6b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ced02723-3548-400e-b2af-fc67aab1bd12"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cf66f399-f4de-451c-a588-a30971975e2b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d2c0ddde-368f-42b0-9fab-8694198bff07"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d49bcf8b-7e64-49bb-8d5a-86d8f5bb46ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d5a3606d-9141-4ed6-a541-0ba8bde25ff0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d72e0ca8-40c2-4c4a-ae96-2f893ba9415f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d9024d38-563a-4579-b4a8-743e596b9de0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d959e638-fffe-4a8c-ac43-c03834343d94"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd73057a-c5c4-44b0-906c-0470ce7e04d5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dec7548f-41c1-4559-b731-6f1885db8097"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("def4ff29-5df3-497b-9be7-12a9f0f27dc6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e061499a-5738-4993-b57e-9118bd52242f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e09c67df-2dd0-4fda-9554-97f53925aec4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0f0f6ac-5d8d-49b1-ac0f-3c021a7ad4d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e53afb17-5d09-4e5e-8387-e6440cd4347e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6ee7b66-1ec8-47ea-bcb8-87baa1fa213b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e88ea8a2-9e81-4666-97d7-4ae39e9f0db7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e9517a56-f42d-4a48-bba3-d792b8b76c1f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb40f2ef-e1de-4abd-afb3-8d52d8576c06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec8bfc2f-bb36-4bff-bdf6-a99051618db4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed0fcfb3-6b9d-44ed-ae3c-b63022c67d47"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("edc222a2-c342-41da-a8e4-3b90ddba3e2d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eeefcac2-1ccc-492d-af82-68153305289b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f07c366e-2da5-4247-9077-b210d5f16559"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f124e591-7c77-49b9-a330-2071ed24afdc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1a2b909-ebde-4660-964b-42b938256c57"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f341b504-01d0-4f45-adcc-5f12b3db6a8c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f3d27ef4-e3fc-48a3-a513-0b72379562b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f3e35f40-3887-43d0-a890-b617bc6b1c0f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f43e2ea4-09fc-4924-be25-1ff6062c0ddb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f57aec81-a2bb-4f81-b2d2-8d0643b0a327"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f581c6a2-0c0f-408f-ada2-15c4163949a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9b2edb2-95ed-434b-8e39-097b45707fb1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9c34bfd-23ae-4bba-ba7e-5a1107a56044"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa1346de-cd16-4b88-a868-3b785f58191e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fcaa84af-d8ea-46a6-bbc5-da1c7806d991"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd993f7d-6b5a-4477-a13f-3f9ccac2ba34"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fde9b6a4-5ae3-4974-98f2-a480d05f8538"));

            migrationBuilder.DropColumn(
                name: "IsGood",
                table: "LogMessages");

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("016568c5-3cd0-4f74-bb4b-2777a17f6ee0"), "Legs" },
                    { new Guid("23129d67-d0dd-4921-b53c-27a6e10578f4"), "Back" },
                    { new Guid("3ec8aa57-67b1-49f4-a130-0c14e4a4cc52"), "Forearms" },
                    { new Guid("48b4b092-2841-4a58-93f3-e85e6ace5fc6"), "Calves" },
                    { new Guid("6f9e6a2e-32cb-469f-9130-05db9586b5c2"), "Bicep" },
                    { new Guid("725e852a-0d7e-46d3-b16e-14ec9f014c04"), "Abs" },
                    { new Guid("79fadf03-f577-4400-9f31-33b7a551fd4a"), "Chest" },
                    { new Guid("8dbffdbc-91ab-498e-bcd9-4bc7343aa64f"), "Shoulder" },
                    { new Guid("95e3d5c0-448c-438a-9a42-383ed5a4ef12"), "Tricep" },
                    { new Guid("fca8cfe7-3b3e-48fa-9ab5-d0628ca163b2"), "Glutes" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("033ea26b-8e97-4773-9995-74c06b80856e"), "Legs", "Romanian Deadlift" },
                    { new Guid("034c582e-174d-4fa8-bd67-63fa7a9ebefc"), "Back", "Deadlift" },
                    { new Guid("03b90fa2-2d3c-4c0a-8c0a-bef3c16f149c"), "Back", "One-Handed Cable Row" },
                    { new Guid("04667907-b2db-4a75-b379-ed4c220e88d3"), "Back", "Block Snatch" },
                    { new Guid("048dda5a-cdf5-4bac-952a-96ede565d1bb"), "Abs", "Hanging Knee Raise" },
                    { new Guid("05757966-d938-4e31-b3db-a257d0a55c3a"), "Back", "Dumbbell Shrug" },
                    { new Guid("09720b48-ebf5-4ab4-adf3-ee5eec2401e9"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("0b2d9408-029a-489e-9566-8d8778360260"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("0bb0b2af-bb64-4105-ab1c-ca8d50748b4f"), "Bicep", "Hammer Curl" },
                    { new Guid("0dc12295-b063-4b53-bd1a-818a6327b721"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("0df7b442-a226-45f5-a31c-9016ff57d6a9"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("0ed233d6-5fa5-4702-97e4-c0d7ac5c6bfa"), "Back", "T-Bar Row" },
                    { new Guid("0f3949b0-77ae-42ac-b352-deaf29484797"), "Chest", "Push-Up Against Wall" },
                    { new Guid("124b65b9-83d7-4f62-a66a-b156102309a2"), "Bicep", "Barbell Curl" },
                    { new Guid("19b8a8d3-4654-48f8-ad5e-45111686b3df"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("1bb9d39d-f99e-4b98-ac79-6581bf148212"), "Chest", "Dumbbell Pullover" },
                    { new Guid("1e01f901-b753-4397-a218-fd05bc0d5396"), "Legs", "Air Squat" },
                    { new Guid("1edf5411-1cfb-4452-bed9-fa13b46cabe0"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("1f520b11-b67b-4bd3-ba64-a77232b06f3e"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("1f60eb90-a3cd-471b-a1cd-b1996197130b"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("206a9441-00d3-49d5-901c-7debf49f81cc"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("218359e2-1ee9-4109-97d6-c61860f66df7"), "Bicep", "Bodyweight Curl" },
                    { new Guid("21efddf4-c150-4b31-b214-c83a803dd0d8"), "Back", "Power Clean" },
                    { new Guid("258f7633-0ff1-4f19-a67b-6f9db481cff9"), "Legs", "Barbell Hack Squat" },
                    { new Guid("25ad0412-0871-4fe8-a934-622129fe5c5a"), "Legs", "Box Squat" },
                    { new Guid("25b83620-68a5-4cd9-9fe5-e906069c83e7"), "Glutes", "Clamshells" },
                    { new Guid("25cdead0-8bfb-4253-b927-dae9ce61c903"), "Chest", "Bar Dip" },
                    { new Guid("26906710-bdb8-4dc4-a47c-3f4e1a4ebf39"), "Chest", "Floor Press" },
                    { new Guid("29533f69-8e20-435f-884d-fd827cbbf728"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("2a0a3c9c-8349-430f-98f1-1584ecbff42e"), "Legs", "Hip Adduction Machine" },
                    { new Guid("2c7fb9b3-4629-45ee-852d-619240112b99"), "Legs", "Front Squat" },
                    { new Guid("2d6aa6eb-6227-4fd5-8c12-534ad35a75d3"), "Chest", "Machine Chest Press" },
                    { new Guid("2db58e3a-11b7-45c5-8bde-fae11476ecff"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("2e0ab3aa-47f3-48df-bc8e-5c78956f1310"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("2e816f0e-dcc5-48f1-a7ee-79b562a810e2"), "Abs", "Lying Leg Raise" },
                    { new Guid("2f80a8aa-fbdc-41fe-964a-41b907d52bb0"), "Back", "Seated Machine Row" },
                    { new Guid("36426cd5-bed9-47fa-b74a-9e9b635469b2"), "Back", "Inverted Row" },
                    { new Guid("3665a6bb-29e3-45ac-ada1-c4946aa72ac7"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("37b5ce94-34aa-4043-b522-937ffa265f83"), "Legs", "Half Air Squat" },
                    { new Guid("37c40175-c70b-45e6-be3f-d6374989ee70"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("38d9d86e-7979-4d83-8f00-0c2c687f5576"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("3a7818d4-5cab-4cfd-8d2b-b43081a0b739"), "Back", "Barbell Shrug" },
                    { new Guid("3a9de4a2-ac91-4fc1-88dd-72d3ccf71548"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("3b648218-ef48-4ad3-ae27-d2785b752062"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("3d02318d-3194-4e5a-b489-33a7e469f0fa"), "Legs", "Belt Squat" },
                    { new Guid("3d02b1e4-3ee9-44b0-8018-c2a5c59618b1"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("3d91b906-8d75-4c5d-843c-ff81153d449a"), "Legs", "Hack Squat Machine" },
                    { new Guid("3df922e6-6502-4d15-a17a-b3cd51ac03b1"), "Legs", "Smith Machine Squat" },
                    { new Guid("3f18edb2-e438-4546-bd2d-2b3acc421496"), "Glutes", "Banded Side Kicks" },
                    { new Guid("3feb669b-d009-47fd-a323-92b4f0af0bc5"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("41ed8105-7244-4b47-8f90-4589dc4cacfe"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("43d541b3-3fa7-4159-8a4c-8e907d681276"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("458500f6-584c-4bc6-afd2-ca090b128b5a"), "Legs", "Barbell Lunge" },
                    { new Guid("45c3456b-a996-4d1b-ae97-384b46230305"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("4832df09-1273-4c15-b3cd-55b20af64b70"), "Shoulder", "Squat Jerk" },
                    { new Guid("484279b5-d57b-4e88-8850-c407696f9b86"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("48d83a48-1f2b-4f7d-b753-2f705c20a95a"), "Back", "Pause Deadlift" },
                    { new Guid("4ab14c44-b39c-4ef7-99e8-f11b3b042d3b"), "Bicep", "Spider Curl" },
                    { new Guid("4b3bcb38-8a47-4ab5-ac6b-3d94676fb77e"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("4ba0f9b5-a4de-4494-ac90-b230b656b63c"), "Forearms", "Bar Hang" },
                    { new Guid("4deb0b17-b59e-4a7a-861c-3b753258f715"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("4e56600b-ae9e-4028-a1c4-2ff53919af33"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("4eea2cd2-1004-404a-aff5-1b95c555930c"), "Legs", "Landmine Hack Squat" },
                    { new Guid("5282861f-f134-4f1c-bd7a-f6be087bbbfa"), "Back", "Deficit Deadlift" },
                    { new Guid("53a1baea-9e19-43c7-a726-ada7c4c71e9b"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("555af316-f944-47ec-9aac-d05b2d96bc8e"), "Back", "Dumbbell Row" },
                    { new Guid("55bcf651-0254-4e1a-88e6-b53c1747dcd4"), "Calves", "Seated Calf Raise" },
                    { new Guid("55d325b8-ec65-43ab-8aef-7a2d51f2103e"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("584fbaab-e3a0-43f4-aa59-afe5b3a825b4"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("58aba172-fc9b-4eab-af93-6a34d5896291"), "Legs", "Dumbbell Squat" },
                    { new Guid("5a28c87d-79ec-4e67-9772-d0fe5bda7635"), "Back", "Clean and Jerk" },
                    { new Guid("5b4a0dae-a48f-4916-b199-cf3cdf14b527"), "Bicep", "Concentration Curl" },
                    { new Guid("5bbfc50f-745d-4d79-a11b-9e205c6ff5d5"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("5bf730a3-5a0d-44a2-aa9d-355e724d5394"), "Legs", "Chair Squat" },
                    { new Guid("5c92f57d-1708-478d-b0c7-23b5a0846445"), "Shoulder", "Overhead Press" },
                    { new Guid("5d0dc4d1-1c4f-480a-b776-7bcc161279f0"), "Glutes", "Hip Thrust" },
                    { new Guid("5d30c0e1-902d-4a95-8bef-9930c00f641e"), "Legs", "Dumbbell Lunge" },
                    { new Guid("61f31a23-9421-4c05-9f90-3722bca9b708"), "Glutes", "Fire Hydrants" },
                    { new Guid("622bb426-3547-4b23-a09e-e2dcc5e4ca35"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("62a6d7ca-ee57-4bf0-8b5a-d3ba49aeccdd"), "Forearms", "Gripper" },
                    { new Guid("631f0896-3ef0-4f56-8629-69745140d9a7"), "Chest", "Bench Press" },
                    { new Guid("678eb8be-d4db-41e5-ba92-fa067990e482"), "Tricep", "Bench Dip" },
                    { new Guid("6896320d-530a-47f0-8bf8-5e50f8ab4580"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("6a53bd78-769d-4da9-bdd2-ca40b7f05a17"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("6cec8630-c0b5-4d04-9ea1-d1d5c033fadc"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("6db21f7a-61d6-4820-847c-4d0b3f897ded"), "Glutes", "Glute Bridge" },
                    { new Guid("6f926583-d634-45f9-86c4-5f4bde333162"), "Back", "Rack Pull" },
                    { new Guid("6fb6a522-f7ce-441d-a3d9-dff9241e4fe1"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("714aae75-7c68-4d83-8534-22643eb63e98"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("746ee8f1-2285-4831-b4ec-ea587b672fb4"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("754cdfb5-bf58-4f1e-abc2-1f6ab20c0a58"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("7588af58-5ae3-4ad4-9d53-e016efcc7b55"), "Abs", "Dead Bug" },
                    { new Guid("765acc5c-5c61-4d96-a9f0-265dc40db623"), "Back", "Kettlebell Swing" },
                    { new Guid("7952ef17-2ae3-45c2-8457-255985aad903"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("7a73307a-e44f-4187-beb2-041b2e12a385"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("7ca21ad2-1fd7-4680-a507-43af2c787357"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("7dc4a4ec-f1fa-455d-b9f7-3a4f0aba2d1c"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("7f7e89fe-09f8-45ab-9288-506a12e06580"), "Abs", "Kneeling Side Plank" },
                    { new Guid("81d1ce73-9a94-4b99-944f-2196f486b678"), "Chest", "Machine Chest Fly" },
                    { new Guid("82cbaafd-c3ab-448a-98c6-a9e1b182eee2"), "Abs", "Oblique Crunch" },
                    { new Guid("8376809d-040f-4ef5-83cf-8935c34a5a25"), "Shoulder", "Split Jerk" },
                    { new Guid("840a4b47-2907-41b5-b32b-925d0235ae88"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("84c6826d-df48-4bb2-a7d3-3ea0555c97e9"), "Chest", "Incline Bench Press" },
                    { new Guid("85b012ec-bb23-47f2-ae4f-57f3c6916e93"), "Back", "Good Morning" },
                    { new Guid("85f85077-86c1-4a89-8b79-7cff5b42818d"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("86be765c-32c7-4295-a6e4-36264d510db3"), "Legs", "Body Weight Lunge" },
                    { new Guid("88ab2c36-cd07-4f32-8a3a-284c7b4fd82d"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("8a546453-e079-4022-80d2-a33cfbdb1f1e"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("8c2d2323-f160-4829-9026-e5704b70c667"), "Abs", "Crunch" },
                    { new Guid("8eaaf47c-01d3-4eb4-a017-437dc0bb18a0"), "Abs", "Sit-Up" },
                    { new Guid("8f205d9d-f293-435f-9ccf-4983fdb90d8b"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("91e0f681-d564-4425-9ef9-387cc62df8ef"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("94bab4b4-cc54-4670-9ba6-a067ce4c4570"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("94dcb7e7-5a6b-4960-b202-ceb2bd2e66c4"), "Shoulder", "Plate Front Raise" },
                    { new Guid("973dad7b-c969-42a3-91b4-b278a3c4a188"), "Legs", "Lying Leg Curl" },
                    { new Guid("99299933-b5fc-42ec-ba23-fbf6e7baf98a"), "Shoulder", "Push Press" },
                    { new Guid("99396d63-c2e3-4509-ad86-b0a845603528"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("9beb2d3d-8ede-4fe8-98cd-5cd36d61b0db"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("9c08c21a-f80b-4eef-9265-c36ad1d43a0c"), "Abs", "Oblique Sit-Up" },
                    { new Guid("9c47b282-1eae-409a-9fb1-10937215059a"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("9f2653bc-2573-4517-b65d-896927470ed1"), "Calves", "Heel Raise" },
                    { new Guid("9fac6bf8-2c6c-47c9-be87-1c605e37302f"), "Back", "Power Snatch" },
                    { new Guid("a0b269c5-3d1a-4228-9c34-2dbdbe7a7da4"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("a44838bb-952d-478b-81d0-c991bf6b49a6"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("a7fd1d1d-4895-4915-8f5b-1c1e275a4fbe"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("a8fcff19-8c5c-4181-819c-fea9a6aea94f"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("a9d8d845-1dfe-43a6-a806-7f37101e5a50"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("aaeafea7-26ac-49d2-8719-cfa32b6d8ee7"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("ad789009-f30e-47ba-a1a6-d8ea5ef14604"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("ae11b0e3-ac1b-4a29-8598-48ec5c95ba9e"), "Back", "Clean" },
                    { new Guid("aff381b5-ac9d-4eb5-9b34-fb72038bca23"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("b061c779-0f91-4a94-8f18-f39808ac2c6b"), "Abs", "Plank" },
                    { new Guid("b14a2fba-f2d4-4e4b-b974-3ff6743c2260"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("b16dd8f7-ae6c-4adf-a74f-7f181446cdde"), "Abs", "Mountain Climbers" },
                    { new Guid("b2c6a3e4-a4aa-4df5-b7cb-bd66f714268b"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("b37b3cbf-ff58-4950-9bba-3eba41688e1e"), "Shoulder", "Front Hold" },
                    { new Guid("b44f2081-630c-461f-87c8-37b36159eec7"), "Back", "Snatch" },
                    { new Guid("b4c1ba1f-7aa0-4520-9fa4-e07e81b8533b"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("b6c48685-5b16-4ba6-92e8-8c0e10d1b304"), "Abs", "Machine Crunch" },
                    { new Guid("b6e12441-e648-47fa-84ea-d2d15a5ae084"), "Chest", "Decline Bench Press" },
                    { new Guid("b70c7da1-3003-4e92-8039-fde27d5cc0c9"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("b7981448-5fc4-4a69-b912-7510d9f873e2"), "Shoulder", "Monkey Row" },
                    { new Guid("b80c7f02-dfe7-47d7-bc10-648223c258ca"), "Legs", "Goblet Squat" },
                    { new Guid("b9226601-0d61-458d-bd62-8240944d2895"), "Forearms", "Farmers Walk" },
                    { new Guid("ba1cbf6d-cd78-4a45-977e-7d94a95e1026"), "Back", "Seal Row" },
                    { new Guid("ba220896-0f4b-4453-8398-9959a8252682"), "Glutes", "Frog Pumps" },
                    { new Guid("ba44f835-96ff-4aed-b277-160dafc1242e"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("bba4b8d1-7fb8-4e9b-9ad5-10c522598fb1"), "Chest", "Push-Up" },
                    { new Guid("bc3f90d7-6569-4e23-9a4d-50417a594c35"), "Legs", "Safety Bar Squat" },
                    { new Guid("bd9adfc4-0106-48cd-a139-0b3193f14813"), "Back", "Barbell Row" },
                    { new Guid("bddc552c-9750-4f52-98fb-87318d519e1a"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("be2d00ac-f580-40cb-be93-af43e65e1044"), "Bicep", "Dumbbell Curl" },
                    { new Guid("bee9dfca-613c-4245-a51e-20424db428c5"), "Back", "Dumbbell Deadlift" },
                    { new Guid("c0a24e3a-938d-4124-a398-339e0d2ebcaf"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("c404ec99-ca77-4d58-94cf-6e773a58925a"), "Calves", "Standing Calf Raise" },
                    { new Guid("c4b34eae-1d4f-4ed5-8db7-f3fd9207fd51"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("c611c960-c247-445b-acf8-bd72986f1c04"), "Back", "Hang Snatch" },
                    { new Guid("c6c3a193-0b4d-4bb3-9b69-49b63b259c68"), "Legs", "Landmine Squat" },
                    { new Guid("c7634cfe-0b08-499e-ba78-cc376f47397c"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("c8abdce9-44a1-4e31-ba95-a9b4a684a3c0"), "Chest", "Pec Deck" },
                    { new Guid("c8ad38b9-669b-4a59-a3c7-7efeb1468563"), "Legs", "Leg Press" },
                    { new Guid("c8cada9f-84c7-4535-b849-9695d2468fcc"), "Legs", "Pause Squat" },
                    { new Guid("ca5b661b-30ef-48f4-94cb-6d747f52e4e6"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("ca978095-edd1-4b87-913c-159eb3ad64f5"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("cab39b11-8f73-4aad-a06c-d1b04183c26c"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("ce44921b-2c9b-4a6d-b490-84f884abd569"), "Abs", "Hanging Leg Raise" },
                    { new Guid("ce4e08af-b068-4dcb-bebc-3da8a8c866a8"), "Shoulder", "Power Jerk" },
                    { new Guid("d0313d5a-277c-4979-83ff-966326449f6d"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("d0d8ec8b-7702-4078-ae7d-16c72770507f"), "Shoulder", "Face Pull" },
                    { new Guid("d10e6cda-b13d-42db-b2f8-ac9425c90097"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("d27515db-cb90-4010-a389-a47576099341"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("d2d3e4c1-1091-4bda-96a3-3bb6f99fb3d7"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("d38aa0ce-dce5-4afd-82ba-829236c4dd96"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("d675d13c-721c-444f-925e-d73266bff284"), "Back", "Hang Power Clean" },
                    { new Guid("d704491d-10bf-4676-bfbc-a4afb8bb19bf"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("d759c60d-ad87-4291-b70d-e50d4dbf2f6b"), "Abs", "Hanging Sit-Up" },
                    { new Guid("dc0624fd-2ac5-454c-9ca2-d9774598a9cd"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("dc409030-66a4-42e4-bb3a-cab52f6953a8"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("dd45f168-d9fd-4d6f-b594-bcbed133e4c8"), "Back", "Back Extension" },
                    { new Guid("de4e728c-a692-4854-b9f9-2acc52e9af5d"), "Legs", "Step Up" },
                    { new Guid("df074f77-97ca-4958-b94a-0f3f089aa1fb"), "Chest", "Incline Push-Up" },
                    { new Guid("df2179ef-0e93-4b6a-93a4-c45997cc92f2"), "Chest", "Kneeling Push-Up" },
                    { new Guid("e27f67f9-b409-4d52-a4b6-7eaeee007b1f"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("e2847785-0830-4322-9582-2ad87ef6346c"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("e2e349a0-453e-486a-ab74-a0c4be5d97ce"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("e6a6b340-37c3-48b6-9de9-7db9c7528eba"), "Back", "Pendlay Row" },
                    { new Guid("e769308f-f4f3-4948-8e3c-0bd2bff5d606"), "Chest", "Cable Chest Press" },
                    { new Guid("e7e29fea-c462-4928-89e0-4a4124c3700f"), "Back", "Floor Back Extension" },
                    { new Guid("e85e458c-3bd4-4775-bb3d-f7cddb06f236"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("e86d4ede-169a-4eac-9067-0b796b190e57"), "Forearms", "Plate Pinch" },
                    { new Guid("e8bb3813-e5bb-4198-8163-a5357155b3e3"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("e8d7e280-3c1a-4313-8516-8028e9885412"), "Back", "Chin-Up" },
                    { new Guid("e9fd8912-265d-4bda-88af-4f641d32b4dd"), "Legs", "Step Up" },
                    { new Guid("ea679a41-f27a-464d-b894-4a5c2a22ea70"), "Abs", "Side Plank" },
                    { new Guid("eaafd368-215c-43be-bf35-0550a92420a6"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("eded6391-79c3-4712-a589-d5a1d3c780fd"), "Back", "Hang Power Snatch" },
                    { new Guid("ee609e86-3349-4017-915a-c04c1cfc2441"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("f0b94bbe-313a-4e28-8e2b-30dac0486aa3"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("f362557f-2e47-44a3-828d-75a0a3bd60b1"), "Abs", "Cable Crunch" },
                    { new Guid("f51de068-e2ea-4dc9-a655-4e1a9b426062"), "Back", "Hang Clean" },
                    { new Guid("f5b4d527-d974-4f14-94bc-a55781592710"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("f5c683d9-7d43-40b1-9f9e-2fa251de569b"), "Glutes", "Step Up" },
                    { new Guid("f6b9579d-0072-482d-a7b2-93195b383c92"), "Forearms", "Towel Pull-Up" },
                    { new Guid("f80038eb-7458-49d0-9c9d-68a1aa4f8e71"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("f852455c-330d-4afd-8db8-40632c1bedc3"), "Legs", "Seated Leg Curl" },
                    { new Guid("f8b871a8-c7b9-4ac5-847e-3d15d5b02dfd"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("f8bcd84d-d72f-45dd-ad84-cf2733bc87f8"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("f940fc24-96af-4a6f-a369-dc80b72465e2"), "Legs", "Squat" },
                    { new Guid("f9aaaee7-967f-4c58-b461-243848fbe07c"), "Legs", "Leg Extension" },
                    { new Guid("f9d0cd75-09e7-4e74-aed4-f251f67902f4"), "Abs", "Kneeling Plank" },
                    { new Guid("fa56c2bc-b1d4-4c5b-aa27-2b36e0cb25fb"), "Back", "Pull-Up" },
                    { new Guid("fc21fd9b-bcac-4f50-9174-67ca13ee6208"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("fcb537fd-62d4-493f-9062-57ef67b65538"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("fef3d9f6-2d6c-46d5-9095-857ffe627bcb"), "Back", "Sumo Deadlift" },
                    { new Guid("ff997f88-844b-49f7-8f88-3b80234a4ebe"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("ffea98c1-3374-4bc0-baae-a416182a37fa"), "Glutes", "Cable Pull Through" }
                });
        }
    }
}
