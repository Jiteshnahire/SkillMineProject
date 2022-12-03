using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class LeapYear
    {
        static void Main(String[] args)
        {
            int year;

            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))

                Console.WriteLine("Leap Year", year);
            
            else
            {
                Console.WriteLine("not Leap Year", year);
            }
        }
    }
}


