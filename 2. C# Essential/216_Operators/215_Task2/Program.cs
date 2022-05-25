using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Block one = new Block(1, 1, 1, 1);

			Block two = new Block(3, 3, 3, 3);

			Block three = new Block(1, 1, 1, 1);

			Console.WriteLine(one.Equals(two));

			Console.WriteLine(one.Equals(three)); 

			string onePrint = one.ToString();

			Console.WriteLine(onePrint);

			Console.ReadKey();
		}
	}
}
