using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class ArrayCreation
    {
        static void Main(String[] args)
        {
            int[] arr = { 5, 3, 2, 8 };
            int[] myarray = new int[4];

            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}