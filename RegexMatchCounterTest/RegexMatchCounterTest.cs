using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using RegexMatchCounterLib;
using System.Text.RegularExpressions;

namespace RegexMatchCounterTest
{
	[TestClass]
	public class RegexMatchCounterTest
	{
		[TestMethod]
		public void CountMatchingLines()
		{
			var content = File.ReadAllText(@"C:\CSharp\CSharp\SIImportTests\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
			RegexMatchCounterClass counter = new RegexMatchCounterClass();
			int rowCount = counter.CountMatchingLines(content, "#VER");
			Assert.AreEqual(165, rowCount);
		}

		[TestMethod]
		public void CountMatchingLinesWithRegEx()
		{
			var contents = File.ReadAllText(@"C:\CSharp\CSharp\SIImportTests\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
			string pattern = @"(^#VER.*$)";
			RegexOptions options = RegexOptions.Multiline;
			Regex regex = new Regex(pattern, options);
			var match = regex.Matches(contents);
			Assert.AreEqual(165, match.Count);
		}
	}
}
