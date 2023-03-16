namespace WorkoutTrackerWebsite.Models
{
    public class Workout
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public List<Round>? Rounds { get; set; }

    }
}
