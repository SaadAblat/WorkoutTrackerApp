using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Repository
{
    public class WorkoutRepository : IWorkoutTrackerRepository<Workout>
    {
        public Task<Workout> AddAsync(Workout workout)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workout>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Workout> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Workout> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
