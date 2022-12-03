using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class Vowel
    {
        static void Main(String[] args)
        {
            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
