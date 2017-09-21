using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDTutorial1;

namespace ConsoleTDDTutorial1
{
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzzLibrary nummer = new FizzBuzzLibrary();
			
			for (int counter = 1; counter < 101; counter++)
			{
				//nummer.Nummer(counter);
				Console.WriteLine(nummer.NummerSträng(counter));
			}
		}
	}
}
