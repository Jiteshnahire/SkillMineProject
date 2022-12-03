using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class DivisibleByFive
    {
        static void Main(String[] args)
        {
            int num;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}