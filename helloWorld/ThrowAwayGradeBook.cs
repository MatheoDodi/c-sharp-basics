using System;
namespace helloWorld
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook()
        {

        }

        public new GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Inside ThrowAwayGradeBook");
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(lowest, grade);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}
