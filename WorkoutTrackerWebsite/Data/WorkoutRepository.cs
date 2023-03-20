using WorkoutTrackerWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Components.Authorization;

namespace WorkoutTrackerWebsite.Data
{
    public class WorkoutRepository:IDisposable
    {
        private readonly WorkoutsTrackerDbContext _ctx;
        public WorkoutRepository(WorkoutsTrackerDbContext ctx)
        {
            _ctx = ctx;
        }


        public void Dispose()
        {
            _ctx.Dispose();
        }
        
        public async Task<ExerciseModel> GetExerciseByIdAsync(Guid id)
        {
            return await _ctx.Exercises.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddWorkout(WorkoutModel workout)
        {
            await _ctx.Workouts.AddAsync(workout);

            if (workout.Rounds != null)
            {
                foreach (var round in workout.Rounds)
                {
                    await _ctx.Rounds.AddAsync(round);

                    if (round.Sets != null)
                    {
                        foreach (var set in round.Sets)
                        {
                            await _ctx.Sets.AddAsync(set);
                        }
                    }
                }
            }

            await _ctx.SaveChangesAsync();

        }



        
        public async Task<List<ExerciseModel>> GetAllExercisesAsync()
        {
            List<ExerciseModel> exercisesAll = await _ctx.Exercises.ToListAsync();
            return exercisesAll;
        }

        public async Task DeleteWorkoutAsync(Guid id)
        {
            var wrk = await _ctx.Workouts.FindAsync(id);
            if (wrk != null)
            {
                if (wrk.Rounds != null)
                {
                    foreach(var round in wrk.Rounds)
                    {
                        if (round.Sets != null)
                        {
                            foreach (var s in round.Sets)
                            {
                                _ctx.Sets.Remove(s);
                            }
                        }
                        _ctx.Rounds.Remove(round);
                    }
                }
                _ctx.Workouts.Remove(wrk);
                await _ctx.SaveChangesAsync();
            }
        }
        //  get all Rounds with the workoutId in the database
        public async Task<List<RoundModel>> GetRoundsByWorkoutIdAsync(WorkoutModel workout)
        {
            var WorkoutRounds = await _ctx.Rounds.Where(r=>r.WorkoutId == workout.Id).ToListAsync();
            return WorkoutRounds;
        }
        // Get all Sets with the RoundId in the Database
        public async Task<List<SetModel>> GetSetsByRoundIdAsync(RoundModel round)
        {
            var RoundSets = await _ctx.Sets.Where(r => r.RoundId == round.Id).ToListAsync();
            return RoundSets;
        }
        // Load the workout 
        public async Task<WorkoutModel> GetWorkoutByIdAsync(Guid id)
        {
            var workout = await _ctx.Workouts.FirstOrDefaultAsync(x => x.Id == id);
            if (workout != null)
            {
                workout.Rounds = await GetRoundsByWorkoutIdAsync(workout);
                foreach(var round in workout.Rounds)
                {
                    round.Sets = await GetSetsByRoundIdAsync(round);
                }

                return workout;

            }
            return new WorkoutModel();
        }

        //Get All the workouts
        public async Task<List<WorkoutModel>> GetAllWorkoutsAsync()
        {
            // load workout from the dataBase
            var workouts= await _ctx.Workouts.ToListAsync();
            var UpdatedWorkouts = new List<WorkoutModel>();
            foreach(WorkoutModel workout in workouts)
            {
               var Updatedworkout = await GetWorkoutByIdAsync(workout.Id);
                UpdatedWorkouts.Add(Updatedworkout);
            }
            return UpdatedWorkouts;
        }
        public async Task<List<WorkoutModel>> GetWorkoutsByUserIdAsync(string id)
        {
            // load workout from the dataBase
            var userWorkouts = await _ctx.Workouts.Where(x =>x.UserId == id).ToListAsync();
            var UpdatedWorkouts = new List<WorkoutModel>();
            foreach (WorkoutModel workout in userWorkouts)
            {
                var Updatedworkout = await GetWorkoutByIdAsync(workout.Id);
                UpdatedWorkouts.Add(Updatedworkout);
            }
            return UpdatedWorkouts;
        }

    }

    
    
}
