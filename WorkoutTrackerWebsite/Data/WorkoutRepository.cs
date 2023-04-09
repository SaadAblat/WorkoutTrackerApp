using WorkoutTrackerWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Routing;
using System.ComponentModel;

using WorkoutTrackerWebsite.Models.LogicModels;
using WorkoutTrackerWebsite.Pages;
using WorkoutTrackerWebsite.Pages.SocalComponents;

namespace WorkoutTrackerWebsite.Data
{
    public class WorkoutRepository:IDisposable
    {
        private readonly WorkoutsTrackerDbContext _ctx;

        private readonly UserManager<IdentityUser> _userManager;
       
        public WorkoutRepository(WorkoutsTrackerDbContext ctx)
        {
            _ctx = ctx;
        }


        public void Dispose()
        {
            _ctx.Dispose();
        }
        




        public async Task UpdateFriendStringAsync(UserFriendsModel userFriendsModel)
        {
            _ctx.UsersFriends.Update(userFriendsModel);
            await _ctx.SaveChangesAsync();
        }
        public async Task AddANewUserFriendsModelAsync(UserFriendsModel userFriendsModel)
        {
            await _ctx.UsersFriends.AddAsync(userFriendsModel);
            await _ctx.SaveChangesAsync();

        }

        public async Task<UserFriendsModel> GetUserFriendsModel(string userId) 
        {
            UserFriendsModel userFriendsModel = new();
            if (_ctx.UsersFriends != null && _ctx.UsersFriends.Count() != 0 && _ctx.UsersFriends.Any(x => x.UserId == userId))
            {
                userFriendsModel = await _ctx.UsersFriends.FirstAsync(x => x.UserId == userId);
            }
            return userFriendsModel;
        }









