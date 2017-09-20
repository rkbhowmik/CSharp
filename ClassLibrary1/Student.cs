using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
	public class Student
	{
		private string Name;

		public Student(string Name)
		{
			this.Name = Name;

		}

		public override string ToString()
		{
			return Name;
		}
	}
}