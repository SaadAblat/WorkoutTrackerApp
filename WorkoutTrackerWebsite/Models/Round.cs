using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWebsite.Models
{
    public class RoundModel
    {
        public Guid Id { get; set; }
        public int RoundNumber { get; set; }


        public string? ExerciseName { get; set; }

        public virtual IList<SetModel>? Sets { get; set; }

        public Guid WorkoutId { get; set; }
        public WorkoutModel? Workout { get; set; }

    }
}
