using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        var calculator = new Calculator();
                        var result = calculator.Add(1, 2);
      //Console.WriteLine(result);
      //Console.ReadLine();

      List<Workout> Workouts = new List<Workout>();
                        Workouts.Add(new Workout(new DateTime(2017, 3, 6), new TimeSpan(1, 1, 1), 89, "YEAH, day 1"));
                        Workouts.Add(new Workout(new DateTime(2017, 3, 7), new TimeSpan(1, 2, 1), 89, "good workout for day 2"));
                        Workouts.Add(new DistanceWorkout(2, new DateTime(2017, 3, 8), new TimeSpan(2, 1, 1), 89, "good workout for day 3"));
                        Workouts.Add(new Workout(new DateTime(2017, 3, 8), new TimeSpan(0, 30, 30), 120, null));

                        var myworkoutRecord = new MyWorkouts()
                        {
                                Workouts = Workouts
                        };
                        string workoutResult = myworkoutRecord.DisplayTodayWorkout();
                        Console.WriteLine(workoutResult);
                }

        }

        public class Calculator
        {
                public int Add(int value1, int value2)
                {
                        return value1 + value2;
                }

                public double Divide(int value1, int value2)
                {
                        return value1 / value2;
                }

        }


}
