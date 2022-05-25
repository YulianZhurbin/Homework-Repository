using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> numberCollection = new MyList<int>();

			const int COLLECTION_LENGTH = 10;

			Random rand = new Random();

			for (int i = 0; i < COLLECTION_LENGTH; i++)
			{
				numberCollection.Add(rand.Next(0, 10));
			}

			Console.WriteLine($"The sixth element = {numberCollection[5]}");

			Console.WriteLine("Overall amount of the elements = {0}", numberCollection.Count);

			Console.Write("all elements of the collection:\n");

			foreach (int iteratorVariable in numberCollection.GetCollection())
			{
				Console.Write(iteratorVariable + "  ");
			}

			Console.WriteLine();

			int[] array = (numberCollection.GetCollection() as IEnumerable<int>).GetArray();

			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("Printing out all the elements, using GetArray() method:");

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + "  ");
			}

			//Delay
			Console.ReadKey();
		}
	}
}
