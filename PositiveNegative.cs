using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class PositiveNegative
    {
        static void Main(String[] args)
        {
            int num;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("num is Negative");
            }
            else if (num > 0)
            {
                Console.WriteLine("num is Positive");
            }
            else
                Console.WriteLine("Zero");
        }
    }
}
