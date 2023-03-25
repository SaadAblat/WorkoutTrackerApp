namespace WorkoutTrackerWebsite.Models
{
    public class CustomExerciseModel
    {
        // add it in dbcontext
        // create getAllCustomExercises in repository
        // Call it in userhome
        // Add the list to the list of exercises in onInitialized

        // Add create a new exercise // BAAD IDEA!
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
    }
}
