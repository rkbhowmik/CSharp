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

namespace KundUppgifterApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			var name = textBox1.Text;
			var phone = textBox2.Text;
			var publish = name + ";" + dateTimePicker1.Text + ";" + phone;
			// WriteAllText will override
			//AppendAllText will add new instance
			File.AppendAllText(saveFileDialog1.FileName, publish);

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
		
	}
}
