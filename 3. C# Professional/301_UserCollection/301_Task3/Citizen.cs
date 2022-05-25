using System;

namespace _301_Task3
{
	abstract class Citizen
	{
		readonly string name;
		readonly string number;

		public string Name
		{
			get { return name; }
		}

		public string Number
		{
			get { return number; }
		}

		public Citizen(string name, string number) 
		{
			this.name = name;
			this.number = number;
		}

		#region Перегрузка оператора равенства
		public static bool operator ==(Citizen one, Citizen two)
		{
			if (one.Name == two.Name && one.Number == two.Number)
			{
				return true;
			}
			else 
			{
				return false;
			}
		}

		public static bool operator !=(Citizen one, Citizen two)
		{
			if (one.Name != two.Name || one.Number != two.Number)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#region Переопределение методов Equals, GetHashCode, ToString
		public override bool Equals(object obj)
		{
			return this == (Citizen)obj;
		}

		public override int GetHashCode()
		{
			return Convert.ToInt32(number);
		}

		public override string ToString()
		{
			return string.Format(name + " - " + number);
		}
		#endregion
	}
}
