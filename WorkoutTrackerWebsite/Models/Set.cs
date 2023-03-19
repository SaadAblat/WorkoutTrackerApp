using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWebsite.Models
{
    public class SetModel
    {
        public Guid Id { get; set; }
        public int SetNumber { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }


        public Guid RoundId { get; set; }
        public RoundModel? Round { get; set; }

    }
}
