using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class loadedExercisesList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("42c6699f-c78b-4811-b615-c54373713b35"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("c64e519b-66e5-4937-ac46-7fe2ad88e569"));

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryModels",
                keyColumn: "Id",
                keyValue: new Guid("cc7beae2-4455-4880-bd0a-26b9c89534e6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
