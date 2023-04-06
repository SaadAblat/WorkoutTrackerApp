using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using WorkoutTrackerWebsite.Models;
using WorkoutTrackerWebsite.Models.LogicModels;
using WorkoutTrackerWebsite.Pages;

namespace WorkoutTrackerWebsite.Logic
{
    public static class ExerciseInfoLogic
    {

        // Exercise Info
        // Calculating Data
        public static decimal CalculateVolume(List<WorkoutModel> workouts, string exerciseName)
        {
            decimal volume = 0;
            foreach (var wrk in workouts)
            {
                foreach (var round in wrk.Rounds)
                {
                    if (round.ExerciseName == exerciseName)
                    {
                        foreach(var set in round.Sets)
                        {
                            volume += (set.Reps * set.Weight);
                        }
                    }
                }
            }
            return volume;
        }
        public static int CalculateReps(List<WorkoutModel> workouts, string exerciseName)
        {
            int reps = 0;
            foreach (var wrk in workouts)
            {
                foreach (var round in wrk.Rounds)
                {
                    if (round.ExerciseName == exerciseName)
                    {
                        foreach (var set in round.Sets)
                        {
                            reps += set.Reps;
                        }
                    }
                }
            }
            return reps;
        }
        public static int GetExerciseTimesTrained(string exerciseName, List<WorkoutModel> workouts)
        {
            int exerciseTimesPlayed = 0;
            foreach (var wrk in workouts)
            {
                foreach (var round in wrk.Rounds)
                {
                    if (round.ExerciseName == exerciseName)
                    {
                        exerciseTimesPlayed++;
                    }
                }
            }
            return exerciseTimesPlayed;
        }
        public static decimal GetExerciseMaxWeightLifted(string exerciseName, List<WorkoutModel> workouts)
        {
            decimal maxWeight = 0;
            foreach (var wrk in workouts)
            {
                foreach (var round in wrk.Rounds)
                {
                    if (round.ExerciseName == exerciseName)
                    {
                        foreach (var set in round.Sets)
                        {
                            if (set.Weight > maxWeight)
                            {
                                maxWeight = set.Weight;
                            }
                        }
                    }
                }
            }
            return maxWeight;
        }
        public static int GetExerciseMaxWeightReps(string exerciseName, decimal maxWeight, List<WorkoutModel> workouts)
        {
            int maxWeightReps = 0;

            foreach (var wrk in workouts)
            {
                foreach (var round in wrk.Rounds)
                {
                    if (round.ExerciseName == exerciseName)
                    {
                        foreach (var set in round.Sets)
                        {
                            if (set.Weight == maxWeight)
                            {
                                if (set.Reps > maxWeightReps)
                                    maxWeightReps = set.Reps;
                            }
                        }
                    }
                }
            }
            return maxWeightReps;
        }

        public static string GetExerciseCategory(string exerciseName, List<ExerciseModel> exercises)
        {
            string CategoryName = "";
            foreach (var ex in exercises)
            {
                if (ex.Name == exerciseName)
                {
                    CategoryName = ex.Category;
                }
            }
            return CategoryName;
        }
        public static ExerciseInfos CreateExerciseInfo(string exerciseName, List<WorkoutModel> workouts, List<ExerciseModel> exercises, bool calculateVolume = false)
        {
            ExerciseInfos exerciseInfo = new();
            exerciseInfo.Name = exerciseName;
            exerciseInfo.NumberOfSessions = GetExerciseTimesTrained(exerciseName, workouts);
            exerciseInfo.MaxWeight = GetExerciseMaxWeightLifted(exerciseName, workouts);
            exerciseInfo.MaxWeightReps = GetExerciseMaxWeightReps(exerciseName, exerciseInfo.MaxWeight, workouts);
            exerciseInfo.Category = GetExerciseCategory(exerciseName, exercises);
            if (calculateVolume)
            {
                exerciseInfo.NumberOfReps = CalculateReps(workouts, exerciseName);
                exerciseInfo.TotalVolume = CalculateVolume(workouts, exerciseName);
                if (exerciseInfo.TotalVolume <= 0 && exerciseInfo.NumberOfReps > 0)
                {
                    exerciseInfo.IsBodyWeight = true;
                }
            }
            return exerciseInfo;
        }
        public static List<ExerciseInfos> CreateAllExercisesInfo(List<ExerciseModel> exercises, List<WorkoutModel> workouts, bool calculateVolume = false)
        {
            List<ExerciseInfos> exercisesInfo = new();
            foreach (var ex in exercises)
            {
                if (ex.Name != null) exercisesInfo.Add(CreateExerciseInfo(ex.Name, workouts, exercises, calculateVolume));
            }
            return exercisesInfo;

        }

        //by exercise
        public static List<ExerciseInfos> CreateExercisesInfoByExerciseName(List<ExerciseModel> exercises, string exerciseName, List<WorkoutModel> workouts)
        {
            List<ExerciseInfos> exercisesInfo = new();
            foreach (var ex in exercises)
            {
                if (ex.Name == exerciseName)
                {
                    exercisesInfo.Add(CreateExerciseInfo(ex.Name, workouts, exercises));
                }
            }
            return exercisesInfo;
        }

        //by category
        public static List<ExerciseInfos> GetExercisesInfoByCategoryName(string categoryName, List<ExerciseModel> exercises, List<WorkoutModel> workouts)
        {
            List<ExerciseInfos> exercisesInfo = new();
            foreach (var ex in exercises)
            {
                if (ex.Category == categoryName)
                {
                    exercisesInfo.Add(CreateExerciseInfo(ex.Name, workouts, exercises));
                }
            }
            return exercisesInfo;
        }
    }
}
