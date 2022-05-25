using System;
using System.Collections.Generic;
using System.Collections;


namespace _302_Task3
{
	class Program
	{
		static void Main()
		{
			MyHashtable accounts = new MyHashtable();

			accounts.Add("1054", 1_000_000.50m);
			accounts.Add("2043", 7_500_000.65m);
			accounts.Add("2001", 4_070_000.40m);
			accounts.Add("1099", 4_003_500.50m);
			accounts.Add("3450", 7_000_000m);
			accounts.Add("0087", 9_004_000m);
			accounts.Add("5566", 7_700_000m);
			accounts.Add("8236", 5_000_000m);
			accounts.Add("1749", 8_000_000m);
			accounts.Add("8564", 8_000_000m);
			accounts.Add("9954", 7_000_000m);
			accounts.Add("1290", 4_000_000m);
			accounts.Add("5558", 2_000_000.50m);
			accounts.Add("3456", 6_000_000m);
			accounts.Add("8876", 8_400_000m);
			accounts.Add("1957", 9_700_000m);
			accounts.Add("4972", 4_560_000.30m);
			accounts.Add("2237", 32_000_000m);
			accounts.Add("0064", 65_000_000m);
			accounts.Add("7744", 3_000_000m);
			accounts.Add("8463", 0_500_000m);
			accounts.Add("9445", 23_000_000.54m);
			accounts.Add("5550", 5_000_000m);
			accounts.Add("8842", 2_000_000m);
			accounts.Add("6900", 1_000_000.01m);
			accounts.Add("0705", 7_000_000m);

			Console.WriteLine("{0}$", accounts["2043"]);

			Console.WriteLine(new string('-', 15));

			Dictionary<string,decimal> genericAccounts = new Dictionary<string, decimal>();

			genericAccounts.Add("1054", 1_000_000.50m);
			genericAccounts.Add("2043", 7_500_000.65m);
			genericAccounts.Add("2001", 4_070_000.40m);
			genericAccounts.Add("1099", 4_003_500.50m);
			genericAccounts.Add("3450", 7_000_000m);
			genericAccounts.Add("0087", 9_004_000m);
			genericAccounts.Add("5566", 7_700_000m);
			genericAccounts.Add("8236", 5_000_000m);
			genericAccounts.Add("1749", 8_000_000m);
			genericAccounts.Add("8564", 8_000_000m);
			genericAccounts.Add("9954", 7_000_000m);
			genericAccounts.Add("1290", 4_000_000m);
			genericAccounts.Add("5558", 2_000_000.50m);
			genericAccounts.Add("3456", 6_000_000m);
			genericAccounts.Add("8876", 8_400_000m);
			genericAccounts.Add("1957", 9_700_000m);
			genericAccounts.Add("4972", 4_560_000.30m);
			genericAccounts.Add("2237", 32_000_000m);
			genericAccounts.Add("0064", 65_000_000m);
			genericAccounts.Add("7744", 3_000_000m);
			genericAccounts.Add("8463", 0_500_000m);
			genericAccounts.Add("9445", 23_000_000.54m);
			genericAccounts.Add("5550", 5_000_000m);
			genericAccounts.Add("8842", 2_000_000m);
			genericAccounts.Add("6900", 1_000_000.01m);
			genericAccounts.Add("0705", 7_000_000m);

			Console.WriteLine("{0}$", accounts["2043"]);

			//Delay
			Console.ReadKey();

		}
	}

	class MyHashtable
	{
		private Hashtable ht = new Hashtable();

		public void Add(string key, decimal value)
		{
			ht.Add(key, value);
		}

		public decimal this[string number]
		{
			get
			{
				return (decimal)ht[number];
			}
		}
	}
}