        public async Task<ExerciseModel> GetExerciseByIdAsync(Guid id)
        {
            return await _ctx.Exercises.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddWorkout(WorkoutModel workout, string userId)
        {
            workout.UserId = userId;
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
        public async Task AddWorkoutTemplateAsync(WorkoutTemplateModel template, WorkoutModel workout, string Name, string UserId)
        {
            List<WorkoutTemplateExercise> templateExercises = new();
            foreach (var round in workout.Rounds)
            {
                WorkoutTemplateExercise exercise = new WorkoutTemplateExercise();
                exercise.Name = round.ExerciseName;
                templateExercises.Add(exercise);
            }
            template.Exercises = templateExercises;
            template.UserId = UserId;
            template.Name = Name;
            await _ctx.WorkoutTemplates.AddAsync(template);
            await _ctx.SaveChangesAsync();

        }

        public async Task<WorkoutTemplateModel> GetWorkoutTemplateByIdAsync(Guid templateId)
        {
            WorkoutTemplateModel template = await _ctx.WorkoutTemplates.FindAsync(templateId);

            List<WorkoutTemplateExercise> exercises = new List<WorkoutTemplateExercise>();
            exercises = _ctx.WorkoutTemplateExercises.Where(x=>x.WorkoutTemplateModelId == templateId).ToList();
            if (template != null && exercises!= null && exercises.Count !=0) 
            { 
                template.Exercises = exercises;
            }

            return template;
        }

        public async Task<List<WorkoutTemplateModel>> GetWorkoutTemplatesByUserIdAsync(string userId)
        {
            List<WorkoutTemplateModel> EmptyTemplates = await _ctx.WorkoutTemplates.Where(x=>x.UserId == userId).ToListAsync();
            List<WorkoutTemplateModel> templates = new();
            foreach (var template in EmptyTemplates)
            {
                WorkoutTemplateModel temp = await GetWorkoutTemplateByIdAsync(template.Id);
                templates.Add(temp);
            }
            return templates;
        }
        public async Task DeleteWorkoutTemplateAsyncById(Guid workoutTemplateId)
        {
            WorkoutTemplateModel templateModel = await GetWorkoutTemplateByIdAsync(workoutTemplateId);
            _ctx.WorkoutTemplates.Remove(templateModel);
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
                    foreach (var round in wrk.Rounds)
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
        public async Task<List<IdentityUser>> GetAllUsersAsync()
        {
            var users = await _ctx.Users.ToListAsync();
            return users;
        }

        public async Task<IdentityUser> GetUserById(string id)
        {

            var user = await _ctx.Users.FindAsync(id);
            return user;
        }




        public async Task<UserAchievementsModel> GetUserAchievementByUserId(string userId)
        {
            if (_ctx.UsersAchievements.Any(r => r.UserId == userId))
            {
                var userAchievemt = await _ctx.UsersAchievements.FirstAsync(r => r.UserId == userId);
                return userAchievemt;

            }
            UserAchievementsModel userAchievement = await CreateUserAchievementAsync(userId);
            return userAchievement;
            
        }
        public async Task<UserAchievementsModel> CreateUserAchievementAsync(string userId)
        {
            UserAchievementsModel userAchievementsModel = new();

            userAchievementsModel.UserId = userId;
            userAchievementsModel.UserName = "";
            userAchievementsModel.TotalWeightLifted = 0;
            userAchievementsModel.TotalWorkoutSessions = 0;
            userAchievementsModel.PeriodTraining = 0;
            userAchievementsModel.MainExercises = "";

            await _ctx.UsersAchievements.AddAsync(userAchievementsModel);
            await _ctx.SaveChangesAsync();
            return userAchievementsModel;
        }
        public async Task UpdateUserAchievementAsync(string userId, string userName)
        {
            var userAchievement = await GetUserAchievementByUserId(userId);
            if (userAchievement == null)
            {
                //add if new
                userAchievement = await CreateUserAchievementAsync(userId);
            }
            //update username
            userAchievement.UserName = userName;
            userAchievement.TotalWeightLifted = 0;
            
            // Calculate total weight lifted in all user workout
            var UserWorkouts = await GetWorkoutsByUserIdAsync(userId);
            foreach (var userWorkout in UserWorkouts)
            {
                if (userWorkout.Rounds != null)
                {
                    foreach (var round in userWorkout.Rounds)
                    {
                        if (round.Sets != null)
                        {
                            foreach (var set in round.Sets)
                            {
                                userAchievement.TotalWeightLifted += (set.Weight * set.Reps);
                            }
                        }
                    }
                }
            }
            // Calculate total workouts
            userAchievement.TotalWorkoutSessions = UserWorkouts.Count;
            await _ctx.SaveChangesAsync();
        }


        public async Task<List<UserAchievementsModel>> GetAllUserAchievementsModel()
        {
            List<UserAchievementsModel> usersAchievements = await _ctx.UsersAchievements.ToListAsync();
            return usersAchievements;
        }

        public async Task AddLogMessageAsync(LogMessageModel msg)
        {
            await _ctx.LogMessages.AddAsync(msg);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<LogMessageModel>> GetAllLogMessageModels()
        {
            return await _ctx.LogMessages.ToListAsync();
        }
        public async Task<List<LogMessageModel>> GetLogMessageModelsByFriendsIds(List<string> FriendsIds, string userId)
        {
            List<LogMessageModel> displayedLogMessages = new();
            List<LogMessageModel> allLogMessages = await GetAllLogMessageModels();
            if (FriendsIds != null && FriendsIds.Count != 0)
            {
                // for every id in friends ids list
                foreach (var friendId in FriendsIds)
                {
                    List<LogMessageModel> logMessageModelsByFriend = new();
                    //search for the messages that have his id in userId
                    logMessageModelsByFriend = allLogMessages.Where(x => x.UserId == friendId).ToList();

                    // then add every message in that list to DisplayedlogMessages
                    displayedLogMessages.AddRange(logMessageModelsByFriend);

                }
                List<LogMessageModel> userLogMessages = allLogMessages.Where(x => x.UserId == userId).ToList();
                displayedLogMessages.AddRange(userLogMessages);


            }
            else
            {
                List<LogMessageModel> userLogMessages = allLogMessages.Where(x => x.UserId == userId).ToList();
                displayedLogMessages.AddRange(userLogMessages);
            }
            return displayedLogMessages;
        }
        public async Task<List<ExerciseCategoryModel>> GetAllExerciseCategories()
        {
            return await _ctx.ExerciseCategoryModels.ToListAsync();
        }
        public async Task UpdateMainExercisesStringByUserIdAsync(string userId, string mainExerciseString)
        {
            var userAchievement = await GetUserAchievementByUserId(userId);
            userAchievement.MainExercises = "";
            userAchievement.MainExercises = mainExerciseString;
            await _ctx.SaveChangesAsync();
        }



    }


  

}
