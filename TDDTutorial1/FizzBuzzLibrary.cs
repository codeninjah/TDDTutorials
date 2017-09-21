using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial1
{
	public class FizzBuzzLibrary
	{
		public void Nummer(int a)
		{
			if (a % 3 == 0)
			{
				Console.WriteLine("Buzz");
			}
			else if (a % 5 == 0)
			{
				Console.WriteLine("Fizz");
			}

			else
			{
				Console.WriteLine(a);
			}

		}

		public string NummerSträng(int a)
		{
			if (a % 3 == 0)
			{
				return "Buzz";
			}
			if (a % 5 == 0)
			{
				return "Fizz";
			}

			else
			{
				return a.ToString();
			}
		}


	}
}
