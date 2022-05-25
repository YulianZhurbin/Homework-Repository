using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_Task2
{
	class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string ProdYear { get; set; }
		public string Color { get; set; }
	}

	class Buyer
	{
		public string Model { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var carCol = new List<Car>
			{
					new Car { Brand = "Lada", Model = "14", ProdYear = "2014", Color = "Gray"},
					new Car { Brand = "Lada", Model = "09", ProdYear = "2000", Color = "Cherry"},
					new Car { Brand = "Lada", Model = "Vesta", ProdYear = "2018", Color = "Yellow"},
			};

			var buyerCol = new List<Buyer>
			{
				new Buyer { Model = "09", Name = "Oleg", Phone = "8-916-056-78-29"},
				new Buyer { Model = "14", Name = "Vlad", Phone = "8-916-044-13-97"}
			};

			var query = from car in carCol
						join buyer in buyerCol
						on car.Model equals buyer.Model
						select new
						{
							car.Brand,
							car.Model,
							car.ProdYear,
							car.Color,
							buyer.Name,
							buyer.Phone
						};

			foreach (var item in query) 
			{
				Console.WriteLine("{0}, {1}, {2}, {3}\t{4}, {5}", item.Brand, item.Model, item.ProdYear, item.Color, item.Name, item.Phone);
			}

			Console.ReadKey();
		}
	}
}
