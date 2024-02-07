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
            //output Table that stores all values gotten by the user inside the loop that was saved to the array that was added to the list
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
            Console.WriteLine(" |COURSE & CODE     |COURSE UNIT      |GRADE      |GRADE-UNIT     |WEIGHT Pt      |REMARK        |");
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");

            foreach (string[] courseRecord in studentRecords)
            {
                Console.WriteLine($" |{courseRecord[0],-18}| {courseRecord[1],-16}|{courseRecord[2],-10} |{courseRecord[3],-14} |{courseRecord[4],-14} |{courseRecord[5],-14}|");
            }
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
        }
    }
}
