using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PracticeApp
{
	
	public partial class Form1 : Form
	{

		private string dateOfBirth;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			dateOfBirth = dateTime.Value.ToString("yyyy-MM-dd");
			var name = TextBoxName.Text;
			var mobileNumber = TextBoxMobile.Text;

			string pattern = @"(\d*)-(\d*)";
			var match = Regex.Match(mobileNumber, pattern);
			var newNumber = $"{match.Groups[1].Value}-{match.Groups[2].Value}";
			var publish = dateOfBirth + ";" + name + ";" + newNumber;
			File.AppendAllText(saveFileDialog1.FileName, publish + Environment.NewLine);
			MessageBox.Show("Information Saved");
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string content = File.ReadAllText(openFileDialog1.FileName);
			saveFileDialog1.ShowDialog();
			// Check the string pattern for 1985-12-20;Rajib Bhowmik;073-9099313
			string pattern1 = @"(\w+)-(\w+-\w+);(\w+ \w+);(\w+-\w+)";
			var match = Regex.Match(content, pattern1);
			string convertName = match.Groups[3].Value;
			string convertAge = match.Groups[1].Value;
			string convertNumber = match.Groups[4].Value;

			//get the age value from the file
			var age = int.Parse(match.Groups[1].Value);
			var convertYear = DateTime.Now.AddYears(-age).Year;

			var convertedText = ($"{convertName} är {convertYear} år gammal och har telefonnumret {convertNumber}");
			saveFileDialog1.ShowDialog();
			File.AppendAllText(saveFileDialog1.FileName, convertedText);



		}
	}
}
