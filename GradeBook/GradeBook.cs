using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        //constructor
        public GradeBook()
            {
                grades = new List<float>();
            }

        //add grades method
        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        //Statistics
        public GradeStatistics ComputeStatistics()
        {
            //create new instance of grade statistics
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;

                stats.MinimumGrade = Math.Min(grade,stats.MinimumGrade);
                stats.MaximumGrade = Math.Max(grade, stats.MaximumGrade);
    
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        List<float> grades;
    }
}
