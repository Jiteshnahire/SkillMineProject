using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class SumOfElement
    {
        static void Main(String[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all the elements of an array: " + sum);
        }
    }
}
