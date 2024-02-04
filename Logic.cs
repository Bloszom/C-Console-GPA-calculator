using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blossom_WeekOne_Task
{
    public class Logic
    {
        public static void LogicMethod()
        {
            string studentGrade;
            string studentRemark;
            int studentGradeUnit;
            int studentWeightPt;
            int studentTotalGradeUnit = 0;
            int studentTotalWeightPt = 0;
            int studentTotalUnitPassed = 0;
            int studentTotalCourseUnit = 0;
            double studentGpa;

            List<string[]> studentRecords = new List<string[]>();

            Console.WriteLine(" Welcome to your GPA calculator\n ");
            Console.WriteLine("Enter your registered Number of courses: ");
            int registeredNumberOfCourses = int.Parse(Console.ReadLine());

            for (int i = 0; i < registeredNumberOfCourses; i++)
            {
                Console.WriteLine($"Enter Course Name and Code:");
                var courseNameAndCode = Console.ReadLine();
                Console.Write($"Enter your Course Unit: ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write($"Enter Course Score: ");
                int courseScore = int.Parse(Console.ReadLine());

                studentGrade = (courseScore >= 70 && courseScore <= 100) ? "A" :
                                (courseScore >= 60 && courseScore <= 69) ? "B" :
                                (courseScore >= 50 && courseScore <= 59) ? "C" :
                                (courseScore >= 45 && courseScore <= 49) ? "D" :
                                (courseScore >= 40 && courseScore <= 44) ? "E" : "F";

                studentGradeUnit = (courseScore >= 70 && courseScore <= 100) ? 5 :
                                   (courseScore >= 60 && courseScore <= 69) ? 4 :
                                   (courseScore >= 50 && courseScore <= 59) ? 3 :
                                   (courseScore >= 45 && courseScore <= 49) ? 2 :
                                   (courseScore >= 40 && courseScore <= 44) ? 1 : 0;

                studentRemark = (courseScore >= 70 && courseScore <= 100) ? "Excellent" :
                                (courseScore >= 60 && courseScore <= 69) ? "Very-Good" :
                                (courseScore >= 50 && courseScore <= 59) ? "Good" :
                                (courseScore >= 45 && courseScore <= 49) ? "Fair" :
                                (courseScore >= 40 && courseScore <= 44) ? "Pass" : "Fail";

                studentWeightPt = courseUnit * studentGradeUnit;

                if (courseScore >= 40)
                {
                    studentTotalUnitPassed += courseUnit;
                }

                studentTotalCourseUnit += courseUnit;
                studentTotalWeightPt += studentWeightPt;
               // studentTotalGradeUnit += studentGradeUnit;

                string[] courseRecord = new string[] { courseNameAndCode,
                                                       courseUnit.ToString(),
                                                       studentGrade,
                                                       studentGradeUnit.ToString(),
                                                       studentWeightPt.ToString(),
                                                       studentRemark };

                studentRecords.Add(courseRecord);
            }

            studentGpa = studentTotalWeightPt / studentTotalCourseUnit;

            PrintTable.PrintStudentRecords(studentRecords);

            Console.WriteLine("\n");
            Console.WriteLine($"Total course Unit Registered is {studentTotalCourseUnit}");
            Console.WriteLine($"Total course Unit Passed is {studentTotalUnitPassed}");
            Console.WriteLine($"Total Weight Point is {studentTotalWeightPt}");
            Console.WriteLine($"Your GPA is = {studentGpa:F2} to 2 decimal places.");

        }
    }
}
