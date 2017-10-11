using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string pNumber = textBox3.Text.Substring(startIndex: 0x9, length: 1);
			int numVal = Int32.Parse(pNumber);
			if (numVal % 2 == 1)
			{
				label4.Text = "God Morgon herr" + " "+ textBox1.Text + textBox2.Text;
			}
			else
			{
				label4.Text = "God Morgon fröken" + " " + textBox1.Text + ""+ textBox2.Text;
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label5.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
