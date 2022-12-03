using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class OddEvenSwithCase
    {
        static void Main(String[] args)
        {
            int num;

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            switch (num % 2)
            {
                case 1:
                    Console.WriteLine(num + " is even number");
                    break;

                case 2:
                    Console.WriteLine(num + " is odd number");
                    break;
            }
        }
    }
}


