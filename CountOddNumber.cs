using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class CountOddNumber
    {
        public void Count(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("Count: " + count);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            CountOddNumber odd = new CountOddNumber();
            odd.Count(a);
        }
    }
}
