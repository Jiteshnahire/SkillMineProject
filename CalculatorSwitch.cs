using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class CalculatorSwitch
    {
        static void Main(String[] args)
        {
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter your choice");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter no1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter no2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Addition = ", c);
                    break;
                case 2:
                    Console.Write("Enter no1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter no2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Subtraction = ", c);
                    break;
                case 3:
                    Console.Write("Enter no1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter no2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("multiplication = ", c);
                    break;
                case 4:
                    Console.Write("Enter no1:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter no2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Divide = ", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
