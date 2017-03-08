using System;

namespace calculator
{
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
