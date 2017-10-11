using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitFinderLib;

namespace DigitFinderTestLib
{
	[TestClass]
	public class DigitFinderTest
	{
		[TestMethod]
		public void Mattias()
		{
			DigitFinder sut = NewMethod();
			sut.Process


		}

		private static DigitFinder NewMethod()
		{
			return new DigitFinder();
		}
	}
}
