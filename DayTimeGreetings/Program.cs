using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTimeGreetings
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime time = DateTime.Now;

			if (time.Hour >= 1 && time.Hour <= 16)
			{
				Console.WriteLine("Greetings from us");
			}
			Console.WriteLine(time);
			Console.ReadLine();
		}
	}
}
