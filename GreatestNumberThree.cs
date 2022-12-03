using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class GreatestNumberThree
    {
        static void Main(String[] args)
        {
            int num1, num2, num3, max=0;
            Console.WriteLine("Enter the value for num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for num3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
                Console.WriteLine("greater number is= " +max);
            }
        }
}
