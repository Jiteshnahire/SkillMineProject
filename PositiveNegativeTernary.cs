using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class PositiveNegativeTernary
    {
        static void Main(String[] args)
        {
            int num;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            string result =num >= 0 ? ("number is positive.") : ("number is negative.");
            Console.WriteLine(result);

        }
    }
}
