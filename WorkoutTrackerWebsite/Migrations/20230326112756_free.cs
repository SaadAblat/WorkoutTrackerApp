using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class free : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("0dd78c29-4fe7-4d5a-932e-c631d191b461"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("543a6b3c-9998-4da1-b424-d9fc2ee52cda"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("6a577dbb-47a1-41f9-b03c-bc64fc5a9d9e"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("6e4a6390-742c-42e1-8deb-5ea67a070ca8"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("7e296865-8de7-48c1-8fd5-7600193dcb3a"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("847fc1ec-3596-4be9-b75b-39ab7e051137"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("d73e9bc8-87e3-4637-8acd-0bbb8a8450c3"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("dda7d010-67c9-4406-a4e4-e08cc4a99fad"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("e09d264f-41d1-4e6c-8993-9d999c44da0d"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("e84f6fd7-2157-4c4e-92fd-b1b532816372"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("015da803-3674-4220-b978-9aab1f447263"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04a160d8-78a0-4b38-b8f6-561822cb157b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04cb2efa-3ad4-4061-815c-7f412c4e336b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04cf21ec-cf46-4d4c-9306-55673b32128c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("06174f55-cafd-460c-a14d-e89af60b6348"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("076a795b-484d-41cd-a565-5709eb282377"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07e6b414-eee9-4f69-9988-67b10bd9d329"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b52da9a-6f65-4438-82a8-0b1ade1b54b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0daac06c-b551-4b76-a465-ae436ef0617e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e571194-4b71-4eb0-a753-3bbf251c936f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0ef71480-22b7-4eb3-9c8f-7f36fc78372f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f89d9fd-acd0-48dc-94fa-b9ccc3cfe501"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("12d475de-c0ac-4fd5-9b78-6ce954f353f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("135daf6c-7ac1-452d-b70c-57b0b844386f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("141ee2d1-edc9-4ecd-8cfb-553469189a2b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("14964c19-899e-4f09-8c4d-7c75397d87aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("17cd465d-9a91-4cae-9ca1-bb2b627f1f69"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1b0a6b7b-b495-41ac-85d7-9ce48179a92c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1bbdb6e4-e2e7-4906-b6ef-f372d2e3e820"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ca811dc-d499-4888-a008-31bc24d16ecb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1de905c2-6fc1-4433-ab54-44f1afbb41ea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1edcffbb-7978-4af1-a51a-e54b10fd9640"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2061ce7f-d91a-48d0-8efa-8cb57e886eff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("209cde4b-f7fc-453a-ab54-5de4e465c211"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("211d2c61-3019-4d85-bc4e-dc3e121e3a31"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21277e03-7a03-44c7-bb6a-3343f251e344"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21796907-9ecd-4253-a7dd-d18c23da446d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("218287c3-6acd-456b-b510-ec6bb0da6a1e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("253ea19b-1ade-49a7-af05-fc61537df1bf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("256cf3b3-0d58-4fa2-9f41-3aa100f21d0f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2777696a-abed-4ced-83af-c5f6ce65fba7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("28b44186-dc7f-4ee1-acfb-03d47c3609e0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a9019a8-150f-4adc-9d0a-a8e661730f08"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a95c536-21cc-4958-8d6e-fe0f04d822ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2be2e0b5-4cb7-46a2-b07d-57bd0b2664bf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2cf80fe5-abdd-486e-a7c9-ad0eebda8925"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2f770831-aa84-457b-bf66-ad219cd35816"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3000ea77-2fba-44fd-a622-66e3267b3199"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("306a777f-5b6f-4cc5-a361-63e2a28f11ca"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("32210d2f-e79d-4f10-9eff-41924c5f19fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("324a74d2-1b71-4cf8-bcc4-f1372d3d8922"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("33ffba2f-a6cd-4dfd-9415-5bae7a0b34a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34624f5c-b51e-4aab-a665-7d0d2f176db8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34a156ed-37aa-49ed-b2dc-60809cedf1f1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34a77544-d1f1-4637-bf03-720c3454f2aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34edf814-41e7-41cb-8303-64cff866baea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35831330-73a4-4661-a378-af4be37c2b36"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35d5ff68-91e3-4749-9f58-d0f1dc1e740d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36495f5f-c007-44d8-8313-9c9c2905779d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("39e08972-1fdd-43dc-8a1d-1f1731937c8f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a822a9f-e7b1-4890-ba58-d09acf81e1db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b45eb76-da0f-4baf-93f0-e62f7daa4991"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d3fd164-41c0-45df-87fc-75ad1b7f7fb4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d5e9040-366c-4239-bf81-03e5aa5c95d0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3dfa538a-e55b-4645-aeee-458055bca90b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f554af6-682e-413c-bd39-d9ec0836fe1b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4035a337-122e-423b-9f56-7cee04bc018d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("419dc51f-75a3-4b3e-9448-429e1eb40c4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4630732a-22ab-48da-a549-37e2a27bda9d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("491c0b3a-2b00-4142-8f48-fa5631c9b048"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a7dba48-80fa-4da4-964a-d381bd5d363b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4d44f3ce-acb4-4397-98c3-76474f58fa8a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4dac6d3b-e4b7-472a-bbc7-b1c04171053f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4fa8972a-8d1f-4332-9c11-b9050a4d0f0d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("52053fbb-c145-4260-a9c8-f2355e358fa7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5455148e-4d6a-4219-9034-3776b3ee15bb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("54888986-5f55-4665-a4fb-d88d2c71f378"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5701072b-6371-4dcc-ae63-81c41eedb9b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("57343099-f98b-46d7-8247-d625ede1de2e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("57f945c2-9678-45c8-b6cc-6c9e2924c8db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("58dad23e-6a10-4682-b71e-070f03725375"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("58ed30a5-6499-4101-8f31-f320d35c5f5a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5997b97b-11e4-4b86-adf6-3a9bc60c2c88"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5aed601a-69b0-48da-b184-d4f07d700277"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bb970ed-5a00-46b6-86e2-54f2f02cba00"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5cac6d71-ca6d-4516-9560-246bfb70e0af"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ce1e8bd-0044-47e5-80a3-078ffd24a0f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d09bf14-0b83-40f6-8400-4dd276adb353"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5eaeba15-41ce-453e-bba5-7ff0195bbc28"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5fc359ac-86c7-44ba-b7e8-eba84dc82848"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("600791f2-0cbb-44ce-b7da-eb71d6145804"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("62e3aed1-353e-4580-94ef-8be70e9a3777"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("63029ba7-4639-4873-b21e-250d61d48fed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("672a2782-b134-4d65-8d0f-81a66802ea18"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("67307853-6912-4d8c-bb67-c16192277900"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("67d29f88-5a7a-44ae-b999-4b3c8a023afa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("680d8c6a-15d7-4697-9869-63e875aa0f75"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("68f33161-ba8a-47dc-9738-b18ffc13daa4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ae2d0e9-6367-4395-bdd7-771921d2d5f5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f36c3bf-1d39-4418-a5db-4bcf75ca548d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7159a865-d9fa-435b-93a7-06ff09593241"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("716a3aa3-deaa-4cb4-a073-29b74841111c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71e9f1aa-6246-4da5-84c4-f6a10e5e17c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72e4373a-8360-494f-8c6b-a51bff23456c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7401eb4f-f8c7-4d6d-8da2-db0ac73149a3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7514a479-663a-462d-b4ca-5824ef676199"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("751ea0a5-3bc4-4573-a682-f858425ab5da"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("752dc954-8516-493a-83e3-32ada9555b33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("75f4be39-7544-45d0-b8e5-3216bd9c80cb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("76f46cab-45eb-417c-9201-1737c0cc98e5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77cb7082-82df-42fd-bbf4-1f34bfed56f1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7886e4d5-1eb9-4cdd-af55-5f0732184ee9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("798414ed-3a91-4b11-a0bd-a9ce6e9d6570"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("79c3cd84-9d01-418c-9f5f-7ceea04cb009"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a01c086-f24e-40b7-859a-0152554159fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c9870bf-4e66-47f9-97ad-a1a87a1a4df0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7cfa72f1-e272-45ba-a871-8428cd7abbbe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7de5bb9c-a674-40e2-9426-2ceadbf855b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7de69e55-361b-4559-9fcf-71797d804eb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ee6b5d8-1195-4dce-97ce-2a6e838f0daa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7fb57ea0-685d-4e63-ba1f-ec01605107d5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("80629717-a8ec-46a7-b262-b2f669929155"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("832a46c5-57e2-4b58-87d6-f5d33d985340"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("836f1420-8b46-4389-9771-015b4d6751c2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("843eeec5-8e32-41c2-8e60-097ac3e2099f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8472ba0b-dc1d-4cf7-a372-31983575bf71"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8526ab71-d4b1-40ee-b88f-7773b4129076"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85d00a46-6f07-41d1-8426-21880011c0f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86b7859f-e78f-43fc-b19b-a37a42c3d582"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("87f06a6e-368a-466b-815b-389ec26d8547"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("87f91362-1291-4ede-8570-ebf33a152080"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8817b275-2bac-466f-8d0b-f37bb3ad3322"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8820088f-bec2-4d36-a1da-94a82e1c08ad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89a79da4-3daa-47a7-a780-f075e9fd3cd9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a4515b1-4950-4c8f-babc-b0b817a7c2f3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a6cf39f-6355-49de-85b2-3d49334dd90e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8aa1a605-1746-46de-a718-798792d4c9aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8afe3e1c-3bfe-4276-becc-6d8de8eadeb6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b00995e-eedc-464f-a20a-da0f76958619"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8caef1e3-b270-4aef-a1c0-1a442a1ad19f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8e834889-8824-4f61-8b5b-931a87abc642"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8ed4c683-f83a-4cc4-a649-f565af50eac0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f178ca5-0dcf-4543-aa0f-986134f845d8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("900bbe77-da0e-4718-a069-64c369830663"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("902be983-3d3b-4423-abab-f5fdab67d852"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("928c9487-58d3-415b-9c1d-85c473d8122c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95844b08-f69a-4394-9d53-a0e048272e9d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95da91eb-c2ce-42d7-95f4-8f75a11cd740"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("960cdde6-90f4-4fe9-9731-30f52a199519"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9812e108-9d24-4bd6-b4d6-717d59aff715"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9871fd67-6efe-4751-a4ca-906d5cd98a70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99aa29d4-2ffd-4aa7-922e-1aeea8ae8df9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b55d90c-d4d0-430b-b2fb-a59e59dc07b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9ba20830-9e04-4903-ac50-4ea2937002a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9bc9b5b5-a991-441e-9103-425aac17668e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9bd446d2-1867-4c63-8490-6503b59c9f0c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9eaca0ed-71b5-4fe9-bffa-622f406671b7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0d742fb-8aea-4109-a44b-eda7de283add"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0e82ceb-5a53-4396-888e-e281af2427b9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2acc40b-228e-4cd0-aea0-646d60ec4dd1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a3ed5c83-50aa-46ff-b854-6fa5846573df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a60042f4-ca94-4435-ae8d-b83181fade5e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a64f65a5-db97-4607-8588-72aba4c9ef0c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a7ac4c5e-0664-4280-b8b9-053f80c6c093"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a829f738-ce92-4ce7-ba0f-5788834ce4ea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a93bd103-2f76-4e5b-af01-8e99e244f43d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9de7d8f-af82-41a0-a399-432b2af026dc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa1e7668-ecd5-4e30-86da-80d449eec79f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa60fa9c-e227-4050-860a-35455a9e6305"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa838d99-ac92-4d8e-abea-38cf01f82f1c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aad4241e-b806-435f-86c1-aa670b8a5372"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aadff977-8f02-4e89-bc8e-a959a64fb7ee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ab8f4b9b-5d78-4cdc-9fdb-b90767532646"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af99ca0c-2285-4ed7-bff7-80bbdd4d597e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("afab800d-31f1-4df6-a0fc-dbae8c4c66ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b06e9e8f-ff34-4a82-b4ec-ee20173ca68a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b18c673a-015b-4bd6-8acc-20abca8c960e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4cc7d04-3247-4d11-8bf6-675df494e3f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b835310a-d0bb-41b1-ac2d-ad300cb898fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b865e8c4-1726-48b0-a008-a982af634ec3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8f62429-1a71-4ea2-87c1-98ab59b37382"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8f8c421-7454-45e7-a760-fc5622587fb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba5fe42e-2ebb-48a3-b1d7-536ac0294616"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba857ef5-c249-49e6-8398-34823a8ece3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bac999f3-a5fe-4639-bc2d-8e75848e1a6e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc7379fa-87cf-4354-b3bb-76595702acf7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be45e07f-1d4a-41dd-88c7-9c04448a459a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c12ce8c1-6cc1-4d64-aae2-d85eb5ff01fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c2669a8e-96ce-4c94-9c3f-8ca02d86ccf3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c34c916c-e770-4d90-837e-380df89d2460"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6193d78-69e6-4271-b522-04b1751504c2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c83b4902-3ebf-4d2f-9783-d89421611efa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c842702c-99cb-4df6-b284-68aaa05cee6a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8eb1386-9c3f-4cdc-b140-82f67af716f2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c92d8599-4b2e-4340-95eb-91b622659201"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c9b9e582-21d9-4adc-8883-5e5c3c747026"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cc9e278e-fdaf-4599-adb3-f187b709ead8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd03e4cc-0862-4753-83d9-53111916a8aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cfc081cb-3d26-4374-8547-7503da5606b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d04228cf-f742-44e6-80f9-5cb39894b28c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4d74047-a5ce-49ed-9bd4-768bf4a6dba8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d7c199d7-596b-47a0-9048-348d9a4ea955"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d8d580e1-92b7-440b-b4a2-d803ad2beb29"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dac290ed-6f9e-41c6-ab79-cb8ffbfa1e78"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dece9cce-f61e-42f6-ab5d-027262d35df9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df6e1674-a7b9-4cc9-b9c3-1f5335fa087e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dfc13ef3-666b-4a9e-b074-7dcde99a9e4c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e069d381-4f05-4c89-9cbf-5860703caec2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e06cba81-1d44-463b-90cb-39f0b6e4e49c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e142dee5-74cc-40b2-a116-86149708b0e0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e31f57ed-27ea-493f-8337-2e2529bbe39a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8e64d5d-a45f-4292-ad40-c52413aa3b02"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea42c1f6-5688-4c14-b01f-6a5c9ef048e5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eab41201-f76b-48a1-a619-83bd999989ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb18c671-a79c-493f-9090-2e98b4b0442e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb1b4e54-730f-4739-a013-5b77642d911f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("edf5708f-8e64-4675-94cc-d923e9386c05"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eea6f336-7e15-4664-ae47-adf4ee3b479e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f05be20d-9a5a-4d33-affa-994d578cdb5f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1e684e7-bc17-4c84-ba87-c6f5970c1952"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f3c70029-ca45-4f28-a645-c409cc091815"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f455d862-c8d9-449a-ac06-aaf505870820"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f70257bf-d1ed-4ae5-a24a-a4f2e9727fc6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa23ae4a-0f2d-4a8d-a586-0350d1217d96"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc71ff7d-dab2-4e5c-be61-97019a892bcb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd26837a-b99a-49d6-bfd4-39e4a7babc76"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("feb692d1-a284-43f4-9d2d-1140742279fb"));

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "UsersAchievements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MainExercises",
                table: "UsersAchievements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13232166-12a9-4291-837e-c36bc014079f"), "Chest" },
                    { new Guid("2edab41e-cc86-47ee-a4e3-90cf50de539c"), "Forearms" },
                    { new Guid("557684c9-dab2-41da-b330-3a38352fcd39"), "Shoulder" },
                    { new Guid("69ddfd40-843f-4b7f-9dd5-6a0807144fda"), "Back" },
                    { new Guid("87ad663d-fc5e-40d8-8d50-0dc9ef20b143"), "Legs" },
                    { new Guid("8ff44ba1-4e46-4b56-ba0e-56b13329b408"), "Glutes" },
                    { new Guid("b2d23c4e-9010-4285-90f0-b2cc26555b24"), "Calves" },
                    { new Guid("c764c918-9ca5-4480-925a-93098b693590"), "Abs" },
                    { new Guid("d0bf9565-737e-4c9a-bc23-97aeb8d60e29"), "Bicep" },
                    { new Guid("d1c61f3a-9ed4-4736-a9e1-246eeeab995f"), "Tricep" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("00ab5804-d495-4a1b-88e3-d33f258ac9be"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("0117e0eb-125f-4298-8235-9c04bb3d3bba"), "Shoulder", "Split Jerk" },
                    { new Guid("0136675d-49b8-452f-a65e-152039c04d59"), "Chest", "Bench Press" },
                    { new Guid("022de2d7-8d10-4a79-882c-994f553c9164"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("02855195-b463-4c02-a6b1-49dc2be33ae0"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("03edc057-e114-4724-929e-8a4298e7eef3"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("06b8b673-dba8-42ce-af8c-b0dddf0072de"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("09479a7b-a584-4117-a953-80b162d787ab"), "Legs", "Smith Machine Squat" },
                    { new Guid("09a23f8c-b59c-44bb-a2ac-20d8352e4747"), "Legs", "Step Up" },
                    { new Guid("0abbfc5e-d12a-450c-8a8e-7cfe6807c89f"), "Chest", "Push-Up Against Wall" },
                    { new Guid("0b257f11-6f53-4391-af6d-9faa72ab0824"), "Abs", "Dead Bug" },
                    { new Guid("0e5bd895-daf8-4651-9343-b2071a2f510a"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("0edabeae-e8a2-40e8-a0e5-5273034b4165"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("10d14919-9f8c-472d-87e0-45af2ad010d3"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("10d6491a-b401-42a2-a376-f6acfa61d9ab"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("1185e0fb-21b6-4008-aca3-2b6c4c3ba88a"), "Back", "One-Handed Cable Row" },
                    { new Guid("11b316aa-c57d-47fc-afe7-5181f5511a56"), "Bicep", "Bodyweight Curl" },
                    { new Guid("1427aca6-dc99-4975-8eb8-0c13dc2e0b6b"), "Calves", "Heel Raise" },
                    { new Guid("15d4f748-56bf-4be8-9e59-dd30498744f8"), "Chest", "Push-Up" },
                    { new Guid("1662f27b-8966-413f-912c-728fb9bbe8eb"), "Calves", "Standing Calf Raise" },
                    { new Guid("19863c5a-7c00-4bba-9432-a5e93a7f3502"), "Calves", "Seated Calf Raise" },
                    { new Guid("1ae68e4e-f48f-4e8d-8e1d-cb72fe4a46ae"), "Legs", "Body Weight Lunge" },
                    { new Guid("1ba9cc72-6363-4168-b9e2-f7bc277bb184"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("1be28c5b-c952-449d-ba01-9f11914093cf"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("1c5e81a0-c607-4bb9-8a1d-d1ed37e2c050"), "Chest", "Machine Chest Fly" },
                    { new Guid("1cbab8e6-7296-4be8-b140-3182bfc269e7"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("1d6a5fbd-6c24-4de8-af2c-ca6fd12464c6"), "Abs", "Oblique Crunch" },
                    { new Guid("1f0c5da0-1b49-4cee-b5c0-c60d94dad7f8"), "Back", "Deficit Deadlift" },
                    { new Guid("20d12742-83e3-453c-8eea-7e55897868d1"), "Legs", "Romanian Deadlift" },
                    { new Guid("20d37a46-fb31-42d4-9e12-3790194a3a8e"), "Glutes", "Fire Hydrants" },
                    { new Guid("22daf746-ec78-4b6c-9df1-bc86bdd9068b"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("2507a2ac-4d09-4063-b582-143cae0a5212"), "Chest", "Kneeling Push-Up" },
                    { new Guid("259bd68b-c447-4553-bcc4-b395e7ba84dc"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("261c186e-f729-4da6-bdfb-aa4ce370c21e"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("2755444e-1b67-4225-99bd-ce5a02212875"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("279b90d0-91bb-4e08-8bc0-9592840dc658"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("27a0cc4d-6457-45b1-80c2-d5111bb26ce7"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("28f95f5c-a17e-4e95-a5ab-9e3d83e5638a"), "Glutes", "Romanian Deadlift" },
                    { new Guid("2bebf5cc-280f-485b-8112-734f0373cb18"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("2ef3ed41-1cfd-4919-b836-e1a4bfa1e72d"), "Abs", "Side Plank" },
                    { new Guid("2f5e9bde-1b37-4cad-ad64-ca993ead9839"), "Bicep", "Dumbbell Curl" },
                    { new Guid("32583c3f-f2e9-4a26-b2b7-ddaefacccf7b"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("35d33afa-92bf-430f-b01b-b01eb7800055"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("378622ad-f842-45a5-8a82-d4f7e501c033"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("3a88ec1b-9b82-4ab9-8720-998ce7d36444"), "Back", "Pause Deadlift" },
                    { new Guid("3b37ffbd-b05f-4343-bb2e-ef60a4148fbb"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("3b914478-aa48-44e7-8d2a-185281374d0e"), "Glutes", "Glute Bridge" },
                    { new Guid("3bb76a5a-03d8-46b4-9fc7-e0ce2f092a0e"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("3bfb20aa-5017-4071-8873-a46d5b811538"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("3c7baf3d-b4e0-4934-b942-78652bec5310"), "Abs", "Mountain Climbers" },
                    { new Guid("3f2f43d3-519c-4e16-8741-6df978d6afcf"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("41414bb1-bd74-4ff8-b785-dc9f96378d79"), "Legs", "Hack Squat Machine" },
                    { new Guid("41c02297-f44c-4811-aa80-0a6acf75724b"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("41cb8873-2fab-434e-88a5-9faa43eb11c9"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("4243c6bc-12e5-498a-ba4d-5f95c4223747"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("431572ef-b7ad-42ad-9c96-760a88433fd5"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("44a7ace4-50a6-404c-8b06-7de73eae10dc"), "Abs", "Sit-Up" },
                    { new Guid("4a34188e-2d45-4240-846f-598711b0c514"), "Back", "Seated Machine Row" },
                    { new Guid("4a4b2a09-2704-4c60-a170-d61bc4ad557d"), "Abs", "Crunch" },
                    { new Guid("4a7bbb50-d52c-4bde-a964-d2d0b4629463"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("4b68c3da-9fb4-4541-8ee8-ef7ddc762591"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("4b793035-0dde-4952-8c41-109f0777d49f"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("4bc615d2-ed69-40f9-a98f-a9b3f4e0675f"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("4c7ca83d-280b-4377-a6df-123a3acf49b0"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("4e4acfa7-f87d-4504-bf37-9eae4354305f"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("4ed72749-255a-4fe9-bf7d-09516254910e"), "Glutes", "Banded Side Kicks" },
                    { new Guid("4fb7fb88-1abc-46bf-af58-351879792247"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("517aebe9-0610-4ba1-8723-dec622cee0e2"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("518526d1-6259-4db9-b405-2e40886d1eb2"), "Shoulder", "Power Jerk" },
                    { new Guid("5255140b-371f-496f-bd0e-bd8f2811b873"), "Forearms", "Farmers Walk" },
                    { new Guid("537e694c-9120-479b-b6ec-bf5603cd230d"), "Shoulder", "Monkey Row" },
                    { new Guid("5391d90f-7bef-45ea-a884-b2b9fdbc1d70"), "Glutes", "Step Up" },
                    { new Guid("54f8df3e-741a-4d4d-8af9-08988965d192"), "Forearms", "Towel Pull-Up" },
                    { new Guid("5575963c-0f1c-4ef6-a9cf-3d3949a73764"), "Shoulder", "Overhead Press" },
                    { new Guid("55b5d921-caae-43c4-8bc8-e8097a04fe72"), "Legs", "Chair Squat" },
                    { new Guid("57198e7f-5e70-42d8-a48d-bbda9910a52f"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("571ec3ff-0a90-44fe-9e8c-f3264564abc8"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("597b5e2d-419d-4edc-adc7-26ccf359a920"), "Legs", "Seated Leg Curl" },
                    { new Guid("5b15c505-e6a5-4a1c-81c1-65f6e6fbdd89"), "Forearms", "Gripper" },
                    { new Guid("5bd1db59-825f-414f-be1d-a958404c274a"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("5c245b26-ed32-4015-8df7-f43825b7b032"), "Abs", "Hanging Knee Raise" },
                    { new Guid("5c8bb65f-d8a4-4283-9e1e-b41fe311f799"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("5ebbc878-c716-4f61-9eba-d36cfb3ee480"), "Back", "Hang Power Snatch" },
                    { new Guid("5fe34274-6ef1-4ee7-92b2-e49e9b314ca9"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("601085e8-3773-4389-8dac-c342c4360ef6"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("634d4d46-cb11-4e09-b1d0-2403630ef512"), "Legs", "Pause Squat" },
                    { new Guid("64286389-b0c4-4579-b7a7-6daa29cdabe8"), "Back", "Sumo Deadlift" },
                    { new Guid("645e38de-e6f1-4a13-8980-d8e8f942b7ab"), "Legs", "Landmine Hack Squat" },
                    { new Guid("647aecfa-1fc5-4f5a-a8f1-f50860666ebc"), "Back", "Snatch" },
                    { new Guid("64c27c94-09a0-4321-8a6f-35575a5804eb"), "Back", "Clean and Jerk" },
                    { new Guid("6596ac95-6318-41f9-884b-b338813673d0"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("65bb796a-62bb-4527-bdf0-876afca21d4f"), "Legs", "Safety Bar Squat" },
                    { new Guid("66ac0c92-6c70-45db-8c9d-31ad61369ab4"), "Legs", "Air Squat" },
                    { new Guid("68bc0664-790b-4319-8b8b-7a72c2840ce8"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("69720751-c660-43d2-bd0f-c79d9a81dc31"), "Back", "Hang Snatch" },
                    { new Guid("69c58909-3666-41c2-9b03-d4d3d8dfb282"), "Abs", "Plank" },
                    { new Guid("6a467a28-1195-4543-876f-919f09cec27e"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("6ba65508-b9b3-409c-abcf-670708e5b3f2"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("6c859191-c7da-46f6-b6d4-5820dc5449a1"), "Back", "Barbell Shrug" },
                    { new Guid("6d104311-0059-4828-a2df-3bfe68069d52"), "Legs", "Hip Adduction Machine" },
                    { new Guid("6d1c5b5e-ea17-4fcc-9a54-134a878af899"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("6dc038b7-f0af-47e6-a4cd-ae8622aa20ac"), "Legs", "Dumbbell Lunge" },
                    { new Guid("6e5d6be2-1607-4b44-9c83-44148600fe74"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("719cb03a-9d50-483e-b3d9-4308509ade2e"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("72ea5049-f70e-441d-9304-754705f0ecbb"), "Legs", "Goblet Squat" },
                    { new Guid("74547546-4e7a-44f4-ad54-6d805994b694"), "Back", "Block Snatch" },
                    { new Guid("749b0468-22e8-427e-ae39-21a53f974ef1"), "Glutes", "Cable Pull Through" },
                    { new Guid("76604e9c-ad5d-4cc4-8374-ce18da83e030"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("7745c7ff-d280-42bd-affd-5a10e207ad9f"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("7a566137-516a-4998-82ec-a40ab69ffe11"), "Back", "T-Bar Row" },
                    { new Guid("7b8d13f8-00eb-4df3-b138-f332af3ac4fd"), "Legs", "Box Squat" },
                    { new Guid("7c79ad60-e342-4199-872c-695aabd7f4d7"), "Back", "Hang Power Clean" },
                    { new Guid("805bebab-89cf-4a86-b5cd-ba2eca10d93a"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("806ee527-6ca4-4e87-a66e-2a267ec31a25"), "Back", "Dumbbell Shrug" },
                    { new Guid("818160d3-83bc-4550-b184-0da89f1da12b"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("820672f4-dfe2-4ef8-9fcd-143c94daad64"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("84719d65-88fc-4fb2-b7d5-b02cd9486ecc"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("858b4475-0f6f-4dcc-a199-5cab49aa1c81"), "Back", "Power Snatch" },
                    { new Guid("8602b4cc-fef3-421d-b91a-7cc9d3d39fd6"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("86ca8012-7ddf-43a6-a57c-c066274d955d"), "Chest", "Dumbbell Pullover" },
                    { new Guid("86de10d9-b62e-4b0a-b27c-e4e3613632bc"), "Legs", "Squat" },
                    { new Guid("8702a693-2e04-4db2-9cf3-43c29b44888d"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("88c8f9a7-ebc5-4033-9480-7a17e4b1313c"), "Legs", "Front Squat" },
                    { new Guid("88cc8a00-82a2-4ec3-860e-e2cafe5c2b79"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("89594671-0ed8-4efd-be42-dd02b847ed0a"), "Abs", "Hanging Leg Raise" },
                    { new Guid("89d3c98b-3f2f-42ed-974c-0c75e6d2479b"), "Legs", "Lying Leg Curl" },
                    { new Guid("8a9b16bd-26a2-4463-bbdb-f6f472f28dbb"), "Legs", "Dumbbell Squat" },
                    { new Guid("8b38dfaa-3777-476f-ae6c-2149d1ccd0b3"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("8b8e4b2f-4782-4d70-ba96-6b8c8a770a70"), "Abs", "Oblique Sit-Up" },
                    { new Guid("8c0a04e8-a5d1-43b1-81d5-4fd28b452a72"), "Shoulder", "Face Pull" },
                    { new Guid("8e6a8dae-2835-4da5-823d-480b3a3444de"), "Forearms", "Bar Hang" },
                    { new Guid("8e72b825-eb68-46b4-9e4e-f90cd83e9602"), "Back", "Good Morning" },
                    { new Guid("905690e2-cdbc-460d-a603-eed165f57cbf"), "Back", "Clean" },
                    { new Guid("92c9ac3a-d7b1-4f5a-89d8-e398e1e824c1"), "Legs", "Barbell Lunge" },
                    { new Guid("939a6f3b-1912-4494-b0d9-816186314378"), "Back", "Barbell Row" },
                    { new Guid("939df12f-67a1-4b2c-98ab-2560864da81d"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("944447ab-6dc0-49df-b367-558ba9a72f38"), "Bicep", "Concentration Curl" },
                    { new Guid("94f4fe61-81be-490e-ba3b-091fb655d01b"), "Back", "Pendlay Row" },
                    { new Guid("9581a267-0567-44a3-8ae7-0afd6773f584"), "Back", "Pull-Up" },
                    { new Guid("9624c29e-a4fc-4160-b69f-583e2a5d4204"), "Back", "Dumbbell Deadlift" },
                    { new Guid("97ac029c-5547-44de-a588-051bb6b65279"), "Glutes", "Clamshells" },
                    { new Guid("9ac5bf4f-09fc-45b2-8ca0-baab86460e65"), "Abs", "Kneeling Plank" },
                    { new Guid("9ad444ab-5c68-45e0-b566-33274601c835"), "Back", "Rack Pull" },
                    { new Guid("9e70bf69-1b47-4914-a51c-e59246958f6b"), "Legs", "Belt Squat" },
                    { new Guid("a0959dd9-687d-4052-9ca2-1befeb7b4004"), "Back", "Power Clean" },
                    { new Guid("a0f877c2-4881-4227-9ba5-b03bb5973f20"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("a19f1e49-c41a-44a3-8358-7e01fbd573d6"), "Back", "Kettlebell Swing" },
                    { new Guid("a2cbd85d-af56-4586-8a4a-d92eccaef8b6"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("a3b94d89-28ac-486e-9819-8a11a66c1b8d"), "Bicep", "Hammer Curl" },
                    { new Guid("a64a1f30-81db-4845-a13e-91d83528c222"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("a72524f4-453f-4d66-aed4-de978f0e8b7b"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("aa0701ac-73cc-4f20-8c60-5a375a569a07"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("aabb9b2e-ef6f-4359-a4e3-ae812c2fd171"), "Back", "Inverted Row" },
                    { new Guid("ad46c92e-8125-4611-8d6d-b427c3e41a47"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("ae61d0a9-76e8-4bdc-a5cb-4215971a2ddc"), "Forearms", "Plate Pinch" },
                    { new Guid("b06624c5-b4bf-44e8-b3aa-92ada62f63ac"), "Abs", "Cable Crunch" },
                    { new Guid("b1de7b15-cdef-4ca2-b98c-0458c6683629"), "Chest", "Machine Chest Press" },
                    { new Guid("b4e47770-3b5c-4f57-96bb-2b15b48e6700"), "Abs", "Lying Leg Raise" },
                    { new Guid("b55f8df4-22e0-43e4-83ec-678140fd7834"), "Back", "Deadlift" },
                    { new Guid("b63702d7-02d6-483f-b583-66e6ca5d3a47"), "Chest", "Decline Bench Press" },
                    { new Guid("b766f05f-577c-4427-b359-6b931bacb061"), "Shoulder", "Push Press" },
                    { new Guid("b7928caa-1fa9-41b3-b5c9-15051d517740"), "Legs", "Half Air Squat" },
                    { new Guid("b8e9d58e-8ca6-409e-9342-a9c590212de7"), "Chest", "Floor Press" },
                    { new Guid("bb53619e-15cc-4e85-bdaa-97e2d28208b2"), "Legs", "Step Up" },
                    { new Guid("bd3c955d-63a0-4088-be4e-db12241d7503"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("bd82b8e1-48c9-4f34-b791-cb7d1ea8134c"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("bdcb253c-e529-4b8e-b796-3dbdbc22d0f2"), "Abs", "Kneeling Side Plank" },
                    { new Guid("c056a346-8ee1-4217-aab3-fad837a578a6"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("c1b10f06-9bce-47f0-80d9-4c8acbb8b70b"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("c27808f9-765f-4df1-a23d-43f384bd7c41"), "Abs", "Hanging Sit-Up" },
                    { new Guid("c2ab0aff-3ff1-4914-87c6-bfcf82dd936a"), "Glutes", "Frog Pumps" },
                    { new Guid("c5e7d875-b09b-48a7-a0a4-8b37b022fea3"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("c6a75e58-b12b-498a-853b-3046a45180c8"), "Chest", "Bar Dip" },
                    { new Guid("cb38321d-794a-4d0f-9372-1d9ce3454cc4"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("cbab935c-43bd-4d69-a453-92266ce5bcde"), "Back", "Dumbbell Row" },
                    { new Guid("cbad0a53-4e67-4acf-a873-f99f6a1479d2"), "Chest", "Pec Deck" },
                    { new Guid("cc838f4a-1681-4179-a7c6-1b81a8a4b5ec"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("cfb4c9d0-22e0-472e-bb30-fe88605f99b4"), "Shoulder", "Squat Jerk" },
                    { new Guid("d0916c8e-a93b-42a0-a686-ec5a7f298610"), "Legs", "Leg Extension" },
                    { new Guid("d6d2442b-9533-4a70-a561-2229ccc30e97"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("d93e771a-4502-46ff-b60c-9dc20f97285a"), "Back", "Hang Clean" },
                    { new Guid("dadf5230-ac02-4d58-9bf6-5fca694d83de"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("db4aeca9-8e6a-4a2f-845c-e99e7a5e1fb3"), "Back", "Chin-Up" },
                    { new Guid("db8b4591-6822-417b-88d2-9b1c0f15d725"), "Shoulder", "Front Hold" },
                    { new Guid("dbf9d993-27a9-4aad-a754-4b87607cc617"), "Legs", "Landmine Squat" },
                    { new Guid("dcecc604-b40a-4ca0-a343-fd0f027e6844"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("dd959ab3-1603-4d87-8422-48d26cf663ed"), "Bicep", "Spider Curl" },
                    { new Guid("dfe5816a-da0b-478c-b742-564f6b1bd892"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("e6b83667-c0a7-45ea-a9c2-f375106964de"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("e73e3814-38ff-461e-a52a-eeb905ec9e1b"), "Legs", "Leg Press" },
                    { new Guid("e7838f7e-7fdc-41bc-8d4f-c1f514c8ccb9"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("ea45356a-5987-4bf1-885f-03358a5e9caf"), "Back", "Floor Back Extension" },
                    { new Guid("eadabe7b-8c74-4d84-bd6c-28f04d9488d4"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("eb004a92-208b-4fd2-a074-4a52cf0e7ae0"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("ec0019cd-a1cf-4263-afd3-ebd064b95ba0"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("ec3cbb8c-7012-405b-aad8-b4cfed65503d"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("ec6dcc79-e95b-44c1-ba75-ab02f3c2d7e3"), "Abs", "Machine Crunch" },
                    { new Guid("ec72d6de-8b5c-4dec-98b4-d83e81b7b1b2"), "Legs", "Barbell Hack Squat" },
                    { new Guid("ec849770-0ce0-40ea-8696-29f214e6f445"), "Chest", "Incline Push-Up" },
                    { new Guid("ed533c3e-3410-4727-a294-9144df76eecc"), "Back", "Back Extension" },
                    { new Guid("ed8f1fc8-2180-42e7-bbee-8bc9dce6a3cb"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("f0057d6a-285f-4177-9ff8-be157c3ce230"), "Chest", "Cable Chest Press" },
                    { new Guid("f03df2fa-8b28-46b6-9f43-bc7cab39830e"), "Chest", "Incline Bench Press" },
                    { new Guid("f06791c5-3af0-422f-9d2b-860ae641da94"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("f1370741-6f98-487b-b131-86ad342848cf"), "Bicep", "Barbell Curl" },
                    { new Guid("f37ac541-980f-4678-a14f-fd2a1773a63b"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("f4ddd030-9d9a-49f3-adb8-d682136d1430"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("f6c0dd5b-2cde-4c1b-ba10-4490573819f6"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("f802a325-414a-48ff-9cf5-d0a5d1b4fcea"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("f9736e6d-ac01-4539-a7ad-17103975ea0c"), "Back", "Seal Row" },
                    { new Guid("f9a95c3b-bfd9-44af-a4d8-469656f6e09c"), "Glutes", "Hip Thrust" },
                    { new Guid("fb3ef827-1ed5-46c5-a064-e486157bfaae"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("fbabbb21-8107-4526-bfb5-7fb77f235e38"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("fc0e0476-c0cb-4cb8-9935-a764cf750ba6"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("fc4001e9-2d64-465f-83aa-797a087abd15"), "Shoulder", "Plate Front Raise" },
                    { new Guid("fdc32314-42ed-4ecb-9422-5d0bef4187d2"), "Tricep", "Bench Dip" },
                    { new Guid("fe932a02-e283-4c45-a43b-d3abf143ea45"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("13232166-12a9-4291-837e-c36bc014079f"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("2edab41e-cc86-47ee-a4e3-90cf50de539c"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("557684c9-dab2-41da-b330-3a38352fcd39"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("69ddfd40-843f-4b7f-9dd5-6a0807144fda"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("87ad663d-fc5e-40d8-8d50-0dc9ef20b143"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("8ff44ba1-4e46-4b56-ba0e-56b13329b408"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("b2d23c4e-9010-4285-90f0-b2cc26555b24"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("c764c918-9ca5-4480-925a-93098b693590"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("d0bf9565-737e-4c9a-bc23-97aeb8d60e29"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("d1c61f3a-9ed4-4736-a9e1-246eeeab995f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("00ab5804-d495-4a1b-88e3-d33f258ac9be"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0117e0eb-125f-4298-8235-9c04bb3d3bba"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0136675d-49b8-452f-a65e-152039c04d59"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("022de2d7-8d10-4a79-882c-994f553c9164"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("02855195-b463-4c02-a6b1-49dc2be33ae0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03edc057-e114-4724-929e-8a4298e7eef3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("06b8b673-dba8-42ce-af8c-b0dddf0072de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("09479a7b-a584-4117-a953-80b162d787ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("09a23f8c-b59c-44bb-a2ac-20d8352e4747"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0abbfc5e-d12a-450c-8a8e-7cfe6807c89f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b257f11-6f53-4391-af6d-9faa72ab0824"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e5bd895-daf8-4651-9343-b2071a2f510a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0edabeae-e8a2-40e8-a0e5-5273034b4165"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("10d14919-9f8c-472d-87e0-45af2ad010d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("10d6491a-b401-42a2-a376-f6acfa61d9ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1185e0fb-21b6-4008-aca3-2b6c4c3ba88a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("11b316aa-c57d-47fc-afe7-5181f5511a56"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1427aca6-dc99-4975-8eb8-0c13dc2e0b6b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("15d4f748-56bf-4be8-9e59-dd30498744f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1662f27b-8966-413f-912c-728fb9bbe8eb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("19863c5a-7c00-4bba-9432-a5e93a7f3502"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ae68e4e-f48f-4e8d-8e1d-cb72fe4a46ae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ba9cc72-6363-4168-b9e2-f7bc277bb184"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1be28c5b-c952-449d-ba01-9f11914093cf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1c5e81a0-c607-4bb9-8a1d-d1ed37e2c050"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1cbab8e6-7296-4be8-b140-3182bfc269e7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d6a5fbd-6c24-4de8-af2c-ca6fd12464c6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f0c5da0-1b49-4cee-b5c0-c60d94dad7f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20d12742-83e3-453c-8eea-7e55897868d1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20d37a46-fb31-42d4-9e12-3790194a3a8e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("22daf746-ec78-4b6c-9df1-bc86bdd9068b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2507a2ac-4d09-4063-b582-143cae0a5212"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("259bd68b-c447-4553-bcc4-b395e7ba84dc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("261c186e-f729-4da6-bdfb-aa4ce370c21e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2755444e-1b67-4225-99bd-ce5a02212875"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("279b90d0-91bb-4e08-8bc0-9592840dc658"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("27a0cc4d-6457-45b1-80c2-d5111bb26ce7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("28f95f5c-a17e-4e95-a5ab-9e3d83e5638a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2bebf5cc-280f-485b-8112-734f0373cb18"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ef3ed41-1cfd-4919-b836-e1a4bfa1e72d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2f5e9bde-1b37-4cad-ad64-ca993ead9839"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("32583c3f-f2e9-4a26-b2b7-ddaefacccf7b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35d33afa-92bf-430f-b01b-b01eb7800055"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("378622ad-f842-45a5-8a82-d4f7e501c033"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a88ec1b-9b82-4ab9-8720-998ce7d36444"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b37ffbd-b05f-4343-bb2e-ef60a4148fbb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b914478-aa48-44e7-8d2a-185281374d0e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3bb76a5a-03d8-46b4-9fc7-e0ce2f092a0e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3bfb20aa-5017-4071-8873-a46d5b811538"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3c7baf3d-b4e0-4934-b942-78652bec5310"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f2f43d3-519c-4e16-8741-6df978d6afcf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("41414bb1-bd74-4ff8-b785-dc9f96378d79"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("41c02297-f44c-4811-aa80-0a6acf75724b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("41cb8873-2fab-434e-88a5-9faa43eb11c9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4243c6bc-12e5-498a-ba4d-5f95c4223747"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("431572ef-b7ad-42ad-9c96-760a88433fd5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("44a7ace4-50a6-404c-8b06-7de73eae10dc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a34188e-2d45-4240-846f-598711b0c514"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a4b2a09-2704-4c60-a170-d61bc4ad557d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a7bbb50-d52c-4bde-a964-d2d0b4629463"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b68c3da-9fb4-4541-8ee8-ef7ddc762591"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b793035-0dde-4952-8c41-109f0777d49f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4bc615d2-ed69-40f9-a98f-a9b3f4e0675f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4c7ca83d-280b-4377-a6df-123a3acf49b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4e4acfa7-f87d-4504-bf37-9eae4354305f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4ed72749-255a-4fe9-bf7d-09516254910e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4fb7fb88-1abc-46bf-af58-351879792247"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("517aebe9-0610-4ba1-8723-dec622cee0e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("518526d1-6259-4db9-b405-2e40886d1eb2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5255140b-371f-496f-bd0e-bd8f2811b873"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("537e694c-9120-479b-b6ec-bf5603cd230d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5391d90f-7bef-45ea-a884-b2b9fdbc1d70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("54f8df3e-741a-4d4d-8af9-08988965d192"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5575963c-0f1c-4ef6-a9cf-3d3949a73764"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55b5d921-caae-43c4-8bc8-e8097a04fe72"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("57198e7f-5e70-42d8-a48d-bbda9910a52f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("571ec3ff-0a90-44fe-9e8c-f3264564abc8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("597b5e2d-419d-4edc-adc7-26ccf359a920"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b15c505-e6a5-4a1c-81c1-65f6e6fbdd89"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bd1db59-825f-414f-be1d-a958404c274a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c245b26-ed32-4015-8df7-f43825b7b032"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c8bb65f-d8a4-4283-9e1e-b41fe311f799"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ebbc878-c716-4f61-9eba-d36cfb3ee480"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5fe34274-6ef1-4ee7-92b2-e49e9b314ca9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("601085e8-3773-4389-8dac-c342c4360ef6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("634d4d46-cb11-4e09-b1d0-2403630ef512"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("64286389-b0c4-4579-b7a7-6daa29cdabe8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("645e38de-e6f1-4a13-8980-d8e8f942b7ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("647aecfa-1fc5-4f5a-a8f1-f50860666ebc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("64c27c94-09a0-4321-8a6f-35575a5804eb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6596ac95-6318-41f9-884b-b338813673d0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65bb796a-62bb-4527-bdf0-876afca21d4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("66ac0c92-6c70-45db-8c9d-31ad61369ab4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("68bc0664-790b-4319-8b8b-7a72c2840ce8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69720751-c660-43d2-bd0f-c79d9a81dc31"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69c58909-3666-41c2-9b03-d4d3d8dfb282"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a467a28-1195-4543-876f-919f09cec27e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ba65508-b9b3-409c-abcf-670708e5b3f2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6c859191-c7da-46f6-b6d4-5820dc5449a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d104311-0059-4828-a2df-3bfe68069d52"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d1c5b5e-ea17-4fcc-9a54-134a878af899"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6dc038b7-f0af-47e6-a4cd-ae8622aa20ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e5d6be2-1607-4b44-9c83-44148600fe74"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("719cb03a-9d50-483e-b3d9-4308509ade2e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72ea5049-f70e-441d-9304-754705f0ecbb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74547546-4e7a-44f4-ad54-6d805994b694"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("749b0468-22e8-427e-ae39-21a53f974ef1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("76604e9c-ad5d-4cc4-8374-ce18da83e030"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7745c7ff-d280-42bd-affd-5a10e207ad9f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a566137-516a-4998-82ec-a40ab69ffe11"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7b8d13f8-00eb-4df3-b138-f332af3ac4fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c79ad60-e342-4199-872c-695aabd7f4d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("805bebab-89cf-4a86-b5cd-ba2eca10d93a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("806ee527-6ca4-4e87-a66e-2a267ec31a25"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("818160d3-83bc-4550-b184-0da89f1da12b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("820672f4-dfe2-4ef8-9fcd-143c94daad64"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("84719d65-88fc-4fb2-b7d5-b02cd9486ecc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("858b4475-0f6f-4dcc-a199-5cab49aa1c81"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8602b4cc-fef3-421d-b91a-7cc9d3d39fd6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86ca8012-7ddf-43a6-a57c-c066274d955d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86de10d9-b62e-4b0a-b27c-e4e3613632bc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8702a693-2e04-4db2-9cf3-43c29b44888d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88c8f9a7-ebc5-4033-9480-7a17e4b1313c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88cc8a00-82a2-4ec3-860e-e2cafe5c2b79"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89594671-0ed8-4efd-be42-dd02b847ed0a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("89d3c98b-3f2f-42ed-974c-0c75e6d2479b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a9b16bd-26a2-4463-bbdb-f6f472f28dbb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b38dfaa-3777-476f-ae6c-2149d1ccd0b3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b8e4b2f-4782-4d70-ba96-6b8c8a770a70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c0a04e8-a5d1-43b1-81d5-4fd28b452a72"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8e6a8dae-2835-4da5-823d-480b3a3444de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8e72b825-eb68-46b4-9e4e-f90cd83e9602"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("905690e2-cdbc-460d-a603-eed165f57cbf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("92c9ac3a-d7b1-4f5a-89d8-e398e1e824c1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("939a6f3b-1912-4494-b0d9-816186314378"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("939df12f-67a1-4b2c-98ab-2560864da81d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("944447ab-6dc0-49df-b367-558ba9a72f38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94f4fe61-81be-490e-ba3b-091fb655d01b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9581a267-0567-44a3-8ae7-0afd6773f584"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9624c29e-a4fc-4160-b69f-583e2a5d4204"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("97ac029c-5547-44de-a588-051bb6b65279"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9ac5bf4f-09fc-45b2-8ca0-baab86460e65"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9ad444ab-5c68-45e0-b566-33274601c835"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e70bf69-1b47-4914-a51c-e59246958f6b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0959dd9-687d-4052-9ca2-1befeb7b4004"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0f877c2-4881-4227-9ba5-b03bb5973f20"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a19f1e49-c41a-44a3-8358-7e01fbd573d6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2cbd85d-af56-4586-8a4a-d92eccaef8b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a3b94d89-28ac-486e-9819-8a11a66c1b8d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a64a1f30-81db-4845-a13e-91d83528c222"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a72524f4-453f-4d66-aed4-de978f0e8b7b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa0701ac-73cc-4f20-8c60-5a375a569a07"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aabb9b2e-ef6f-4359-a4e3-ae812c2fd171"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad46c92e-8125-4611-8d6d-b427c3e41a47"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ae61d0a9-76e8-4bdc-a5cb-4215971a2ddc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b06624c5-b4bf-44e8-b3aa-92ada62f63ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b1de7b15-cdef-4ca2-b98c-0458c6683629"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4e47770-3b5c-4f57-96bb-2b15b48e6700"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b55f8df4-22e0-43e4-83ec-678140fd7834"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b63702d7-02d6-483f-b583-66e6ca5d3a47"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b766f05f-577c-4427-b359-6b931bacb061"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b7928caa-1fa9-41b3-b5c9-15051d517740"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8e9d58e-8ca6-409e-9342-a9c590212de7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bb53619e-15cc-4e85-bdaa-97e2d28208b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd3c955d-63a0-4088-be4e-db12241d7503"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bd82b8e1-48c9-4f34-b791-cb7d1ea8134c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bdcb253c-e529-4b8e-b796-3dbdbc22d0f2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c056a346-8ee1-4217-aab3-fad837a578a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c1b10f06-9bce-47f0-80d9-4c8acbb8b70b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c27808f9-765f-4df1-a23d-43f384bd7c41"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c2ab0aff-3ff1-4914-87c6-bfcf82dd936a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5e7d875-b09b-48a7-a0a4-8b37b022fea3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6a75e58-b12b-498a-853b-3046a45180c8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cb38321d-794a-4d0f-9372-1d9ce3454cc4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cbab935c-43bd-4d69-a453-92266ce5bcde"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cbad0a53-4e67-4acf-a873-f99f6a1479d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cc838f4a-1681-4179-a7c6-1b81a8a4b5ec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cfb4c9d0-22e0-472e-bb30-fe88605f99b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0916c8e-a93b-42a0-a686-ec5a7f298610"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d6d2442b-9533-4a70-a561-2229ccc30e97"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d93e771a-4502-46ff-b60c-9dc20f97285a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dadf5230-ac02-4d58-9bf6-5fca694d83de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("db4aeca9-8e6a-4a2f-845c-e99e7a5e1fb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("db8b4591-6822-417b-88d2-9b1c0f15d725"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dbf9d993-27a9-4aad-a754-4b87607cc617"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dcecc604-b40a-4ca0-a343-fd0f027e6844"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd959ab3-1603-4d87-8422-48d26cf663ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dfe5816a-da0b-478c-b742-564f6b1bd892"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6b83667-c0a7-45ea-a9c2-f375106964de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e73e3814-38ff-461e-a52a-eeb905ec9e1b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7838f7e-7fdc-41bc-8d4f-c1f514c8ccb9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea45356a-5987-4bf1-885f-03358a5e9caf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eadabe7b-8c74-4d84-bd6c-28f04d9488d4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb004a92-208b-4fd2-a074-4a52cf0e7ae0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec0019cd-a1cf-4263-afd3-ebd064b95ba0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec3cbb8c-7012-405b-aad8-b4cfed65503d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec6dcc79-e95b-44c1-ba75-ab02f3c2d7e3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec72d6de-8b5c-4dec-98b4-d83e81b7b1b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec849770-0ce0-40ea-8696-29f214e6f445"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed533c3e-3410-4727-a294-9144df76eecc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ed8f1fc8-2180-42e7-bbee-8bc9dce6a3cb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0057d6a-285f-4177-9ff8-be157c3ce230"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f03df2fa-8b28-46b6-9f43-bc7cab39830e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f06791c5-3af0-422f-9d2b-860ae641da94"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1370741-6f98-487b-b131-86ad342848cf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f37ac541-980f-4678-a14f-fd2a1773a63b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f4ddd030-9d9a-49f3-adb8-d682136d1430"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f6c0dd5b-2cde-4c1b-ba10-4490573819f6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f802a325-414a-48ff-9cf5-d0a5d1b4fcea"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9736e6d-ac01-4539-a7ad-17103975ea0c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f9a95c3b-bfd9-44af-a4d8-469656f6e09c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fb3ef827-1ed5-46c5-a064-e486157bfaae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fbabbb21-8107-4526-bfb5-7fb77f235e38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc0e0476-c0cb-4cb8-9935-a764cf750ba6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc4001e9-2d64-465f-83aa-797a087abd15"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fdc32314-42ed-4ecb-9422-5d0bef4187d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fe932a02-e283-4c45-a43b-d3abf143ea45"));

            migrationBuilder.DropColumn(
                name: "Level",
                table: "UsersAchievements");

            migrationBuilder.DropColumn(
                name: "MainExercises",
                table: "UsersAchievements");

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0dd78c29-4fe7-4d5a-932e-c631d191b461"), "Chest" },
                    { new Guid("543a6b3c-9998-4da1-b424-d9fc2ee52cda"), "Tricep" },
                    { new Guid("6a577dbb-47a1-41f9-b03c-bc64fc5a9d9e"), "Abs" },
                    { new Guid("6e4a6390-742c-42e1-8deb-5ea67a070ca8"), "Bicep" },
                    { new Guid("7e296865-8de7-48c1-8fd5-7600193dcb3a"), "Glutes" },
                    { new Guid("847fc1ec-3596-4be9-b75b-39ab7e051137"), "Calves" },
                    { new Guid("d73e9bc8-87e3-4637-8acd-0bbb8a8450c3"), "Forearms" },
                    { new Guid("dda7d010-67c9-4406-a4e4-e08cc4a99fad"), "Shoulder" },
                    { new Guid("e09d264f-41d1-4e6c-8993-9d999c44da0d"), "Legs" },
                    { new Guid("e84f6fd7-2157-4c4e-92fd-b1b532816372"), "Back" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("015da803-3674-4220-b978-9aab1f447263"), "Abs", "Oblique Sit-Up" },
                    { new Guid("04a160d8-78a0-4b38-b8f6-561822cb157b"), "Legs", "Seated Leg Curl" },
                    { new Guid("04cb2efa-3ad4-4061-815c-7f412c4e336b"), "Bicep", "Spider Curl" },
                    { new Guid("04cf21ec-cf46-4d4c-9306-55673b32128c"), "Shoulder", "Face Pull" },
                    { new Guid("06174f55-cafd-460c-a14d-e89af60b6348"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("076a795b-484d-41cd-a565-5709eb282377"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("07e6b414-eee9-4f69-9988-67b10bd9d329"), "Glutes", "Glute Bridge" },
                    { new Guid("0b52da9a-6f65-4438-82a8-0b1ade1b54b4"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("0daac06c-b551-4b76-a465-ae436ef0617e"), "Chest", "Decline Bench Press" },
                    { new Guid("0e571194-4b71-4eb0-a753-3bbf251c936f"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("0ef71480-22b7-4eb3-9c8f-7f36fc78372f"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("0f89d9fd-acd0-48dc-94fa-b9ccc3cfe501"), "Forearms", "Bar Hang" },
                    { new Guid("12d475de-c0ac-4fd5-9b78-6ce954f353f8"), "Forearms", "Gripper" },
                    { new Guid("135daf6c-7ac1-452d-b70c-57b0b844386f"), "Legs", "Smith Machine Squat" },
                    { new Guid("141ee2d1-edc9-4ecd-8cfb-553469189a2b"), "Back", "Kettlebell Swing" },
                    { new Guid("14964c19-899e-4f09-8c4d-7c75397d87aa"), "Back", "Dumbbell Row" },
                    { new Guid("17cd465d-9a91-4cae-9ca1-bb2b627f1f69"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("1b0a6b7b-b495-41ac-85d7-9ce48179a92c"), "Bicep", "Bodyweight Curl" },
                    { new Guid("1bbdb6e4-e2e7-4906-b6ef-f372d2e3e820"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("1ca811dc-d499-4888-a008-31bc24d16ecb"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("1de905c2-6fc1-4433-ab54-44f1afbb41ea"), "Calves", "Heel Raise" },
                    { new Guid("1edcffbb-7978-4af1-a51a-e54b10fd9640"), "Chest", "Push-Up" },
                    { new Guid("2061ce7f-d91a-48d0-8efa-8cb57e886eff"), "Tricep", "Bench Dip" },
                    { new Guid("209cde4b-f7fc-453a-ab54-5de4e465c211"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("211d2c61-3019-4d85-bc4e-dc3e121e3a31"), "Back", "Good Morning" },
                    { new Guid("21277e03-7a03-44c7-bb6a-3343f251e344"), "Legs", "Box Squat" },
                    { new Guid("21796907-9ecd-4253-a7dd-d18c23da446d"), "Chest", "Bar Dip" },
                    { new Guid("218287c3-6acd-456b-b510-ec6bb0da6a1e"), "Back", "Barbell Row" },
                    { new Guid("253ea19b-1ade-49a7-af05-fc61537df1bf"), "Legs", "Dumbbell Squat" },
                    { new Guid("256cf3b3-0d58-4fa2-9f41-3aa100f21d0f"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("2777696a-abed-4ced-83af-c5f6ce65fba7"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("28b44186-dc7f-4ee1-acfb-03d47c3609e0"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("2a9019a8-150f-4adc-9d0a-a8e661730f08"), "Abs", "Kneeling Plank" },
                    { new Guid("2a95c536-21cc-4958-8d6e-fe0f04d822ef"), "Legs", "Dumbbell Lunge" },
                    { new Guid("2be2e0b5-4cb7-46a2-b07d-57bd0b2664bf"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("2cf80fe5-abdd-486e-a7c9-ad0eebda8925"), "Legs", "Romanian Deadlift" },
                    { new Guid("2f770831-aa84-457b-bf66-ad219cd35816"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("3000ea77-2fba-44fd-a622-66e3267b3199"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("306a777f-5b6f-4cc5-a361-63e2a28f11ca"), "Shoulder", "Power Jerk" },
                    { new Guid("32210d2f-e79d-4f10-9eff-41924c5f19fc"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("324a74d2-1b71-4cf8-bcc4-f1372d3d8922"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("33ffba2f-a6cd-4dfd-9415-5bae7a0b34a8"), "Back", "Barbell Shrug" },
                    { new Guid("34624f5c-b51e-4aab-a665-7d0d2f176db8"), "Legs", "Step Up" },
                    { new Guid("34a156ed-37aa-49ed-b2dc-60809cedf1f1"), "Legs", "Front Squat" },
                    { new Guid("34a77544-d1f1-4637-bf03-720c3454f2aa"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("34edf814-41e7-41cb-8303-64cff866baea"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("35831330-73a4-4661-a378-af4be37c2b36"), "Shoulder", "Squat Jerk" },
                    { new Guid("35d5ff68-91e3-4749-9f58-d0f1dc1e740d"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("36495f5f-c007-44d8-8313-9c9c2905779d"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("39e08972-1fdd-43dc-8a1d-1f1731937c8f"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("3a822a9f-e7b1-4890-ba58-d09acf81e1db"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("3b45eb76-da0f-4baf-93f0-e62f7daa4991"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("3d3fd164-41c0-45df-87fc-75ad1b7f7fb4"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("3d5e9040-366c-4239-bf81-03e5aa5c95d0"), "Back", "Snatch" },
                    { new Guid("3dfa538a-e55b-4645-aeee-458055bca90b"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("3f554af6-682e-413c-bd39-d9ec0836fe1b"), "Chest", "Incline Bench Press" },
                    { new Guid("4035a337-122e-423b-9f56-7cee04bc018d"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("419dc51f-75a3-4b3e-9448-429e1eb40c4f"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("4630732a-22ab-48da-a549-37e2a27bda9d"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("491c0b3a-2b00-4142-8f48-fa5631c9b048"), "Chest", "Machine Chest Fly" },
                    { new Guid("4a7dba48-80fa-4da4-964a-d381bd5d363b"), "Legs", "Barbell Lunge" },
                    { new Guid("4d44f3ce-acb4-4397-98c3-76474f58fa8a"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("4dac6d3b-e4b7-472a-bbc7-b1c04171053f"), "Legs", "Chair Squat" },
                    { new Guid("4fa8972a-8d1f-4332-9c11-b9050a4d0f0d"), "Glutes", "Hip Thrust" },
                    { new Guid("52053fbb-c145-4260-a9c8-f2355e358fa7"), "Legs", "Air Squat" },
                    { new Guid("5455148e-4d6a-4219-9034-3776b3ee15bb"), "Calves", "Seated Calf Raise" },
                    { new Guid("54888986-5f55-4665-a4fb-d88d2c71f378"), "Shoulder", "Split Jerk" },
                    { new Guid("5701072b-6371-4dcc-ae63-81c41eedb9b0"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("57343099-f98b-46d7-8247-d625ede1de2e"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("57f945c2-9678-45c8-b6cc-6c9e2924c8db"), "Chest", "Floor Press" },
                    { new Guid("58dad23e-6a10-4682-b71e-070f03725375"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("58ed30a5-6499-4101-8f31-f320d35c5f5a"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("5997b97b-11e4-4b86-adf6-3a9bc60c2c88"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("5aed601a-69b0-48da-b184-d4f07d700277"), "Glutes", "Fire Hydrants" },
                    { new Guid("5bb970ed-5a00-46b6-86e2-54f2f02cba00"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("5cac6d71-ca6d-4516-9560-246bfb70e0af"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("5ce1e8bd-0044-47e5-80a3-078ffd24a0f4"), "Bicep", "Dumbbell Curl" },
                    { new Guid("5d09bf14-0b83-40f6-8400-4dd276adb353"), "Legs", "Belt Squat" },
                    { new Guid("5eaeba15-41ce-453e-bba5-7ff0195bbc28"), "Legs", "Pause Squat" },
                    { new Guid("5fc359ac-86c7-44ba-b7e8-eba84dc82848"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("600791f2-0cbb-44ce-b7da-eb71d6145804"), "Legs", "Body Weight Lunge" },
                    { new Guid("62e3aed1-353e-4580-94ef-8be70e9a3777"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("63029ba7-4639-4873-b21e-250d61d48fed"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("672a2782-b134-4d65-8d0f-81a66802ea18"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("67307853-6912-4d8c-bb67-c16192277900"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("67d29f88-5a7a-44ae-b999-4b3c8a023afa"), "Chest", "Dumbbell Pullover" },
                    { new Guid("680d8c6a-15d7-4697-9869-63e875aa0f75"), "Legs", "Leg Press" },
                    { new Guid("68f33161-ba8a-47dc-9738-b18ffc13daa4"), "Back", "Inverted Row" },
                    { new Guid("6ae2d0e9-6367-4395-bdd7-771921d2d5f5"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("6f36c3bf-1d39-4418-a5db-4bcf75ca548d"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("7159a865-d9fa-435b-93a7-06ff09593241"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("716a3aa3-deaa-4cb4-a073-29b74841111c"), "Back", "Back Extension" },
                    { new Guid("71e9f1aa-6246-4da5-84c4-f6a10e5e17c5"), "Legs", "Lying Leg Curl" },
                    { new Guid("72e4373a-8360-494f-8c6b-a51bff23456c"), "Abs", "Kneeling Side Plank" },
                    { new Guid("7401eb4f-f8c7-4d6d-8da2-db0ac73149a3"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("7514a479-663a-462d-b4ca-5824ef676199"), "Back", "Power Clean" },
                    { new Guid("751ea0a5-3bc4-4573-a682-f858425ab5da"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("752dc954-8516-493a-83e3-32ada9555b33"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("75f4be39-7544-45d0-b8e5-3216bd9c80cb"), "Back", "Chin-Up" },
                    { new Guid("76f46cab-45eb-417c-9201-1737c0cc98e5"), "Bicep", "Hammer Curl" },
                    { new Guid("77cb7082-82df-42fd-bbf4-1f34bfed56f1"), "Abs", "Crunch" },
                    { new Guid("7886e4d5-1eb9-4cdd-af55-5f0732184ee9"), "Back", "Hang Power Snatch" },
                    { new Guid("798414ed-3a91-4b11-a0bd-a9ce6e9d6570"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("79c3cd84-9d01-418c-9f5f-7ceea04cb009"), "Back", "Hang Power Clean" },
                    { new Guid("7a01c086-f24e-40b7-859a-0152554159fb"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("7c9870bf-4e66-47f9-97ad-a1a87a1a4df0"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("7cfa72f1-e272-45ba-a871-8428cd7abbbe"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("7de5bb9c-a674-40e2-9426-2ceadbf855b0"), "Shoulder", "Push Press" },
                    { new Guid("7de69e55-361b-4559-9fcf-71797d804eb3"), "Abs", "Cable Crunch" },
                    { new Guid("7ee6b5d8-1195-4dce-97ce-2a6e838f0daa"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("7fb57ea0-685d-4e63-ba1f-ec01605107d5"), "Glutes", "Step Up" },
                    { new Guid("80629717-a8ec-46a7-b262-b2f669929155"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("832a46c5-57e2-4b58-87d6-f5d33d985340"), "Forearms", "Farmers Walk" },
                    { new Guid("836f1420-8b46-4389-9771-015b4d6751c2"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("843eeec5-8e32-41c2-8e60-097ac3e2099f"), "Legs", "Safety Bar Squat" },
                    { new Guid("8472ba0b-dc1d-4cf7-a372-31983575bf71"), "Chest", "Kneeling Push-Up" },
                    { new Guid("8526ab71-d4b1-40ee-b88f-7773b4129076"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("85d00a46-6f07-41d1-8426-21880011c0f9"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("86b7859f-e78f-43fc-b19b-a37a42c3d582"), "Back", "Sumo Deadlift" },
                    { new Guid("87f06a6e-368a-466b-815b-389ec26d8547"), "Abs", "Machine Crunch" },
                    { new Guid("87f91362-1291-4ede-8570-ebf33a152080"), "Abs", "Sit-Up" },
                    { new Guid("8817b275-2bac-466f-8d0b-f37bb3ad3322"), "Glutes", "Frog Pumps" },
                    { new Guid("8820088f-bec2-4d36-a1da-94a82e1c08ad"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("89a79da4-3daa-47a7-a780-f075e9fd3cd9"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("8a4515b1-4950-4c8f-babc-b0b817a7c2f3"), "Back", "Pendlay Row" },
                    { new Guid("8a6cf39f-6355-49de-85b2-3d49334dd90e"), "Glutes", "Clamshells" },
                    { new Guid("8aa1a605-1746-46de-a718-798792d4c9aa"), "Back", "Hang Clean" },
                    { new Guid("8afe3e1c-3bfe-4276-becc-6d8de8eadeb6"), "Chest", "Push-Up Against Wall" },
                    { new Guid("8b00995e-eedc-464f-a20a-da0f76958619"), "Shoulder", "Plate Front Raise" },
                    { new Guid("8caef1e3-b270-4aef-a1c0-1a442a1ad19f"), "Chest", "Bench Press" },
                    { new Guid("8e834889-8824-4f61-8b5b-931a87abc642"), "Abs", "Plank" },
                    { new Guid("8ed4c683-f83a-4cc4-a649-f565af50eac0"), "Legs", "Half Air Squat" },
                    { new Guid("8f178ca5-0dcf-4543-aa0f-986134f845d8"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("900bbe77-da0e-4718-a069-64c369830663"), "Back", "Power Snatch" },
                    { new Guid("902be983-3d3b-4423-abab-f5fdab67d852"), "Back", "Deadlift" },
                    { new Guid("928c9487-58d3-415b-9c1d-85c473d8122c"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("95844b08-f69a-4394-9d53-a0e048272e9d"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("95da91eb-c2ce-42d7-95f4-8f75a11cd740"), "Chest", "Cable Chest Press" },
                    { new Guid("960cdde6-90f4-4fe9-9731-30f52a199519"), "Legs", "Landmine Squat" },
                    { new Guid("9812e108-9d24-4bd6-b4d6-717d59aff715"), "Legs", "Squat" },
                    { new Guid("9871fd67-6efe-4751-a4ca-906d5cd98a70"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("99aa29d4-2ffd-4aa7-922e-1aeea8ae8df9"), "Back", "One-Handed Cable Row" },
                    { new Guid("9b55d90c-d4d0-430b-b2fb-a59e59dc07b6"), "Back", "Seal Row" },
                    { new Guid("9ba20830-9e04-4903-ac50-4ea2937002a0"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("9bc9b5b5-a991-441e-9103-425aac17668e"), "Legs", "Leg Extension" },
                    { new Guid("9bd446d2-1867-4c63-8490-6503b59c9f0c"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("9eaca0ed-71b5-4fe9-bffa-622f406671b7"), "Back", "Pause Deadlift" },
                    { new Guid("a0d742fb-8aea-4109-a44b-eda7de283add"), "Back", "T-Bar Row" },
                    { new Guid("a0e82ceb-5a53-4396-888e-e281af2427b9"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("a2acc40b-228e-4cd0-aea0-646d60ec4dd1"), "Shoulder", "Overhead Press" },
                    { new Guid("a3ed5c83-50aa-46ff-b854-6fa5846573df"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("a60042f4-ca94-4435-ae8d-b83181fade5e"), "Glutes", "Cable Pull Through" },
                    { new Guid("a64f65a5-db97-4607-8588-72aba4c9ef0c"), "Legs", "Hip Adduction Machine" },
                    { new Guid("a7ac4c5e-0664-4280-b8b9-053f80c6c093"), "Back", "Pull-Up" },
                    { new Guid("a829f738-ce92-4ce7-ba0f-5788834ce4ea"), "Back", "Hang Snatch" },
                    { new Guid("a93bd103-2f76-4e5b-af01-8e99e244f43d"), "Legs", "Landmine Hack Squat" },
                    { new Guid("a9de7d8f-af82-41a0-a399-432b2af026dc"), "Legs", "Goblet Squat" },
                    { new Guid("aa1e7668-ecd5-4e30-86da-80d449eec79f"), "Chest", "Incline Push-Up" },
                    { new Guid("aa60fa9c-e227-4050-860a-35455a9e6305"), "Shoulder", "Monkey Row" },
                    { new Guid("aa838d99-ac92-4d8e-abea-38cf01f82f1c"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("aad4241e-b806-435f-86c1-aa670b8a5372"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("aadff977-8f02-4e89-bc8e-a959a64fb7ee"), "Chest", "Machine Chest Press" },
                    { new Guid("ab8f4b9b-5d78-4cdc-9fdb-b90767532646"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("af99ca0c-2285-4ed7-bff7-80bbdd4d597e"), "Chest", "Pec Deck" },
                    { new Guid("afab800d-31f1-4df6-a0fc-dbae8c4c66ef"), "Forearms", "Towel Pull-Up" },
                    { new Guid("b06e9e8f-ff34-4a82-b4ec-ee20173ca68a"), "Abs", "Mountain Climbers" },
                    { new Guid("b18c673a-015b-4bd6-8acc-20abca8c960e"), "Back", "Clean and Jerk" },
                    { new Guid("b4cc7d04-3247-4d11-8bf6-675df494e3f4"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("b835310a-d0bb-41b1-ac2d-ad300cb898fa"), "Calves", "Standing Calf Raise" },
                    { new Guid("b865e8c4-1726-48b0-a008-a982af634ec3"), "Abs", "Dead Bug" },
                    { new Guid("b8f62429-1a71-4ea2-87c1-98ab59b37382"), "Abs", "Oblique Crunch" },
                    { new Guid("b8f8c421-7454-45e7-a760-fc5622587fb5"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("ba5fe42e-2ebb-48a3-b1d7-536ac0294616"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("ba857ef5-c249-49e6-8398-34823a8ece3c"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("bac999f3-a5fe-4639-bc2d-8e75848e1a6e"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("bc7379fa-87cf-4354-b3bb-76595702acf7"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("be45e07f-1d4a-41dd-88c7-9c04448a459a"), "Shoulder", "Front Hold" },
                    { new Guid("c12ce8c1-6cc1-4d64-aae2-d85eb5ff01fb"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("c2669a8e-96ce-4c94-9c3f-8ca02d86ccf3"), "Abs", "Hanging Sit-Up" },
                    { new Guid("c34c916c-e770-4d90-837e-380df89d2460"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("c6193d78-69e6-4271-b522-04b1751504c2"), "Abs", "Hanging Knee Raise" },
                    { new Guid("c83b4902-3ebf-4d2f-9783-d89421611efa"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("c842702c-99cb-4df6-b284-68aaa05cee6a"), "Abs", "Side Plank" },
                    { new Guid("c8eb1386-9c3f-4cdc-b140-82f67af716f2"), "Back", "Rack Pull" },
                    { new Guid("c92d8599-4b2e-4340-95eb-91b622659201"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("c9b9e582-21d9-4adc-8883-5e5c3c747026"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("cc9e278e-fdaf-4599-adb3-f187b709ead8"), "Legs", "Hack Squat Machine" },
                    { new Guid("cd03e4cc-0862-4753-83d9-53111916a8aa"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("cfc081cb-3d26-4374-8547-7503da5606b6"), "Legs", "Barbell Hack Squat" },
                    { new Guid("d04228cf-f742-44e6-80f9-5cb39894b28c"), "Abs", "Lying Leg Raise" },
                    { new Guid("d4d74047-a5ce-49ed-9bd4-768bf4a6dba8"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("d7c199d7-596b-47a0-9048-348d9a4ea955"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("d8d580e1-92b7-440b-b4a2-d803ad2beb29"), "Glutes", "Banded Side Kicks" },
                    { new Guid("dac290ed-6f9e-41c6-ab79-cb8ffbfa1e78"), "Back", "Clean" },
                    { new Guid("dece9cce-f61e-42f6-ab5d-027262d35df9"), "Back", "Dumbbell Shrug" },
                    { new Guid("df6e1674-a7b9-4cc9-b9c3-1f5335fa087e"), "Back", "Dumbbell Deadlift" },
                    { new Guid("dfc13ef3-666b-4a9e-b074-7dcde99a9e4c"), "Legs", "Step Up" },
                    { new Guid("e069d381-4f05-4c89-9cbf-5860703caec2"), "Abs", "Hanging Leg Raise" },
                    { new Guid("e06cba81-1d44-463b-90cb-39f0b6e4e49c"), "Glutes", "Romanian Deadlift" },
                    { new Guid("e142dee5-74cc-40b2-a116-86149708b0e0"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("e31f57ed-27ea-493f-8337-2e2529bbe39a"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("e8e64d5d-a45f-4292-ad40-c52413aa3b02"), "Back", "Seated Machine Row" },
                    { new Guid("ea42c1f6-5688-4c14-b01f-6a5c9ef048e5"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("eab41201-f76b-48a1-a619-83bd999989ce"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("eb18c671-a79c-493f-9090-2e98b4b0442e"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("eb1b4e54-730f-4739-a013-5b77642d911f"), "Back", "Block Snatch" },
                    { new Guid("edf5708f-8e64-4675-94cc-d923e9386c05"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("eea6f336-7e15-4664-ae47-adf4ee3b479e"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("f05be20d-9a5a-4d33-affa-994d578cdb5f"), "Back", "Deficit Deadlift" },
                    { new Guid("f1e684e7-bc17-4c84-ba87-c6f5970c1952"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("f3c70029-ca45-4f28-a645-c409cc091815"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("f455d862-c8d9-449a-ac06-aaf505870820"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("f70257bf-d1ed-4ae5-a24a-a4f2e9727fc6"), "Back", "Floor Back Extension" },
                    { new Guid("fa23ae4a-0f2d-4a8d-a586-0350d1217d96"), "Bicep", "Barbell Curl" },
                    { new Guid("fc71ff7d-dab2-4e5c-be61-97019a892bcb"), "Forearms", "Plate Pinch" },
                    { new Guid("fd26837a-b99a-49d6-bfd4-39e4a7babc76"), "Bicep", "Concentration Curl" },
                    { new Guid("feb692d1-a284-43f4-9d2d-1140742279fb"), "Glutes", "Lateral Walk With Band" }
                });
        }
    }
}
