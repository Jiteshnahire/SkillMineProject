using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class MaxAndMinValue
    {
        static void Main(String[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the value for num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for num2");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num2 is greater");
            }
        }
    }
}
