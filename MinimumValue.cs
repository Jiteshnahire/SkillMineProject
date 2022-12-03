using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class MinimumValue
    {
        public int FindMin(int[] a)
        {
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 7, 2, 8, 1 };
            MinimumValue m = new MinimumValue();
            Console.WriteLine("Min from array " + m.FindMin(arr));
        }
    }
}
