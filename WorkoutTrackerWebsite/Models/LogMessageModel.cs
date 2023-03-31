namespace WorkoutTrackerWebsite.Models
{
    public class LogMessageModel
    {
        public Guid Id { get; set; }
        public DateTime MessageDate { get; set; }
        public string? MessageBody { get; set; }
        public string? MessageColor { get; set; }

    }
}
