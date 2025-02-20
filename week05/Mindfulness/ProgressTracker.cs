using System;
using System.Diagnostics.CodeAnalysis;

public class ProgressTracker{
        private List<string> _completedActivities = new List<string>();
       private int _totalTime;
        public void LogActivity(string activityName, int duration){
            _completedActivities.Append(activityName);
            _totalTime = duration;
        }
        public void DisplayProgress(){
        Console.Write(_totalTime);
        Console.WriteLine(_completedActivities);
        }
    }
