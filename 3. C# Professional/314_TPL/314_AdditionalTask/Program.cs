using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _314_AdditionalTask
{
	class Program
	{
		static void Main()
		{
			int[] array = new int[1000_000];

			Random rand = new Random();

			Parallel.For(0, array.Length, (int i) => { array[i] = rand.Next(10); });

			ParallelQuery<int> oddNums = from element in array.AsParallel()
										 where element % 2 != 0
										 select element;

			foreach (int element in oddNums)
			{
				Console.Write(element + " ");
			}

			//Delay
			Console.ReadKey();
		}
	}
}
