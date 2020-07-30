using System;
using System.Collections.Generic;

namespace Lab5_2_Enum
{
    class Program
    {
        public enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 5.2");
            
            //Create list to hold tasks
            List<string> taskList = new List<string>();

            //For each value in the enum, let the user create a task
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.Write("\n Enter a new task for " + day + ":  ");
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            Console.WriteLine();

            //print all the tasks
            foreach (string task in taskList)
            {
                Console.WriteLine("\n" + task);
            }


        }
    }
}
