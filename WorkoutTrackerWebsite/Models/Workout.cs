namespace WorkoutTrackerWebsite.Models
{
    public class WorkoutModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }


        public virtual ICollection<RoundModel>? Rounds { get; set; }

    }
}
