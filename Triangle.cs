using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class Triangle
    {
        static void Main(String[] args)
        {
        Console.Write("Enter the Base:");
        double Base = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Height:");
        double Height = Convert.ToDouble(Console.ReadLine());

        double Area = (Base * Height) / 2;
        Console.Write("Area of a Triangle = " + Area);
        Console.ReadKey();
    }
}
}
