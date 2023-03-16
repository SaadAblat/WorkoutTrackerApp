using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Data
{
    public class WorkoutsTrackerDbContext: DbContext
    {
        public WorkoutsTrackerDbContext(DbContextOptions<WorkoutsTrackerDbContext> options):base(options)
        {
            
        }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Set> Set { get; set; }
    }
}
