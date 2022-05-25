using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _302_Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			NameValueCollection nv = new NameValueCollection();

			nv.Add("John", "chips");
			nv.Add("John", "beverage");
			nv.Add("Toni", "fruit");
			nv.Add("Toni", "beverage");
			nv.Add("Toni", "bread");
			nv.Add("Paul", "beverage");
			nv.Add("Paul", "chips");
			nv.Add("Paul", "vegetables");
			nv.Add("George", "fruit");

			foreach (var item in nv.GetValues("Paul"))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine(new string('*', 40));

			foreach (var item in nv.GetBuyers("fruit"))
			{
				Console.WriteLine(item);
			}

			//Delay
			Console.ReadKey();
		}		
	}

	static class ExtensionMethodClass
	{
		public static List<string> GetBuyers(this NameValueCollection nv, string goods)
		{
			List<string> buyers = new List<string>();

			foreach (var item in nv)
			{
				if (item.GetType() != goods.GetType())
				{
					Console.WriteLine("Only text data can be handled");
					return null;
				}

				foreach (var innerItem in nv.GetValues((string)item))
				{
					if (innerItem.GetType() != goods.GetType())
					{
						Console.WriteLine("Only text data can be handled");
						return null;
					}

					if (innerItem == goods)
					{
						buyers.Add((string)item);
						break;
					}
				}
			}

			return buyers;
		}
	}
}
