using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
	public class ListHandler
	{
		public List<string> List = new List<string>();

		public void AddFiveStrings()
		{
			List.Add("Today is wednesday");
			List.Add("C# programming is going on");
			List.Add("It takes two hours from home to school");
			List.Add("This is the final year in YH");
			List.Add("More time should be invested in C#");
		}

		public void RemoveThirdString()
		{
			List.RemoveAt(2);
		}

		public void Sort()
		{
			List.Sort();
		}
	}
}