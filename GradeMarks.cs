using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class GradeMarks
    {
        static void Main(String[] args)
        {
            float marathi, hindi, english, math, sci;
            Console.WriteLine("Enter obtained marks in marathi");
            marathi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter obtained marks in hindi");
            hindi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter obtained marks in english");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter obtained marks in math");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter obtained marks in sci");
            sci = int.Parse(Console.ReadLine());

            float total = marathi + hindi + english + math + sci;
            float per = total / 5;
            Console.WriteLine("Percentage : " + per + " %");

            if (per >= 70)
            {
                Console.WriteLine("Distinction");
            }
            else if (per < 70 && per >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (per < 60 && per >= 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (per < 50 && per >= 35)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
