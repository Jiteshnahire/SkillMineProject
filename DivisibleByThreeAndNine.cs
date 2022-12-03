using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class DivisibleByThreeAndNine
    {
        static void Main(String[] args)
        {
            int num;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 9 == 0 )
            {
                Console.WriteLine("Divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }
}
