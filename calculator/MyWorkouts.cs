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
            if(null != Workouts)
            {
                var todayWorkout = Workouts.Where(w => w.Date == DateTime.Now.Date)
                    .FirstOrDefault();
                if(null != todayWorkout)
                {
                    if (todayWorkout is DistanceWorkout dist)
                    {
                        return string.Format("I ran {0} miles", dist.Distance);
                    }

                    return todayWorkout.Notes.Length >15 ? todayWorkout.Notes :"not bad workout";
                }
            }

            return string.Empty;
        }
    }
}
