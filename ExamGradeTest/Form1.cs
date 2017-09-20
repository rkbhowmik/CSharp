using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGradeTest
{
	public partial class Form1 : Form
	{
		Exam exam = new Exam("");
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var student = (Student)comboBox1.SelectedItem;
			exam.Grade(student, combograde.SelectedItem.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var gradeCountDictionary = exam.GenerateStatistics();
			var IGCounter = gradeCountDictionary["IG"];
			label1.Text = $"IG: {IGCounter}";

			var GCounter = gradeCountDictionary["G"];
			label2.Text = $"G: {GCounter}";

			var VGCounter = gradeCountDictionary["VG"];
			label3.Text = $"VG: {VGCounter}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Student student = new Student(txtStudent.Text);//h
			exam.Assign(student);
			comboBox1.Items.Add(student);
		}
	}
}



