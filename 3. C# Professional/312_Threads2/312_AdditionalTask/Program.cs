using System;
using System.IO;
using System.Threading;

namespace _312_AdditionalTask
{
	class Program
	{
		static Semaphore pool;

		static void Procedure(object number)
		{
			pool.WaitOne();
			File.AppendAllText("log.txt", string.Format("Thread{0} is in\n", number));
			File.AppendAllText("log.txt", string.Format("Thread{0} is out\n", number));
			pool.Release();
		}

		static void Main()
		{
			pool = new Semaphore(1, 5,"MySemaphore");

			for (int i = 0; i < 5; i++)
			{
				new Thread(Procedure).Start(i + 1);
			}

			Console.WriteLine("Press any key");
			Console.ReadKey();
		}
	}
}
