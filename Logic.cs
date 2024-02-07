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
            // decimal studentTotalGradeUnit = 0;
            int studentTotalWeightPt = 0;
            int studentTotalUnitPassed = 0;
            int studentTotalCourseUnit = 0;
            decimal studentGpa;

            List<string[]> studentRecords = new List<string[]>();

            Console.WriteLine(" Welcome to your GPA calculator\n ");
            Console.WriteLine("Please Enter your registered Number of courses: ");
            int registeredNumberOfCourses = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 0; i < registeredNumberOfCourses; i++)
            {
               
                Console.WriteLine($"{i + 1}) Please enter the Course name & Code:  ");
                var courseNameAndCode = Console.ReadLine();
                Console.Write($"{i + 1}) Please enter your Course Unit for {courseNameAndCode}:  ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}) Please enter Course Score for {courseNameAndCode}:  ");
                int courseScore = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

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

                string[] courseRecord = {   courseNameAndCode,
                                            courseUnit.ToString(),
                                            studentGrade,
                                            studentGradeUnit.ToString(),
                                            studentWeightPt.ToString(),
                                            studentRemark };

                studentRecords.Add(courseRecord);
            }

            studentGpa = (decimal)studentTotalWeightPt / studentTotalCourseUnit;

            PrintTable.PrintStudentRecords(studentRecords);

            Console.WriteLine("\n");
            Console.WriteLine($"Total course Unit Registered is {studentTotalCourseUnit}");
            Console.WriteLine($"Total course Unit Passed is {studentTotalUnitPassed}");
            Console.WriteLine($"Total Weight Point is {studentTotalWeightPt}");
            Console.WriteLine($"Your GPA is = {Math.Round(studentGpa, 2, MidpointRounding.ToEven)} to 2 decimal places.");

        }
    }
}
