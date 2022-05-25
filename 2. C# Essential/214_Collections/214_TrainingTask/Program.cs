using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_TrainingTask
{
	class Program
	{
		static void Main(string[] args)
		{
			UserCollection myCollection = new UserCollection(10);

			myCollection.Fill();

			foreach (int i in myCollection)
			{
				Console.Write(i + "  ");
			}

			Console.WriteLine("\n" + new string('-', 40));

			IEnumerator iterator = myCollection;

			while (iterator.MoveNext())
			{
				Console.Write(iterator.Current + "  "); 
			}

			Console.WriteLine("\nCurrent value of position = {0}", myCollection.position);

			//Delay
			Console.ReadKey();
		}
	}
}
