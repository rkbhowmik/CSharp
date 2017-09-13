﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestLib
{
	[TestClass]
	public class PurchaseCalculationTest
	{
		[TestMethod]
		public void ExcludedVAT()
		{
			var sut = new PurchaseCalculation();
			var total = sut.Execute(10, 100.0M, false);
			Assert.AreEqual(1000.0M, total);
		}

		[TestMethod]
		public void IncludedVAT()
		{
			var sut = new PurchaseCalculation();
			var total = sut.Execute(10, 100.0M, true);
			Assert.AreEqual(1250.0M, total);
		}
	}

}
