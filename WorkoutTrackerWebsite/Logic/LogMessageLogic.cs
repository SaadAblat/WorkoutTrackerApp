﻿using WorkoutTrackerWebsite.Models;

namespace WorkoutTrackerWebsite.Logic
{
    public static class LogMessageLogic
    {

        public static LogMessageModel GenerateLogMessage(string body, WorkoutModel workout, string cssClass)
        {
            LogMessageModel logMessage = new();
            logMessage.UserId = workout.UserId;
            logMessage.WorkoutDate = workout.Date;
            logMessage.MessageDate = DateTime.Now;
            logMessage.MessageBody = body;
            logMessage.CssClass = cssClass;

            return logMessage;

        }
        public static LogMessageModel GenerateLogMessage(string body, string userId, string cssClass)
        {
            LogMessageModel logMessage = new();
            logMessage.UserId = userId;
            logMessage.WorkoutDate = DateTime.Now; // No workout here, maybe I need to change this name to something more general
            logMessage.MessageDate = DateTime.Now;
            logMessage.MessageBody = body;
            logMessage.CssClass = cssClass;

            return logMessage;
        }
    }
}
