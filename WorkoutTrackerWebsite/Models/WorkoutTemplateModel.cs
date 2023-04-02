using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerWebsite.Models
{
    public class WorkoutTemplateModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? Name { get; set; }



        public ICollection<WorkoutTemplateExercise>? Exercises { get; set; }

    }
}
