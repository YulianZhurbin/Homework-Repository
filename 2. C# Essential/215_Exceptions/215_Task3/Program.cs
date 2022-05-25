using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Price[] database = new Price[2];

			string name, shop;
			int worth;

			for (int i = 0; i < database.Length; i++)
			{
				Console.Write("The item name: ");
				name = Console.ReadLine();

				Console.Write("The shop name: ");
				shop = Console.ReadLine();

				Console.Write("The price, uah: ");
				worth = Convert.ToInt32(Console.ReadLine());

				database[i] = new Price(name, shop, worth);

				Console.WriteLine();
			}

			ShopNotFoundException e = new ShopNotFoundException("Such a shop was not found");

			while (true)
			{
				Console.Write("Enter the name of the interested shop: ");

				string interestedShop = Console.ReadLine();

				if (interestedShop == database[0].Shop)
				{
					database[0].PrintInfo();
				}
				else if (interestedShop == database[1].Shop)
				{
					database[1].PrintInfo();
				}
				else
				{
					try
					{
						throw e;
					}
					catch(ShopNotFoundException ex)
					{
						Console.WriteLine(ex.Message);
					}
				}

				Console.WriteLine();
			}
		}
	}
}
