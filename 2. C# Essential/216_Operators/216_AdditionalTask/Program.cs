using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_AdditionalTask
{
	struct Point
	{
		int x, y, z;

		public Point(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Point operator +(Point one, Point two)
		{
			return new Point(one.x + two.x, one.y + two.y, one.z + two.z);
		}

		public override string ToString()
		{
			return String.Format("{0}, {1}, {2}", x, y, z);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point(2, 2, 2);
			Point B = new Point(-1, -1, -1);

			Point C = A + B;

			Console.WriteLine(C.ToString());

			Console.ReadKey();
		}
	}
}
