using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLIb
{
	public class Game
	{
		private bool youarewinner;

		public int Dice1 { get; private set; }
		public int Dice2 { get; private set; }

		public int ThowDice(int v1, int v2)
		{
			Dice1 = v1;
			Dice2 = v2;
			var result = v1 + v2;
			if (result == 7)
			{
				youarewinner = true;
			}
			else {
				throw new Exception("TRy again");
			}
			return result;
		}
	}
}
