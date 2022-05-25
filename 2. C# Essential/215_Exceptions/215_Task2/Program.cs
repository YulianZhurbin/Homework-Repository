
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_Task2
{
	class WrongDataException : Exception
	{
		public WrongDataException(string message) : base(message)
		{
		}
	}

	struct Worker
	{
		string identity, capacity, firstYear;

		public string ID
		{
			set { identity = value; }
			get { return identity; }
		}

		public string Capacity
		{
			set { capacity = value; }
			get { return capacity; }
		}

		public string FirstYear
		{
			set { firstYear = value; }
			get { return firstYear; }
		}
	}

	class Program
	{
		static bool CheckYear(string firstYear)
		{
			bool correctYear = (firstYear.Length == 4 && Convert.ToInt32(firstYear) <= DateTime.Now.Year);
			return correctYear;
		}

		static void Main(string[] args)
		{
			Worker[] database = new Worker[5];

			WrongDataException e = new WrongDataException("Wrong year format(correct example is \"1997\")");

			Console.WriteLine("Fill the array with 5 workers.");

			for (int i = 0; i < database.Length; i++)
			{
				Console.Write("Name: ");
				database[i].ID = Console.ReadLine(); 
				
				Console.Write("Capacity: ");
				database[i].Capacity = Console.ReadLine();

				while (true)
				{
					try
					{
						Console.Write("First work year: ");
						database[i].FirstYear = Console.ReadLine();
						bool correctYear = CheckYear(database[i].FirstYear);

						if (correctYear)
						{
							break;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Red;
							throw e;
						}
					}
					catch
					{
						Console.WriteLine(e.Message);
						Console.ForegroundColor = ConsoleColor.Gray;
					}
				}

				Console.WriteLine();
			}

			Console.Write("Enter the number to compare with work experience of the workers: ");

			int exp = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Workers with experience more than {0} years:", exp);

			int workerExp;

			for (int i = 0; i < database.Length; i++)
			{
				workerExp = (int)DateTime.Now.Year - Convert.ToInt32(database[i].FirstYear);
				
				if (workerExp > exp)
				{
					Console.WriteLine(database[i].ID);
				}
			}

			//Delay
			Console.ReadKey();			
		}
	}
}
