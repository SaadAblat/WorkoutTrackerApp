namespace WorkoutTrackerWebsite.Models
{
    public class UserAchievementsModel
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int PeriodTraining { get; set; }
        public decimal TotalWeightLifted { get; set; }
        public int TotalWorkoutSessions { get; set; }
        public string? MainExercises { get; set; }
        

    }
}
