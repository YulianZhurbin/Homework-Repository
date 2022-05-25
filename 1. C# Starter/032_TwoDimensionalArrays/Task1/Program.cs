using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrayAStringNumber, arrayAColomnsNumber, arrayBStringNumber, arrayBColomnsNumber;

			decimal[,] A; 
			decimal [,] B;

			// Receiving sizes of arrays A and B
			while (true)
			{
				Console.WriteLine("Enter sizes of arrays A and B. A should be able to be multiplied by B!");

				Console.WriteLine("Input the number of strings in array A: ");
				arrayAStringNumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Input the number of colomns in array A: ");
				arrayAColomnsNumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Input the number of strings in array B: ");
				arrayBStringNumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Input the number of colomns in array B: ");
				arrayBColomnsNumber = Convert.ToInt32(Console.ReadLine());

				if (arrayAColomnsNumber == arrayBStringNumber)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Array A can be multiplied by aray B!");
					Console.ForegroundColor = ConsoleColor.Gray;

					A = new decimal[arrayAStringNumber, arrayAColomnsNumber];
					B = new decimal[arrayBStringNumber, arrayBColomnsNumber];
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Array A CAN'T be multiplied by array B! Try inputting new values!");
					Console.ForegroundColor = ConsoleColor.Gray;
				}
			}

			// Inputting elements of the arrays
			{
				// Creating array A
				{
					Console.WriteLine("Input elements of array A");

					for (int i = 0; i < A.GetLength(0); i++)
					{
						for (int j = 0; j < A.GetLength(1); j++)
						{
							A[i, j] = Convert.ToDecimal(Console.ReadLine());
						}
					}

					Console.WriteLine();
				}

				// Creating array B
				{
					Console.WriteLine("Input elements of array B");

					for (int i = 0; i < B.GetLength(0); i++)
					{
						for (int j = 0; j < B.GetLength(1); j++)
						{
							B[i, j] = Convert.ToDecimal(Console.ReadLine());
						}
					}

					Console.WriteLine();
				}

				// Printing array A
				{
					Console.WriteLine("Array A");

					for (int i = 0; i < A.GetLength(0); i++)
					{
						for (int j = 0; j < A.GetLength(1); j++)
						{
							Console.Write($"{A[i, j]}  "); 
						}
						Console.WriteLine();
					}

					Console.WriteLine();
				}

				// Printing array B
				{
					Console.WriteLine("Array B");

					for (int i = 0; i < B.GetLength(0); i++)
					{
						for (int j = 0; j < B.GetLength(1); j++)
						{
							Console.Write($"{B[i, j]}  ");
						}
						Console.WriteLine();
					}

					Console.WriteLine();
				}
			}

			// Multiplying A by B and printing the result
			{
				decimal[,] C = new decimal[arrayAStringNumber, arrayBColomnsNumber];

				for (int i = 0; i < A.GetLength(0); i++)
				{
					for (int k = 0; k < C.GetLength(1); k++)
					{
						for (int j = 0; j < A.GetLength(1); j++)
						{
							C[i, k] += A[i, j] * B[j, k];
						}
					}
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Array C");

				for (int i = 0; i < C.GetLength(0); i++)
				{
					for (int j = 0; j < C.GetLength(1); j++)
					{
						Console.Write($"{C[i, j],2}  ");
					}
					Console.WriteLine();
				}

			}

			// Delay
			Console.ReadKey();
		}
	}
}
