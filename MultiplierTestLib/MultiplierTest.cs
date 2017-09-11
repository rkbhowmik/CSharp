﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
	[TestClass]
	public class MultiplierTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
			// Act
			var actual=myMultiplier.Simple(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}
		[TestMethod]
		public void UsingFor()
		{
			// Arrange
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
			// Act
			var actual = myMultiplier.UsingFor(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}
	}
}
