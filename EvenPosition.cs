using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class EvenPosition
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Enter Even Position :");

            for (int i = 1; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}