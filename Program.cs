using System;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Gradebook";
        }
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

           GiveBookAName(g1);

            Console.WriteLine(g1.Name);
            Console.WriteLine(g2.Name);

            int x1 = 4;
            int x2 = x1;
            
            x1 = 100;
            Console.WriteLine(x2);


            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);    

        }
    }
}
