using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _314_Task2
{
	class Program
	{
		static void Task1()
		{
			for (int i = 0; i < 80; i++)
			{
				Console.Write("+");
				Thread.Sleep(1);
			}
		}	
		
		static void Task2()
		{
			for (int i = 0; i < 80; i++)
			{
				Console.Write("-");
				Thread.Sleep(1);
			}
		}
		static void Main()
		{
			Console.WriteLine("Main thread's started working");

			ParallelOptions options = new ParallelOptions();

			Task.Factory.StartNew(() => Parallel.Invoke(Task1, Task2));

			Console.WriteLine("Main thread's finished working");

			//Delay
			Console.ReadKey();
		}
	}
}
