namespace WorkoutTrackerWebsite.Models
{
    public class Round
    {
        public Guid Id { get; set; }
        public int RoundNumber { get; set; }
        public string? Name { get; set; }
        public List<Set>? Sets { get; set; }
        public Exercise? Exercise { get; set; }

    }
}
