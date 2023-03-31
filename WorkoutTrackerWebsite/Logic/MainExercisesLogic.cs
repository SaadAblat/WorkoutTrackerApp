using Microsoft.EntityFrameworkCore.Internal;
using WorkoutTrackerWebsite.Data;
using WorkoutTrackerWebsite.Models;
using WorkoutTrackerWebsite.Models.LogicModels;

namespace WorkoutTrackerWebsite.Logic
{
    public static class MainExercisesLogic
    {


        //extract a list from string:MainExercises
        public static List<string> GetMainExercisesListFromString(UserAchievementsModel userAchievements)
        {

            if (userAchievements.MainExercises == null)
            {
                return new List<string>();
            }
            return userAchievements.MainExercises.Split(";").ToList();
        }

        //convert the List of strings to list of ExerciseInfo
        public static List<ExerciseInfos> ConvertListOfStringsToListOfExercisesInfos(UserAchievementsModel userAchievements, List<ExerciseModel> exercises, List<WorkoutModel> workouts)
        {
            List<ExerciseInfos> _mainExercisesInfo = new();
            //loop into each string and then find its matching exercise
            foreach (var exerciseName in GetMainExercisesListFromString(userAchievements))
            {
                foreach (var exercise in exercises)
                {
                    if (exerciseName == exercise.Name)
                    {
                        // now create an exercise Info from the exercise name and add it to the list
                        _mainExercisesInfo.Add(ExerciseInfoLogic.CreateExerciseInfo(exerciseName, workouts, exercises));
                    }
                }
            }
            return _mainExercisesInfo;
        }


    }
}
