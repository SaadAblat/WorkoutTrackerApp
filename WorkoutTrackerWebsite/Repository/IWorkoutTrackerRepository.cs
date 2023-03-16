using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Repository
{
    public interface IWorkoutTrackerRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Guid id);
        Task<TEntity> UpdateAsync(Guid id);
        Task<TEntity> AddAsync(TEntity workout);
        Task<bool> DeleteAsync(Guid id);
    }
}