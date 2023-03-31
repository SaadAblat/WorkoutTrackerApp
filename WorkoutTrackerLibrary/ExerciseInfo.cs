using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTrackerLibrary
{
    internal class ExerciseInfo
    {
        public string? name;
        public string categoy = "";
        public decimal maxWeight = 0;
        public int maxWeightReps = 0;
        public int numberOfSessions = 0;
        public int numberOfSets = 0;
        public int numberOfReps = 0;
        public decimal totalWeightLifted = 0;
    }
}
