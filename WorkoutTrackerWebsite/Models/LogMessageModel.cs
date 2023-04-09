namespace WorkoutTrackerWebsite.Models
{
    public class LogMessageModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public DateTime MessageDate { get; set; }
        public string? MessageBody { get; set; }
        public string? CssClass { get; set; }

    }
}
