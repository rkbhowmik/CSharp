using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexMatchCounterLib
{
	public class RegexMatchCounterClass
	{
		public int CountMatchingLines(string content, string regexPattern)
		{
			int rows = 0;
			StringReader sr = new StringReader(content);
			while (true)
			{
				var line = sr.ReadLine();
				if (line == null)
					break;
				var match = Regex.Match(line, regexPattern);
				if (match.Success)
					rows++;
			}
			return rows;
		}
	}
}
