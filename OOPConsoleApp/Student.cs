using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
	class Student
	{
		public string Name;
		public string Email;
		private int StudyHardCounder = 0;
		public event EventHandler TooTired;
		public override string ToString()
		{
			return $"{this.Name} {this.Email}"; // $ means interpolation string
		}

		internal void StudyHarder()
		{
			StudyHardCounder++;
			if (StudyHardCounder > 2)
				TooTired?.Invoke(this, null); // more information about the event
			Name = "Super" + Name;
		}
	}
}
