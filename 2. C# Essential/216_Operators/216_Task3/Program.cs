using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			House festivalnaya = new House(3, 3);

			House okruzhnaya = (House)festivalnaya.Clone();

			House lenina = festivalnaya.DeepClone();

			okruzhnaya.Area = 1;
			okruzhnaya.Price = 1;

			lenina.Area = 2;
			lenina.Price = 2;

			Console.WriteLine("Festivalnaya: Area = {0}, Price = {1}",festivalnaya.Area, festivalnaya.Price);

			Console.WriteLine("Okruzhnaya: Area = {0}, Price = {1}",okruzhnaya.Area, okruzhnaya.Price);

			Console.WriteLine("Lenina: Area = {0}, Price = {1}",lenina.Area, lenina.Price);

			//Delay
			Console.ReadKey();
		}
	}
}
