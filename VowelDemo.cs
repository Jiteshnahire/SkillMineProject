using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
    class VowelDemo
    {
        static void Main(String[] args)
        {
            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'U' || ch == 'u')
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
