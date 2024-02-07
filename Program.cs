using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;


namespace Blossom_WeekOne_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referencing the main logic behind the application in the main entry point (seperation of concern).
            Logic.LogicMethod();
        }
    }
}
