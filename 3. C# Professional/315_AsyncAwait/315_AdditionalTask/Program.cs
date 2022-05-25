using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _315_AdditionalTask
{
	class Program
	{
		static int counter;

		static void Circle()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Counter = {0}, ThreadId = {1}", ++counter, Thread.CurrentThread.ManagedThreadId);		
			}
		}

		static async Task CircleAsync()
		{
			await Task.Factory.StartNew(Circle);
		}

		static void Main()
		{
			Task task1 = CircleAsync();
			Task.WaitAll(task1);
			Console.WriteLine("1-st task was finished");
			Task task2 = CircleAsync();
			Task.WaitAll(task2);
			Console.WriteLine("2-nd task was finished");
			Task task3 = CircleAsync();
			Task.WaitAll(task3);
			Console.WriteLine("3-rd task was finished");

			//Delay
			Console.ReadKey();
		}
	}
}
