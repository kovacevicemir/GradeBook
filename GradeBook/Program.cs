using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of gradebook
            GradeBook book = new GradeBook();

            //Add some grades
            book.AddGrades(10);
            book.AddGrades(20.5f);
            book.AddGrades(17.5f);

            //Do Calculations
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Minimum grade: " + stats.MinimumGrade);
            Console.WriteLine("Maximum grade: " + stats.MaximumGrade);
            Console.ReadKey();
        }
    }
}
