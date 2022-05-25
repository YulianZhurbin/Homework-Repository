using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_Task4
{
	class Date
	{
		int day, month, year, total;

		public int Total
		{
			get { return total; }
		}

		public Date(int day, int month, int year)
		{
			try
			{
				if (day <= 31 && day > 0 && month > 0 && month <= 12)
				{
					this.day = day;
					this.month = month;
					this.year = year;

					CastToDays();
				}
				else
				{
					throw new Exception("Wrong date input!");
				}
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ForegroundColor = ConsoleColor.Gray;

				//Delay
				Console.ReadKey();
			}

		}

		private int CastToDays()
		{
			int monthInDays;

			switch (month)
			{
				case 1:
					monthInDays = 0; // number of days in previous months
					break;
				case 2:
					monthInDays = 31;
					break;
				case 3:
					monthInDays = 31 + 28;
					break;
				case 4:
					monthInDays = 31 + 28 + 31;
					break;
				case 5:
					monthInDays = 31 + 28 + 31 + 30;
					break;
				case 6:
					monthInDays = 31 + 28 + 31 + 30 + 31;
					break;
				case 7:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30;
					break;
				case 8:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30 + 31;
					break;
				case 9:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
					break;
				case 10:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
					break;
				case 11:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
					break;
				case 12:
					monthInDays = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
					break;
				default:
					{
						monthInDays = 0;
						break;
					}
			}

			int yearsInDays;

			yearsInDays = year * 365 + (year / 4 + 1);

			return total = day + monthInDays + yearsInDays;
		}

		public static int operator -(Date op1, Date op2)
		{
			return op1.total - op2.total;
		}

		public static int operator +(Date op1, int op2)
		{
			return op1.total + op2;
		}
	}
}
