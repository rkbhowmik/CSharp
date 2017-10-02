using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleAPP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			var content1 = File.ReadAllText(openFileDialog1.FileName);
			var content2 = File.ReadAllText(openFileDialog2.FileName);
			File.AppendAllText(saveFileDialog1.FileName, content1);
			File.AppendAllText(saveFileDialog1.FileName, content2);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			var path = folderBrowserDialog1.SelectedPath;
			Directory.GetFiles(path, "*.txt");
			foreach (var fileName in Directory.GetFiles(path, "*.txt"))
			{
				comboBox1.Items.Add(fileName);
			}
		}
	}
}
