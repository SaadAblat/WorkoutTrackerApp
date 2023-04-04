using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWebsite.Models
{
    public class WorkoutModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public virtual ICollection<RoundModel>? Rounds { get; set; }

        public string? Note { get; set; }


        [NotMapped]
        public bool IsExpanded { get; set; }
        [NotMapped]
        public string CssAnimation { get; set; }

    }
}
