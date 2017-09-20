using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
	public class Exam
	{
		private string courseName;

		private Dictionary<Student, string> studenDictionary = new Dictionary<Student, string>();
		List<Student> studentList = new List<Student>();

		public Exam(string courseName)
		{
			this.courseName = courseName;
		}

		public void Assign(Student student)
		{
			studentList.Add(student);
			studenDictionary.Add(student, "IG");

		}

		public void Grade(Student student, string grade)
		{
			if (!studenDictionary.ContainsKey(student))
				throw new UnassignedStudentException();
			studenDictionary[student] = grade;
		}

		public Dictionary<string, int> GenerateStatistics()
		{
			var gradeCountDictionary = new Dictionary<string, int>();
			gradeCountDictionary.Add("IG", 0);
			gradeCountDictionary.Add("G", 0);
			gradeCountDictionary.Add("VG", 0);

			foreach (var item in studenDictionary)

			{
				gradeCountDictionary[item.Value]++;
			}
			return gradeCountDictionary;

		}
	}
}