namespace WorkoutTrackerWebsite.Models.LogicModels
{
    public static class LogMessageModelLogic
    {
        
        public static LogMessageModel GenerateLogMessage(string body, WorkoutModel workout, string color)
        {
            LogMessageModel logMessage = new();
            logMessage.WorkoutDate = workout.Date;
            logMessage.MessageDate = DateTime.Now;
            logMessage.MessageBody = body;
            logMessage.MessageColor = color;
            
            return logMessage;
            
        }
    }
}
