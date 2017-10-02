using GuessNumberLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGui
{
	public partial class Form1 : Form
	{
		private GuessNumber _game = new GuessNumber();
		public Form1()
		{
			InitializeComponent();
		}

		
		private void Form1_Load(object sender, EventArgs e)
		{
			lblFeedback.Text = _game.Feedback;
		}

		private void btnGuess_Click_1(object sender, EventArgs e)
		{
			_game.Guess(int.Parse(txtGuess.Text));
			lblFeedback.Text = _game.Feedback;
		}

		private void txtGuess_TextChanged(object sender, EventArgs e)
		{

		}
	}
}