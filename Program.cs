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

             double studentGpa;
             string studentGrade;
             string studentRemark;
             int studentGradeUnit;
             int studentWeightPt;
             int studentTotalGradeUnit = 0;
             int studentTotalWeightPt = 0;
             int studentTotalUnitPassed = 0;
             int studentTotalCourseUnit = 0;

            List<string[]> studentRecords = new List<string[]>();

            for (int i = 0; i < registeredNumberOfCourses; i++)
            {
                Console.WriteLine($"{i + 1}Enter Course Name and Code (For eaxmple: (mth 101)):");
                var courseCode = Console.ReadLine();
                Console.Write($"{i + 1}Enter Course Unit: ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}Enter Course Score: ");
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

                if (courseScore >= 40)
                {
                    studentTotalUnitPassed += courseUnit;
                }
                studentTotalCourseUnit += courseUnit;
                studentTotalWeightPt += studentWeightPt;
                studentTotalGradeUnit += studentGradeUnit;


                string[] courseRecord = new string[] { courseCode,
                                                        courseUnit.ToString(),
                                                            studentGrade,
                                                                studentGradeUnit.ToString(),
                                                                    studentWeightPt.ToString(),
                                                                       studentRemark };


                studentRecords.Add(courseRecord);
            }

                studentGpa = studentTotalWeightPt / studentTotalGradeUnit;


                Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
                Console.WriteLine(" | COURSE & CODE    | COURSE UNIT     | GRADE     | GRADE-UNIT    | WEIGHT Pt     | REMARK       |");
                Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
                foreach (string[] courseRecord in studentRecords)
                {
                    Console.WriteLine($" |    {courseRecord[0],-14}|  " +
                                         $"   {courseRecord[1],-12}|  " +
                                         $"   {courseRecord[2],-6}|  " +
                                         $"  {courseRecord[3],-11}| " +
                                         $"   {courseRecord[4],-11}| " +
                                         $"   {courseRecord[5],-10}|");
                }

                Console.WriteLine("\n\n");
                Console.WriteLine($"Total course Unit registered is {studentTotalCourseUnit}");
                Console.WriteLine($"Total course Unit passed is {studentTotalUnitPassed}");
                Console.WriteLine($"Total Weight point is {studentTotalWeightPt}");
                Console.WriteLine($"GPA is {studentGpa:F2}");
 

        }
    }

}
