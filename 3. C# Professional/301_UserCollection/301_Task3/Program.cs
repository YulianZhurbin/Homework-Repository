using System;

namespace _301_Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Line queue = new Line();

			queue.Add(new Retired("Sidorov", "3000"));
			queue.Add(new Retired("Tinkov", "3721"));
			queue.Add(new Retired("Kuanyshev", "3400"));
			queue.Add(new Student("Smirnov", "1457"));
			queue.Add(new Worker("Sobol", "2540"));
			queue.Add(new Student("Ivanov", "1012"));
			queue.Add(new Worker("Petrov", "2104"));

			foreach (Citizen item in queue)
			{
				Console.Write(item + " | ");
			}

			DrawLineFromNewLine();


			Console.Write("Add one more: ");

			Retired one = new Retired("Tyshchenko", "3557");

			Console.Write(one);

			Console.WriteLine($" ({queue.Add(one)} place in the queue)");

			DrawLine();


			Console.Write("Add one more: ");

			Worker two = new Worker("James", "2407");

			Console.Write(two);

			Console.WriteLine($" ({queue.Add(two)} place in the queue)");

			DrawLine();


			Console.Write("Add one more: ");

			Worker three = new Worker("Smirnov", "1457");

			Console.Write(three);

			if (queue.Add(three) != null)
				Console.WriteLine($" ({queue.Add(two)} place in the queue)");

			DrawLine();
			DrawLine();

			Console.WriteLine("New line: ");

			foreach (Citizen item in queue)
			{
				Console.Write(item + " | ");
			}

			DrawLineFromNewLine();

			Console.WriteLine("Remove the first person");
			queue.Remove();
			DrawLine();

			Console.WriteLine("Remove and get the first person: {0}", queue.Service());
			DrawLine();

			Worker sobol = new Worker("Sobol","2540");
			Console.WriteLine("Check if there is {0} in the queue: {1}, {2} place", sobol.Name, queue.Contains(sobol).isContained, queue.Contains(sobol).place);
			DrawLine();
			DrawLine();

			Console.WriteLine("New line: ");
			foreach (Citizen item in queue)

			{
				Console.Write(item + " | ");
			}

			DrawLineFromNewLine();

			Console.WriteLine("Get the last person and his place: {0}, {1}", queue.ReturnLast().lastOne.Name, queue.ReturnLast().place);

			queue.Clear();

			foreach (Citizen item in queue)
			{
				Console.Write(item + " | ");
			}

			queue.Add(new Worker("Sobol", "2540"));
			queue.Add(new Student("Ivanov", "1012"));
			queue.Add(new Worker("Petrov", "2104"));
			queue.Add(new Retired("Novikov", "3012"));

			foreach (Citizen item in queue)
			{
				Console.Write(item + " | ");
			}

			//Delay
			Console.ReadKey();
		}

		static void DrawLine()
		{
			Console.WriteLine(new string('-', 150));
		}

		static void DrawLineFromNewLine()
		{
			Console.WriteLine("\n" + new string('-', 150));
		}
	}
}
