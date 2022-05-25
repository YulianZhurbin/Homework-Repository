using System;
using System.Collections.Generic;
using System.Collections;

namespace _307_AdditionalTask
{
	class Program
	{
		static void Main()
		{
			Worker[] staff = new Worker[] {
			new Manager { Name = "Mike" },
			new Manager { Name = "Steve" },
			new Manager { Name = "George" },
			new Manager { Name = "Ben" },
			new Manager { Name = "Tyrone" },
			new Director { Name = "Jack" },
			new Programmer { Name = "Paul" }
		};

			foreach (var worker in staff)
			{
				Type workerType = worker.GetType();

				object[] attributes = workerType.GetCustomAttributes(false);

				foreach (AccessLevelAttribute attribute in attributes)
				{
					Console.WriteLine("{0,-10}{1}", worker.Name, attribute.AccessLevel);
				}
			}

			Console.WriteLine(new string('-',40));

			Console.WriteLine("Enter you name: ");
			string guest = Console.ReadLine();
			int counter = staff.Length;

			foreach (Worker worker in staff)
			{
				if (guest == worker.Name)
				{
					if (worker.GetType() == typeof(Programmer))
					{
						Console.WriteLine("You have access to the secret information.");
					}
					else
					{
						Console.WriteLine("You don't have access to the information");
					}
					break;
				}

				if (--counter == 0)
				{
					Console.WriteLine("Such worker was not found!");
				}
			}
			//Delay
			Console.ReadKey();
		}
	}
}
