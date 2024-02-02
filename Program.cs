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

/*
            string grade;
            int gradeUnit;
            string remark;
            int weightPt;
            double Gpa;
            int TotalGradeUnit = 0;
            int TotalweightPt = 0;
            int totalunitpass = 0;
            int totalCourseUnit = 0;*/


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

                if (courseScore >= 70 && courseScore <= 100)
                {
                    studentGrade = "A";
                    studentGradeUnit = 5;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Excellent";
                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    studentGrade = "B";
                    studentGradeUnit = 4;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Very-Good";
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    studentGrade = "C";
                    studentGradeUnit = 3;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Good";
                }
                else if (courseScore >= 40 && courseScore <= 49)
                {
                    studentGrade = "D";
                    studentGradeUnit = 2;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Fair";
                }else if (courseScore >= 60 && courseScore <= 69)
                {
                    studentGrade = "E";
                    studentGradeUnit = 1;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Pass";
                }else {
                    studentGrade = "F";
                    studentGradeUnit = 0;
                    studentWeightPt = courseUnit * studentGradeUnit;
                    studentRemark = "Fail";
                }

            }

        }
    }
}
