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
            // Declaration of every necessary variable to be used in the application
            string studentGrade;
            string studentRemark;
            double studentGradeUnit;
            double studentWeightPt;
            // decimal studentTotalGradeUnit = 0;
            double studentTotalWeightPt = 0;
            double studentTotalUnitPassed = 0;
            double studentTotalCourseUnit = 0;
            double studentGpa;

            //creation of a list to output my values and calculations with a string array
            List<string[]> studentRecords = new List<string[]>();

            //Asking user for input and storing the input to use it for the loop according to
            //how many numbers the user inputs
            Console.WriteLine(" Welcome to your GPA calculator\n ");
            Console.WriteLine("Please Enter your registered Number of courses: ");
            int registeredNumberOfCourses = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            //A for Loop to store the required values needed by the application to run as many times as the input
            //the user has input above
            for (int i = 0; i < registeredNumberOfCourses; i++)
            {
               //Accepting of user inputs according to the application requirements
                Console.WriteLine($"{i + 1}) Please enter the Course name & Code:  ");
                var courseNameAndCode = Console.ReadLine();
                Console.Write($"{i + 1}) Please enter your Course Unit for {courseNameAndCode}:  ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}) Please enter Course Score for {courseNameAndCode}:  ");
                int courseScore = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                //a ternary operator that determines the logic of how the loop works regarding the grades,gradeunit,and remark
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

                //Calculations for the application requirements to output to the user after he has inputed all his
                //values to be calculated 
                studentWeightPt = courseUnit * studentGradeUnit;

                if (courseScore >= 40)
                {
                    studentTotalUnitPassed += courseUnit;
                }

                studentTotalCourseUnit += courseUnit;
                studentTotalWeightPt += studentWeightPt;
               // studentTotalGradeUnit += studentGradeUnit;

                //creation of an array to store values
                string[] courseRecord = {   courseNameAndCode,
                                            courseUnit.ToString(),
                                            studentGrade,
                                            studentGradeUnit.ToString(),
                                            studentWeightPt.ToString(),
                                            studentRemark };
                //adding of the array created above to my List
                studentRecords.Add(courseRecord);
            }
            //the final gpa formula.
            studentGpa = studentTotalWeightPt / studentTotalCourseUnit;

            //referencing student records List to print ou the tabe from another class named PrintTable
            PrintTable.PrintStudentRecords(studentRecords);

            //logging out calculated app requirement done above.
            Console.WriteLine("\n");
            Console.WriteLine($"Total course Unit Registered is {studentTotalCourseUnit}");
            Console.WriteLine($"Total course Unit Passed is {studentTotalUnitPassed}");
            Console.WriteLine($"Total Weight Point is {studentTotalWeightPt}");
            Console.WriteLine($"Your GPA is = {studentGpa:F2} to 2 decimal places.");

        }
    }
}
