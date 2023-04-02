using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class rer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("07d19e75-a2b2-46ab-ae62-0fbe1dc0d08f"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("2503921d-ee23-4e55-bc6d-795c39cf9825"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("3302aa3b-86f6-4ecb-b1e6-0b3fc32f3e7b"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("4288c9fa-8a89-4f74-aba1-18d88abec621"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("45ea0862-ce9f-4aaa-bb1d-0aa815384b30"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("4c23d15c-21e5-4234-954d-e7bf4b65343a"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("bb183c51-9428-4d5a-9b6b-08892158d890"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("dd272e82-83d1-4140-b64b-446e26cb3160"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("eee0ea8b-004e-4dd2-9b95-6a87d730cafe"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("fe1c79ce-fba3-4b7c-b0e9-0b5af4880831"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("00aa8d31-b585-4cc8-b8b3-0223f6f59f70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("01859719-4f07-43d5-811c-32ad2626e53a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03b42bc6-6e4a-44e0-b7e2-355e6e81af44"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("048537d3-13de-4020-b380-f2948ba6f122"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("04da86d4-a67d-4a06-9515-9be5691e2149"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0650fde1-d1ec-44c4-9792-f92f7f5700e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0711aab7-d62a-48ec-ae5d-0aab326ee3df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("076ee134-02eb-4889-bc84-3da269548e96"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07f9a3fd-e8c6-48ef-b949-d4abeb7ecf50"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b49834b-a648-4ee6-8890-2b262bd4dbb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0d7d48fa-8d9b-45ae-af32-e118a8f47fa8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e434734-26e2-4854-9df7-caea47ed9a90"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f994db9-aa45-4b78-b87d-cba964345c92"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("11b39362-4c5d-46f2-a3ce-fc888973a21b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("17003901-bebf-41df-8a60-6aded3ad19d8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1790d5c1-c270-4c0d-8a3c-245abb2d1f6a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("17faec90-514d-4e98-964f-d18b1fce5bd3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("190dc03d-1c3d-4073-99ab-ba88e5f980e1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1a83c430-a1fc-499f-81aa-b29d4689151b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d978bc8-fefc-46dd-b668-8a80faad096d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1dd6b197-4feb-4940-9146-0f7452a30507"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ef06462-3a95-4c3e-a001-89ac0f1e1ec2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1fd3ac77-a282-4472-9a42-35f7f351dc51"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2419c863-6fa0-4d59-ae37-380564d6f272"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2478c022-413f-4823-8c4a-6e0c081c7b17"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("255eb60c-d3ae-4ad1-90df-a78aecec7ecb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("25d77e05-3162-4cf9-99d4-27ef057299b9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2663cf60-788c-459b-a61e-6bf6e2ffa8c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26b59f12-9447-4f73-b569-3bded6cae643"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26e8e5c8-1c4c-46e4-a947-5a512e6ba5b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2769a177-0ee0-45f7-9040-48753be7e1c4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("29650dbb-29e0-4745-8e8b-93824381a5cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a8e0984-5989-4c5d-9587-ef642d1560cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2db0f1b0-08b4-42cf-b805-89ebb8b1e962"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ffc779c-3cf4-46da-ad49-064d65df40fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("31e76109-a9c5-44bc-956a-c11271c3e872"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("32e4df50-238d-447c-9323-5276ecd39013"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("342df36c-1530-41c4-bbf7-6c73ad42cee5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35f7c5b7-f933-40b1-8a02-2e6a878dcb2f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35fc2633-c611-459f-bfdc-889aa5088a57"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("37359a9d-962f-4567-bf46-b93986ecd57c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a4ce8c0-618f-4982-812e-679ba30efcc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a863a03-690b-420c-895b-4c330731409c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d8ad340-35be-4ef7-b1af-280f75730ed0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3e73ef88-c89e-46c8-9b00-c0b20ed6750d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("402393d2-9418-43bd-8b12-2f54f2eb0117"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("440d64d8-da83-47aa-a708-baf255eb3854"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("44c24bc3-8ef8-48ee-9491-acac4c963b73"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45b4a27a-edbb-43db-b2e3-e75633d9c976"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45f120fa-a05d-4327-a53e-931d0e17e1ad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("48207ae5-6ab9-4ae2-a307-db253b4b303a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("48cd3123-f820-4199-991e-e7f0fb9c7b93"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a7ce8bb-3fac-4693-af7e-a4e0610d9137"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4aea3de8-1d8c-43fa-bebd-cd830e725ca8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b89db5c-a358-40e9-bb66-34d1d23b9337"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4bdadacc-ba4b-41e8-9dbf-65b85dd1b66a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4be2baec-2928-48c5-9920-4797fc4c2614"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("51171bff-a0a8-482d-b377-d2d9993a27eb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("54c99704-32e2-4db3-a97e-ad7b79430d72"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("559f6c61-7375-4557-9634-d7121f5d3a0d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("55a44225-7e6b-4742-9da3-b406958c916b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("56b70393-755f-48ae-a57e-feb84c4a7916"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("56fbe0a9-489d-4a30-b20b-d2cd737700f1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("580b44ad-15ad-40dc-b914-678c3aa8e43d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("586cb92b-083f-4598-9c47-5827300878b3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("59f91571-f7bf-479d-ae12-06796d3eb985"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5d6e475f-7fbe-4ea1-a812-33afeb14d89d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6014d1fb-c2be-45cf-aa5b-791b089cfd9f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("604fea05-65c6-456c-ad41-1ef499916151"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("644ef566-2ea5-4dd6-b659-a243a625a0fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6729e31b-4493-4f1c-b2af-322c67f2fdec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("674a788b-bbc7-445e-a003-20aa12ed820e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("67ac78a7-8576-472c-8653-255b397b8eee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("68a0f13e-30d8-418d-9cc3-44f775db839c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("693a9d7b-dd72-40f8-8d39-879f5b8cbc1d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6973b0ba-7694-4696-8472-a60cc957eccd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6989f571-22ff-4090-8cf0-837063e3a4f7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6a1d405b-0cab-425e-a3ad-563642237fc4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6b9476d3-7df7-48c6-a98e-8fc0a67e2843"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d99fbbe-fcb9-4be9-91db-9b858c8a37fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6daaee04-8c37-40f9-8ba7-3255d9cf4278"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e056e2f-6656-40d1-b10b-f4702d5943ae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("725f06a9-6dde-4809-8d54-ef9308172bb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7261ec97-9464-4ef9-8fba-c7a22d43d327"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("72bfb545-79ed-49a0-813b-37fcf1248a72"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74776ded-1145-48b2-8c2b-7eb35911d3da"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("75fd673e-fd74-486f-93aa-dd9e3653a9c4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("76fd2121-036f-4fa1-8f7f-49defcc11308"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("774a2142-7284-42d0-b83e-d9602c7e85ee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77f4b2c9-f2ee-42a1-88af-438c7fedf163"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77fb1376-5af6-4a11-a580-23355bf39167"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7bd24425-2260-47c8-a506-d1ef92742363"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7d5870c4-b539-4ded-9377-8ea025b207ff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e0382d6-7238-4e5f-9634-165dfa7532e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e94d909-68eb-42d0-8254-2f428a3d9fec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7f248de6-7cff-4827-b9c8-e57f267b32e4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("83fb0397-788d-4d67-b4b3-f4df35f7b234"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85d619b0-d436-420c-af0a-d9f06f5879fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("868f4dbd-5d81-407e-9968-40dfaec9e965"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86b5bd18-de54-41b6-bdde-ef582204585a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8783928c-ac1f-49b4-81a1-eb09ca210855"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8dd10bad-b9b4-4ed5-972f-f68dc182d2da"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8e17f350-b37b-4839-a078-2a1564d801cb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9093c728-e92d-44fe-9766-6268dca3744a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90b898ef-06eb-441e-a9bd-259ec071e3b7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93b2431a-cf25-469f-8f21-1f45512481b2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93dcc050-ca7a-4a57-bf92-fc95ec4027e6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94d6d001-6cc8-4ce0-80e8-50077394ee70"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95793c8d-33c0-4015-a4fa-3978f05cc7ba"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9637a5ae-c481-4359-9eec-85086bedbf84"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9793e204-a9a7-4842-8d27-692e60ce3f4b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("979b97f1-9be2-49f8-a692-2a240c904ef8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9819624f-22f6-43e7-926b-a9b8aa940603"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9822e0ea-af01-4cb2-9f89-2302da024c41"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("995e6efc-438f-47ae-a577-256adb72f2ff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9af541bf-0d13-4273-aa2a-5dc03ec57cda"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b019f9e-0753-45f0-9829-41cbc8959ec8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b6e7ee2-6dfe-4085-96b7-19ca97a73179"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9bed626c-2a09-4d8b-a345-d60ee837f5c6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9da16b95-f7ac-4128-8a85-85d9c5e07480"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a09c0443-9334-4856-8c6c-41d3b2dd3d89"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0fcba14-baa2-45df-961e-2de578427574"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1028368-b3b6-406b-ad10-f0aa9d3cf1f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1848ddb-f28d-4906-a772-c83830450ecf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1ad7065-413d-4e3f-b3bf-b99bfa89aca6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2d55bc4-7c80-4152-9f53-bc21a86c1386"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a2db30fa-e0ed-4d3f-9d76-02990f2cde59"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a31e165d-6a79-4fe4-aef0-7b2b73a653df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a328c713-ded5-4fa1-b562-7b8cb88a4a51"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a48cd9d5-6fb1-4d33-950d-b983dde1a63c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a4c7fab4-263c-41f2-9dff-5ce2a892c6f0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a566d8d8-6ce3-4f76-9cb1-687f2add5cf8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a640258e-88c9-4a4a-bb07-016b9f36f25a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a8900063-2f89-4d44-998b-3d303d631f8a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aa5be987-c464-45bf-8f7b-e7aae4f23a51"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b04a2307-cfe9-4a9f-8023-86fc405301ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b2d498bf-a623-4c71-8809-3202e56627af"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b34a1fa6-0e13-489f-9fb9-18a2b329fce2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b5272d9d-566f-46f9-be44-9f6f0c38a581"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b66e90aa-063d-48d7-ac45-d0237f105173"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b6accb22-ab60-4ac6-9af2-d3472af89ee0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b6ba1a3b-a0ac-4629-823d-e2bf9dd00899"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b703a12e-db32-4233-92f7-fb4437d9abae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9ac2fca-9293-4da0-b820-d6b5b4a0610e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bb31d734-b515-4e61-ac98-0c5c6eadac95"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bbdca610-41da-46af-b733-47b66e2eecb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bea1d5fe-0fad-47b7-ad1c-388ac761c018"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bedad317-3dbf-4ae1-a2e9-bda84248c38e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bef6df04-1693-458c-a000-708a4374f1bd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bf25b04d-ca97-47a7-95c2-daf6510e6133"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c105fbf0-0ecd-47f9-a8e8-71189c9eb77a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c10c8812-3d21-4157-9c12-5c9b9a391c40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c1131acb-b118-4962-9920-13657f3d599f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c28cf495-8b0b-4394-9cd8-939e71f5a3fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c3c8ead7-e00c-473e-9b4f-356cd2cfb99e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c42796a2-a786-4469-8f8e-42e497284ae7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c476fad6-b6ac-4e87-9db2-8ee7807d58c7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c4b9ebb1-cee9-4d55-8451-f14531b3d9e4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5589cf9-1be5-4a4d-bc33-8acfb67af9d0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5694994-448c-42f2-8f5c-0ca17ab445f7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c865a5c4-2adb-4ea1-934a-78fe32936035"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c882feb6-86b6-40cd-b1b4-609920e1eff2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c9af03a7-b6e5-4e75-8ca7-ac9950898cbd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ca94c4a1-1621-4c26-8bd1-c0b5520ad763"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cbd11a5d-1020-47db-abad-c88405f4d8ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cc0ab1ab-86d0-4ba0-85cc-3f8636ac7de7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ccbbc91a-662b-4c5a-82d4-a0b8d33ce075"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ccc1798b-b9d6-4a09-9aed-cd095b96f48d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd969216-7425-4be6-8988-edff7a6d0d4e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce5360a4-82b0-4a84-a202-8f5ccc1b0ece"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cf415f53-906c-494d-943a-c280db08f650"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d09d0fc7-8e85-4c58-b73e-d33671d0cc62"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d162d59c-c658-4c80-8906-ae46d0eab866"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d1986555-136a-42ad-ac22-bbd47fe8ef53"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d3494381-705f-4e58-812c-cb674e16f6ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d377d25b-9ef1-4c1f-8fc5-a178f5b62467"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d554a0b6-9767-4bea-8ebd-0491e119e299"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d9e79ca6-ec93-4b63-9b83-12c672ee735a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("da66414b-af71-4efb-9f94-4532f8d57679"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("da82bdea-de8c-49ec-b283-0e59a5fc34fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("daaff0e2-663f-4f70-9a3e-11ad94feead5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("db18f154-c0a5-4b46-b74e-24d8636c1a15"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dbc11099-e928-4882-8eb6-e9c1b51b083b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc0fca1c-c4ed-474d-87e6-0a892749a6b9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc23620b-1e4d-469a-a48e-c299e353b3a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ddc67dc9-801e-41f1-8652-078b02ee6bb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ddf38253-0317-41b3-acf8-8175919cda9a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df311d3f-22a1-4bde-b146-b836878a871d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e0f026a2-d866-4c3a-915c-36be76c94399"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e1383fe3-3f73-457a-8f7f-f0bea7077837"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e1711f95-2e4a-462d-a24b-69b57f71aa5f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e2de4182-8d57-40dd-8d7e-063a994f8914"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e3b285f1-ed0c-4da8-91c0-9ada579798df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e3e3f2b6-9eaf-4ab1-ba96-671792b0484c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e565d1a3-d3fd-4352-ac62-ca9fcb19086d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6a98c9f-4b1c-444f-a7e8-ebaea3a22b5d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7d59e21-2847-420d-aec4-63a096303c80"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8da6257-b6e7-4be8-bb29-b46e23dc02f7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e9e81af5-d4e5-4d67-8fd9-8773a465c17f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ea0d45ed-4aa0-4033-85fa-6366cd958418"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ebab9d90-d39a-42e9-82b7-24a5b0e99fae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec6dfae4-5e4a-48e4-b606-938356f798be"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec98ed2b-c04b-47ca-a315-59392f8a5f4a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ec9acd3a-1351-4b23-882a-548535323db4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eee44667-fb74-4f3c-bfc1-621444ae75fa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ef97e075-2268-4870-97f8-efb800211259"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f114d688-6e7d-4797-b341-09dc6ddb076f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f12144a3-caae-4231-aa47-8e984fc49d2d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f34a3e42-789c-4c63-b4d0-ff893d70471b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f36cb40d-08ae-4e57-a775-8caf93490f34"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f68b49a8-e8e0-4add-be30-18e0c99c1de7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f6946e2d-0e9f-45e4-b8a2-e9ea62946cd3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f7572984-53a5-4f49-b39b-4cd1dc91099a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f7712579-c71b-41a2-b1f4-d2f185e8b495"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ff7f6b93-2cea-4bcc-a33a-443c98fc7bf1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fff6690d-eaa9-4d27-9cbd-57ff2984de01"));

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkoutDate",
                table: "LogMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1579d6c9-2d38-40d1-bcbf-1acc4ef32990"), "Calves" },
                    { new Guid("1c82b7d8-e087-48fd-a167-e39723d61f84"), "Back" },
                    { new Guid("44820426-4a1b-406b-ab99-3c1140e6f333"), "Shoulder" },
                    { new Guid("57d920ab-c8a1-4414-bd93-45324b814152"), "Bicep" },
                    { new Guid("76f3593b-f5a0-47bf-a2b5-8836bcfec3f2"), "Abs" },
                    { new Guid("787f9ee7-f378-4156-bfe3-e4f06af7b976"), "Legs" },
                    { new Guid("85916128-e445-4542-9787-eb88c7da5a0c"), "Tricep" },
                    { new Guid("aa1c05d8-dbc3-4999-82c4-c87733e48a8b"), "Chest" },
                    { new Guid("b032d452-e9cb-4729-bd34-dd145289a03f"), "Forearms" },
                    { new Guid("faa4e07d-4d17-4238-9284-532eacc5db86"), "Glutes" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("006d0fc2-635d-4a8b-b9a3-ce83125d7888"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("00b983e3-7798-485c-a90e-6147ce0a674d"), "Calves", "Seated Calf Raise" },
                    { new Guid("028b4edf-43e0-41ea-88da-174d295d3bd7"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("03149533-66ed-40ef-9414-ecbfd075ccef"), "Shoulder", "Face Pull" },
                    { new Guid("03a01497-317c-4c31-8e0e-63bfc110347a"), "Chest", "Dumbbell Pullover" },
                    { new Guid("0502aeb5-6059-4502-9118-2d6bd7e381b5"), "Chest", "Floor Press" },
                    { new Guid("05f55b2c-06c6-47dd-bd58-1a7a76c83198"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("070652d6-59d2-413d-8e74-622d4aefd2fb"), "Legs", "Leg Press" },
                    { new Guid("0719426b-74ee-4b17-960f-e4272fb1665e"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("0726fd8e-17b2-4c04-a903-b6dd0a5f1c9f"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("07c2f4a3-ae0b-4d28-a6a6-8f5e16a1dcd7"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("09c5a6f1-3adb-4d03-8615-7eca627a4f09"), "Back", "Chin-Up" },
                    { new Guid("0b224738-3ee6-49b9-8a96-47486318e210"), "Shoulder", "Plate Front Raise" },
                    { new Guid("0dac05cf-3018-4677-b4df-261fc794a99e"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("0fb225bf-500a-431e-beb6-1797caf37f81"), "Legs", "Lying Leg Curl" },
                    { new Guid("126b45f6-73a8-4750-bd8e-56f9e18e235b"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("1388c65c-84c1-42d2-8b41-9b5e5673b1a0"), "Chest", "Machine Chest Fly" },
                    { new Guid("14f2144b-1f44-45e5-90d9-b3e9385527c3"), "Abs", "Kneeling Plank" },
                    { new Guid("15033df6-fa3a-44ce-91f5-6777f63bedcc"), "Back", "Good Morning" },
                    { new Guid("1511badd-17c4-4c03-a2c4-6349fe85fbe9"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("15a70278-bf49-4cbe-ad22-7265d691abb0"), "Back", "Clean" },
                    { new Guid("15d8a891-c575-426c-9f50-7c0074e78e59"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("162b3dd4-6601-4776-b70c-1524bf541281"), "Forearms", "Towel Pull-Up" },
                    { new Guid("18b2985b-1087-453d-af89-333f439a4e6c"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("1a3ff2b5-f8b0-4176-8ee4-6d0eb4cb7196"), "Calves", "Standing Calf Raise" },
                    { new Guid("1d7565d7-420b-4c79-8bb0-cfb45e8f7e3c"), "Back", "Block Snatch" },
                    { new Guid("1db46b1c-c568-45b9-bd55-f5d17d41644c"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("1efc8ade-8bd8-489d-afb2-92dc114b5d0f"), "Glutes", "Banded Side Kicks" },
                    { new Guid("1fbac780-d0a6-41ad-ba3b-9c8fcfc8fc02"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("1fc3aca2-b66b-4ffe-8042-ec57cf088927"), "Abs", "Hanging Sit-Up" },
                    { new Guid("2001d410-8d8e-41eb-a64d-d7e09982fb8b"), "Abs", "Mountain Climbers" },
                    { new Guid("2048c242-a4cf-4645-993c-cc19ac08c27d"), "Abs", "Hanging Knee Raise" },
                    { new Guid("20d2a6cd-bf1f-4ca0-a394-778b6b13771e"), "Legs", "Step Up" },
                    { new Guid("2211ed77-7499-4252-8f0f-ad1d3f8d3163"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("23fef4c0-e03e-41f8-bdc5-fc765854bcb9"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("2643b1e9-6dc5-4c6a-8738-5bf4fbe0d08d"), "Back", "Hang Power Snatch" },
                    { new Guid("26b386f4-737b-4212-9b72-7b9dd919aa24"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("290e3414-c68e-45eb-b2ef-36f77ede8318"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("2a485965-90a4-46a6-9c0f-60f87a634eb7"), "Abs", "Plank" },
                    { new Guid("2b5bda05-2568-4a36-a025-ea09017b807a"), "Shoulder", "Power Jerk" },
                    { new Guid("2c9fbba7-5128-40b3-aba9-c9b07831cdff"), "Glutes", "Hip Thrust" },
                    { new Guid("2ec1e419-73fd-4310-800f-5b5d0aba8bb5"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("2ec342e5-eee3-4ac2-a9f7-5ee851ae0c2f"), "Back", "Pull-Up" },
                    { new Guid("2ec36fe4-ad63-42d9-8ad2-e338bff429a0"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("2edcc802-4b1d-4818-bc23-68b90aece419"), "Back", "Seal Row" },
                    { new Guid("31d72622-7aec-4af9-b4c1-c7c7c3485ea0"), "Legs", "Belt Squat" },
                    { new Guid("3222b9f3-f158-4031-b4be-b9cd382eb5b5"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("342df3f0-3358-4ca2-990a-53371ac864ae"), "Abs", "Hanging Leg Raise" },
                    { new Guid("353d860a-f604-42c7-a956-db126d45a109"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("35d839df-d08b-497a-9238-e3752a8d09c6"), "Chest", "Push-Up" },
                    { new Guid("36ac9b79-d7bf-44b8-9abd-9bfb10efd271"), "Back", "Pause Deadlift" },
                    { new Guid("36f0c643-6c71-4a6f-94d3-53e4b123e03a"), "Abs", "Oblique Sit-Up" },
                    { new Guid("38441205-89c7-4b70-8741-07adc5e78265"), "Chest", "Decline Bench Press" },
                    { new Guid("3a52c520-c90d-47fb-892c-72c724ceee9c"), "Legs", "Squat" },
                    { new Guid("3b773bdd-98d2-4845-b2ce-a701b3b90bbd"), "Legs", "Landmine Hack Squat" },
                    { new Guid("3e163919-fe59-46e5-9d96-04a3aea2c96f"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("412767aa-95b6-4e76-bb17-919f24c422fc"), "Chest", "Machine Chest Press" },
                    { new Guid("4195ee9f-a70a-4f87-92ce-1d803275713e"), "Legs", "Smith Machine Squat" },
                    { new Guid("42d00e3d-be75-473e-b5bd-2057ef9dbdc6"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("458cf334-0d0b-4951-94b4-8f39f1b3d919"), "Legs", "Goblet Squat" },
                    { new Guid("45fa84ad-0ace-4899-aeed-c17062ea10b5"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("46b205ee-5182-4c51-8620-4e3e50336845"), "Abs", "Kneeling Side Plank" },
                    { new Guid("4723e148-1892-44fa-806e-138b72fc1a56"), "Legs", "Body Weight Lunge" },
                    { new Guid("4851b232-eb74-43d1-b1a2-3c8ff13cd7fb"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("494c0356-3221-4e83-ad45-2ad1613e1642"), "Forearms", "Farmers Walk" },
                    { new Guid("4a33dcf3-ab79-49a8-aa32-fbbaebb712a7"), "Glutes", "Glute Bridge" },
                    { new Guid("4aa340db-7580-4928-9806-f748b2d4ab4e"), "Back", "Clean and Jerk" },
                    { new Guid("4b0d6401-4b88-49d4-92ef-ae7f69f6d148"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("4b1cb68d-d2ee-433b-b1a4-7fa1d03fb437"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("4d56ca16-6bbd-4dbe-ae46-b86c1307141b"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("50580ee4-df08-40f0-9ef2-89909e2a866e"), "Bicep", "Hammer Curl" },
                    { new Guid("515e0609-2fb6-4723-801a-8656cf0eb8b7"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("5238eff7-dcd6-483d-a2f7-dd50021fd74b"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("54410007-7642-49fe-9763-5145b2d0b1a3"), "Abs", "Cable Crunch" },
                    { new Guid("54a5259a-f5ce-449b-867c-b736fb831a48"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("59a65044-3306-46e8-948b-d4b011d1b47a"), "Forearms", "Plate Pinch" },
                    { new Guid("5ac6b9b4-7edf-44a8-b3b2-520cdf269124"), "Bicep", "Dumbbell Curl" },
                    { new Guid("5b108e73-db02-42f6-a92c-955c75f31070"), "Back", "Deadlift" },
                    { new Guid("5c1cb5a8-5257-46a3-92fc-db11efe17855"), "Back", "Barbell Shrug" },
                    { new Guid("5e8326d9-fd0a-4c05-9cab-62dce868d601"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("5edb419a-d994-4342-86ab-6fabbb77440a"), "Bicep", "Concentration Curl" },
                    { new Guid("5ff4d12c-0fb6-458f-a1ca-543113ffbe17"), "Legs", "Hip Adduction Machine" },
                    { new Guid("620f4822-4672-43c5-8fc3-0cae99063a87"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("6299fe86-7da3-4a22-b37b-03cf658e84bc"), "Legs", "Air Squat" },
                    { new Guid("64637b9b-ba06-4e9f-b0da-3706c0946898"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("65307cc5-29f4-408d-8433-c6ab29974ec3"), "Legs", "Safety Bar Squat" },
                    { new Guid("65969d5e-d2fc-4c38-80d5-4b32c9f7fb78"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("65fe7e75-76e7-42a6-89e1-87119dfbdbc1"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("6726fbab-a837-4245-8d50-76d5dd4a7521"), "Abs", "Oblique Crunch" },
                    { new Guid("675e8689-9a83-453a-a679-73f24b8e06a8"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("69126b31-fbe9-4d8f-935b-29b929fb7a2a"), "Back", "Sumo Deadlift" },
                    { new Guid("69768b67-c3b5-4402-b329-453cd8b197aa"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("6b639580-9a9f-4eaa-8419-056d80d830e2"), "Shoulder", "Front Hold" },
                    { new Guid("6b669c64-b49d-4747-9b64-e9420898fdad"), "Back", "Hang Clean" },
                    { new Guid("6c28b7b6-5c23-4898-9075-bd2dc5f74e7c"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("6d566a5b-bccb-4daa-9ac8-ad016781514a"), "Abs", "Side Plank" },
                    { new Guid("6d8ef9ee-f5d4-4f1d-bd7a-82568e749858"), "Back", "Hang Snatch" },
                    { new Guid("6e12f583-dea9-4e12-8bb5-8704f0ce8f43"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("6fdc5f34-cd56-4fe3-b740-2e33ab3e2006"), "Abs", "Sit-Up" },
                    { new Guid("71346909-bedb-4f02-bbf1-62f5c6a39239"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("7282e941-4c6f-4641-9a67-56df4bac8ceb"), "Back", "Barbell Row" },
                    { new Guid("747a0582-28e6-4523-9fbf-b27463f5ccd7"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("74ee836e-ed66-4753-a016-4fc2b8ce549a"), "Legs", "Seated Leg Curl" },
                    { new Guid("763e06bb-e532-4134-a199-68d7e4ed5147"), "Legs", "Front Squat" },
                    { new Guid("767226db-cd2e-4d39-8f9f-aab617606eab"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("772e26fd-f50f-4dc2-88d5-7182a98411bc"), "Chest", "Kneeling Push-Up" },
                    { new Guid("7ba2191e-4eb0-410c-9074-5cd554566f43"), "Bicep", "Bodyweight Curl" },
                    { new Guid("7cf83b40-7141-4a0c-8b39-03b0d516215e"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("7d99f2fd-f4c7-455c-8f10-110559620679"), "Back", "One-Handed Cable Row" },
                    { new Guid("7e47a50c-f265-4c65-b238-7cf216930ed6"), "Back", "Hang Power Clean" },
                    { new Guid("7e907938-8516-4d2f-9b59-2020e80452db"), "Glutes", "Fire Hydrants" },
                    { new Guid("7f0161f9-775b-4f8a-8925-b6262efe4201"), "Back", "Dumbbell Row" },
                    { new Guid("839a1cc6-c3d6-4e7f-a007-f4764307d5dd"), "Chest", "Bar Dip" },
                    { new Guid("85c75a57-3f8a-479d-a750-6f0c1784380b"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("88e9401c-a418-4b17-9ae8-bf4a826f7b47"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("8b635a3d-8ad9-4d23-a0e9-8cff5093b1dc"), "Bicep", "Spider Curl" },
                    { new Guid("8b6ac436-8e4e-4ef2-8c12-b22b8c6c0f4e"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("8b7faf9d-80a9-4405-8f9b-238f9b1e0432"), "Back", "Power Snatch" },
                    { new Guid("8ba02b77-4a28-4606-bcfb-5d0d1e62afb5"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("8bee26c5-7334-4b40-9a92-70cda07d0602"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("8d8ca520-cc8d-46df-8d0c-4314d8e5053f"), "Legs", "Half Air Squat" },
                    { new Guid("8dc6fc40-2511-4dcc-a1a5-b6746235a65f"), "Shoulder", "Overhead Press" },
                    { new Guid("8f4f6124-f071-409c-8569-406b92593472"), "Shoulder", "Split Jerk" },
                    { new Guid("8fdfa8e4-9d4a-48a7-b56c-204da0708021"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("90be2fde-84c0-469a-a4f5-df46619594bf"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("91ae2e26-20e7-432e-b43b-78f5e2c3f4d6"), "Abs", "Dead Bug" },
                    { new Guid("92545585-2f18-4b43-a523-93ace5a56474"), "Legs", "Step Up" },
                    { new Guid("950eace8-e097-49d3-8123-f980b38f9ce8"), "Legs", "Dumbbell Squat" },
                    { new Guid("95685fc4-593b-4a8f-8008-eaa29b7a16d3"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("96c73dc2-0759-4194-8a0d-ace9f65e367c"), "Back", "Seated Machine Row" },
                    { new Guid("971723d6-8612-4162-93b2-9f7d5ce8aa5e"), "Back", "Power Clean" },
                    { new Guid("97293cba-e851-4054-bf52-4adeb9302965"), "Shoulder", "Squat Jerk" },
                    { new Guid("97874de5-bcc6-4f9d-826a-167de4c951df"), "Chest", "Cable Chest Press" },
                    { new Guid("97feb7f0-d010-4b55-bde6-f085854fa5f3"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("98212d18-d2dc-4e6a-ad0c-4ddd32aadadd"), "Glutes", "Frog Pumps" },
                    { new Guid("98fb9fae-3990-4b21-a9c6-9dd86c3576d0"), "Legs", "Box Squat" },
                    { new Guid("99c08f9d-493c-4e8c-b3a0-ab55c507c0de"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("9b364365-407b-45d4-a3ed-a35cc13786be"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("9bb6638d-396f-4baa-863b-548abcac3f2d"), "Tricep", "Bench Dip" },
                    { new Guid("9c66784c-8b0e-4ffc-9bd1-a9d3a9ca41a2"), "Back", "Rack Pull" },
                    { new Guid("9cc413c6-4316-4711-9452-1d000b6bfb6a"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("9db42bed-60c8-44db-850e-2010a67ad1c9"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("9f52d62f-e313-468d-9ca8-9fc288f3a90f"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("9fec56a3-1a32-4b0e-9820-e260b872289c"), "Back", "Deficit Deadlift" },
                    { new Guid("a0143c34-5567-4ac3-9213-3802d7310131"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("a1937d02-df19-4a93-92e3-2f7595467edd"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("a225063e-17ec-4c05-a50f-4ca46478c7d1"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("a299cfb9-1d0c-4da2-b18e-f040dcbcc49e"), "Chest", "Bench Press" },
                    { new Guid("a3809885-4ed2-49ea-af4a-d4d88044cccc"), "Back", "T-Bar Row" },
                    { new Guid("a703108f-e93f-423e-941d-106dd9288dfa"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("a88833a1-3711-4c57-8a06-7a985ac429bf"), "Glutes", "Clamshells" },
                    { new Guid("a8d4f302-4621-4376-afa7-a7093be80ff6"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("a9d6b96d-78a6-431c-8293-d8cae482354d"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("a9f016d7-6833-421e-8999-c1ebd4ce5719"), "Legs", "Pause Squat" },
                    { new Guid("aadcca22-a98e-439f-b855-ea6c6ed08251"), "Back", "Pendlay Row" },
                    { new Guid("ac143a63-3639-4108-920d-76e19b5970a1"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("ac2a593e-f8e1-4a87-b55c-f8f69292d991"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("ad4087f1-2523-46ad-83a4-7e25992317a0"), "Legs", "Leg Extension" },
                    { new Guid("ae6ab67b-32fe-411e-b750-dc8650e0bac6"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("aed1a3a3-3bb6-47db-9b78-d911e790b0ad"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("af954e06-4cf4-4bc8-b221-07dd391b78de"), "Glutes", "Cable Pull Through" },
                    { new Guid("b1128ef8-537f-4b98-965f-7f5de64c0bfc"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("b16278f4-e5cf-42f6-80de-459564daf751"), "Legs", "Barbell Lunge" },
                    { new Guid("b330967a-e0e7-4a01-b165-ec5028a65c20"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("b39f897f-7bca-4cbb-8935-335822e48dfe"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("b4f83785-8b8c-4c0d-a1be-4660161e6697"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("b63fba35-0487-4e4a-bb89-0828cc8935c5"), "Glutes", "Step Up" },
                    { new Guid("b6a1e679-8da2-40f3-a6bc-c14555ffa5b3"), "Back", "Inverted Row" },
                    { new Guid("b73211ec-d9e2-4708-a909-bb977b28bc57"), "Calves", "Heel Raise" },
                    { new Guid("b743b8c8-69d8-4ef2-ac67-42d3db2885d2"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("b83e3d2c-4463-4115-a01f-5a571af09f07"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("b9e4a7e3-3802-4921-801e-457219f28ed0"), "Legs", "Chair Squat" },
                    { new Guid("bc49e88a-fdb8-46c3-ae7d-6cb677f01aab"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("be580e59-e684-46e1-b6c4-9adde2bc0c0f"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("c09e8c53-b20c-4c38-8abf-36f3e0360387"), "Abs", "Crunch" },
                    { new Guid("c28eb57a-9279-4d33-b062-ef1a4f5e9146"), "Back", "Dumbbell Deadlift" },
                    { new Guid("cad931d3-1c79-4f65-964a-eab89ebbced0"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("cc52a9ea-ee30-44d2-bb1a-b12b22048ebc"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("cd852944-643e-4585-b839-64567d6f55be"), "Back", "Dumbbell Shrug" },
                    { new Guid("cde0b527-05f8-493f-9035-548934f6b7c7"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("ce54176d-4664-40f9-a405-b031dfbcf907"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("d015dac4-d082-4e08-827b-25d77627453f"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("d0ee2ff3-2696-4b7f-b109-1737dc9f78a7"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("d1a50ed3-4f72-4413-a47e-125ee84d34cf"), "Shoulder", "Monkey Row" },
                    { new Guid("d3481d85-eb94-4843-a4a8-31ea9b491d97"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("d4422b5d-2290-4420-b659-27bc2b95385d"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("d4ddb7b3-9e5f-4da1-9e06-8260aaa3c741"), "Legs", "Dumbbell Lunge" },
                    { new Guid("d4de873a-5b1c-4e76-848f-18e02f1c83ab"), "Back", "Snatch" },
                    { new Guid("d676c8da-b46b-4072-82f0-cff83770eee4"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("d69be103-455a-4acc-a152-87cba2738e68"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("d6ab7573-9559-4742-a2df-76f30bdf4143"), "Chest", "Incline Push-Up" },
                    { new Guid("d736a6d0-29c8-447e-8b70-f9407216a3ef"), "Legs", "Barbell Hack Squat" },
                    { new Guid("d824f78b-ab54-4e92-9326-8f774cca206f"), "Back", "Back Extension" },
                    { new Guid("d8ca87c6-ae84-4cf0-a0b5-c40ac4a791aa"), "Chest", "Incline Bench Press" },
                    { new Guid("db2a6497-ffdc-4836-bf5f-c36101eb68ba"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("dd775647-dab3-4db8-a361-7e6ae485d2cc"), "Abs", "Lying Leg Raise" },
                    { new Guid("de8aa49e-8ea9-41a0-be82-ccaeeabdd731"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("df06c866-ae8e-44c6-97ba-d9e53438db44"), "Shoulder", "Push Press" },
                    { new Guid("e10a56dd-6ba8-4e3d-9211-d0c16eeb0be9"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("e322aaca-5fc5-4e36-b997-d958c35747c5"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("e33c3d7d-5262-41e0-ac48-483af142982e"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("e4147921-c97e-40a0-aaba-a1c534e688a5"), "Chest", "Pec Deck" },
                    { new Guid("e4392c65-b5b6-41b0-a134-e62322096e7c"), "Abs", "Machine Crunch" },
                    { new Guid("e43bfcbc-4d19-4ed5-8b11-371e20d6b33d"), "Back", "Floor Back Extension" },
                    { new Guid("e440728f-0e93-411e-aeb5-15aa93373828"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("e593a4d5-bd1e-4f09-88bc-24f61370e465"), "Bicep", "Barbell Curl" },
                    { new Guid("e6fb5125-8a46-4f12-895f-3fcb5939dccb"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("e714e173-b3fe-45b9-94da-1bbdef91a81d"), "Forearms", "Bar Hang" },
                    { new Guid("eb1d8382-b406-490e-b05d-40ab07553b4c"), "Legs", "Landmine Squat" },
                    { new Guid("ecd68744-9172-46f0-964c-4898f6783d1c"), "Legs", "Hack Squat Machine" },
                    { new Guid("f195b90f-75c2-4524-959f-bf7735ff16f3"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("f48b500d-8534-40c0-80eb-de938bf9280a"), "Forearms", "Gripper" },
                    { new Guid("f822498e-58e5-40b9-bf54-85e033fbf080"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("f98cd195-f8c8-4552-8f3f-5f43b005c2db"), "Legs", "Romanian Deadlift" },
                    { new Guid("fa94b6a6-f7a8-4ffd-ae5b-201eb5749a04"), "Chest", "Push-Up Against Wall" },
                    { new Guid("fc3684e1-a08f-4ab0-ab35-18e2a3360b57"), "Back", "Kettlebell Swing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("1579d6c9-2d38-40d1-bcbf-1acc4ef32990"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("1c82b7d8-e087-48fd-a167-e39723d61f84"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("44820426-4a1b-406b-ab99-3c1140e6f333"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("57d920ab-c8a1-4414-bd93-45324b814152"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("76f3593b-f5a0-47bf-a2b5-8836bcfec3f2"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("787f9ee7-f378-4156-bfe3-e4f06af7b976"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("85916128-e445-4542-9787-eb88c7da5a0c"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("aa1c05d8-dbc3-4999-82c4-c87733e48a8b"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("b032d452-e9cb-4729-bd34-dd145289a03f"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("faa4e07d-4d17-4238-9284-532eacc5db86"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("006d0fc2-635d-4a8b-b9a3-ce83125d7888"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("00b983e3-7798-485c-a90e-6147ce0a674d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("028b4edf-43e0-41ea-88da-174d295d3bd7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03149533-66ed-40ef-9414-ecbfd075ccef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03a01497-317c-4c31-8e0e-63bfc110347a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0502aeb5-6059-4502-9118-2d6bd7e381b5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("05f55b2c-06c6-47dd-bd58-1a7a76c83198"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("070652d6-59d2-413d-8e74-622d4aefd2fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0719426b-74ee-4b17-960f-e4272fb1665e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0726fd8e-17b2-4c04-a903-b6dd0a5f1c9f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("07c2f4a3-ae0b-4d28-a6a6-8f5e16a1dcd7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("09c5a6f1-3adb-4d03-8615-7eca627a4f09"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0b224738-3ee6-49b9-8a96-47486318e210"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0dac05cf-3018-4677-b4df-261fc794a99e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0fb225bf-500a-431e-beb6-1797caf37f81"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("126b45f6-73a8-4750-bd8e-56f9e18e235b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1388c65c-84c1-42d2-8b41-9b5e5673b1a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("14f2144b-1f44-45e5-90d9-b3e9385527c3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("15033df6-fa3a-44ce-91f5-6777f63bedcc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1511badd-17c4-4c03-a2c4-6349fe85fbe9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("15a70278-bf49-4cbe-ad22-7265d691abb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("15d8a891-c575-426c-9f50-7c0074e78e59"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("162b3dd4-6601-4776-b70c-1524bf541281"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("18b2985b-1087-453d-af89-333f439a4e6c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1a3ff2b5-f8b0-4176-8ee4-6d0eb4cb7196"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d7565d7-420b-4c79-8bb0-cfb45e8f7e3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1db46b1c-c568-45b9-bd55-f5d17d41644c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1efc8ade-8bd8-489d-afb2-92dc114b5d0f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1fbac780-d0a6-41ad-ba3b-9c8fcfc8fc02"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1fc3aca2-b66b-4ffe-8042-ec57cf088927"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2001d410-8d8e-41eb-a64d-d7e09982fb8b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2048c242-a4cf-4645-993c-cc19ac08c27d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20d2a6cd-bf1f-4ca0-a394-778b6b13771e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2211ed77-7499-4252-8f0f-ad1d3f8d3163"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("23fef4c0-e03e-41f8-bdc5-fc765854bcb9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2643b1e9-6dc5-4c6a-8738-5bf4fbe0d08d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("26b386f4-737b-4212-9b72-7b9dd919aa24"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("290e3414-c68e-45eb-b2ef-36f77ede8318"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2a485965-90a4-46a6-9c0f-60f87a634eb7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b5bda05-2568-4a36-a025-ea09017b807a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2c9fbba7-5128-40b3-aba9-c9b07831cdff"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ec1e419-73fd-4310-800f-5b5d0aba8bb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ec342e5-eee3-4ac2-a9f7-5ee851ae0c2f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2ec36fe4-ad63-42d9-8ad2-e338bff429a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2edcc802-4b1d-4818-bc23-68b90aece419"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("31d72622-7aec-4af9-b4c1-c7c7c3485ea0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3222b9f3-f158-4031-b4be-b9cd382eb5b5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("342df3f0-3358-4ca2-990a-53371ac864ae"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("353d860a-f604-42c7-a956-db126d45a109"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35d839df-d08b-497a-9238-e3752a8d09c6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36ac9b79-d7bf-44b8-9abd-9bfb10efd271"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36f0c643-6c71-4a6f-94d3-53e4b123e03a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38441205-89c7-4b70-8741-07adc5e78265"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3a52c520-c90d-47fb-892c-72c724ceee9c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3b773bdd-98d2-4845-b2ce-a701b3b90bbd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3e163919-fe59-46e5-9d96-04a3aea2c96f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("412767aa-95b6-4e76-bb17-919f24c422fc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4195ee9f-a70a-4f87-92ce-1d803275713e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("42d00e3d-be75-473e-b5bd-2057ef9dbdc6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("458cf334-0d0b-4951-94b4-8f39f1b3d919"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45fa84ad-0ace-4899-aeed-c17062ea10b5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("46b205ee-5182-4c51-8620-4e3e50336845"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4723e148-1892-44fa-806e-138b72fc1a56"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4851b232-eb74-43d1-b1a2-3c8ff13cd7fb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("494c0356-3221-4e83-ad45-2ad1613e1642"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a33dcf3-ab79-49a8-aa32-fbbaebb712a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4aa340db-7580-4928-9806-f748b2d4ab4e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b0d6401-4b88-49d4-92ef-ae7f69f6d148"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4b1cb68d-d2ee-433b-b1a4-7fa1d03fb437"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4d56ca16-6bbd-4dbe-ae46-b86c1307141b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("50580ee4-df08-40f0-9ef2-89909e2a866e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("515e0609-2fb6-4723-801a-8656cf0eb8b7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5238eff7-dcd6-483d-a2f7-dd50021fd74b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("54410007-7642-49fe-9763-5145b2d0b1a3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("54a5259a-f5ce-449b-867c-b736fb831a48"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("59a65044-3306-46e8-948b-d4b011d1b47a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ac6b9b4-7edf-44a8-b3b2-520cdf269124"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b108e73-db02-42f6-a92c-955c75f31070"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c1cb5a8-5257-46a3-92fc-db11efe17855"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5e8326d9-fd0a-4c05-9cab-62dce868d601"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5edb419a-d994-4342-86ab-6fabbb77440a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ff4d12c-0fb6-458f-a1ca-543113ffbe17"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("620f4822-4672-43c5-8fc3-0cae99063a87"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6299fe86-7da3-4a22-b37b-03cf658e84bc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("64637b9b-ba06-4e9f-b0da-3706c0946898"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65307cc5-29f4-408d-8433-c6ab29974ec3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65969d5e-d2fc-4c38-80d5-4b32c9f7fb78"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65fe7e75-76e7-42a6-89e1-87119dfbdbc1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6726fbab-a837-4245-8d50-76d5dd4a7521"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("675e8689-9a83-453a-a679-73f24b8e06a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69126b31-fbe9-4d8f-935b-29b929fb7a2a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69768b67-c3b5-4402-b329-453cd8b197aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6b639580-9a9f-4eaa-8419-056d80d830e2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6b669c64-b49d-4747-9b64-e9420898fdad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6c28b7b6-5c23-4898-9075-bd2dc5f74e7c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d566a5b-bccb-4daa-9ac8-ad016781514a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d8ef9ee-f5d4-4f1d-bd7a-82568e749858"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e12f583-dea9-4e12-8bb5-8704f0ce8f43"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6fdc5f34-cd56-4fe3-b740-2e33ab3e2006"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71346909-bedb-4f02-bbf1-62f5c6a39239"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7282e941-4c6f-4641-9a67-56df4bac8ceb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("747a0582-28e6-4523-9fbf-b27463f5ccd7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74ee836e-ed66-4753-a016-4fc2b8ce549a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("763e06bb-e532-4134-a199-68d7e4ed5147"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("767226db-cd2e-4d39-8f9f-aab617606eab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("772e26fd-f50f-4dc2-88d5-7182a98411bc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ba2191e-4eb0-410c-9074-5cd554566f43"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7cf83b40-7141-4a0c-8b39-03b0d516215e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7d99f2fd-f4c7-455c-8f10-110559620679"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e47a50c-f265-4c65-b238-7cf216930ed6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7e907938-8516-4d2f-9b59-2020e80452db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7f0161f9-775b-4f8a-8925-b6262efe4201"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("839a1cc6-c3d6-4e7f-a007-f4764307d5dd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("85c75a57-3f8a-479d-a750-6f0c1784380b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("88e9401c-a418-4b17-9ae8-bf4a826f7b47"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b635a3d-8ad9-4d23-a0e9-8cff5093b1dc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b6ac436-8e4e-4ef2-8c12-b22b8c6c0f4e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8b7faf9d-80a9-4405-8f9b-238f9b1e0432"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8ba02b77-4a28-4606-bcfb-5d0d1e62afb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8bee26c5-7334-4b40-9a92-70cda07d0602"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8d8ca520-cc8d-46df-8d0c-4314d8e5053f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8dc6fc40-2511-4dcc-a1a5-b6746235a65f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f4f6124-f071-409c-8569-406b92593472"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8fdfa8e4-9d4a-48a7-b56c-204da0708021"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90be2fde-84c0-469a-a4f5-df46619594bf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("91ae2e26-20e7-432e-b43b-78f5e2c3f4d6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("92545585-2f18-4b43-a523-93ace5a56474"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("950eace8-e097-49d3-8123-f980b38f9ce8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("95685fc4-593b-4a8f-8008-eaa29b7a16d3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("96c73dc2-0759-4194-8a0d-ace9f65e367c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("971723d6-8612-4162-93b2-9f7d5ce8aa5e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("97293cba-e851-4054-bf52-4adeb9302965"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("97874de5-bcc6-4f9d-826a-167de4c951df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("97feb7f0-d010-4b55-bde6-f085854fa5f3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("98212d18-d2dc-4e6a-ad0c-4ddd32aadadd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("98fb9fae-3990-4b21-a9c6-9dd86c3576d0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("99c08f9d-493c-4e8c-b3a0-ab55c507c0de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9b364365-407b-45d4-a3ed-a35cc13786be"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9bb6638d-396f-4baa-863b-548abcac3f2d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9c66784c-8b0e-4ffc-9bd1-a9d3a9ca41a2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9cc413c6-4316-4711-9452-1d000b6bfb6a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9db42bed-60c8-44db-850e-2010a67ad1c9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9f52d62f-e313-468d-9ca8-9fc288f3a90f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9fec56a3-1a32-4b0e-9820-e260b872289c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a0143c34-5567-4ac3-9213-3802d7310131"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a1937d02-df19-4a93-92e3-2f7595467edd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a225063e-17ec-4c05-a50f-4ca46478c7d1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a299cfb9-1d0c-4da2-b18e-f040dcbcc49e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a3809885-4ed2-49ea-af4a-d4d88044cccc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a703108f-e93f-423e-941d-106dd9288dfa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a88833a1-3711-4c57-8a06-7a985ac429bf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a8d4f302-4621-4376-afa7-a7093be80ff6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9d6b96d-78a6-431c-8293-d8cae482354d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a9f016d7-6833-421e-8999-c1ebd4ce5719"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aadcca22-a98e-439f-b855-ea6c6ed08251"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ac143a63-3639-4108-920d-76e19b5970a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ac2a593e-f8e1-4a87-b55c-f8f69292d991"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad4087f1-2523-46ad-83a4-7e25992317a0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ae6ab67b-32fe-411e-b750-dc8650e0bac6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aed1a3a3-3bb6-47db-9b78-d911e790b0ad"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af954e06-4cf4-4bc8-b221-07dd391b78de"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b1128ef8-537f-4b98-965f-7f5de64c0bfc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b16278f4-e5cf-42f6-80de-459564daf751"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b330967a-e0e7-4a01-b165-ec5028a65c20"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b39f897f-7bca-4cbb-8935-335822e48dfe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4f83785-8b8c-4c0d-a1be-4660161e6697"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b63fba35-0487-4e4a-bb89-0828cc8935c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b6a1e679-8da2-40f3-a6bc-c14555ffa5b3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b73211ec-d9e2-4708-a909-bb977b28bc57"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b743b8c8-69d8-4ef2-ac67-42d3db2885d2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b83e3d2c-4463-4115-a01f-5a571af09f07"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b9e4a7e3-3802-4921-801e-457219f28ed0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc49e88a-fdb8-46c3-ae7d-6cb677f01aab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be580e59-e684-46e1-b6c4-9adde2bc0c0f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c09e8c53-b20c-4c38-8abf-36f3e0360387"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c28eb57a-9279-4d33-b062-ef1a4f5e9146"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cad931d3-1c79-4f65-964a-eab89ebbced0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cc52a9ea-ee30-44d2-bb1a-b12b22048ebc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd852944-643e-4585-b839-64567d6f55be"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cde0b527-05f8-493f-9035-548934f6b7c7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ce54176d-4664-40f9-a405-b031dfbcf907"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d015dac4-d082-4e08-827b-25d77627453f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0ee2ff3-2696-4b7f-b109-1737dc9f78a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d1a50ed3-4f72-4413-a47e-125ee84d34cf"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d3481d85-eb94-4843-a4a8-31ea9b491d97"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4422b5d-2290-4420-b659-27bc2b95385d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4ddb7b3-9e5f-4da1-9e06-8260aaa3c741"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d4de873a-5b1c-4e76-848f-18e02f1c83ab"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d676c8da-b46b-4072-82f0-cff83770eee4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d69be103-455a-4acc-a152-87cba2738e68"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d6ab7573-9559-4742-a2df-76f30bdf4143"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d736a6d0-29c8-447e-8b70-f9407216a3ef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d824f78b-ab54-4e92-9326-8f774cca206f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d8ca87c6-ae84-4cf0-a0b5-c40ac4a791aa"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("db2a6497-ffdc-4836-bf5f-c36101eb68ba"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd775647-dab3-4db8-a361-7e6ae485d2cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de8aa49e-8ea9-41a0-be82-ccaeeabdd731"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df06c866-ae8e-44c6-97ba-d9e53438db44"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e10a56dd-6ba8-4e3d-9211-d0c16eeb0be9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e322aaca-5fc5-4e36-b997-d958c35747c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e33c3d7d-5262-41e0-ac48-483af142982e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e4147921-c97e-40a0-aaba-a1c534e688a5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e4392c65-b5b6-41b0-a134-e62322096e7c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e43bfcbc-4d19-4ed5-8b11-371e20d6b33d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e440728f-0e93-411e-aeb5-15aa93373828"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e593a4d5-bd1e-4f09-88bc-24f61370e465"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e6fb5125-8a46-4f12-895f-3fcb5939dccb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e714e173-b3fe-45b9-94da-1bbdef91a81d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb1d8382-b406-490e-b05d-40ab07553b4c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ecd68744-9172-46f0-964c-4898f6783d1c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f195b90f-75c2-4524-959f-bf7735ff16f3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f48b500d-8534-40c0-80eb-de938bf9280a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f822498e-58e5-40b9-bf54-85e033fbf080"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f98cd195-f8c8-4552-8f3f-5f43b005c2db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fa94b6a6-f7a8-4ffd-ae5b-201eb5749a04"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc3684e1-a08f-4ab0-ab35-18e2a3360b57"));

            migrationBuilder.DropColumn(
                name: "WorkoutDate",
                table: "LogMessages");

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07d19e75-a2b2-46ab-ae62-0fbe1dc0d08f"), "Chest" },
                    { new Guid("2503921d-ee23-4e55-bc6d-795c39cf9825"), "Shoulder" },
                    { new Guid("3302aa3b-86f6-4ecb-b1e6-0b3fc32f3e7b"), "Forearms" },
                    { new Guid("4288c9fa-8a89-4f74-aba1-18d88abec621"), "Tricep" },
                    { new Guid("45ea0862-ce9f-4aaa-bb1d-0aa815384b30"), "Back" },
                    { new Guid("4c23d15c-21e5-4234-954d-e7bf4b65343a"), "Legs" },
                    { new Guid("bb183c51-9428-4d5a-9b6b-08892158d890"), "Abs" },
                    { new Guid("dd272e82-83d1-4140-b64b-446e26cb3160"), "Glutes" },
                    { new Guid("eee0ea8b-004e-4dd2-9b95-6a87d730cafe"), "Calves" },
                    { new Guid("fe1c79ce-fba3-4b7c-b0e9-0b5af4880831"), "Bicep" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("00aa8d31-b585-4cc8-b8b3-0223f6f59f70"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("01859719-4f07-43d5-811c-32ad2626e53a"), "Chest", "Incline Push-Up" },
                    { new Guid("03b42bc6-6e4a-44e0-b7e2-355e6e81af44"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("048537d3-13de-4020-b380-f2948ba6f122"), "Back", "Pendlay Row" },
                    { new Guid("04da86d4-a67d-4a06-9515-9be5691e2149"), "Back", "Kettlebell Swing" },
                    { new Guid("0650fde1-d1ec-44c4-9792-f92f7f5700e2"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("0711aab7-d62a-48ec-ae5d-0aab326ee3df"), "Abs", "Oblique Sit-Up" },
                    { new Guid("076ee134-02eb-4889-bc84-3da269548e96"), "Back", "Rack Pull" },
                    { new Guid("07f9a3fd-e8c6-48ef-b949-d4abeb7ecf50"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("0b49834b-a648-4ee6-8890-2b262bd4dbb3"), "Shoulder", "Power Jerk" },
                    { new Guid("0d7d48fa-8d9b-45ae-af32-e118a8f47fa8"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("0e434734-26e2-4854-9df7-caea47ed9a90"), "Glutes", "Banded Side Kicks" },
                    { new Guid("0f994db9-aa45-4b78-b87d-cba964345c92"), "Chest", "Incline Bench Press" },
                    { new Guid("11b39362-4c5d-46f2-a3ce-fc888973a21b"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("17003901-bebf-41df-8a60-6aded3ad19d8"), "Shoulder", "Face Pull" },
                    { new Guid("1790d5c1-c270-4c0d-8a3c-245abb2d1f6a"), "Abs", "Cable Crunch" },
                    { new Guid("17faec90-514d-4e98-964f-d18b1fce5bd3"), "Bicep", "Spider Curl" },
                    { new Guid("190dc03d-1c3d-4073-99ab-ba88e5f980e1"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("1a83c430-a1fc-499f-81aa-b29d4689151b"), "Back", "Hang Snatch" },
                    { new Guid("1d978bc8-fefc-46dd-b668-8a80faad096d"), "Legs", "Landmine Squat" },
                    { new Guid("1dd6b197-4feb-4940-9146-0f7452a30507"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("1ef06462-3a95-4c3e-a001-89ac0f1e1ec2"), "Abs", "Oblique Crunch" },
                    { new Guid("1fd3ac77-a282-4472-9a42-35f7f351dc51"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("2419c863-6fa0-4d59-ae37-380564d6f272"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("2478c022-413f-4823-8c4a-6e0c081c7b17"), "Back", "Hang Clean" },
                    { new Guid("255eb60c-d3ae-4ad1-90df-a78aecec7ecb"), "Abs", "Hanging Leg Raise" },
                    { new Guid("25d77e05-3162-4cf9-99d4-27ef057299b9"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("2663cf60-788c-459b-a61e-6bf6e2ffa8c5"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("26b59f12-9447-4f73-b569-3bded6cae643"), "Shoulder", "Plate Front Raise" },
                    { new Guid("26e8e5c8-1c4c-46e4-a947-5a512e6ba5b2"), "Legs", "Dumbbell Lunge" },
                    { new Guid("2769a177-0ee0-45f7-9040-48753be7e1c4"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("29650dbb-29e0-4745-8e8b-93824381a5cc"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("2a8e0984-5989-4c5d-9587-ef642d1560cc"), "Forearms", "Bar Hang" },
                    { new Guid("2db0f1b0-08b4-42cf-b805-89ebb8b1e962"), "Legs", "Front Squat" },
                    { new Guid("2ffc779c-3cf4-46da-ad49-064d65df40fa"), "Legs", "Leg Extension" },
                    { new Guid("31e76109-a9c5-44bc-956a-c11271c3e872"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("32e4df50-238d-447c-9323-5276ecd39013"), "Legs", "Air Squat" },
                    { new Guid("342df36c-1530-41c4-bbf7-6c73ad42cee5"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("35f7c5b7-f933-40b1-8a02-2e6a878dcb2f"), "Back", "Inverted Row" },
                    { new Guid("35fc2633-c611-459f-bfdc-889aa5088a57"), "Chest", "Floor Press" },
                    { new Guid("37359a9d-962f-4567-bf46-b93986ecd57c"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("3a4ce8c0-618f-4982-812e-679ba30efcc1"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("3a863a03-690b-420c-895b-4c330731409c"), "Abs", "Mountain Climbers" },
                    { new Guid("3d8ad340-35be-4ef7-b1af-280f75730ed0"), "Legs", "Step Up" },
                    { new Guid("3e73ef88-c89e-46c8-9b00-c0b20ed6750d"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("402393d2-9418-43bd-8b12-2f54f2eb0117"), "Back", "One-Handed Cable Row" },
                    { new Guid("440d64d8-da83-47aa-a708-baf255eb3854"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("44c24bc3-8ef8-48ee-9491-acac4c963b73"), "Shoulder", "Overhead Press" },
                    { new Guid("45b4a27a-edbb-43db-b2e3-e75633d9c976"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("45f120fa-a05d-4327-a53e-931d0e17e1ad"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("48207ae5-6ab9-4ae2-a307-db253b4b303a"), "Legs", "Pause Squat" },
                    { new Guid("48cd3123-f820-4199-991e-e7f0fb9c7b93"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("4a7ce8bb-3fac-4693-af7e-a4e0610d9137"), "Glutes", "Step Up" },
                    { new Guid("4aea3de8-1d8c-43fa-bebd-cd830e725ca8"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("4b89db5c-a358-40e9-bb66-34d1d23b9337"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("4bdadacc-ba4b-41e8-9dbf-65b85dd1b66a"), "Back", "Power Snatch" },
                    { new Guid("4be2baec-2928-48c5-9920-4797fc4c2614"), "Chest", "Decline Bench Press" },
                    { new Guid("51171bff-a0a8-482d-b377-d2d9993a27eb"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("54c99704-32e2-4db3-a97e-ad7b79430d72"), "Calves", "Seated Calf Raise" },
                    { new Guid("559f6c61-7375-4557-9634-d7121f5d3a0d"), "Abs", "Kneeling Side Plank" },
                    { new Guid("55a44225-7e6b-4742-9da3-b406958c916b"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("56b70393-755f-48ae-a57e-feb84c4a7916"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("56fbe0a9-489d-4a30-b20b-d2cd737700f1"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("580b44ad-15ad-40dc-b914-678c3aa8e43d"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("586cb92b-083f-4598-9c47-5827300878b3"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("59f91571-f7bf-479d-ae12-06796d3eb985"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("5d6e475f-7fbe-4ea1-a812-33afeb14d89d"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("6014d1fb-c2be-45cf-aa5b-791b089cfd9f"), "Back", "Pull-Up" },
                    { new Guid("604fea05-65c6-456c-ad41-1ef499916151"), "Chest", "Cable Chest Press" },
                    { new Guid("644ef566-2ea5-4dd6-b659-a243a625a0fd"), "Legs", "Hip Adduction Machine" },
                    { new Guid("6729e31b-4493-4f1c-b2af-322c67f2fdec"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("674a788b-bbc7-445e-a003-20aa12ed820e"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("67ac78a7-8576-472c-8653-255b397b8eee"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("68a0f13e-30d8-418d-9cc3-44f775db839c"), "Legs", "Squat" },
                    { new Guid("693a9d7b-dd72-40f8-8d39-879f5b8cbc1d"), "Shoulder", "Monkey Row" },
                    { new Guid("6973b0ba-7694-4696-8472-a60cc957eccd"), "Back", "Dumbbell Shrug" },
                    { new Guid("6989f571-22ff-4090-8cf0-837063e3a4f7"), "Chest", "Dumbbell Pullover" },
                    { new Guid("6a1d405b-0cab-425e-a3ad-563642237fc4"), "Forearms", "Towel Pull-Up" },
                    { new Guid("6b9476d3-7df7-48c6-a98e-8fc0a67e2843"), "Abs", "Hanging Sit-Up" },
                    { new Guid("6d99fbbe-fcb9-4be9-91db-9b858c8a37fe"), "Chest", "Push-Up" },
                    { new Guid("6daaee04-8c37-40f9-8ba7-3255d9cf4278"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("6e056e2f-6656-40d1-b10b-f4702d5943ae"), "Glutes", "Cable Pull Through" },
                    { new Guid("725f06a9-6dde-4809-8d54-ef9308172bb5"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("7261ec97-9464-4ef9-8fba-c7a22d43d327"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("72bfb545-79ed-49a0-813b-37fcf1248a72"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("74776ded-1145-48b2-8c2b-7eb35911d3da"), "Back", "Good Morning" },
                    { new Guid("75fd673e-fd74-486f-93aa-dd9e3653a9c4"), "Legs", "Leg Press" },
                    { new Guid("76fd2121-036f-4fa1-8f7f-49defcc11308"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("774a2142-7284-42d0-b83e-d9602c7e85ee"), "Legs", "Goblet Squat" },
                    { new Guid("77f4b2c9-f2ee-42a1-88af-438c7fedf163"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("77fb1376-5af6-4a11-a580-23355bf39167"), "Shoulder", "Push Press" },
                    { new Guid("7bd24425-2260-47c8-a506-d1ef92742363"), "Chest", "Push-Up Against Wall" },
                    { new Guid("7d5870c4-b539-4ded-9377-8ea025b207ff"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("7e0382d6-7238-4e5f-9634-165dfa7532e2"), "Back", "Dumbbell Deadlift" },
                    { new Guid("7e94d909-68eb-42d0-8254-2f428a3d9fec"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("7f248de6-7cff-4827-b9c8-e57f267b32e4"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("83fb0397-788d-4d67-b4b3-f4df35f7b234"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("85d619b0-d436-420c-af0a-d9f06f5879fc"), "Glutes", "Hip Thrust" },
                    { new Guid("868f4dbd-5d81-407e-9968-40dfaec9e965"), "Abs", "Side Plank" },
                    { new Guid("86b5bd18-de54-41b6-bdde-ef582204585a"), "Legs", "Dumbbell Squat" },
                    { new Guid("8783928c-ac1f-49b4-81a1-eb09ca210855"), "Shoulder", "Squat Jerk" },
                    { new Guid("8dd10bad-b9b4-4ed5-972f-f68dc182d2da"), "Legs", "Body Weight Lunge" },
                    { new Guid("8e17f350-b37b-4839-a078-2a1564d801cb"), "Legs", "Romanian Deadlift" },
                    { new Guid("9093c728-e92d-44fe-9766-6268dca3744a"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("90b898ef-06eb-441e-a9bd-259ec071e3b7"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("93b2431a-cf25-469f-8f21-1f45512481b2"), "Legs", "Step Up" },
                    { new Guid("93dcc050-ca7a-4a57-bf92-fc95ec4027e6"), "Back", "Deficit Deadlift" },
                    { new Guid("94d6d001-6cc8-4ce0-80e8-50077394ee70"), "Forearms", "Farmers Walk" },
                    { new Guid("95793c8d-33c0-4015-a4fa-3978f05cc7ba"), "Back", "Dumbbell Row" },
                    { new Guid("9637a5ae-c481-4359-9eec-85086bedbf84"), "Back", "Seated Machine Row" },
                    { new Guid("9793e204-a9a7-4842-8d27-692e60ce3f4b"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("979b97f1-9be2-49f8-a692-2a240c904ef8"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("9819624f-22f6-43e7-926b-a9b8aa940603"), "Legs", "Half Air Squat" },
                    { new Guid("9822e0ea-af01-4cb2-9f89-2302da024c41"), "Legs", "Hack Squat Machine" },
                    { new Guid("995e6efc-438f-47ae-a577-256adb72f2ff"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("9af541bf-0d13-4273-aa2a-5dc03ec57cda"), "Legs", "Landmine Hack Squat" },
                    { new Guid("9b019f9e-0753-45f0-9829-41cbc8959ec8"), "Glutes", "Clamshells" },
                    { new Guid("9b6e7ee2-6dfe-4085-96b7-19ca97a73179"), "Back", "Hang Power Clean" },
                    { new Guid("9bed626c-2a09-4d8b-a345-d60ee837f5c6"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("9da16b95-f7ac-4128-8a85-85d9c5e07480"), "Legs", "Chair Squat" },
                    { new Guid("a09c0443-9334-4856-8c6c-41d3b2dd3d89"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("a0fcba14-baa2-45df-961e-2de578427574"), "Glutes", "Glute Bridge" },
                    { new Guid("a1028368-b3b6-406b-ad10-f0aa9d3cf1f9"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("a1848ddb-f28d-4906-a772-c83830450ecf"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("a1ad7065-413d-4e3f-b3bf-b99bfa89aca6"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("a2d55bc4-7c80-4152-9f53-bc21a86c1386"), "Bicep", "Bodyweight Curl" },
                    { new Guid("a2db30fa-e0ed-4d3f-9d76-02990f2cde59"), "Abs", "Plank" },
                    { new Guid("a31e165d-6a79-4fe4-aef0-7b2b73a653df"), "Abs", "Dead Bug" },
                    { new Guid("a328c713-ded5-4fa1-b562-7b8cb88a4a51"), "Legs", "Belt Squat" },
                    { new Guid("a48cd9d5-6fb1-4d33-950d-b983dde1a63c"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("a4c7fab4-263c-41f2-9dff-5ce2a892c6f0"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("a566d8d8-6ce3-4f76-9cb1-687f2add5cf8"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("a640258e-88c9-4a4a-bb07-016b9f36f25a"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("a8900063-2f89-4d44-998b-3d303d631f8a"), "Forearms", "Plate Pinch" },
                    { new Guid("aa5be987-c464-45bf-8f7b-e7aae4f23a51"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("b04a2307-cfe9-4a9f-8023-86fc405301ef"), "Chest", "Bench Press" },
                    { new Guid("b2d498bf-a623-4c71-8809-3202e56627af"), "Legs", "Safety Bar Squat" },
                    { new Guid("b34a1fa6-0e13-489f-9fb9-18a2b329fce2"), "Legs", "Seated Leg Curl" },
                    { new Guid("b5272d9d-566f-46f9-be44-9f6f0c38a581"), "Shoulder", "Front Hold" },
                    { new Guid("b66e90aa-063d-48d7-ac45-d0237f105173"), "Back", "Floor Back Extension" },
                    { new Guid("b6accb22-ab60-4ac6-9af2-d3472af89ee0"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("b6ba1a3b-a0ac-4629-823d-e2bf9dd00899"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("b703a12e-db32-4233-92f7-fb4437d9abae"), "Abs", "Lying Leg Raise" },
                    { new Guid("b9ac2fca-9293-4da0-b820-d6b5b4a0610e"), "Legs", "Barbell Lunge" },
                    { new Guid("bb31d734-b515-4e61-ac98-0c5c6eadac95"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("bbdca610-41da-46af-b733-47b66e2eecb0"), "Bicep", "Hammer Curl" },
                    { new Guid("bea1d5fe-0fad-47b7-ad1c-388ac761c018"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("bedad317-3dbf-4ae1-a2e9-bda84248c38e"), "Back", "Back Extension" },
                    { new Guid("bef6df04-1693-458c-a000-708a4374f1bd"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("bf25b04d-ca97-47a7-95c2-daf6510e6133"), "Back", "Deadlift" },
                    { new Guid("c105fbf0-0ecd-47f9-a8e8-71189c9eb77a"), "Chest", "Pec Deck" },
                    { new Guid("c10c8812-3d21-4157-9c12-5c9b9a391c40"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("c1131acb-b118-4962-9920-13657f3d599f"), "Back", "Chin-Up" },
                    { new Guid("c28cf495-8b0b-4394-9cd8-939e71f5a3fd"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("c3c8ead7-e00c-473e-9b4f-356cd2cfb99e"), "Back", "Sumo Deadlift" },
                    { new Guid("c42796a2-a786-4469-8f8e-42e497284ae7"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("c476fad6-b6ac-4e87-9db2-8ee7807d58c7"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("c4b9ebb1-cee9-4d55-8451-f14531b3d9e4"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("c5589cf9-1be5-4a4d-bc33-8acfb67af9d0"), "Back", "T-Bar Row" },
                    { new Guid("c5694994-448c-42f2-8f5c-0ca17ab445f7"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("c865a5c4-2adb-4ea1-934a-78fe32936035"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("c882feb6-86b6-40cd-b1b4-609920e1eff2"), "Legs", "Lying Leg Curl" },
                    { new Guid("c9af03a7-b6e5-4e75-8ca7-ac9950898cbd"), "Chest", "Machine Chest Press" },
                    { new Guid("ca94c4a1-1621-4c26-8bd1-c0b5520ad763"), "Abs", "Machine Crunch" },
                    { new Guid("cbd11a5d-1020-47db-abad-c88405f4d8ef"), "Legs", "Smith Machine Squat" },
                    { new Guid("cc0ab1ab-86d0-4ba0-85cc-3f8636ac7de7"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("ccbbc91a-662b-4c5a-82d4-a0b8d33ce075"), "Back", "Barbell Shrug" },
                    { new Guid("ccc1798b-b9d6-4a09-9aed-cd095b96f48d"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("cd969216-7425-4be6-8988-edff7a6d0d4e"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("ce5360a4-82b0-4a84-a202-8f5ccc1b0ece"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("cf415f53-906c-494d-943a-c280db08f650"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("d09d0fc7-8e85-4c58-b73e-d33671d0cc62"), "Back", "Power Clean" },
                    { new Guid("d162d59c-c658-4c80-8906-ae46d0eab866"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("d1986555-136a-42ad-ac22-bbd47fe8ef53"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("d3494381-705f-4e58-812c-cb674e16f6ed"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("d377d25b-9ef1-4c1f-8fc5-a178f5b62467"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("d554a0b6-9767-4bea-8ebd-0491e119e299"), "Legs", "Barbell Hack Squat" },
                    { new Guid("d9e79ca6-ec93-4b63-9b83-12c672ee735a"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("da66414b-af71-4efb-9f94-4532f8d57679"), "Glutes", "Fire Hydrants" },
                    { new Guid("da82bdea-de8c-49ec-b283-0e59a5fc34fe"), "Bicep", "Dumbbell Curl" },
                    { new Guid("daaff0e2-663f-4f70-9a3e-11ad94feead5"), "Calves", "Heel Raise" },
                    { new Guid("db18f154-c0a5-4b46-b74e-24d8636c1a15"), "Bicep", "Concentration Curl" },
                    { new Guid("dbc11099-e928-4882-8eb6-e9c1b51b083b"), "Forearms", "Gripper" },
                    { new Guid("dc0fca1c-c4ed-474d-87e6-0a892749a6b9"), "Back", "Block Snatch" },
                    { new Guid("dc23620b-1e4d-469a-a48e-c299e353b3a7"), "Chest", "Machine Chest Fly" },
                    { new Guid("ddc67dc9-801e-41f1-8652-078b02ee6bb0"), "Back", "Clean" },
                    { new Guid("ddf38253-0317-41b3-acf8-8175919cda9a"), "Back", "Pause Deadlift" },
                    { new Guid("df311d3f-22a1-4bde-b146-b836878a871d"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("e0f026a2-d866-4c3a-915c-36be76c94399"), "Chest", "Kneeling Push-Up" },
                    { new Guid("e1383fe3-3f73-457a-8f7f-f0bea7077837"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("e1711f95-2e4a-462d-a24b-69b57f71aa5f"), "Back", "Seal Row" },
                    { new Guid("e2de4182-8d57-40dd-8d7e-063a994f8914"), "Abs", "Crunch" },
                    { new Guid("e3b285f1-ed0c-4da8-91c0-9ada579798df"), "Shoulder", "Split Jerk" },
                    { new Guid("e3e3f2b6-9eaf-4ab1-ba96-671792b0484c"), "Bicep", "Barbell Curl" },
                    { new Guid("e565d1a3-d3fd-4352-ac62-ca9fcb19086d"), "Back", "Clean and Jerk" },
                    { new Guid("e6a98c9f-4b1c-444f-a7e8-ebaea3a22b5d"), "Back", "Hang Power Snatch" },
                    { new Guid("e7d59e21-2847-420d-aec4-63a096303c80"), "Calves", "Standing Calf Raise" },
                    { new Guid("e8da6257-b6e7-4be8-bb29-b46e23dc02f7"), "Abs", "Kneeling Plank" },
                    { new Guid("e9e81af5-d4e5-4d67-8fd9-8773a465c17f"), "Tricep", "Bench Dip" },
                    { new Guid("ea0d45ed-4aa0-4033-85fa-6366cd958418"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("ebab9d90-d39a-42e9-82b7-24a5b0e99fae"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("ec6dfae4-5e4a-48e4-b606-938356f798be"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("ec98ed2b-c04b-47ca-a315-59392f8a5f4a"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("ec9acd3a-1351-4b23-882a-548535323db4"), "Abs", "Hanging Knee Raise" },
                    { new Guid("eee44667-fb74-4f3c-bfc1-621444ae75fa"), "Back", "Snatch" },
                    { new Guid("ef97e075-2268-4870-97f8-efb800211259"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("f114d688-6e7d-4797-b341-09dc6ddb076f"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("f12144a3-caae-4231-aa47-8e984fc49d2d"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("f34a3e42-789c-4c63-b4d0-ff893d70471b"), "Abs", "Sit-Up" },
                    { new Guid("f36cb40d-08ae-4e57-a775-8caf93490f34"), "Back", "Barbell Row" },
                    { new Guid("f68b49a8-e8e0-4add-be30-18e0c99c1de7"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("f6946e2d-0e9f-45e4-b8a2-e9ea62946cd3"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("f7572984-53a5-4f49-b39b-4cd1dc91099a"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("f7712579-c71b-41a2-b1f4-d2f185e8b495"), "Glutes", "Frog Pumps" },
                    { new Guid("ff7f6b93-2cea-4bcc-a33a-443c98fc7bf1"), "Legs", "Box Squat" },
                    { new Guid("fff6690d-eaa9-4d27-9cbd-57ff2984de01"), "Chest", "Bar Dip" }
                });
        }
    }
}
