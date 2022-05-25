using System;

namespace _309_Task2
{
	class MemoryMonitor
	{
		private readonly long memoryLimit; 
		public MemoryMonitor(long memoryLimit)
		{
			this.memoryLimit = memoryLimit;	
		}

		public void ReviseMemoryExcess()
		{
			if (GC.GetTotalMemory(false) > memoryLimit)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Memory limit excess!");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
		}
	}

	class MyClass
	{
		int[] array = new int[10000000];

		public int this[int index]
		{
			get { return array[index]; }
		}

		public void SomeMethod(int i)
		{
			Console.WriteLine(i);
		}		
	}

	class Program
	{
		static void Main()
		{
			var monitor = new MemoryMonitor(40000000);
			for (int i = 0; i < 20; i++)
			{
				new MyClass().SomeMethod(i);
				monitor.ReviseMemoryExcess();
			}

			//Delay
			Console.ReadKey();
		}
	}
}
