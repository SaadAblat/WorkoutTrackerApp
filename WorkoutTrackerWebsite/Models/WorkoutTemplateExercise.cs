namespace WorkoutTrackerWebsite.Models
{
    public class WorkoutTemplateExercise
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public Guid WorkoutTemplateModelId { get; set; }
    }
}
