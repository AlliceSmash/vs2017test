using System;
using System.Collections.Generic;
using System.Linq;

namespace calculator
{
    public class MyWorkouts
    {
        public List<Workout> Workouts { get; set; }
        public MyWorkouts()
        {

        }

        public string DisplayTodayWorkout()
        {
            return DisplayWorkout(DateTime.Today);
        }

        public string DisplayWorkout(DateTime aDay)
        {
            if (null != Workouts)
            {
                var workout = Workouts.Where(w => w.Date == aDay.Date)
                    .FirstOrDefault();
                return GetDisplayString(workout);
            }
            return string.Empty;
        }

        public string GetDisplayString(Workout workout)
        {
            if (null == workout) return string.Empty;

            if (workout is DistanceWorkout dist)
            {
                return string.Format("I ran {0} miles", dist.Distance);

            }
            else
            {
                return workout.Notes.Length > 15 ? workout.Notes : "not bad workout";
            }

        }
    }

  
}
