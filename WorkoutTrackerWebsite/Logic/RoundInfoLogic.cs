using WorkoutTrackerWebsite.Models;
using WorkoutTrackerWebsite.Models.LogicModels;
using WorkoutTrackerWebsite.Pages;

namespace WorkoutTrackerWebsite.Logic
{
    public static class RoundInfoLogic
    {
        public static List<RoundInfos> AllRoundsInfo(List<WorkoutModel> workouts)
        {
            List<RoundInfos> RoundsInfo = new();
            foreach (var workout in workouts.OrderBy(x => x.Date))
            {
                foreach (var round in workout.Rounds)
                {
                    RoundInfos roundInfo = new()
                    {
                        roundId = round.Id,
                        workoutId = workout.Id,
                        ExerciseName = round.ExerciseName,

                    };
                    if (RoundsInfo.Any(x => x.ExerciseName == round.ExerciseName))
                    {
                        roundInfo.LastRoundIdWithTheSameExerciseName = RoundsInfo.Last(x => x.ExerciseName == round.ExerciseName).roundId;
                        roundInfo.LastWorkoutIdWithTheSameExerciseName = RoundsInfo.Last(x => x.ExerciseName == round.ExerciseName).workoutId;
                    }
                    else
                    {
                        roundInfo.LastRoundIdWithTheSameExerciseName = roundInfo.roundId;
                        roundInfo.LastWorkoutIdWithTheSameExerciseName = roundInfo.workoutId;

                    }
                    RoundsInfo.Add(roundInfo);
                }
            }
            return RoundsInfo;
        }

        public static decimal Get_Previous_Round_Best_Set_s_Weight(List<WorkoutModel> workouts, RoundModel round)
        {
            if (AllRoundsInfo(workouts).Any(x => x.roundId == round.Id))
            {
                //find the matching RoundInfo
                RoundInfos matchingRoundInfo = Get_Round_Matching_RoundInfo(workouts, round);

                //Get the last workout with the same exercise
                WorkoutModel previousWorkout = Get_LastWorkout_Including_thisRound_Exercise(workouts, matchingRoundInfo);

                //get the round from the last workout with the same exercise
                RoundModel previousRound = Get_LastWorkoutRound_Including_thisRound_Exercise(matchingRoundInfo, previousWorkout);

                //Find the set with the max weight
                SetModel previousSetWithMaxWeight = previousRound.Sets.MaxBy(x => x.Weight);

                // Get the weight
                decimal previousSet_Weight_Output = previousSetWithMaxWeight.Weight;

                return previousSet_Weight_Output;
            }
            return 0;
        }
        public static int Get_Previous_Round_Best_Set_s_Reps(List<WorkoutModel> workouts, RoundModel round, decimal previousSet_Weight_Output )
        {
            if (AllRoundsInfo(workouts).Any(x => x.roundId == round.Id))
            {
                //find the matching RoundInfo
                RoundInfos matchingRoundInfo = Get_Round_Matching_RoundInfo(workouts, round);

                //Get the last workout with the same exercise
                WorkoutModel previousWorkout = Get_LastWorkout_Including_thisRound_Exercise(workouts, matchingRoundInfo);

                //get the round from the last workout with the same exercise
                RoundModel previousRound = Get_LastWorkoutRound_Including_thisRound_Exercise(matchingRoundInfo, previousWorkout);

                //Find the set with the max weight
                SetModel previousSetWithMaxWeight = previousRound.Sets.MaxBy(x => x.Weight);

                // Get all the sets with max weight:
                IEnumerable<SetModel> previousSetsWithMaxWeight = previousRound.Sets.Where(x => x.Weight == previousSet_Weight_Output);
                // Get the one with the max reps, and get its reps:
                int previousSet_Reps_Output = previousSetsWithMaxWeight.MaxBy(x => x.Reps).Reps;

                return previousSet_Reps_Output;
            }
            return 0;
        }
        public static RoundInfos Get_Round_Matching_RoundInfo(List<WorkoutModel> workouts, RoundModel round)
        {
            RoundInfos matchingRoundInfo = AllRoundsInfo(workouts).First(x => x.roundId == round.Id);
            return matchingRoundInfo;
        }

        public static WorkoutModel Get_LastWorkout_Including_thisRound_Exercise(List<WorkoutModel> workouts, RoundInfos matchingRoundInfo)
        {
            Guid previousWorkoutId = matchingRoundInfo.LastWorkoutIdWithTheSameExerciseName;
            WorkoutModel previousWorkout = workouts.First(x => x.Id == previousWorkoutId);

            return previousWorkout;
        }

        public static RoundModel Get_LastWorkoutRound_Including_thisRound_Exercise(RoundInfos matchingRoundInfo, WorkoutModel previousWorkout)
        {
            Guid PreviousRoundId = matchingRoundInfo.LastRoundIdWithTheSameExerciseName;
            RoundModel previousRound = previousWorkout.Rounds.First(x => x.Id == PreviousRoundId);
            return previousRound;
        }
    }


}
