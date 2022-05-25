using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Task2
{
	static class AdditionalClass
	{
		public static T[] GetArray<T>(this IEnumerable<T> list)
		{
			int index = 0;

			T[] array = new T[list.Count()];

			index = 0;

			foreach (T element in list)
			{
				array[index++] = element;
			}

			return array;
		}
	}
}
