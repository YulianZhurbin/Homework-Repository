using System;

namespace _023_Triangles
{
	class Program
	{
		static void Main(string[] args)
		{
			bool IsTriangleExists;
			
			Console.WriteLine("Enter the sides of the triangle: ");
			int side1 = Convert.ToInt32(Console.ReadLine());
			int side2 = Convert.ToInt32(Console.ReadLine());
			int side3 = Convert.ToInt32(Console.ReadLine());

			{
				// A triangle can exist only when any side is less then the sum of two left ones

				bool IsSide1LessOthers = side1 < (side2 + side3);
				bool IsSide2LessOthers = side2 < (side1 + side3);
				bool IsSide3LessOthers = side3 < (side1 + side2);

				IsTriangleExists = IsSide1LessOthers && IsSide2LessOthers && IsSide3LessOthers;

				if (IsTriangleExists)
				{
					Console.WriteLine("Such a triangle exists");
				}
				else
				{
					Console.WriteLine("Such a triangle doesn't exist. Try again.");
				}
			}

			{
				bool triangleEquilateral = (side1 == side2) && (side2 == side3) && IsTriangleExists;

				if (triangleEquilateral)
				{
					Console.WriteLine("The triangle is equilateral");
				}
			}

			{
				bool triangleIsosceles = ((side1 == side2) || (side2 == side3) || (side3 == side1)) && IsTriangleExists;

				if (triangleIsosceles)
				{
					Console.WriteLine("The triangle is isosceles");
				}
			}

			{
				double side1Square = Math.Pow(side1, 2);
				double side2Square = Math.Pow(side2, 2);
				double side3Square = Math.Pow(side3, 2);

				bool side1Hepotenuse = (side1Square == (side2Square + side3Square));
				bool side2Hepotenuse = (side2Square == (side3Square + side1Square));
				bool side3Hepotenuse = (side3Square == (side1Square + side2Square));

				bool triangleRight = (side1Hepotenuse || side2Hepotenuse || side3Hepotenuse) && IsTriangleExists;

				if (triangleRight)
				{
					Console.Write("The triangle is right-angled");
				}
			}

			// Delay
			Console.ReadKey();

		}	
	}
}
