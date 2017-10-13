using System;
using System.Collections.Generic;

namespace SIAccountLib
{
    public class Account
    {
		public string Name { get; set; }
		public bool IsSummary { get; set; }
		public List<Account> Children { get; set; }
	}
}
