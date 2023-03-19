namespace WorkoutTrackerWebsite.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<WorkoutModel>? Workouts { get; set; }

    }
}
