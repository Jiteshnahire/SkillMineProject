using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class PrimeNumberArray
    {
        static void Main(String[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("All number list");

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 2; j < num[i]; j++)
                    if (j == num[i])
                    {
                        Console.WriteLine("Prime Number" +num[i]);
                    }
            }
        }
    }
}