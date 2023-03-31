namespace WorkoutTrackerWebsite.Models.LogicModels
{
    public class RoundInfos
    {
        public Guid roundId { get; set; }
        public Guid workoutId { get; set; }

        public string? ExerciseName { get; set; }

        public Guid LastRoundIdWithTheSameExerciseName { get; set; }
        public Guid LastWorkoutIdWithTheSameExerciseName { get; set; }
    }
}
