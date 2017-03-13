using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace calculator.test
{
    [TestFixture]
    public class WorkoutTests
    {

        private MyWorkouts MyRecord;
        [SetUp]
        public void Init()
        {
            MyRecord = new MyWorkouts();
            var Workouts = new List<Workout>();
            Workouts.Add(new Workout(new DateTime(2017, 3, 6), new TimeSpan(1, 1, 1), 89, "YEAH, day 1"));
            Workouts.Add(new Workout(new DateTime(2017, 3, 7), new TimeSpan(1, 2, 1), 89, "good workout for day 2"));
            MyRecord.Workouts = Workouts;

        }
        [Test]
        public void DisplayWorkout_Should_Return_WhenNoTodayRecord()
        {
            var result = MyRecord.DisplayTodayWorkout();
        }

        [Test]
        public void DisplayWorkout_Should_ThrowException_WhenNotesNull()
        {
            Assert.Throws<ArgumentNullException>(
                ()=> MyRecord.Workouts.Add(
                    new Workout(new DateTime(2017, 3, 8), new TimeSpan(0, 30, 30), 120, null)));
        }

        [Test]
        public void DisplayWorkout_Should__Return_WithTodayWorkoutNotes()
        {
            MyRecord.Workouts.Add(new Workout(new DateTime(2017, 3, 8), new TimeSpan(0, 30, 30), 120, "nice"));
            var result = MyRecord.DisplayTodayWorkout();
        }

        [Test]
        public void DistanceWorkout_Should_Return_CorrectTodayWorkout()
        {
            MyRecord.Workouts.Add(new DistanceWorkout(23, new DateTime(2017, 3, 8), new TimeSpan(1, 2, 2), 110, "biking"));
            var result = MyRecord.DisplayTodayWorkout();
        }

        [Test]
        public void DispalyWrokOut_Should_Display_CorrectWorkout()
        {
            var result = MyRecord.DisplayWorkout(new DateTime(2017, 3,6));
            Assert.AreEqual("not bad workout", result);

        }
    }
}
