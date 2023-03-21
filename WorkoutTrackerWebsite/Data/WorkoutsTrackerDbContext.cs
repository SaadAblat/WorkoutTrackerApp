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
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Bench-Press" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Squat" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Deadlift" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Pull-Ups" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Push-Ups" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Overhead-Press" },
                new ExerciseModel { Id = Guid.NewGuid(), Name = "Biceps-Curl" });

        }

        public DbSet<WorkoutModel> Workouts { get; set; }
        public DbSet<UserAchievementsModel> UsersAchievements { get; set; }
        public DbSet<RoundModel> Rounds { get; set; }
        public DbSet<ExerciseModel> Exercises { get; set; }
        public DbSet<SetModel> Sets { get; set; }
        public DbSet<LogMessageModel> LogMessages { get; set; }

       
        
    }
}
