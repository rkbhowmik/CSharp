using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			var aSchool = new School("EC Utbildning");
			var CSharp = new Class("CSharp", 32);
			var JS = new Class("JS", 32);
			var MVC = new Class("MVC", 26);

			aSchool.Classes.Add(CSharp);
			aSchool.Classes.Add(JS);
			aSchool.Classes.Add(MVC);

			int sum = aSchool.NumberOfStudents();
			Console.WriteLine($"{aSchool}");
			Console.ReadKey();
		}
	}
}
