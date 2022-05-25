using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_Task3
{
	struct Price
	{
		string name, shop;
		int worth;

		public Price(string name, string shop, int worth)
		{
			this.name = name;
			this.shop = shop;
			this.worth = worth;
		}

		public string Name { get { return name; } }
		public string Shop { get { return shop; } }
		public int Worth { get { return worth; } }

		public void PrintInfo()
		{
			Console.WriteLine("Goods: {0}\nName of the shop: {1}\nPrice: {2} uah", name, shop, worth);
		}
	}
}
