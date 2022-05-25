using System;
using System.Threading;

namespace _311_AdditionalTask
{
	class Program
	{
		static int counter;
		static object block = new object();

		public static void Procedure()
		{
			lock (block)
			{
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine("Counter = {0,3}\t{1}", ++counter,Thread.CurrentThread.ManagedThreadId);
				}
			}		
		}

		static void Main()
		{
			ThreadStart threadDelegate = new ThreadStart(Procedure);

			const int THREAD_NUMBER = 3;

			for (int i = 0; i < THREAD_NUMBER; i++)
			{
				new Thread(threadDelegate).Start();
			}

			Thread.Sleep(2000);

			Console.WriteLine("Main thread has finished working.");

			//Delay
			Console.ReadKey();
		}
	}
}
