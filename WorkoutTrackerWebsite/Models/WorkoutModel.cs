using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerWebsite.Models
{
    public class WorkoutModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime Date { get; set; }

        
        public virtual ICollection<RoundModel>? Rounds { get; set; }

    }
}
