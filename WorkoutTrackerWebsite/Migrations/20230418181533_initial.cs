using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutTrackerWebsite.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    { new Guid("0d5ab2a2-14b0-4fd2-a18c-33166c77e5f3"), "Forearms" },
                    { new Guid("2ec41abb-d87d-4bbf-a682-22da9e43eea5"), "Back" },
                    { new Guid("39ddfaa1-77b3-4df0-9650-b3a90163a7e0"), "Calves" },
                    { new Guid("471dc78d-ccec-4f7d-8175-ee1be9533f99"), "Tricep" },
                    { new Guid("6f10ee07-f7de-42b3-a697-a44f30666606"), "Legs" },
                    { new Guid("8dd92cbc-4b24-4029-8dd2-c0763b8c8dea"), "Shoulder" },
                    { new Guid("bd55e67d-bc0e-42f3-b383-39fc58b5aaea"), "Bicep" },
                    { new Guid("c0fed27a-1f10-40a0-806c-a5551b765304"), "Glutes" },
                    { new Guid("c9a03327-6e38-4b56-a0a9-c728c875e265"), "Abs" },
                    { new Guid("f8016bc0-2aed-491f-bd90-aa871f848590"), "Chest" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { new Guid("0195a832-e02f-4b6f-8b68-82b996d044cd"), "Back", "Barbell Row" },
                    { new Guid("020dbec6-88dc-407d-a143-6a752798cb88"), "Legs", "Landmine Hack Squat" },
                    { new Guid("051c79a9-162d-4e74-bdc0-f450f6af630d"), "Legs", "Box Squat" },
                    { new Guid("0771a484-fca9-465d-8040-ebea9178e982"), "Shoulder", "Band External Shoulder Rotation" },
                    { new Guid("07aeff38-0985-466b-a406-f953e6597c1a"), "Chest", "Resistance Band Chest Fly" },
                    { new Guid("08e841a3-37e2-4502-a6c2-5933c267d5ec"), "Back", "Pendlay Row" },
                    { new Guid("09cd1404-1ad1-4863-b178-a59c5fe3bce5"), "Glutes", "Hip Thrust" },
                    { new Guid("0afca2c5-dd1c-4840-b19a-a07cd19be991"), "Back", "One-Handed Lat Pulldown" },
                    { new Guid("0b96bd27-b63f-4fa1-8b5a-63ee46ebcef8"), "Legs", "Front Squat" },
                    { new Guid("0be3be0d-ba4b-43fb-a85b-5696a4bfd107"), "Tricep", "Tricep Pushdown With Bar" },
                    { new Guid("0c26b68a-1a0c-49a8-9494-13c2dd7875be"), "Shoulder", "Monkey Row" },
                    { new Guid("0d29c68e-494c-4936-94f7-9aaa233f0a68"), "Shoulder", "Machine Lateral Raise" },
                    { new Guid("1072898d-93b4-4332-95b5-81fce1467d66"), "Chest", "Feet-Up Bench Press" },
                    { new Guid("1124f543-56fa-47fd-9aff-93c92cba3f69"), "Abs", "Hanging Knee Raise" },
                    { new Guid("148fb42d-ad0a-4e61-8caf-f66a6614acb5"), "Shoulder", "Barbell Front Raise" },
                    { new Guid("14b00c40-7f25-49b0-8e9d-b032babda43b"), "Back", "Kettlebell Swing" },
                    { new Guid("1571f5c7-cb1b-4232-92e6-921c8ff53c4f"), "Calves", "Eccentric Heel Drop" },
                    { new Guid("15cd1615-f73c-415d-a1bb-ceba757b043e"), "Chest", "Dumbbell Floor Press" },
                    { new Guid("168cab0f-e233-4fb2-be84-d1db85be8148"), "Shoulder", "Barbell Upright Row" },
                    { new Guid("171538f1-bd3d-4f69-8a5d-5c80d159d173"), "Chest", "Push-Up Against Wall" },
                    { new Guid("18808320-a63b-428e-9d0b-7560c3f11b32"), "Legs", "Dumbbell Squat" },
                    { new Guid("1a693bdf-98dd-48bc-895b-cd39477b851c"), "Back", "Dumbbell Row" },
                    { new Guid("1b953cc9-cfd8-4d42-972a-3231ca261d02"), "Bicep", "Concentration Curl" },
                    { new Guid("1c6c480b-1bfb-475c-a251-c566eca15713"), "Abs", "Crunch" },
                    { new Guid("1ebfff2f-983c-4284-9a6c-e28480ae7aa0"), "Glutes", "Hip Abduction Machine" },
                    { new Guid("1f404d20-3f1c-4dcf-b636-2999f324b26c"), "Legs", "Barbell Lunge" },
                    { new Guid("1f597490-20db-4c73-a685-bfc141ee99d9"), "Bicep", "Dumbbell Curl" },
                    { new Guid("20bdbda2-57e6-4cdd-8bca-9673045c734d"), "Back", "Trap Bar Deadlift With High Handles" },
                    { new Guid("2184f984-c84b-4559-8c08-138651c8ffb5"), "Legs", "Leg Press" },
                    { new Guid("2195315e-127b-4329-8e1e-f2986dc5a750"), "Forearms", "Farmers Walk" },
                    { new Guid("2718bc15-cbb7-4154-b493-e4c560577769"), "Back", "Chin-Up" },
                    { new Guid("275350af-74c6-41e8-9b39-53bd02a96f8a"), "Back", "Power Snatch" },
                    { new Guid("2827b667-0232-4943-8195-fa6c69e9d114"), "Calves", "Standing Calf Raise" },
                    { new Guid("29fa82b8-544f-4fbf-a9f3-48acea9a3043"), "Back", "Dumbbell Shrug" },
                    { new Guid("2a5fa146-00ef-49e3-8f2b-eb9e8f1d9442"), "Forearms", "Bar Hang" },
                    { new Guid("2bdafd89-ff93-4598-9459-bc07599fb037"), "Legs", "Lying Leg Curl" },
                    { new Guid("2bef41ee-826f-4b08-b4ea-60cf237093ca"), "Abs", "Kneeling Side Plank" },
                    { new Guid("2c008989-756f-438a-bdd8-2910c4ca3c83"), "Legs", "Pause Squat" },
                    { new Guid("2c71e76a-06be-44d3-9f1f-18de4c99485c"), "Shoulder", "Dumbbell Front Raise" },
                    { new Guid("2c89c5f6-2b61-4135-9f0b-66eb973433d8"), "Back", "Dumbbell Deadlift" },
                    { new Guid("2dfc90d7-5cb2-43a4-be1b-ae36dde4ea11"), "Shoulder", "Split Jerk" },
                    { new Guid("2f6ce80f-5080-48ad-bb8d-2be634b6b736"), "Chest", "Machine Chest Press" },
                    { new Guid("2fd15d2e-67d1-44fc-91f8-7667edd66515"), "Shoulder", "Cable Rear Delt Row" },
                    { new Guid("30f73001-2ab0-492a-b5b2-7db21cf0a478"), "Abs", "Plank" },
                    { new Guid("31e73b95-f194-4c99-88c6-5f20d6db60a2"), "Back", "Cable Wide Grip Seated Row" },
                    { new Guid("33f6e7b5-8ab1-4479-8fab-2b3a7222c1b5"), "Bicep", "Cable Curl With Rope" },
                    { new Guid("347400f2-7b3b-409b-a8b6-9dfd26f042c4"), "Abs", "Sit-Up" },
                    { new Guid("34af233b-3b87-4c99-a036-9a55caa608fa"), "Chest", "Bench Press" },
                    { new Guid("35464eab-20fa-4279-bb42-3f680fe563bb"), "Shoulder", "Seated Barbell Overhead Press" },
                    { new Guid("37a22e2e-329d-4ffd-9484-8bdb6bbb211a"), "Forearms", "Plate Pinch" },
                    { new Guid("3d64e4db-1f54-417a-82b6-c357bc392f45"), "Back", "Rack Pull" },
                    { new Guid("3f751e15-fbec-414b-b250-278d662c35d1"), "Back", "Hang Power Clean" },
                    { new Guid("3f8f84d6-1848-4bed-a5da-6215f4323b7a"), "Tricep", "Dumbbell Standing Triceps Extension" },
                    { new Guid("4091072b-c826-4a0c-85da-65c442cb20a9"), "Abs", "Mountain Climbers" },
                    { new Guid("4181a217-c83e-46e4-9701-dbdb7304b6d4"), "Abs", "Horizontal Wood Chop with Band" },
                    { new Guid("41f83d10-070f-475b-92e2-1e5c56664941"), "Tricep", "Close-Grip Push-Up" },
                    { new Guid("41fb04ae-76b0-4c8f-8264-b7a8d087eb8f"), "Bicep", "Bodyweight Curl" },
                    { new Guid("4204f089-8f91-45db-b039-0eb86d729a27"), "Chest", "Decline Bench Press" },
                    { new Guid("43ee40ac-86cc-4a97-aa41-8b15bbd52044"), "Glutes", "Glute Bridge" },
                    { new Guid("44ceae4e-9697-4e4d-ae26-abf4b080c754"), "Back", "Seated Machine Row" },
                    { new Guid("45e7897b-ee56-4135-949e-abd3d65a6a78"), "Back", "Hang Snatch" },
                    { new Guid("482cd1d2-aca5-4588-8e65-2fd31c395e7f"), "Abs", "Kneeling Plank" },
                    { new Guid("49e73689-bc44-4259-9268-d9bc5ba1039e"), "Bicep", "Cable Curl With Bar" },
                    { new Guid("4d3106fb-2c61-41d9-8f8f-851aa6e03b71"), "Forearms", "Plate Wrist Curl" },
                    { new Guid("4d616183-6757-47d9-8e19-21c902610d84"), "Chest", "Dumbbell Pullover" },
                    { new Guid("5185fdfc-8840-46a7-b8cf-1b8cb0c0c999"), "Back", "Hang Clean" },
                    { new Guid("5482f7bb-3d29-4a5d-91d7-dae1c1fa434b"), "Forearms", "Dumbbell Wrist Curl" },
                    { new Guid("556bea9c-c390-43eb-983d-5c936426fdca"), "Glutes", "One-Legged Hip Thrust" },
                    { new Guid("5681e267-ee5c-47cb-9713-4167746c06e1"), "Glutes", "Hip Thrust Machine" },
                    { new Guid("58a50017-31ba-49ab-b2fb-bb5621624157"), "Shoulder", "Overhead Press" },
                    { new Guid("58f19d13-386d-4cec-9a49-638b44df9333"), "Bicep", "Hammer Curl" },
                    { new Guid("598dbdee-684d-4b84-a485-bc260b4b55de"), "Bicep", "Machine Bicep Curl" },
                    { new Guid("5b02cd89-c570-465d-8b2d-0d577e16936b"), "Chest", "Standing Cable Chest Fly" },
                    { new Guid("5b44873f-c84d-4786-b014-580eb0a8242b"), "Abs", "Lying Leg Raise" },
                    { new Guid("5d38fc58-645b-49d9-815c-62ab0f19b298"), "Shoulder", "Dumbbell Horizontal Internal Shoulder Rotation" },
                    { new Guid("5e0a1428-9bba-4c70-b778-a05e4cfab3d5"), "Chest", "Dumbbell Chest Press" },
                    { new Guid("5e53ae20-d08b-427b-8c20-14ed9793b506"), "Legs", "Bulgarian Split Squat" },
                    { new Guid("5f3d9be3-4ffe-4c94-bb0e-0fe1cc8ed23d"), "Chest", "Smith Machine Incline Bench Press" },
                    { new Guid("5fa8dc38-ba04-4c6d-ae33-de307c73afef"), "Back", "Deadlift" },
                    { new Guid("5fd6eba4-19a4-4437-8664-7fe9c40829cf"), "Legs", "Side Lunges (Bodyweight)" },
                    { new Guid("60a7a47c-54de-41c9-963a-8e6b0e7e8019"), "Legs", "Shallow Body Weight Lunge" },
                    { new Guid("60f3686e-ece4-4bd1-85bd-f4e4f1695aa0"), "Legs", "Landmine Squat" },
                    { new Guid("62f09e36-dcd6-4dba-a666-8f504e24d3cb"), "Chest", "Kneeling Incline Push-Up" },
                    { new Guid("643fcd91-ffd7-443b-aa07-43fea276177f"), "Tricep", "Barbell Standing Triceps Extension" },
                    { new Guid("65f3bf41-51a1-4c87-a63d-07af6dd87f67"), "Shoulder", "Dumbbell Lateral Raise" },
                    { new Guid("6be6f932-5431-4e83-b591-46ff91a06ad8"), "Glutes", "Lateral Walk With Band" },
                    { new Guid("6c7fac59-c9b6-414d-9c5d-621d7bcd5c78"), "Tricep", "Overhead Cable Triceps Extension" },
                    { new Guid("6e89286f-8143-4c9d-b6e3-c1d6257ef0c2"), "Glutes", "Cable Pull Through" },
                    { new Guid("708ace27-4dfa-43a5-9419-4eb7ef1c0a0b"), "Tricep", "Barbell Lying Triceps Extension" },
                    { new Guid("70b55350-7876-4940-a41b-d34790a3dcba"), "Chest", "Incline Dumbbell Press" },
                    { new Guid("7148656d-2127-486f-a184-385c865a0bf4"), "Abs", "Cable Crunch" },
                    { new Guid("71f76ec7-a6ca-4b6d-b5a6-5b633e19bdf1"), "Abs", "Kneeling Ab Wheel Roll-Out" },
                    { new Guid("73f71447-3db2-4849-bfb4-57aaa3fdb3f1"), "Abs", "Lying Windshield Wiper with Bent Knees" },
                    { new Guid("7638e619-71af-4ed6-9c08-c09e69b156e9"), "Abs", "Dead Bug" },
                    { new Guid("77bc4c7b-1c2d-41ef-9a7c-cd8315af040b"), "Bicep", "Spider Curl" },
                    { new Guid("77c18141-be95-468c-93ee-d705d46acdf6"), "Shoulder", "Squat Jerk" },
                    { new Guid("79679e9e-64bb-44ae-a847-13c11bf51737"), "Chest", "Pec Deck" },
                    { new Guid("79822338-6771-4079-9d75-f6e2c45765fc"), "Shoulder", "Cable Lateral Raise" },
                    { new Guid("7998e15b-30c7-4b29-a729-664577b182c0"), "Shoulder", "Barbell Rear Delt Row" },
                    { new Guid("7bf7f9ed-b4ba-4429-bce5-39bcf2bab6fa"), "Glutes", "Frog Pumps" },
                    { new Guid("7c34d6d2-0ee9-4c30-8c86-ff1f68a3e956"), "Legs", "Safety Bar Squat" },
                    { new Guid("7c8d41f8-ab25-4d2a-a337-feb1aedb576e"), "Legs", "Smith Machine Squat" },
                    { new Guid("7cd2ff93-c339-4e07-9545-2b644499f4c2"), "Back", "Hang Power Snatch" },
                    { new Guid("7d2195f8-44e8-4120-b372-48daaef4b88a"), "Abs", "Oblique Crunch" },
                    { new Guid("7ee2349c-8a69-4018-9eb4-08f71b33ffdc"), "Bicep", "Barbell Curl" },
                    { new Guid("7f7d7b5c-667c-4fbd-97e6-7995a40398bf"), "Legs", "Leg Extension" },
                    { new Guid("800af0ad-03b7-431d-97ea-471094f7bef3"), "Abs", "Side Plank" },
                    { new Guid("82fd2301-32ea-4f0f-82a4-80ac13d4854b"), "Back", "Straight Arm Lat Pulldown" },
                    { new Guid("83227b67-d8a9-48a4-8974-7dc9a0cbc163"), "Chest", "Push-Up" },
                    { new Guid("8354bf9d-42c5-4637-bf82-b5d6f1818ee4"), "Shoulder", "Plate Front Raise" },
                    { new Guid("841f9812-8dc8-4182-8137-411433034919"), "Chest", "Push-Ups With Feet in Rings" },
                    { new Guid("8520e565-8c06-4968-b621-e6360eb1988e"), "Calves", "Seated Calf Raise" },
                    { new Guid("8659e390-937b-4c90-8204-05e943b1610c"), "Glutes", "Dumbbell Romanian Deadlift" },
                    { new Guid("868c1034-880d-4d21-8fae-971a68bf3457"), "Tricep", "Bench Dip" },
                    { new Guid("869ce2b8-93f3-45c5-93f6-89db958b862f"), "Glutes", "Clamshells" },
                    { new Guid("86e2400b-7e4a-4b35-b728-1d6bbd8543ac"), "Glutes", "Banded Side Kicks" },
                    { new Guid("86ed4039-fd53-4530-b4cf-f8614120e47a"), "Back", "Floor Back Extension" },
                    { new Guid("88e93410-f69b-4041-959c-cfbd26a03403"), "Shoulder", "Reverse Dumbbell Flyes" },
                    { new Guid("89be0df6-0a43-42b2-b025-c41021840f03"), "Glutes", "Standing Glute Kickback in Machine" },
                    { new Guid("8b82e7b8-8108-4064-b6ac-9b7ad77e94bf"), "Back", "Snatch Grip Deadlift" },
                    { new Guid("8bcdaf36-c439-42d6-85b3-9b1afd4ececf"), "Chest", "Kneeling Push-Up" },
                    { new Guid("8dd315f0-6717-476d-a84e-3873fef8cf28"), "Glutes", "Single Leg Romanian Deadlift" },
                    { new Guid("8de64c24-59b2-44b5-8133-abb52a25835e"), "Back", "Trap Bar Deadlift With Low Handles" },
                    { new Guid("8e0457d9-2464-40d2-b9a2-7f55112596ad"), "Back", "Deficit Deadlift" },
                    { new Guid("8f670c50-0a69-4164-8110-42baba5f84ae"), "Abs", "Hanging Leg Raise" },
                    { new Guid("8f88700c-c1d4-4c19-9b22-5d6e6777ffb8"), "Chest", "Incline Bench Press" },
                    { new Guid("9541112a-e24a-4f6b-9e9a-95a2292fa3fd"), "Back", "Pull-Up" },
                    { new Guid("95cb9196-9d41-42db-9b28-519ffda00126"), "Forearms", "Barbell Wrist Curl" },
                    { new Guid("97bec9ba-c9e7-4826-9db4-c83524d1bdf6"), "Back", "Sumo Deadlift" },
                    { new Guid("988606f6-4e9a-4b3e-b0c8-66d585c10213"), "Forearms", "Dumbbell Wrist Extension" },
                    { new Guid("997ed233-9301-448f-96b1-7eb7a08fb51b"), "Legs", "Hack Squat Machine" },
                    { new Guid("99b07bd3-1516-44d5-b09f-aba231b25cfa"), "Glutes", "Hip Abduction Against Band" },
                    { new Guid("9a20b882-ee0f-4efc-9c98-1ac37eb77df9"), "Legs", "Half Air Squat" },
                    { new Guid("9b66c24c-dbd7-44bd-be76-8b92673d9d8a"), "Legs", "Romanian Deadlift" },
                    { new Guid("9d029e4f-0083-4fb1-a305-9c94e86d7cc0"), "Shoulder", "Band Internal Shoulder Rotation" },
                    { new Guid("9ef8f0a5-616f-4c9a-a89c-72ed25c82cf2"), "Back", "T-Bar Row" },
                    { new Guid("9f228b96-a8a7-485b-89f4-ecde1a147cf1"), "Chest", "Cable Chest Press" },
                    { new Guid("a008d5b4-0e42-45bf-84cf-7d5dce3b5085"), "Forearms", "One-Handed Bar Hang" },
                    { new Guid("a365cf55-0c7d-42ec-8a26-a5d609295bfb"), "Glutes", "Dumbbell Frog Pumps" },
                    { new Guid("a40e150c-4535-4ad4-922c-c6969fdf69f9"), "Forearms", "Gripper" },
                    { new Guid("a6bfc80e-6d51-4822-94ac-f2eb42de677a"), "Forearms", "Barbell Wrist Extension" },
                    { new Guid("a6f72ee9-8b07-4e20-95c6-f2ba4ebdc5c2"), "Legs", "Air Squat" },
                    { new Guid("a9d18b6d-6abc-4411-b382-bc072c4d90c3"), "Forearms", "Fat Bar Deadlift" },
                    { new Guid("aa064d10-6084-4d50-887c-8a092d77dde6"), "Back", "Barbell Shrug" },
                    { new Guid("aa13ac8d-7a22-46a1-88c3-69d322fc0d63"), "Shoulder", "Lying Dumbbell Internal Shoulder Rotation" },
                    { new Guid("ae15bb14-b103-4442-a4d6-e70fe28e69e5"), "Abs", "Lying Windshield Wiper" },
                    { new Guid("ae189018-e101-43f0-ab3f-79fb8287c903"), "Abs", "High to Low Wood Chop with Band" },
                    { new Guid("ae582b87-2fc8-44be-8eba-98e3888869d2"), "Shoulder", "Dumbbell Shoulder Press" },
                    { new Guid("aeb001e4-9ff6-4bb4-974d-ebf45c64041a"), "Legs", "Hip Adduction Machine" },
                    { new Guid("af3ca46e-e3bb-42fd-bdc9-335e5777c654"), "Legs", "Barbell Hack Squat" },
                    { new Guid("b027c1cd-90ed-4e8a-8d0e-6d479dfd5972"), "Forearms", "Barbell Wrist Curl Behind the Back" },
                    { new Guid("b281ac05-5afa-43e8-898f-03dc957cb045"), "Tricep", "Dumbbell Lying Triceps Extension" },
                    { new Guid("b35cfbf7-b26d-4b23-94a9-082d3eb6edad"), "Legs", "Belt Squat" },
                    { new Guid("b4da1602-9a39-4a0c-8461-f91eb94a6fd9"), "Shoulder", "Seated Smith Machine Shoulder Press" },
                    { new Guid("b5136d65-f174-4650-8ad8-adc208c45957"), "Chest", "Dumbbell Decline Chest Press" },
                    { new Guid("b5f20365-c298-4a9c-990c-35f5571e0aab"), "Legs", "Barbell Walking Lunge" },
                    { new Guid("b6836fc3-2722-4f15-bf6c-4a18226cda8b"), "Legs", "Goblet Squat" },
                    { new Guid("b9dadb6e-e562-4c60-a996-077441e7aaba"), "Back", "Inverted Row" },
                    { new Guid("bb810523-f886-4e5a-a1d9-134c28b5286c"), "Shoulder", "Dumbbell Horizontal External Shoulder Rotation" },
                    { new Guid("bc9f38b0-6b86-4402-b64b-fae920f82eb2"), "Back", "Snatch" },
                    { new Guid("bcc228f6-0007-47c4-b215-781347679b7a"), "Chest", "Smith Machine Bench Press" },
                    { new Guid("bd2eae5a-2c0c-47fd-b353-fb084bf099e5"), "Chest", "Bar Dip" },
                    { new Guid("bdcea1ee-00f2-4101-afa2-335bd5fa0bc0"), "Shoulder", "Push Press" },
                    { new Guid("bdfaaa8e-73f3-4b3d-b567-7763da727b07"), "Back", "Back Extension" },
                    { new Guid("be612f94-39ef-422d-87e1-e2b12908924f"), "Chest", "Close-Grip Bench Press" },
                    { new Guid("c01df4a7-f973-4003-8899-395509d52ab7"), "Shoulder", "Snatch Grip Behind the Neck Press" },
                    { new Guid("c26e55ea-945f-4f9c-91c5-ae36a06a0637"), "Glutes", "Hip Thrust With Band Around Knees" },
                    { new Guid("c5323025-ac01-4d8c-b8fb-8929c38a1e9f"), "Abs", "Oblique Sit-Up" },
                    { new Guid("c5e13a34-953e-4fb6-a53a-313bf6edd032"), "Legs", "Squat" },
                    { new Guid("c601a369-35f5-4c4b-b0b1-4ddaaa0c403c"), "Shoulder", "Front Hold" },
                    { new Guid("c65a919c-cb29-4daf-8992-5408d7fc037e"), "Shoulder", "Dumbbell Rear Delt Row" },
                    { new Guid("c674aff0-dafd-47bf-981f-1cf9030819ba"), "Chest", "Machine Chest Fly" },
                    { new Guid("c75f032a-1e8d-454b-8a67-f2f86d29fd91"), "Bicep", "Incline Dumbbell Curl" },
                    { new Guid("c93efc6c-1419-4352-b71d-161e4faf3791"), "Shoulder", "Power Jerk" },
                    { new Guid("c9542f7a-b9a5-478f-86a8-6b7b9c6a4258"), "Back", "Lat Pulldown With Supinated Grip" },
                    { new Guid("ca9a58ad-36e5-456e-a10d-e0042c3cb96f"), "Shoulder", "Machine Shoulder Press" },
                    { new Guid("cb6c99d4-e472-4828-85c5-9ce2d6f37923"), "Back", "Stiff-Legged Deadlift" },
                    { new Guid("cbb1304c-4cc6-4440-a06d-6da5270e78ae"), "Back", "Cable Close Grip Seated Row" },
                    { new Guid("cd6665e7-2bb2-4c9f-b2c1-dd84c3eadd36"), "Shoulder", "Face Pull" },
                    { new Guid("cda6a5ed-25ec-46b2-a48e-b47a138b6ef6"), "Back", "Block Snatch" },
                    { new Guid("ce7b65f3-9248-442d-a2b4-1f55deac27f3"), "Legs", "Dumbbell Lunge" },
                    { new Guid("cee22187-0749-4c54-98cd-08699a2194c5"), "Back", "Seal Row" },
                    { new Guid("d1256f14-3a35-451f-b59d-b98ea1f7adfe"), "Back", "Pause Deadlift" },
                    { new Guid("d63a1b14-af1d-4c14-adf0-ac18acc90250"), "Legs", "Seated Leg Curl" },
                    { new Guid("d71b1e4f-752a-4b7b-a5b8-b98c69fa20ba"), "Legs", "Chair Squat" },
                    { new Guid("d80ea772-6a29-43b9-8f2e-709c651977b3"), "Chest", "Floor Press" },
                    { new Guid("d8c180fa-947f-4272-a59d-53fdfdc63be2"), "Abs", "Hanging Sit-Up" },
                    { new Guid("d8ebe4d5-8a60-415c-90f9-05da59f810e1"), "Tricep", "Tricep Pushdown With Rope" },
                    { new Guid("d910fad4-24b0-47d8-9aff-3c59f78da81f"), "Back", "Power Clean" },
                    { new Guid("d946c68b-368c-4361-b7d7-858a1eb2f3d2"), "Back", "Inverted Row with Underhand Grip" },
                    { new Guid("da5120aa-9f08-479e-89bc-52ab7dde4aa2"), "Back", "Lat Pulldown With Pronated Grip" },
                    { new Guid("da6fa21f-9422-4487-94b5-3f72183ae390"), "Back", "Good Morning" },
                    { new Guid("db4ee30e-84df-4d5e-aa0f-d1ac8a764dd6"), "Shoulder", "Behind the Neck Press" },
                    { new Guid("dcffe063-147c-4f65-b38e-c66062306f5d"), "Shoulder", "Lying Dumbbell External Shoulder Rotation" },
                    { new Guid("dea1687f-47ca-4004-8b9d-1c014b3a3fa0"), "Chest", "Dumbbell Chest Fly" },
                    { new Guid("e0b1048b-2996-46d1-80e2-0f413d854e2d"), "Glutes", "Step Up" },
                    { new Guid("e0b10898-2629-48c4-9330-f0c373b5778e"), "Back", "Clean" },
                    { new Guid("e2d10c6f-30bf-4b1a-b4df-8be1c8d02525"), "Back", "Clean and Jerk" },
                    { new Guid("e6d9729f-19a3-41b3-9feb-fc80d817b66a"), "Bicep", "Dumbbell Preacher Curl" },
                    { new Guid("e71207f0-4897-4381-ad59-f74ec79e3c1b"), "Calves", "Heel Raise" },
                    { new Guid("eb8f163d-b97f-4334-810b-40214fba5691"), "Shoulder", "Seated Dumbbell Shoulder Press" },
                    { new Guid("ece65b4d-10a6-47eb-9458-9968b3b873c8"), "Legs", "Step Up" },
                    { new Guid("eee56879-3588-46f1-9ad8-50c6c68d4a54"), "Back", "One-Handed Cable Row" },
                    { new Guid("efcb9aa0-61aa-4d65-b5f9-ac2856166407"), "Chest", "Incline Push-Up" },
                    { new Guid("f3fbd829-6834-49e8-aade-4abe533b4637"), "Forearms", "Towel Pull-Up" },
                    { new Guid("f558b0e1-d154-4b18-a85b-dd29130e24ce"), "Glutes", "One-Legged Glute Bridge" },
                    { new Guid("f59dda33-f215-4b6f-bf77-4c3c2bf78bec"), "Glutes", "Fire Hydrants" },
                    { new Guid("f5dd8bb0-9d1c-4db7-bc84-feb48a44bf6a"), "Legs", "Body Weight Lunge" },
                    { new Guid("f6673576-4e92-466f-9bb8-3769d1390961"), "Tricep", "Tricep Bodyweight Extension" },
                    { new Guid("f6fe6034-bd95-4506-b5a1-9d673cbe6d88"), "Chest", "Close-Grip Feet-Up Bench Press" },
                    { new Guid("f7a44e94-e8a6-4293-b27e-18253d90d9f7"), "Shoulder", "Reverse Machine Fly" },
                    { new Guid("f9be2d18-a4f3-4999-8b88-da858fd26ef1"), "Bicep", "Barbell Preacher Curl" },
                    { new Guid("fa76314b-4800-405c-a586-b6be7c8aadf6"), "Abs", "Machine Crunch" },
                    { new Guid("fbdd8aec-313d-4a92-b10a-f0106e7fc5c2"), "Legs", "Step Up" },
                    { new Guid("fc6ed00a-b7f4-4a2a-8629-208ec3eec8ce"), "Glutes", "Machine Glute Kickbacks" },
                    { new Guid("fd806d4c-ab4a-4e37-bf6b-481273564560"), "Shoulder", "Band Pull-Apart" }
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
