using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System.Diagnostics;

namespace CalculatorTest
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void EmptyDisplay()
		{
			var sut = new Calculator();
			sut.PowerOn(); // ctrl + . --> to generate
			Assert.AreEqual(0, sut.Display);
		}

		[TestMethod]
		public void OneDigitDisplay()
		{
			var sut = new Calculator();
			sut.Press("7"); // ctrl + . --> to generate
			Assert.AreEqual(7, sut.Display);
		}

		[TestMethod]
		public void TwoDigitDisplay()
		{
			var sut = new Calculator();
			sut.Press("5");
			sut.Press("7"); // ctrl + . --> to generate
			Assert.AreEqual(57, sut.Display);
		}

		[TestMethod]
		public void Add12and25()
		{
			var sut = new Calculator();
			sut.Press("1");
			Debug.WriteLine(sut.Display);
			sut.Press("2");
			Debug.WriteLine(sut.Display);
			sut.Press("+");
			Debug.WriteLine(sut.Display);
			sut.Press("2");
			Debug.WriteLine(sut.Display);
			sut.Press("5");
			Debug.WriteLine(sut.Display);
			sut.Press("=");
			Debug.WriteLine(sut.Display);

			// ctrl + . --> to generate
			Assert.AreEqual(37, sut.Display);
		}

	}
}
