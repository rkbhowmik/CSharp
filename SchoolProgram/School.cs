using System.Collections.Generic;
using System.Linq;

namespace SchoolProgram
{
	internal class School
	{
		private string Name;

		public School(string name)
		{
			this.Name = name;
		}

		public List<Class> Classes {get; internal set; }
			= new List<Class>();

		public int NumberOfStudents()
		{
			return this.Classes.Sum(Class => Class.antalElever);
		}

		public override string ToString()
		{
			return  Name + " has " + NumberOfStudents().ToString() + " students";
		}
	}
}