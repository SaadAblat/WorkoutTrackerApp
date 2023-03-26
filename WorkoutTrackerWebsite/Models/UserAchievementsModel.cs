namespace WorkoutTrackerWebsite.Models
{
    public class UserAchievementsModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int Level { get; set; }
        public decimal TotalWeightLifted { get; set; }
        public int TotalWorkoutSessions { get; set; }
        public List<string>? MainExercises { get; set; }
        

    }
}
