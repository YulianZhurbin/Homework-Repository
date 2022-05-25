using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task2
{
	class Block
	{
		private readonly int side1;
		private readonly int side2;
		private readonly int side3;
		private readonly int side4;

		public Block(int side1, int side2, int side3, int side4)
		{
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
			this.side4 = side4;
		}

		public override bool Equals(object obj)
		{
			Block comp = (Block)obj;
			return (side1 == comp.side1 && side2 == comp.side2 && side3 == comp.side3 && side4 == comp.side4);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return string.Format("side1 = {0}, side2 = {1}, side3 = {2}, side4 = {3}", side1, side2, side3, side4);
		}
	}
}
