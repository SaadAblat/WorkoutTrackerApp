using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Logic
{
    public static class FriendsLogic
    {
        /// <summary>
        /// Returns a list of string:
        /// Convert the User friends String To a List Of string containing the Friends Ids 
        /// </summary>
        /// <returns></returns>
        public static List<string>  Friends_Ids_List(string friendsString)
        {
            List<string> ListOfFriendsIds = new();
            if (friendsString != null && friendsString.Count() != 0)
            {
                ListOfFriendsIds = friendsString.Split(";").ToList();
            }
            return ListOfFriendsIds;
        }
        /// <summary>
        /// Returns a list of UserAchievements :
        /// Takes in a string convert it To a list of string then Convert the List Of string To a List Of User Achievements. 
        /// </summary>
        /// <returns></returns>
        public static List<UserAchievementsModel> Friends_UserAchievements_List(string friendsString, List<UserAchievementsModel> usersAchievementsList)
        {
            List<UserAchievementsModel> userAchList = new();
            foreach (var id in Friends_Ids_List(friendsString))
            {
                if (usersAchievementsList.Any(x => x.UserId == id))
                {
                    UserAchievementsModel friendUserAch = new();
                    friendUserAch = usersAchievementsList.First(x => x.UserId == id);
                    userAchList.Add(friendUserAch);
                }

            }
            return userAchList;
        }

    }
}
