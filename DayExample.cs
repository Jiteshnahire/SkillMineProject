using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class DayExample
    {
        static void Main(String[] args)
        {
            int weekday;

            Console.WriteLine("Enter weekday day number (1-7) : ");
            weekday = int.Parse(Console.ReadLine());
            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (weekday == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {

                Console.WriteLine("Please enter weekday number between 1-7.");
            }
        }
    }
}