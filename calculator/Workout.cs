using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Workout
    {
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public double AvgHeartRate { get; set; }
        public string Notes { get; set; }

        public Workout(DateTime date, TimeSpan duration, double heartRate, string notes)
        {
            Date = date;
            Duration = duration;
            AvgHeartRate = heartRate;
            Notes = notes ?? throw new ArgumentNullException(nameof(notes));
        }
       
       
    }

    public class DistanceWorkout : Workout
    {
        public double Distance { get; set; }
        public double Pace { get; set; }
        public DistanceWorkout(double distance, DateTime date, TimeSpan duration, double heartRate, string notes)
            : base(date, duration, heartRate, notes)
        {
            Distance = distance;
        }
    }
}
