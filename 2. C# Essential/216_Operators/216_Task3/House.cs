using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task3
{
	class House : ICloneable
	{
		double area, pricePerMonth;

		public House(double area, double pricePerMonth)
		{
			this.area = area;
			this.pricePerMonth = pricePerMonth;
		}

		public double Area
		{
			get { return area; }
			set { area = value; }
		}

		public double Price
		{
			get { return pricePerMonth; }
			set { pricePerMonth = value; }
		}

		public object Clone()
		{
			return this;
		}

		public House DeepClone()
		{
			return new House(area, pricePerMonth);
		}
	}
}
