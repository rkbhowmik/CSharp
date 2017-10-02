using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLIb;

namespace DiceTestLib
{
	[TestClass]
	public class DiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sut = new Game();
			var result = sut.ThowDice(4,3);
			Assert.AreEqual(7,result);

		}
	}
}
