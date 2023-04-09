using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersAchievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodTraining = table.Column<int>(type: "int", nullable: false),
                    TotalWeightLifted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalWorkoutSessions = table.Column<int>(type: "int", nullable: false),
                    MainExercises = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAchievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersFriends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FriendsString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersFriends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoundNumber = table.Column<int>(type: "int", nullable: false),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rounds_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutTemplateExercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkoutTemplateModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTemplateExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutTemplateExercises_WorkoutTemplates_WorkoutTemplateModelId",
                        column: x => x.WorkoutTemplateModelId,
                        principalTable: "WorkoutTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_Rounds_RoundId",
                        column: x => x.RoundId,
                        principalTable: "Rounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0190c6ad-8841-48f5-be44-c4ffa65eeb3c"), "Abs" },
                    { new Guid("1c55238a-a78d-4855-a826-caeff8f13148"), "Legs" },
                    { new Guid("61dea103-d9c7-4e05-8014-893b16bff671"), "Chest" },
                    { new Guid("6d6e5a35-14d5-441d-ac79-c06d40d6963d"), "Bicep" },
                    { new Guid("6da5b50e-1fdb-4ec0-808f-4df5e36967fb"), "Back" },
                    { new Guid("73f8b056-ae84-4007-b569-d986965b1a83"), "Forearms" },
                    { new Guid("964aae36-6fdc-4285-873d-a279ea06d6d4"), "Tricep" },
                    { new Guid("a7247de7-329f-41e4-a445-f67568126522"), "Calves" },
                    { new Guid("c21e35be-91f8-44ff-ad35-1e688e6b218a"), "Shoulder" },
                    { new Guid("ce0e5e86-b033-4bb2-9c01-bca9000b0ab3"), "Glutes" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("02034963-214a-4d3a-b06f-6de9809c927a"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("02c18c57-210c-4119-808c-455b16f35315"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("033f1db1-d728-458d-ba23-22bbf0b2c93e"), "Abs", "Crunch" },
                    { new Guid("03e051f4-56ce-4604-8f12-9c31744a34dd"), "Abs", "Lying Leg Raise" },
                    { new Guid("03f4382f-dfb8-4466-9b60-4c1ace628138"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("040ba28d-ad06-4e3a-977d-817e8959b986"), "Bicep", "Concentration Curl" },
                    { new Guid("0453f88d-50bc-4718-81a6-87e3688e2f7e"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("06791ba7-abaf-4d92-ba3d-56cd0c6c2dfd"), "Back", "Floor Back Extension" },
                    { new Guid("06df4c06-01b3-463e-96f4-e9e6773f48c2"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("06feff9c-69ba-41b4-b962-105371d34660"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("07223acf-2e53-41f3-87d2-8513bc3f5a8a"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("092f6f32-e76b-4dae-b42c-5365e8c6532f"), "Forearms", "Farmers Walk" },
                    { new Guid("0ab86e28-121e-4540-92af-941a3b18379b"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("0bd81753-43d6-484d-bc95-3bdd82f225c0"), "Legs", "Landmine Squat" },
                    { new Guid("0d6a84ed-1113-4e5c-92a3-6f5f7c3bdc99"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("0dc86e88-2f62-4c56-8449-46648a44edaa"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("0e20ddcf-0e03-426e-ab13-141d39df66ed"), "Legs", "Chair Squat" },
                    { new Guid("0e5cbe57-dd13-4ad0-a4dc-05d134f95f97"), "Glutes", "Glute Bridge" },
                    { new Guid("10b3d711-3ad7-4b35-97d4-044ba7e242bb"), "Bicep", "Dumbbell Curl" },
                    { new Guid("111134e4-7b1e-47c4-a74e-a317c7561870"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("1257c062-80ca-419b-ba2f-de3e8900c19d"), "Chest", "Machine Chest Fly" },
                    { new Guid("155f27d6-6f0d-4893-9c12-bef9b7c19c64"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("17627963-2005-434f-b003-734eb44139a2"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("1891b6d3-8785-434b-a956-caee1292091f"), "Legs", "Leg Press" },
                    { new Guid("1af013f9-a389-485c-8cb8-fe7bf7bbbc06"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("1d038d62-8a6d-4a57-aa34-6c669b8085ab"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("1d19cb7d-1297-4834-ac0f-8ee32f8d5b15"), "Chest", "Incline Push-Up" },
                    { new Guid("1d8aec9a-73d2-4d18-b8f9-282b9c742e93"), "Back", "Hang Power Clean" },
                    { new Guid("1dc573f6-4c96-4516-9188-8ba63788ecbd"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("1e6bf50e-80f4-425f-b6ec-baab56662fc3"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("1f9cf358-1d94-46a2-a627-430b94a9328c"), "Chest", "Floor Press" },
                    { new Guid("2173ce52-c7ac-4949-a6a4-c307bb85a02a"), "Forearms", "Bar Hang" },
                    { new Guid("21a0fc1f-5f54-44a7-bead-0e320eeec2e4"), "Chest", "Push-Up" },
                    { new Guid("23b1d92d-4013-47b7-ad45-643150c86474"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("25238f55-7d83-41d7-8d46-ab448fe42ab7"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("272648f1-a3be-494c-9950-75f806111423"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("27b4f10b-79af-4cec-b29b-ed6de99da78d"), "Glutes", "Step Up" },
                    { new Guid("2957181d-9c92-4efd-9936-c3a5d79b9703"), "Shoulder", "Monkey Row" },
                    { new Guid("2a48737e-9d73-4b20-8851-ef0f0b86a653"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("2aeebfaf-0175-41b9-b05d-f5150430b4a8"), "Legs", "Step Up" },
                    { new Guid("2d2e141a-1c00-4fb9-b976-b4b8b9409a90"), "Legs", "Dumbbell Lunge" },
                    { new Guid("2d31757b-b7a7-4449-8d62-b8c7fd290379"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("2e751622-9f00-487e-bd66-f3a93ab10a90"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("3003d0d7-8506-49fe-b8af-cee6f1a02e9e"), "Legs", "Romanian Deadlift" },
                    { new Guid("305ee5da-9705-4c8a-bbae-69a489ae5409"), "Back", "Barbell Row" },
                    { new Guid("318af06a-caee-48cd-9f1c-4568fabd9279"), "Shoulder", "Plate Front Raise" },
                    { new Guid("31e1587c-d57e-4690-9b3d-012c32515585"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("31eebc44-904a-45e8-8fd6-26e0ab7a9c94"), "Back", "Pendlay Row" },
                    { new Guid("33d5c97b-4c76-448e-824d-b6981dda75fc"), "Back", "Dumbbell Deadlift" },
                    { new Guid("34c760a2-8b13-42d0-ad35-dbb899beec71"), "Back", "Power Clean" },
                    { new Guid("35609971-afe2-4759-959f-082ac13da261"), "Legs", "Squat" },
                    { new Guid("38c021ed-f77b-4f41-93e8-f3979fc36311"), "Back", "Hang Snatch" },
                    { new Guid("394ecfa4-c2f8-4ddd-a0ca-d093a6364dec"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("3a930ec9-79a3-4e4d-a579-06f5baa98a8a"), "Bicep", "Barbell Curl" },
                    { new Guid("3acf41cc-508e-4aa3-a320-72faed89a2fd"), "Back", "Pause Deadlift" },
                    { new Guid("3d5d67f4-4bfd-4eae-94f2-c86792d99f4a"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("3eee306d-66f9-41bd-9d90-91b93c34e99a"), "Legs", "Leg Extension" },
                    { new Guid("41a52b97-6ba0-4c35-9b3e-3d7f60be73e1"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("436beff5-e9e0-4be8-ba5f-f3506787cc92"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("450ee0d1-228a-4ae2-b985-8118fa023605"), "Forearms", "Towel Pull-Up" },
                    { new Guid("4659b3dd-e8dc-4f92-9c8c-fb18074a7b89"), "Back", "Snatch" },
                    { new Guid("49c84d5e-e9ee-4549-9d29-28178a130d8f"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("4a1d8b7b-0d70-41a4-90c8-18240d735f46"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("4a293620-d086-4d9e-987b-1213127b7867"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("4aa11a86-7299-44bb-9da4-a2d1ec8ca1ba"), "Back", "Hang Clean" },
                    { new Guid("4b73f71e-4d5a-43af-a1b0-ee9ff7cee0b4"), "Abs", "Hanging Leg Raise" },
                    { new Guid("4d08f948-ce18-47c2-8a25-36914ca1c105"), "Chest", "Push-Up Against Wall" },
                    { new Guid("4e78c17b-bc12-413a-9e7d-e0a277ac850e"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("5287ecae-4423-48b0-984b-a6fe775070d9"), "Shoulder", "Band Pull-Apart" },
                    { new Guid("52b235e4-3433-4884-906a-ed4b528338a0"), "Back", "Dumbbell Row" },
                    { new Guid("5388353e-3948-403d-88ef-96bbb49be73a"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("58e199e7-0f55-4074-93af-b347ff717d35"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("59af639d-c0a0-4d30-8c6b-767e2377b110"), "Legs", "Pause Squat" },
                    { new Guid("59b21579-53fb-4044-8f1d-417e156bc532"), "Back", "T-Bar Row" },
                    { new Guid("59e2f868-65cf-48ea-9530-e4dbe71079f7"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("5bf3b30a-9f7b-4f35-98a1-e7604968ab12"), "Calves", "Seated Calf Raise" },
                    { new Guid("5c5cbf8e-5985-403d-a5cc-049c00b62245"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("5e37d2a2-6592-4ff0-b5e3-c6787ffd6470"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("612d9da5-1a24-4a83-80d7-c75fbe90278e"), "Back", "Sumo Deadlift" },
                    { new Guid("62ee1c06-e3d1-4a3d-ae78-d94f7629c3df"), "Chest", "Decline Bench Press" },
                    { new Guid("63afbf5a-7822-497f-8251-2353ec6e6d7a"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("65668a36-1917-4e4a-b227-7f4395e78922"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("678b1f50-c2b4-4ea7-bc4b-0da58b5a0807"), "Back", "Kettlebell Swing" },
                    { new Guid("6792c225-20d3-4f6a-8237-aa6ab52b8d3f"), "Legs", "Hip Adduction Machine" },
                    { new Guid("68f624a2-49b0-4d9b-abdb-efd9b3a9693e"), "Chest", "Pec Deck" },
                    { new Guid("69f7ab3a-ff4f-41cf-a66a-858aa8b9ffda"), "Legs", "Belt Squat" },
                    { new Guid("6a582a91-0fc5-4943-898f-9baa0098b392"), "Back", "One-Handed Cable Row" },
                    { new Guid("6c419251-0388-4583-851f-936e0f1b90e8"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("6d17bcbb-e47c-4a05-ac88-63c6a939ebb9"), "Back", "Barbell Shrug" },
                    { new Guid("6d8a11ec-db54-4540-8483-d800ade06454"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("6eb6798a-cabf-466f-8599-7d11318ebb2a"), "Abs", "Machine Crunch" },
                    { new Guid("7336f959-4a65-442a-8046-7ddccdc15aa8"), "Legs", "Barbell Lunge" },
                    { new Guid("7707c431-3314-452d-b619-99388f764362"), "Abs", "Kneeling Side Plank" },
                    { new Guid("7717600c-c0db-404a-9ac6-677adf4f8d04"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("77eb103e-edda-405c-afaa-79a82889e320"), "Shoulder", "Face Pull" },
                    { new Guid("79396d19-409a-477e-bc5f-7810868f502d"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("793ed83b-fee9-4e66-b26f-f119ba850e08"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("7b1460ff-8973-4cdd-873f-5b4dacff53e8"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("7b43e5b4-2619-4080-a5a9-412defa11a63"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("7c7a7b9f-9496-4ad9-91bd-c1ff29df6035"), "Back", "Block Snatch" },
                    { new Guid("7f80a75e-3405-47a7-b9c3-56bc656b30d8"), "Legs", "Half Air Squat" },
                    { new Guid("81d1477b-9434-4208-bc44-584a546dc08f"), "Back", "Inverted Row" },
                    { new Guid("8369846b-aba4-4f39-8521-42db1ba1c1b2"), "Legs", "Lying Leg Curl" },
                    { new Guid("83c3704d-0cf0-4473-b9ba-94860cc0d830"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("857a9f34-6cfa-419c-8a26-bce1881957be"), "Back", "Seated Machine Row" },
                    { new Guid("85c12ca1-95a4-456e-af08-974b1a6a2c10"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("860ed2c2-2d09-4c6e-924e-c5aed2672f7a"), "Legs", "Goblet Squat" },
                    { new Guid("867bb980-16d8-4726-acf4-e5edde4bbce0"), "Back", "Pull-Up" },
                    { new Guid("87a1ada2-32ce-4ede-ad75-2501c4c2fde7"), "Legs", "Air Squat" },
                    { new Guid("89a896ce-75e6-453f-9aa4-a8c64fee4cae"), "Abs", "Kneeling Plank" },
                    { new Guid("8b966457-eef0-417a-a930-10a4d21ed1a7"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("8e006b73-b384-488b-b2f6-e880ebc7d928"), "Bicep", "Bodyweight Curl" },
                    { new Guid("914a8547-4583-48af-b6ab-52d1b835c75d"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("92021c37-db58-459a-b919-bb5c991a7d2f"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("93a19498-f750-4cf8-b08c-11c05251d21f"), "Back", "Clean and Jerk" },
                    { new Guid("93b3f675-c5f9-435c-9001-682d081d7f34"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("94650533-766e-41b5-a105-3eba0f40daef"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("94d72dc6-0192-4b0f-b497-9ac9eac5195c"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("956a3ea9-97c7-4b0b-b648-0008326cc72e"), "Bicep", "Hammer Curl" },
                    { new Guid("968db85b-c84a-4bad-ae00-b6bafbca4269"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("96956feb-0b02-4d9e-850f-08c62c486043"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("98c23ca4-05bb-4665-ad6d-93c1373a07e0"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("9a7d8966-1d59-470a-9a22-d78c0157aac5"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("9b14de2c-df64-4b66-b3bf-47f473e2e4e5"), "Tricep", "Bench Dip" },
                    { new Guid("9c70870e-41de-4303-ab58-53cb4881b943"), "Legs", "Step Up" },
                    { new Guid("9c9411d2-5b86-4c6b-aea9-ff8000fea7a1"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("9d713f0e-5b77-40cb-9006-c116248aed41"), "Back", "Rack Pull" },
                    { new Guid("9da945df-5f76-4d35-88ef-60da67002532"), "Legs", "Safety Bar Squat" },
                    { new Guid("9dc7c5f0-a950-4897-912b-bf4d39f27084"), "Back", "Back Extension" },
                    { new Guid("9f0b8d2e-aba2-4997-b357-410bb6af9b63"), "Chest", "Bench Press" },
                    { new Guid("a0d1f3b6-e4ab-45e6-b15f-1f72e4e6e6d2"), "Forearms", "Gripper" },
                    { new Guid("a210098d-6baa-473c-88d7-a9894d46a815"), "Back", "Good Morning" },
                    { new Guid("a386ea4d-bad1-4281-b686-a05fdf84fff8"), "Chest", "Dumbbell Pullover" },
                    { new Guid("a3f398f4-17ec-49b2-8675-103a3af0d8ac"), "Abs", "Cable Crunch" },
                    { new Guid("a3ff1089-cb13-41d1-80d6-e124b45267d6"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("a4fc6319-c0e6-4122-a8af-a75616d9152a"), "Chest", "Bar Dip" },
                    { new Guid("a517b5f8-d146-45fc-8776-eb9c949ff1b5"), "Shoulder", "Power Jerk" },
                    { new Guid("a6c1779d-f2a8-4845-9b5a-3cbe2b62f49c"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("a82f9888-5066-4d93-a0c0-e6f146b4aa26"), "Bicep", "Spider Curl" },
                    { new Guid("a84ff3c1-3a43-4c53-9b1a-3f45a6528365"), "Chest", "Kneeling Push-Up" },
                    { new Guid("a85d58eb-1442-498f-82a9-cdfcbfe72e6b"), "Back", "Power Snatch" },
                    { new Guid("a8b9ba38-e4c6-4a3d-929f-64d5e07bbf67"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("a9eee132-41f0-46f7-9474-3eb406c4648f"), "Legs", "Front Squat" },
                    { new Guid("ab2898b4-1b15-4ecd-ac46-2ce79ba7a24f"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("acf0c26a-f957-4e4c-91d8-485bcf1db648"), "Back", "Deficit Deadlift" },
                    { new Guid("b0025ea6-b3dc-4209-af86-f884a18152e4"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("b061664b-6e5f-4cb3-b293-b0c9d9e9ffc0"), "Glutes", "Fire Hydrants" },
                    { new Guid("b1b2f0f6-3d75-46db-bbb8-f3a3651cd439"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("b3192f6c-ef95-4f34-bfa5-5fa7c56782cd"), "Back", "Dumbbell Shrug" },
                    { new Guid("b3773efe-9df9-4a62-9f88-4023c372d1f5"), "Glutes", "Clamshells" },
                    { new Guid("b5a5fe11-d6bc-4a6c-8c21-4ef0107a27f7"), "Chest", "Incline Bench Press" },
                    { new Guid("b68fcfc7-997b-4d3e-83e4-db65b452e1d6"), "Chest", "Machine Chest Press" },
                    { new Guid("b6ed3c3e-90bb-4d24-8788-4800916969ce"), "Glutes", "Hip Thrust" },
                    { new Guid("ba9ba4d5-9764-4cd1-b593-14009e2ae526"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("be3d663c-5491-4929-9ecd-9cf68a440eb9"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("be601fe5-0c43-40cf-b504-a21cba2ebae8"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("bf3fc640-7759-46c9-a75e-5bd6bc747e19"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("bf79d6ed-a73d-441c-886b-9613e6723874"), "Legs", "Smith Machine Squat" },
                    { new Guid("bfb410d2-a216-417f-bbc2-129c8770f403"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("c1d20037-df5b-4557-8459-c9f229109f3f"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("c2aff932-4eda-415c-9612-b093a115c4b9"), "Back", "Clean" },
                    { new Guid("c3183c3c-a219-4e22-9ef3-5eecbcbc1794"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("c43eccdb-a777-4133-bc1c-8c41fb5aa032"), "Legs", "Seated Leg Curl" },
                    { new Guid("c470715c-27c2-4484-ad4d-ffdf24c4e142"), "Calves", "Standing Calf Raise" },
                    { new Guid("c83071d4-4c66-450a-96f5-8c864c75c78e"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("c84e7f2c-5109-46ec-88fa-6a37b2a86589"), "Legs", "Box Squat" },
                    { new Guid("c85fafc5-6a8d-489b-b9a2-51189b82b8d6"), "Abs", "Oblique Sit-Up" },
                    { new Guid("c9a85270-c779-4c6a-8492-ab3c05d2d5ee"), "Abs", "Sit-Up" },
                    { new Guid("cbb54891-c26f-4ffa-bd63-c00b5a3ff9b3"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("cdc48ab8-132a-4945-8f95-52349ac77be4"), "Abs", "Oblique Crunch" },
                    { new Guid("ce869a6c-dd9a-49f9-9ce9-cab728c5a805"), "Abs", "Side Plank" },
                    { new Guid("d0477ea0-476c-4401-8e28-aad655d2c57b"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("d0691483-7d87-45a4-b7ff-83f34b05ddbd"), "Shoulder", "Overhead Press" },
                    { new Guid("d165c3da-07a3-4c1d-bfc3-251a6d313c5e"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("d2f8d0b3-3f0f-4a34-9869-e4b2e6c1fb26"), "Forearms", "Plate Pinch" },
                    { new Guid("d3e85fa8-c86c-481b-ac14-f7c320cf5b21"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("d41dad43-b273-4216-a809-53e8aa799a1c"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("d4c71792-fd12-4ac2-9a03-097307e4646b"), "Shoulder", "Push Press" },
                    { new Guid("d78de9a2-8718-40fd-abd2-897c0b8461bc"), "Shoulder", "Squat Jerk" },
                    { new Guid("d7c067ef-a54c-470b-8889-048f1c4486ca"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("d7d5506f-d049-43ed-923a-66544cc8faa3"), "Back", "Hang Power Snatch" },
                    { new Guid("d9978b8a-5502-475a-beb4-31154c7db345"), "Back", "Deadlift" },
                    { new Guid("daf36e28-1f36-42aa-b1cc-5e9a99bbeb2e"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("dc09acca-9521-4592-892c-afc30e85d46c"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("dcdac711-5b9f-4f55-8ff3-c3b0a9d43149"), "Abs", "Dead Bug" },
                    { new Guid("dd1dfdce-d8a1-49c7-b7b5-6a04cc51f1c1"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("ded2f188-2d7e-422b-a89f-cccbae9d2a2f"), "Glutes", "Banded Side Kicks" },
                    { new Guid("df8ece85-e20a-4d27-b55b-f11f18127058"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("dfacaaca-271f-446e-b00b-381494ffde5f"), "Back", "Chin-Up" },
                    { new Guid("e2cddf04-b7d5-4950-bb24-b6223d8d1ae6"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("e5a5d5a3-3059-48ad-adfe-ac3d0b0db9fb"), "Glutes", "Cable Pull Through" },
                    { new Guid("e71db73c-555f-4b17-bb6c-da0a5d30c2ce"), "Calves", "Heel Raise" },
                    { new Guid("e822ee8d-ea40-4221-833c-869e8fe1bddf"), "Back", "Seal Row" },
                    { new Guid("e8b3ca24-06c7-4453-a008-f05c780bedb3"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("e9c3df19-0172-4b34-9fe3-0c9847b783ea"), "Legs", "Barbell Hack Squat" },
                    { new Guid("ea505092-c8c5-4859-a801-f9bb2fcdb158"), "Abs", "Plank" },
                    { new Guid("eab50a42-0db3-49f8-b6f1-85af7ac2fce6"), "Legs", "Landmine Hack Squat" },
                    { new Guid("eaba1ac5-5fba-4649-adfe-fdbaad6bb97e"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("eb8f2b01-17ef-4764-b893-44e527c8142f"), "Glutes", "Frog Pumps" },
                    { new Guid("ebf7f6d8-38c7-47cb-929a-fa94aa91c284"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("edbc006f-a21c-4a8d-ad52-c6e2663a702e"), "Legs", "Hack Squat Machine" },
                    { new Guid("ee5339ac-346c-4594-bb8c-c32d73d66767"), "Chest", "Cable Chest Press" },
                    { new Guid("eedb7dd2-3933-4fd3-9b68-05a6b2567969"), "Abs", "Mountain Climbers" },
                    { new Guid("eef4b799-aa34-4e0e-ab17-7a68f68a4edc"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("ef606e1a-a1e4-421d-8880-a0c493614e95"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("f18bc2f9-c540-49e2-a3f7-9794a4548b75"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("f2e83444-d593-4818-b8b6-aed176aebc1d"), "Shoulder", "Front Hold" },
                    { new Guid("f4f502d3-e9cd-49db-85af-88584957a2b4"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("f7f343fc-0690-47fd-8b1b-76d5755f7a99"), "Legs", "Body Weight Lunge" },
                    { new Guid("f9165751-9aa1-4fb4-897e-bf203827ca43"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("f9270ea5-b7e9-4cb4-beaa-a90571773aba"), "Shoulder", "Split Jerk" },
                    { new Guid("fa3abbdd-566e-4ee0-bd92-c77eaf178a03"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("fbfedb62-5ff4-4663-8511-12bbf45735ae"), "Abs", "Hanging Sit-Up" },
                    { new Guid("fdf37ac0-0bb9-483e-b643-870301993aba"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("fdfbef0a-dcf4-4032-86d0-e91fd8e2997a"), "Abs", "Hanging Knee Raise" },
                    { new Guid("fed9c48b-c513-495b-9b21-1c91dfbb648a"), "Legs", "Dumbbell Squat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_WorkoutId",
                table: "Rounds",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_RoundId",
                table: "Sets",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutTemplateExercises_WorkoutTemplateModelId",
                table: "WorkoutTemplateExercises",
                column: "WorkoutTemplateModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExerciseCategoryModels");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "LogMessages");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "UsersAchievements");

            migrationBuilder.DropTable(
                name: "UsersFriends");

            migrationBuilder.DropTable(
                name: "WorkoutTemplateExercises");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "WorkoutTemplates");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
