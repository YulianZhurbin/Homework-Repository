using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _302_Task2_Optimized
{
	class Program
	{
		static void Main(string[] args)
		{
			MyCollection mc = new MyCollection();

			mc.Add("John", "chips");
			mc.Add("John", "beverage");
			mc.Add("Toni", "fruit");
			mc.Add("Toni", "beverage");
			mc.Add("Toni", "bread");
			mc.Add("Paul", "beverage");
			mc.Add("Paul", "chips");
			mc.Add("Paul", "vegetables");
			mc.Add("George", "fruit");


			foreach (var item in mc.GetGoods("John"))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine(new string('*', 40));

			foreach (var item in mc.GetBuyers("beverage"))
			{
				Console.WriteLine(item);
			}

			//Delay
			Console.ReadKey();
		}
	}

	class MyCollection
	{
		private NameValueCollection buyerGoods = new NameValueCollection();
		private NameValueCollection goodsBuyer = new NameValueCollection();

		public void Add(string buyer, string goods)
		{
			buyerGoods.Add(buyer, goods);
			goodsBuyer.Add(goods,buyer);
		}

		public string[] GetGoods(string buyer)
		{
			string[] result = buyerGoods.GetValues(buyer);

			if(result.Length == 0)
				Console.WriteLine("no goods");

			return result;
		}

		public string[] GetBuyers(string goods)
		{
			string[] result = goodsBuyer.GetValues(goods);
			if (result.Length == 0)
				Console.WriteLine("no buyers");
			return result;
		}
	}
}
