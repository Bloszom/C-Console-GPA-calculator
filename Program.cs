using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;


namespace Blossom_WeekOne_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to your GPA calculator\n ");
            Console.WriteLine("Please enter your registered Number of courses: ");
            int registeredNumberOfCourses = int.Parse(Console.ReadLine());

             double StudentGpa;
             string studentGrade;
             string studentRemark;
             int studentGradeUnit;
             int studentWeightPt;
             int studentTotalGradeUnit = 0;
             int studentTotalWeightPoint = 0;
             int studentTotalUnitPassed = 0;
             int studentTotalCourseUnit = 0;

            List<string[]> studentRecords = new List<string[]>();

            for (int i = 0; i < registeredNumberOfCourses; i++)
            {
                Console.WriteLine($"Enter Course Code");
                var courseCode = Console.ReadLine();
                Console.Write($"Enter Course Unit: ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write($" Enter Course Score: ");
                int courseScore = int.Parse(Console.ReadLine());

                studentGrade = (courseScore >= 70 && courseScore <= 100) ? "A" :
                                (courseScore >= 60 && courseScore <= 69) ? "B" :
                                (courseScore >= 50 && courseScore <= 59) ? "C" :
                                (courseScore >= 40 && courseScore <= 49) ? "D" :
                                (courseScore >= 30 && courseScore <= 39) ? "E" : "F";

                studentGradeUnit = (courseScore >= 70 && courseScore <= 100) ? 5 :
                                   (courseScore >= 60 && courseScore <= 69) ? 4 :
                                   (courseScore >= 50 && courseScore <= 59) ? 3 :
                                   (courseScore >= 40 && courseScore <= 49) ? 2 :
                                   (courseScore >= 30 && courseScore <= 39) ? 1 : 0;

                studentRemark = (courseScore >= 70 && courseScore <= 100) ? "Excellent" :
                               (courseScore >= 60 && courseScore <= 69) ? "Very-Good" :
                               (courseScore >= 50 && courseScore <= 59) ? "Good" :
                               (courseScore >= 40 && courseScore <= 49) ? "Fair" :
                               (courseScore >= 30 && courseScore <= 39) ? "Pass" : "Fail";

                studentWeightPt = courseUnit * studentGradeUnit;

               

            }

        }
    }

}
