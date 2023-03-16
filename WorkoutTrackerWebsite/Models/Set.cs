namespace WorkoutTrackerWebsite.Models
{
    public class Set
    {
        public Guid Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }

    }
}
