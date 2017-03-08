using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
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
}
