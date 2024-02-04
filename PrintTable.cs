using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blossom_WeekOne_Task
{
    public class PrintTable
    { 
        public static void PrintStudentRecords(List<string[]> studentRecords)
        {
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
            Console.WriteLine(" | COURSE & CODE    | COURSE UNIT     | GRADE     | GRADE-UNIT    | WEIGHT Pt     | REMARK       |");
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");

            foreach (string[] courseRecord in studentRecords)
            {
                Console.WriteLine($"  |   {courseRecord[0],-14}|  " +
                                    $"  {courseRecord[1],-12}|  " +
                                    $"  {courseRecord[2],-6} |  " +
                                    $"  {courseRecord[3],-11}|  " +
                                    $"  {courseRecord[4],-11}|  " +
                                    $"  {courseRecord[5],-10}|  ");
            }
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
        }
    }
}
