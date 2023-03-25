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
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bench-Press", Category="Push"  },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Squat", Category="Legs" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Deadlift", Category= "Pull" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pull-Ups", Category = "Pull" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Push-Ups", Category = "Push" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Overhead-Press", Category = "Push" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Biceps-Curl", Category="Legs" });

            modelBuilder.Entity<ExerciseCategoryModel>().HasData(
                new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Push" },
                new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Pull" },
                new ExerciseCategoryModel { Id = Guid.NewGuid(), Name = "Legs" });
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
