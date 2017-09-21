using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorial1;

namespace TDDTutorial1Tests
{
	[TestClass]
	public class TDDT1Tests
	{

		[TestMethod]
		public void AreDividedBy3()
		{
			FizzBuzzLibrary delaMedTre = new FizzBuzzLibrary();
			var expected = delaMedTre.NummerSträng(3);

			var actual = delaMedTre.NummerSträng(9);

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void AreDividedBy5()
		{
			FizzBuzzLibrary delaMedTre = new FizzBuzzLibrary();
			var expected = delaMedTre.NummerSträng(5);

			var actual = delaMedTre.NummerSträng(10);

			Assert.AreEqual(actual, expected);
		}

		[TestMethod]
		public void AreNotDividedBy3Or5()
		{
			FizzBuzzLibrary delaMedTre = new FizzBuzzLibrary();
			var expected = delaMedTre.NummerSträng(1);

			var actual = delaMedTre.NummerSträng(1);

			Assert.AreEqual(actual, expected);
		}


		//This returns always green even if it shouldn't
		[TestMethod]
		public void TestVoid()
		{
			FizzBuzzLibrary testVoid = new FizzBuzzLibrary();
			try
			{
				testVoid.Nummer(11);
				Assert.IsTrue(true);
			}
			catch
			{
				Assert.IsTrue(false);
			}
		}
	}
}
