using System;

namespace _309_AdditionalTask
{
	class MyClass : IDisposable
	{
		int[] array = new int[1000000];

		bool disposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
			{
				return;
			}

			if (disposing)
			{
				Console.WriteLine("Some managed objects were released.");
			}

			Console.WriteLine("Some unmanaged objects were released.");

			disposed = true;
		}

		~MyClass()
		{
			Dispose(false);

			Console.WriteLine("A MyClass object was collected.");
		}

		public void SomeMethod()
		{
			Console.WriteLine("SomeMethod was done.");
		}
	}
	class Program
	{
		static void Main()
		{
			using (MyClass my = new MyClass())
			{
				my.SomeMethod();
			}

			Console.WriteLine(new string('-', 50));

			MyClass my2 = new MyClass();

			using (my2)
			{
				my2.SomeMethod();
			}

			Console.WriteLine(new string('-', 50));

			var instance = new MyClass();

			try
			{
				instance.SomeMethod();
			}
			finally
			{
				if (instance is IDisposable && instance != null)
					instance.Dispose();
			}

			Console.WriteLine(new string('-', 50));

			var my3 = new MyClass();

			my3.Dispose();
			my3.Dispose();

			Console.WriteLine(new string('-', 50));

			for (int i = 0; i < 10; i++)
			{
				var my4 = new MyClass();
			}

			GC.Collect();

			//Delay
			Console.ReadKey();
		}
	}
}
