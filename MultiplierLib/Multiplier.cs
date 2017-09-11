using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class Multiplier
    {
		public long Simple(long l1, long l2)
		{
			return l1 * l2;
		}

		public long While(long l1, long l2)
		{
			long total = 0;
			long loopVar = 0;
			while (loopVar < l1)
			{
				total += l2;
				loopVar++;
			}
			return total;
		}
	}
}
