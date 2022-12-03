using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class ToggleArray
    {
        public char[] chengeArray(char[]ch)
        {
            for (int i = 0; i < ch.Length; i++)
                {
                if(ch[i]>='a' && ch[i]<='z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
                else if(ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
                else
                {
                    ch[i] = ch[i];
                }
            }
            return ch;
        }
        static void Main(string[] args)
        {
            char[] c = { 't', 'R', 'U', 'a', 'l' };
            Console.WriteLine(string.Join(" ", c));
            ToggleArray t = new ToggleArray();
            char[] mytoggle = t.chengeArray(c);

            Console.WriteLine(string.Join(" ", mytoggle));
        }
    }
}
