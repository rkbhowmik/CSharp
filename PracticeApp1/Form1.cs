using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			var name = txtName.Text;
			var phone = txtPhone.Text;
			var age = dtpBirthday.Value.ToString("yyyy-MM-dd");
			var contents = age + ";"+ name + ";" + phone;
			File.WriteAllText(saveFileDialog1.FileName, contents);

		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void btnChooseFileName_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			saveFileDialog1.ShowDialog();
			var contents = File.ReadAllText(openFileDialog1.FileName);
			string pattern = @"(\d{4}-\d{2}-\d{2});(.*);(.*)";
			var match = Regex.Match(contents, pattern);
			var date = DateTime.Parse(match.Groups[1].Value);
			var name = match.Groups[2].Value;
			var phone = match.Groups[3].Value;
			var age = DateTime.Now.Year - date.Year;
			string message = $"{name} är {age} år gammal och har telefonnumret {phone}";
			File.WriteAllText(saveFileDialog1.FileName, message);

		}

		private void dtpBirthday_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
