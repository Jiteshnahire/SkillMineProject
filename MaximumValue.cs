using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class MaximumValue
    {
        public int FindMax(int []a)
        {
            int max = a[0];

            for(int i=0; i<a.Length; i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 7, 2, 8, 1 };
            MaximumValue m = new MaximumValue();
            Console.WriteLine("Max from array " + m.FindMax(arr));
        }
    }
}
