﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLib
{
	[TestClass]
	public class MultiplierTest
	{
		[TestMethod]
		public void Simple()
		{
			// Arrange
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
			// Act
			var actual=myMultiplier.Simple(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}

		[TestMethod]
		public void While()
		{
			// Arrange
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
			// Act
			var actual = myMultiplier.While(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}
		
	}
}
