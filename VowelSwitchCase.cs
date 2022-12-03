using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalDemo
{
	class VowelSwitchCase
	{
		static void Main(String[] args)
		{
			char ch;
			Console.WriteLine("Enter the char");
			ch = Convert.ToChar(Console.ReadLine());

			switch (ch)
			{
				case 'a':
				case 'A':
				case 'e':
				case 'E':
				case 'i':
				case 'I':
				case 'o':
				case 'O':
				case 'u':
				case 'U':
					Console.WriteLine("Vowel");
					break;

				default:
					Console.WriteLine("Consonent");
					break;
			}
		}
	}
			
}
