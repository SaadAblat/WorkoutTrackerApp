using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWebsite.Models.LogicModels
{
    public class ExerciseInfos
    {
        // This one is not Added to the database
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal MaxWeight { get; set; }
        public int MaxWeightReps { get; set; }
        public int NumberOfSessions { get; set; }
        public int NumberOfSets { get; set; }
        public int NumberOfReps { get; set; }
        public decimal TotalVolume { get; set; }

        public  bool IsBodyWeight { get; set; }

        public bool IsDropDownActive { get; set; }

    }
}
