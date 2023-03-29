using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Data
{
    public class WorkoutsTrackerDbContext: IdentityDbContext
    {
        public WorkoutsTrackerDbContext(DbContextOptions<WorkoutsTrackerDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RoundModel>()
                .HasOne<WorkoutModel>(round => round.Workout)
                .WithMany(wrk => wrk.Rounds)
                .HasForeignKey(round => round.WorkoutId);


            modelBuilder.Entity<SetModel>()
                .HasOne<RoundModel>(set => set.Round)
                .WithMany(round => round.Sets)
                .HasForeignKey(set => set.RoundId);


            // Add some initial exercises
            modelBuilder.Entity<ExerciseModel>().HasData(
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Bar Dip", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Chest Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Close-Grip Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Close-Grip Feet-Up Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Decline Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Chest Fly", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Chest Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Decline Chest Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Floor Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Pullover", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Feet-Up Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Floor Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Incline Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Incline Dumbbell Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Incline Push-Up", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Kneeling Incline Push-Up", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Kneeling Push-Up", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Chest Fly", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Chest Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Pec Deck", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Push-Up", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Push-Up Against Wall", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Push-Ups With Feet in Rings", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Resistance Band Chest Fly", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Smith Machine Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Smith Machine Incline Bench Press", Category = "Chest" },
                 new ExerciseModel { Id = Guid.NewGuid(), Name = "Standing Cable Chest Fly", Category = "Chest" },


                new ExerciseModel { Id = Guid.NewGuid(), Name = "Band External Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Band Internal Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Band Pull-Apart", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Front Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Rear Delt Row", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Upright Row", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Behind the Neck Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Lateral Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Rear Delt Row", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Front Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Horizontal Internal Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Horizontal External Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Lateral Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Rear Delt Row", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Shoulder Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Face Pull", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Front Hold", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Dumbbell External Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Dumbbell Internal Shoulder Rotation", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Lateral Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Shoulder Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Monkey Row", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Overhead Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Plate Front Raise", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Power Jerk", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Push Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Reverse Dumbbell Flyes", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Reverse Machine Fly", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Dumbbell Shoulder Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Barbell Overhead Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Smith Machine Shoulder Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Snatch Grip Behind the Neck Press", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Squat Jerk", Category = "Shoulder" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Split Jerk", Category = "Shoulder" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Preacher Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bodyweight Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Curl With Bar", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Curl With Rope", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Concentration Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Preacher Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hammer Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Incline Dumbbell Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Bicep Curl", Category = "Bicep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Spider Curl", Category = "Bicep" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Standing Triceps Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Lying Triceps Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bench Dip", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Close-Grip Push-Up", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Lying Triceps Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Standing Triceps Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Overhead Cable Triceps Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Tricep Bodyweight Extension", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Tricep Pushdown With Bar", Category = "Tricep" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Tricep Pushdown With Rope", Category = "Tricep" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Air Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Hack Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Lunge", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Walking Lunge", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Belt Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Body Weight Lunge", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Box Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bulgarian Split Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Chair Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Lunge", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Front Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Goblet Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hack Squat Machine", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Half Air Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Adduction Machine", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Landmine Hack Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Landmine Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Leg Extension", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Leg Press", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Leg Curl", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pause Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Romanian Deadlift", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Safety Bar Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Leg Curl", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Shallow Body Weight Lunge", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Side Lunges (Bodyweight)", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Smith Machine Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Squat", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Step Up", Category = "Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Step Up", Category = "Legs" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Back Extension", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Shrug", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Block Snatch", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Close Grip Seated Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Wide Grip Seated Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Chin-Up", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Clean", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Clean and Jerk", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Deficit Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Shrug", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Floor Back Extension", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Good Morning", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hang Clean", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hang Power Clean", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hang Power Snatch", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hang Snatch", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Inverted Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Inverted Row with Underhand Grip", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Kettlebell Swing", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lat Pulldown With Pronated Grip", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lat Pulldown With Supinated Grip", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "One-Handed Cable Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "One-Handed Lat Pulldown", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pause Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pendlay Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Power Clean", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Power Snatch", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pull-Up", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Rack Pull", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seal Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Machine Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Snatch", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Snatch Grip Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Stiff-Legged Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Straight Arm Lat Pulldown", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Sumo Deadlift", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "T-Bar Row", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Trap Bar Deadlift With High Handles", Category = "Back" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Trap Bar Deadlift With Low Handles", Category = "Back" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Banded Side Kicks", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Pull Through", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Clamshells", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Romanian Deadlift", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Frog Pumps", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Fire Hydrants", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Frog Pumps", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Glute Bridge", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Abduction Against Band", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Abduction Machine", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Thrust", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Thrust Machine", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hip Thrust With Band Around Knees", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lateral Walk With Band", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Glute Kickbacks", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "One-Legged Glute Bridge", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "One-Legged Hip Thrust", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Single Leg Romanian Deadlift", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Standing Glute Kickback in Machine", Category = "Glutes" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Step Up", Category = "Glutes" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Cable Crunch", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Crunch", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dead Bug", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hanging Leg Raise", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hanging Knee Raise", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Hanging Sit-Up", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "High to Low Wood Chop with Band", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Horizontal Wood Chop with Band", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Kneeling Ab Wheel Roll-Out", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Kneeling Plank", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Kneeling Side Plank", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Leg Raise", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Windshield Wiper", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Lying Windshield Wiper with Bent Knees", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Machine Crunch", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Mountain Climbers", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Oblique Crunch", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Oblique Sit-Up", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Plank", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Side Plank", Category = "Abs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Sit-Up", Category = "Abs" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Eccentric Heel Drop", Category = "Calves" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Heel Raise", Category = "Calves" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Seated Calf Raise", Category = "Calves" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Standing Calf Raise", Category = "Calves" },

                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Wrist Curl", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Wrist Curl Behind the Back", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bar Hang", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Wrist Curl", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Farmers Walk", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Fat Bar Deadlift", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Gripper", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "One-Handed Bar Hang", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Plate Pinch", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Plate Wrist Curl", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Towel Pull-Up", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Barbell Wrist Extension", Category = "Forearms" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Dumbbell Wrist Extension", Category = "Forearms" });















            modelBuilder.Entity<ExerciseCategoryModel>().HasData(
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Chest" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Shoulder" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Bicep" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Tricep" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Legs" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Back" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Glutes" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Abs" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Calves" },
                    new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Forearms" });
                
        }

        public DbSet<WorkoutModel> Workouts { get; set; }
        public DbSet<UserAchievementsModel> UsersAchievements { get; set; }
        public DbSet<RoundModel> Rounds { get; set; }
        public DbSet<ExerciseModel> Exercises { get; set; }
        public DbSet<SetModel> Sets { get; set; }
        public DbSet<LogMessageModel> LogMessages { get; set; }
        public DbSet<ExerciseCategoryModel> ExerciseCategoryModels { get; set; }


       
        
    }
}
