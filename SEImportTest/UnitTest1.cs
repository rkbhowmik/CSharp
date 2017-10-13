using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace SEImportTest
{
	[TestClass]
	public class SEImportTester
			{
		[TestMethod]
		public void CanRead()
		{
			var streamReader = File.OpenText (@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt")
				while (true)
			{
				var line = streamReader.ReadLine();
				if (line == null)
					break;
				Debug.WriteLine(line);
			}
		}
	}
}
